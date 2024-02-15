using ConsoleXLAPI.Models;
using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO.Pipes;
using System.Text;

namespace ConsoleXLAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommoditiesController : ControllerBase
    {
        private readonly ILogger<CommoditiesController> _logger;

        XLCommoditiesController XLCommodities { get; set; }
        public CommoditiesController(ILogger<CommoditiesController> logger, XLCommoditiesController xLCommoditiesController)
        {
            _logger = logger;
            XLCommodities = xLCommoditiesController;
        }
        private async Task<OutputMessage> SendRequestToConsoleApp(object request, string pipeName)
        {

            try
            {
                //_logger.w.WriteEntry("");
                // Serializuj obiekt do JSON
                string jsonRequest = JsonConvert.SerializeObject(request);
                //eventLog.WriteEntry("jsonRequest" + jsonRequest);

                // Zamieñ JSON na bajty
                byte[] requestBytes = Encoding.UTF8.GetBytes(jsonRequest);
                //eventLog.WriteEntry("requestBytes");
                // Otwórz potok klienta

                using (NamedPipeClientStream clientStream = new NamedPipeClientStream(".", pipeName, PipeDirection.InOut, PipeOptions.None))
                {
                    //eventLog.WriteEntry("" + pipeName);

                    // Po³¹cz siê z potokiem
                    clientStream.Connect();

                    // Wyœlij dane do potoku
                    await clientStream.WriteAsync(requestBytes, 0, requestBytes.Length);

                    // Poczekaj na zakoñczenie przetwarzania i uzyskaj wynik
                    await Task.Delay(100); // Symulacja oczekiwania

                    // Odczytaj wynik z potoku (mo¿esz dostosowaæ logikê odczytu)
                    byte[] responseBytes = new byte[1024 * 1024 * 10]; // 10 MB
                    int bytesRead = await clientStream.ReadAsync(responseBytes, 0, responseBytes.Length);
                    string responseData = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    // Deserializuj odpowiedŸ
                    OutputMessage outputMessage = JsonConvert.DeserializeObject<OutputMessage>(responseData);

                    return outputMessage;
                }
            }
            catch (Exception ex)
            {
                // Obs³u¿ b³êdy
                Console.WriteLine($"B³¹d podczas wysy³ania ¿¹dania do aplikacji konsolowej: {ex.Message}");
                return null;
            }
        }

        [HttpPut("Add", Name = "AddCommodities")]  //, Name = "Add contractors")]
        public async Task<ActionResult<OutputMessage>> AddMore([FromBody] CommodityResquest response)
        {
            response.DateTime = DateTime.Now;
            try
            {
                if (response.Json.Any())
                {
                    // var result = await XLMainController.TaskRun(response);
                    //   OutputMessage result = await SendRequestToConsoleApp(response, "AddCommodities");
                    response.PipeName = "AddCommodities";
                    OutputMessage? result = await response.SendData();

                    if (result == null)
                    {
                        return NotFound();
                    }
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Get/{Guid}")] //, Name = "Get single Element by Guid")]
        public async Task<ActionResult<OutputMessage>> GetSingle(Guid guid)
        {
            try
            {//GET NIE POTRZEBUJE RESPONSE

                //  var result = await OutputMessage.ResultOk(nameof(GetSingle) + "" + nameof(CommoditiesController), ""); // await XLController.TaskRun(new ConsoleXLAPI.ContractorResponse() { });
                OutputMessage result = await SendRequestToConsoleApp(guid, "GetSingleComm");
                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]//("Get All Contractors")]
        public async Task<ActionResult<OutputMessage>> GetAll()
        {
            try
            {
                OutputMessage result = await SendRequestToConsoleApp("", "GetAllComm");
                //get nie potrzebuje response
                //      var result = await OutputMessage.ResultOk(nameof(GetSingle) + "" + nameof(CommoditiesController), "");// await XLController.TaskRun(new ConsoleXLAPI.ContractorResponse() { }  );

                if (result == null)
                {
                    return NotFound();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}