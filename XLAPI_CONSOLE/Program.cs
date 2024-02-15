//using Newtonsoft.Json;
//using System;
//using System.Collections.Concurrent;
//using System.Collections.Generic;
//using System.IO.Pipes;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web.Http;
//using System.Web.Http.SelfHost;
//using XLAPI_CONSOLE.Models;
//using XLAPI_CONSOLE.StaticController;
//using XLAPI_CONSOLE.Utils.Request;

//namespace XLAPI_CONSOLE
//{
//    class PipeTypes
//    {
//        public PipeTypes(Type type, string name)
//        {
//            Type = type;
//            Name = name;

//        }
//        public Type Type { get; set; }
//        public string Name { get; set; }
//    }
//    class Program
//    {
//        private static BlockingCollection<Request> requestQueue = new BlockingCollection<Request>();

//        static void Main(string[] args)
//        {
//            var config = new HttpSelfHostConfiguration("http://localhost:7799");

//            config.Routes.MapHttpRoute("API Default", "api/{controller}/{id}", new { id = RouteParameter.Optional });

//            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
//            {
//                server.OpenAsync().Wait();
//                Console.WriteLine("Web API server started. Press Enter to exit.");
//                Console.ReadLine();
//            }
//        }
//        //List<Task> tasks = new List<Task>();
//        //// Lista potoków, które chcesz obsługiwać
//        //List<PipeTypes> Pipes = new List<PipeTypes> { new PipeTypes(typeof(CategoriesRequest), "AddCategories"),
//        //new PipeTypes(typeof(Guid), "GetSingleCat") ,
//        //new PipeTypes(typeof(string), "GetAllCat") ,
//        //new PipeTypes(typeof(CommodityResquest), "AddCommodities") ,
//        //new PipeTypes(typeof(Guid), "GetSingleComm") ,
//        //new PipeTypes(typeof(string), "GetAllComm") ,
//        //new PipeTypes(typeof(ContractorRequest), "AddContractors") ,
//        //new PipeTypes(typeof(ContractorSQLRequest), "AddContractorsSQL") ,
//        //new PipeTypes(typeof(Guid), "GetSingleContractorsSQL") ,
//        //new PipeTypes(typeof(TradingDocs), "PutFZ"),
//        //new PipeTypes(typeof(TradingDocs), "PutFA"),
//        //new PipeTypes(typeof(OrderDocs), "PutFPA"),
//        //new PipeTypes(typeof(ImportDocs), "PutFROD"),
//        //new PipeTypes(typeof(SADDocs), "PutFPF"),
//        //new PipeTypes(typeof(TradingDocs), "PutPW"),
//        //new PipeTypes(typeof(TradingDocs), "PutRW"),
//        //new PipeTypes(typeof(TradingDocs), "PutPA"),
//        //new PipeTypes(typeof(WarehouseDocs), "PutPAWZ"),
//        //new PipeTypes(typeof(SADDocs), "PutPARO"),
//        //new PipeTypes(typeof(TradingDocs), "PutWZ"),
//        //new PipeTypes(typeof(TradingDocs), "PutPZ"),
//        //new PipeTypes(typeof(TradingDocs), "PutPZZD"),
//        //new PipeTypes(typeof(TradingDocs), "PutRO"),
//        //new PipeTypes(typeof(TradingDocs), "PutROPF"),
//        //new PipeTypes(typeof(OrderDocs), "PutZD"),
//        //new PipeTypes(typeof(SADDocs), "PutZROD"),
//        //new PipeTypes(typeof(WarehouseDocs), "PutMM")
//        //}; 
//        //foreach (var pipe in Pipes)
//        //{
//        //    tasks.Add(Task.Run(async () =>
//        //    {
//        //        while (true)
//        //        {
//        //            using (NamedPipeServerStream serverStream = new NamedPipeServerStream(pipe.Name))
//        //            {
//        //                Console.WriteLine($"Oczekiwanie na połączenie na potoku {pipe.Name}...");
//        //                await serverStream.WaitForConnectionAsync();
//        //                Console.WriteLine($"Połączono na potoku {pipe.Name}!");
//        //                byte[] buffer = new byte[1024 * 1024 * 10]; // 5 MB
//        //                int bytesRead = await serverStream.ReadAsync(buffer, 0, buffer.Length);
//        //                string requestData = Encoding.UTF8.GetString(buffer, 0, bytesRead);
//        //                //Console.WriteLine(requestData.Substring(33));
//        //                // Deserializuj żądanie
//        //                var requestType = pipe.Type;
//        //                var request = JsonConvert.DeserializeObject(requestData, requestType);
//        //                var t = request as Request;
//        //                // Dodaj żądanie do kolejki
//        //                //     requestQueue.Add(request);
//        //                // Oczekaj na zakończenie przetwarzania i uzyskaj wynik
//        //                OutputMessage outputMessage = await Task.Run(() => GetResponse(t));
//        //                // Serializuj wynik do JSON string
//        //                string responseData = JsonConvert.SerializeObject(outputMessage);
//        //                Console.WriteLine(responseData.Substring(50, 120));
//        //                // Wyślij odpowiedź do klienta
//        //                byte[] responseBuffer = Encoding.UTF8.GetBytes(responseData);
//        //                await serverStream.WriteAsync(responseBuffer, 0, responseBuffer.Length);
//        //                // Zakończ połączenie
//        //                serverStream.WaitForPipeDrain();
//        //                serverStream.Close();
//        //            }
//        //        }
//        //    }));
//        //}
//        //// Oczekaj na zakończenie wszystkich zadań
//        //await Task.WhenAll(tasks);
//        // }
        
