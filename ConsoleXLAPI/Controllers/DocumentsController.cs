using ConsoleXLAPI.Models;
using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using System.IO.Pipes;
using System.Text;

namespace ConsoleXLAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentsController : ControllerBase
    {
        XLDocumentsController XLDocuments { get; set; }
        public DocumentsController(XLDocumentsController xLDocumentsController)
        {
            XLDocuments = xLDocumentsController;
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

        [HttpGet]  //, Name = "Add Documents")]
        public async Task<ActionResult<OutputMessage>> GetDocs()
        {
            try
            {

                var result = await XLDocuments.GetOrderDocuments();
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

        [SwaggerOperation(Summary = "Faktura zakupu", Description = "Optima: 301000 > XL: 1521 ")]
        [HttpPut("FZ")]
        public async Task<ActionResult<OutputMessage>> PutFZ([FromBody] TradingDocs request)
        {
            foreach (var item in request.Json)
            {
                item.Tryb = 2;
                item.Typ = 1521;
            }
            request.DateTime = DateTime.Now;
            try
            {
                if (request.Json.Any())
                {
                    //OutputMessage result = await SendRequestToConsoleApp(request, "PutFZ");
                    request.PipeName = "PutFZ";
                    OutputMessage? result = await request.SendData();
                    // var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Faktura sprzeda¿y", Description = "Optima: 302000 > XL: 2033 ")]
        [HttpPut("FA")]
        public async Task<ActionResult<OutputMessage>> PutFA([FromBody] TradingDocs request)
        {

            foreach (var item in request.Json)
            {
                item.Tryb = 2;
                item.Typ = 2033;
                item.Akwizytor = "JC";
            }
            request.DateTime = DateTime.Now;
            try
            {
                //Console.WriteLine(JsonConvert.SerializeObject(request));
                if (request.Json.Any())
                {
                    //       OutputMessage result = await SendRequestToConsoleApp(request, "PutFA");
                    request.PipeName = "PutFA";
                    OutputMessage? result = await request.SendData();
                    //
                    //  var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Faktura sprzeda¿y z paragonu", Description = "302006 > XL: 2035 ")] // ??????????
        [HttpPut("FPA")]
        public async Task<ActionResult<OutputMessage>> PutFPA([FromBody] OrderDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2035;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutFPA";
                    OutputMessage? result = await request.SendData();
                    //                    OutputMessage result = await SendRequestToConsoleApp(request, "PutFPA");

                    //     var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Faktura sprzeda¿y z RO", Description = "302008 > xl: 2033")] //>> ???????
        [HttpPut("FROD")]
        public async Task<ActionResult<OutputMessage>> PutFROD([FromBody] ImportDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2033;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutFROD";
                    OutputMessage? result = await request.SendData();
                    //                        OutputMessage result = await SendRequestToConsoleApp(request, "PutFROD");

                    //   var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Faktura sprzeda¿y z pro-formy", Description = "302009 > xl: 2033")] // > ?????????
        [HttpPut("FPF")]
        public async Task<ActionResult<OutputMessage>> PutFPF([FromBody] SADDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2033;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutFPF";
                    OutputMessage? result = await request.SendData();
                    //   OutputMessage result = await SendRequestToConsoleApp(request, "PutFPF");

                    //   var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Przychód wewnêtrzny", Description = "optima: 303000 > xl: 1617")]
        [HttpPut("PW")]
        public async Task<ActionResult<OutputMessage>> PutPW([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            try
            {
                foreach (var item in request.Json)
                {
                    item.Tryb = 2; item.Typ = 1617;
                }
                if (request.Json.Any())
                {
                    request.PipeName = "PutPW";
                    OutputMessage? result = await request.SendData();
                    //                      OutputMessage result = await SendRequestToConsoleApp(request, "PutPW");

                    //     var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Rozchód wewnêtrzny", Description = "opt: 304000 > xl: 1616")]
        [HttpPut("RW")]
        public async Task<ActionResult<OutputMessage>> PutRW([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;

            try
            {
                foreach (var item in request.Json)
                {
                    item.Tryb = 2; item.Typ = 1616;
                }
                if (request.Json.Any())
                {
                    request.PipeName = "PutRW";
                    OutputMessage? result = await request.SendData();
                    //     OutputMessage result = await SendRequestToConsoleApp(request, "PutRW");

                    //       var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Paragon", Description = "opt: 305000> xl: 2034")]
        [HttpPut("PA")]
        public async Task<ActionResult<OutputMessage>> PutPA([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2034;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutPA";
                    OutputMessage? result = await request.SendData();
                    //    OutputMessage result = await SendRequestToConsoleApp(request, "PutPA");

                    //  var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Paragon sprzeda¿y przekszta³cony z WZ", Description = "opt: 305004> xl: 2034 ")] // >> ???????
        [HttpPut("PAWZ")]
        public async Task<ActionResult<OutputMessage>> PutPAWZ([FromBody] WarehouseDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2034;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutPAWZ";
                    OutputMessage? result = await request.SendData();
                    //OutputMessage result = await SendRequestToConsoleApp(request, "PutPAWZ");

                    //  var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Paragon z RO", Description = "opt: 305008> xl: 2034 ")] // >> ???????
        [HttpPut("PARO")]
        public async Task<ActionResult<OutputMessage>> PutPARO([FromBody] SADDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2034;
            }
            try
            {

                if (request.Json.Any())
                {
                    request.PipeName = "PutPARO";
                    OutputMessage? result = await request.SendData();
                    // OutputMessage result = await SendRequestToConsoleApp(request, "PutPARO");

                    //    var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Wydanie zewnêtrzne", Description = "opt: 306000 > xl: 2001")]
        [HttpPut("WZ")]
        public async Task<ActionResult<OutputMessage>> PutWZ([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 2001;
                item.Akwizytor = "JC";
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutWZ";
                    OutputMessage? result = await request.SendData();
                    //  OutputMessage result = await SendRequestToConsoleApp(request, "PutWZ");

                    // var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "przyjêcie zewnêtrzne", Description = "opt:307000 > xl: 1489")]
        [HttpPut("PZ")]
        public async Task<ActionResult<OutputMessage>> PutPZ([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 1489;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutPZ";
                    OutputMessage? result = await request.SendData();
                    //  OutputMessage result = await SendRequestToConsoleApp(request, "PutPZ");

                    //  var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Przyjêcie zewnêtrzne powsta³e z zamówienia dostawcy", Description = "opt: 307010 > xl: 1489")] // przyjêcie zewnêtrzne importowe? 
        [HttpPut("PZZD")]
        public async Task<ActionResult<OutputMessage>> PutPZZD([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 1489;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutPZZD";
                    OutputMessage? result = await request.SendData();
                    //   OutputMessage result = await SendRequestToConsoleApp(request, "PutPZZD");

                    // var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Rezerwacja odbiorcy", Description = "opt: 308000> xl: 6")] // >> faktura zaliczkowa sprzeda¿y?
        [HttpPut("RO")]
        public async Task<ActionResult<OutputMessage>> PutRO([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 6;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutRO";
                    OutputMessage? result = await request.SendData();
                    //   OutputMessage result = await SendRequestToConsoleApp(request, "PutRO");

                    //var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Rezerwacja odbiorcy przeksztalcona z PF", Description = "opt: 308011 > xl: 6")] // faktura zaliczkowa zakupu?
        [HttpPut("ROPF")]
        public async Task<ActionResult<OutputMessage>> PutROPF([FromBody] TradingDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 6;
            }
            try
            {

                if (request.Json.Any())
                {
                    request.PipeName = "PutROPF";
                    OutputMessage? result = await request.SendData();
                    //  OutputMessage result = await SendRequestToConsoleApp(request, "PutROPF");

                    //      var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Zamówienie dostawcy", Description = "opt: 309000 > xl: 5")]
        [HttpPut("ZD")]
        public async Task<ActionResult<OutputMessage>> PutZD([FromBody] OrderDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 5;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutZD";
                    OutputMessage? result = await request.SendData();
                    //  OutputMessage result = await SendRequestToConsoleApp(request, "PutZD");

                    // var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = "Zamówienie dostawcy wygenrowane z RO", Description = "opt: 309308 > xl: 5")]
        [HttpPut("ZROD")]
        public async Task<ActionResult<OutputMessage>> PutZROD([FromBody] SADDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 6;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutZROD";
                    OutputMessage? result = await request.SendData();
                    //   OutputMessage result = await SendRequestToConsoleApp(request, "PutZROD");

                    // var result = await XLMainController.TaskRun(request);
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

        [SwaggerOperation(Summary = " Przesuniecie MM", Description = "opt: 312000> xl: 1603")]
        [HttpPut("MM")]
        public async Task<ActionResult<OutputMessage>> PutMM([FromBody] WarehouseDocs request)
        {
            request.DateTime = DateTime.Now;
            foreach (var item in request.Json)
            {
                item.Tryb = 2; item.Typ = 1603;
            }
            try
            {
                if (request.Json.Any())
                {
                    request.PipeName = "PutMM";
                    OutputMessage? result = await request.SendData();
                    //  OutputMessage result = await SendRequestToConsoleApp(request, "PutMM");

                    //       var result = await XLMainController.TaskRun(request);
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
    }
}