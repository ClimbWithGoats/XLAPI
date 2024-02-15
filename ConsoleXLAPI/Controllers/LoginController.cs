using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;
using ConsoleXLAPI.XLControllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO.Pipes;
using System.Reflection;
using System.Text;

namespace ConsoleXLAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        readonly XLLoginController XLLoginController;
        public LoginController(ILogger<LoginController> logger, XLLoginController xLLogin)
        {
            _logger = logger;
            XLLoginController = xLLogin;
        }
        private async Task<OutputMessage> SendRequestToConsoleApp(object request, string pipeName)
        {

            //try
            //{
            //    string jsonRequest = JsonConvert.SerializeObject(request);
            //    byte[] requestBytes = Encoding.UTF8.GetBytes(jsonRequest);

            //    using (NamedPipeClientStream clientStream = new NamedPipeClientStream(".", pipeName, PipeDirection.InOut, PipeOptions.None))
            //    {
            //        Task connectTask = clientStream.ConnectAsync();
            //        Task timeoutTask = Task.Delay(TimeSpan.FromMicroseconds(500)); // Ustaw w³asny limit czasu (5 sekund w tym przypadku)
            //        await Task.WhenAny(connectTask, timeoutTask);

            //        if (!connectTask.IsCompleted)
            //        {
            //            Task.Delay(5000).Wait();
            //            return new OutputMessage() { InnerMessage = pipeName, Message = pipeName +  ":> Przekroczono limit czasu na po³¹czenie z potokiem." };
            //        }
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

        [HttpGet("Login", Name = "Login")]
        public async Task<ActionResult<OutputMessage>> Login()
        {
            try
            {
                if (!XLMainController.IsLoged)
                {
                    XLMainController.Initialize();


                    var result = await XLLoginController.Message("Zalogowano do XL", nameof(Login));
                    if (result == null)
                    {
                        return NotFound();
                    }
                    return Ok(result);
                }
                else
                {
                    return Ok(OutputMessage.ResultOk("U¿ytkownik XL ju¿ jest zalogowany", ""));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Login1", Name = "Login1")]
        public async Task<ActionResult<OutputMessage>> Logino()
        {
            try
            {

                //   Pobierz wszystkie zestawy w bie¿¹cym kontekœcie domeny aplikacji
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();

                var t = XLMainController.Wersja;
                // Zbuduj string z numeracj¹ i informacjami o zestawach
                StringBuilder result1 = new StringBuilder();
                for (int i = 0; i < assemblies.Length; i++)
                {
                    result1.Append($"{i + 1}. {assemblies[i].FullName} $#$ ");
                }


                var result = await XLLoginController.Message(result1.ToString(), nameof(Login));
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

        [HttpGet("Logout", Name = "Logout")]
        public async Task<ActionResult<OutputMessage>> Logout()
        {
            try
            {
                if (XLMainController.IsLoged)
                {
                    var message = XLMainController.Wyloguj();
                    var result = await XLLoginController.Message(message, nameof(Login));
                    if (result != null)
                    {
                        return Ok(result);
                    }
                }
                return NotFound();

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("Queue", Name = "Queue")]
        public async Task<ActionResult<OutputMessage>> Queue()
        {
            try
            {//GET NIE POTRZEBUJE RESPONSE

                var result = await OutputMessage.ResultOk(nameof(Queue) + "" + nameof(LoginController), ""); ;// await XLController.TaskRun(new ConsoleXLAPI.ContractorResponse() { });

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