//        private static async Task<OutputMessage> GetResponse(Request request)
//        {
//            OutputMessage outputMessage = await Task.Run(() => XLMainController.TaskRun(request));
//            return outputMessage;
//        }
//    }

//    public class DocumentsController : ApiController
//    {
//        [HttpPut]
//        [Route("api/{controller}/PutFA")]
//        public IHttpActionResult PutFA(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutFA)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutFZ")]
//        public IHttpActionResult PutFZ(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutFZ)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }

//        [HttpPut]
//        [Route("api/{controller}/PutFPA")]
//        public IHttpActionResult PutFPA(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutFPA)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutFROD")]
//        public IHttpActionResult PutFROD(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutFROD)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutFPF")]
//        public IHttpActionResult PutFPF(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutFPF)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutPW")]
//        public IHttpActionResult PutPW(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutPW)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutRW")]
//        public IHttpActionResult PutRW(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutRW)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutPA")]
//        public IHttpActionResult PutPA(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutPA)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutPAWZ")]
//        public IHttpActionResult PutPAWZ(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutPAWZ)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutPARO")]
//        public IHttpActionResult PutPARO(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutPARO)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutWZ")]
//        public IHttpActionResult PutWZ(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutWZ)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutPZ")]
//        public IHttpActionResult PutPZ(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutPZ)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutPZZD")]
//        public IHttpActionResult PutPZZD(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutPZZD)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutRO")]
//        public IHttpActionResult PutRO(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutRO)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutROPF")]
//        public IHttpActionResult PutROPF(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutROPF)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutZD")]
//        public IHttpActionResult PutZD(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutZD)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutZROD")]
//        public IHttpActionResult PutZROD(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutZROD)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/PutMM")]
//        public IHttpActionResult PutMM(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(PutMM)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//    }
//    public class CommoditiesController : ApiController
//    {
//        [HttpPost]
//        public IHttpActionResult Post(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(Post)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//    }

//    public class ContractorsController : ApiController
//    {
//        [HttpPut]
//        [Route("api/{controller}/AddContractors")]
//        public IHttpActionResult AddContractors(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(AddContractors)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//        [HttpPut]
//        [Route("api/{controller}/AddContractorsSQL")]
//        public IHttpActionResult AddContractorsSQL(string endpoint, [FromBody] Request requestData)
//        {
//            try
//            {
//                if (requestData == null || requestData.Guid == null)
//                {
//                    var invalidResponse = new OutputMessage()
//                    {
//                        Date = DateTime.Now.ToString("s"),
//                        Message = "Invalid request data",
//                        ResultJson = "Wynikowy JSON",
//                        Methods = nameof(AddContractorsSQL)
//                    };

//                    return Ok(invalidResponse);
//                }

//                var outputMessage = XLMainController.TaskRun(requestData);
//                return Ok(outputMessage);
//            }
//            catch (Exception ex)
//            {
//                return InternalServerError(ex);
//            }
//        }
//    }
//}
