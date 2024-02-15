using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Text;
using System.Threading.Tasks;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;
using XLAPI_CONSOLE.Utils.Request;

namespace XLAPI_CONSOLE
{
    class PipeTypes
    {
        public PipeTypes(Type type, string name)
        {
            Type = type;
            Name = name;

        }
        public Type Type { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        private static BlockingCollection<Request> requestQueue = new BlockingCollection<Request>();
        public static async void ConnectionChecker()
        {
            while (true)
            {
                try
                {
                    using (NamedPipeServerStream serverStream = new NamedPipeServerStream("ConsoleXL"))
                    {
                        await serverStream.WaitForConnectionAsync();
                    }
                }
                catch (Exception ex)
                {
                }
            };
        }

        public static async void RunLoop()
        {
            List<Task> tasks = new List<Task>();

            List<PipeTypes> Pipes = new List<PipeTypes> { new PipeTypes(typeof(CategoriesRequest), "AddCategories"),
            new PipeTypes(typeof(Guid), "GetSingleCat") ,
            new PipeTypes(typeof(string), "GetAllCat") ,
            new PipeTypes(typeof(CommodityResquest), "AddCommodities") ,
            new PipeTypes(typeof(Guid), "GetSingleComm") ,
            new PipeTypes(typeof(string), "GetAllComm") ,
            new PipeTypes(typeof(ContractorRequest), "AddContractors") ,
            new PipeTypes(typeof(ContractorSQLRequest), "AddContractorsSQL") ,
            new PipeTypes(typeof(Guid), "GetSingleContractorsSQL") ,
            new PipeTypes(typeof(TradingDocs), "PutFZ"),
            new PipeTypes(typeof(TradingDocs), "PutFA"),
            new PipeTypes(typeof(OrderDocs), "PutFPA"),
            new PipeTypes(typeof(ImportDocs), "PutFROD"),
            new PipeTypes(typeof(SADDocs), "PutFPF"),
            new PipeTypes(typeof(TradingDocs), "PutPW"),
            new PipeTypes(typeof(TradingDocs), "PutRW"),
            new PipeTypes(typeof(TradingDocs), "PutPA"),
            new PipeTypes(typeof(WarehouseDocs), "PutPAWZ"),
            new PipeTypes(typeof(SADDocs), "PutPARO"),
            new PipeTypes(typeof(TradingDocs), "PutWZ"),
            new PipeTypes(typeof(TradingDocs), "PutPZ"),
            new PipeTypes(typeof(TradingDocs), "PutPZZD"),
            new PipeTypes(typeof(TradingDocs), "PutRO"),
            new PipeTypes(typeof(TradingDocs), "PutROPF"),
            new PipeTypes(typeof(OrderDocs), "PutZD"),
            new PipeTypes(typeof(SADDocs), "PutZROD"),
            new PipeTypes(typeof(WarehouseDocs), "PutMM")

            };

            foreach (var pipe in Pipes)
            {
                try
                {
                    tasks.Add(Task.Run(async () =>
                    {
                        while (true)
                        {
                            try
                            {
                                using (NamedPipeServerStream serverStream = new NamedPipeServerStream(pipe.Name))
                                {
                                    Debug.WriteLine($"Oczekiwanie na połączenie na potoku {pipe.Name}...");

                                    await serverStream.WaitForConnectionAsync();
                                    Debug.WriteLine($"Połączono na potoku {pipe.Name}!");

                                    byte[] buffer = new byte[1024 * 1024 * 10]; // 5 MB
                                    int bytesRead = await serverStream.ReadAsync(buffer, 0, buffer.Length);

                                    string requestData = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                                    var requestType = pipe.Type;
                                    var request = JsonConvert.DeserializeObject(requestData, requestType);
                                    var t = request as Request;
                                    Console.WriteLine($"Potok {pipe.Name}! ...:> {t.Guid}");

                                    OutputMessage outputMessage = await Task.Run(() => GetResponse(t));
                                    string responseData = JsonConvert.SerializeObject(outputMessage);

                                    byte[] responseBuffer = Encoding.UTF8.GetBytes(responseData);
                                    await serverStream.WriteAsync(responseBuffer, 0, responseBuffer.Length);

                                    serverStream.WaitForPipeDrain();
                                    serverStream.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(":> " + ex.Message);
                            }
                        }

                    }));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            await Task.WhenAll(tasks);
        }

        static void Main(string[] args)
        {
            XLMainController.InitXLMainController();
            Task.Run(() => { ConnectionChecker(); });
            Task.Run(() => { RunLoop(); });
            Console.ReadKey();
        }
        private static async Task<OutputMessage> GetResponse(Request request)
        {
            OutputMessage outputMessage = await Task.Run(() => XLMainController.TaskRun(request));
            return outputMessage;
        }
    }
}
