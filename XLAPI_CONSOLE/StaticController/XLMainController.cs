using Newtonsoft.Json;
using System;
//using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.Repository;
using XLAPI_CONSOLE.Utils.Request;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod )

    public static partial class XLMainController
    {
        private static MainControllerRepository repository;
        private static ConfigRoot configuration;
        public static void InitXLMainController()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string appJsonPath = Path.Combine(currentDirectory, "appsettings.json");
            string jsonContent = File.ReadAllText(appJsonPath);
            configuration = JsonConvert.DeserializeObject<ConfigRoot>(jsonContent);
            repository = new MainControllerRepository(configuration);
            Initialize();
        }

        public static MainControllerRepository Repository
        {
            get { return repository; }
        }

        public static void Initialize()
        {
            Task.Run(() => ProcessQueue());
            if (!IsLoged)
            {
                XLLoginInfo item = configuration.OptimaUsers?.First();
                if (item != null)
                {
                    EnqueueTask(new RequestTask() { Request = new XLAccountRequest() { XLLogin = item } });
                    Wersja = item?.Wersja ?? 0;
                }
            }
        }

        public static int Wersja;


        static int Sesja = 0;
#pragma warning disable CA2211 // Naming Styles
        public static bool IsLoged = false;
        //public ZarzadcaBazy zarzadcaBazy { get; set; }
        static Type CdnApiType = typeof(cdn_api.cdn_api); 
        public static async Task<OutputMessage> TaskRun(Request response)
        {
            try
            {
                EnqueueTask(new RequestTask() { Request = response });
                Fedder fedder;
                do
                {
                    if (response == null && response?.Guid == null)
                    {
                        var y = new OutputMessage()
                        {
                            Date = DateTime.Now.ToString("s"),
                            Message = $"zła zwrotka",
                            ResultJson = "Wynikowy JSON",
                            Methods = nameof(TaskRun)
                        };
                        //   Console.WriteLine(nameof(TaskRun) + " :> " + y.Guid + "zła zwrotka");// ": > " + y.Message);

                        return y;
                    }
                    fedder = CanGetData(response.Guid);

                } while (fedder == null && (DateTime.Now - response.DateTime).TotalSeconds < 30);

                if (fedder != null)
                {
                    lock (Fedders)
                    {
                        Fedders.Remove(fedder);
                    }
                    var y = new OutputMessage()
                    {
                        Date = DateTime.Now.ToString("s"),
                        Guid = response.Guid,
                        Message = $"{JsonConvert.SerializeObject(fedder.PrepareSerializeObject())}",
                        ResultJson = "Wynikowy JSON",
                        Methods = nameof(TaskRun)
                    };
                    //  Console.WriteLine(nameof(TaskRun) + " :> " + y.Guid + ": > " + y.Message.Substring(30));

                    return y;
                }
                else
                {
                    // Zwróć informację o zainicjowaniu i trwającej operacji przetwarzania danych
                    var x = new OutputMessage()
                    {
                        Date = DateTime.Now.ToString("s"),
                        Guid = response.Guid,
                        Message = $"Zainicjowano nowe zadania do kolejki operacji w XL. Dane oczekujące na przetworzenie: {GetQueueSize()}, W danym cyklu kolejki Wykonano {taskCount} Operacji.. Trwa przetwarzanie danych...",
                        InnerMessage = " Zachowaj Guid aby przejrzeć wyniki operacji do 24h dnia roboczego. Po 24h dane operacji pozostaną usunięte z pamięci tymczasowej. Zmodyfikowane w trakcie operacji dane na bazie XL pozostaną zachowane.",
                        Methods = nameof(TaskRun)
                    };
                    //      Console.WriteLine(nameof(TaskRun) + " :> " + x.Guid);

                    return x;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(nameof(TaskRun) + " exception :> " + ex.Message);
                throw;
            }
        }

        private static XLResponse PrepareObjectAndInvokeMethod<T>(T item, string CreateObjectInstanceName, string InvokeMethodName, ref object[] args)
        {
            //Console.WriteLine(nameof(PrepareObjectAndInvokeMethod) + " " + CreateObjectInstanceName + "metoda wzbudzana" + InvokeMethodName + " response result: ");

            XLResponse response = null;
            var resultObject = XLReflection.CreateObjectInstance($"{CreateObjectInstanceName}_{XLMainController.Wersja}", item);
            if (resultObject != null)
            {
                if (CreateObjectInstanceName.EndsWith("XLLoginInfo") || CreateObjectInstanceName.EndsWith("XLAtrObiektInfo"))
                {
                    args[0] = resultObject;
                }
                else if (InvokeMethodName.EndsWith("XLZamknijKontrahentaSQL"))
                {
                }
                else
                {
                    object[] newArgs = new object[args.Length + 1];
                    Array.Copy(args, newArgs, args.Length);
                    newArgs[newArgs.Length - 1] = resultObject;
                    args = newArgs;
                }
                int res = XLReflection.GetMethodAndInvoke(InvokeMethodName, args, ref XLMainController.CdnApiType);
                response = new XLResponse(res, resultObject);
            }
            //Console.WriteLine(nameof(PrepareObjectAndInvokeMethod) + " response result:> " + response.ResId);
            return response;
        }
    }
}


