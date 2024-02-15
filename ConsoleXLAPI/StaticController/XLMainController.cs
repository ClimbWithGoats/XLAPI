using ConsoleXLAPI.Models;
using ConsoleXLAPI.Repository;
using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )

    public static partial class XLMainController
    {


        private static readonly MainControllerRepository repository;
        private static readonly IConfiguration configuration;
        //static XLMainController()
        //{
        //    if (CdnApiType == null)
        //    {
        //        InitializeCDNType();
        //    }

        //    // Tutaj uzyskaj IConfiguration, np. z AppSettings
        //    configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //    .Build();

        //    repository = new MainControllerRepository(configuration);
        //    Initialize();
        //}
        // Metoda do zapisywania zdarzeń do dziennika zdarzeń
        // Metoda do zapisywania zdarzeń do dziennika zdarzeń
        private static void LogEvent(string message)
        {
            string eventLogName = "NazwaTwojegoDziennikaZdarzen"; // Zastąp nazwą rzeczywistego dziennika zdarzeń
            string eventSource = "NazwaTwojegoZrodla"; // Zastąp nazwą rzeczywistego źródła zdarzeń

            if (!EventLog.SourceExists(eventSource))
            {
                EventLog.CreateEventSource(eventSource, eventLogName);
            }

            EventLog.WriteEntry(eventSource, message, EventLogEntryType.Information);
        }
        public static void InitializeCDNType()
        {
            LogEvent($"ładowanie");

            if (CdnApiType == null)
            {
                string assemblyPath = "C:\\cdnapi\\cdn_api20231.net.dll";
                LogEvent($"sciezka : {assemblyPath}");

                try
                {
                    // Załaduj zestaw z podanej ścieżki
                    Assembly customAssembly = Assembly.LoadFrom(assemblyPath);
                    LogEvent($"Custom assembly");

                    LogEvent($"ładowanie typu");
                    CdnApiType = customAssembly.GetType("cdn_api.cdn_api");
                    LogEvent($"załadowano typ: {CdnApiType?.Name}");
                }
                catch (Exception ex)
                {
                    // Loguj błędy do dziennika zdarzeń
                    LogEvent($"Błąd podczas ładowania zestawu: {ex.Message}");
                }
            }
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
                XLLoginInfo? item = configuration.GetSection("OptimaUsers:User").Get<XLLoginInfo>();
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
        //public ZarzadcaBazy? zarzadcaBazy { get; set; }
        static Type CdnApiType;// = typeof(cdn_api.cdn_api);

        //public static async Task<OutputMessage> TaskRun(Request response)
        //{
        //    EnqueueTask(new RequestTask() { Request = response });

        //    Fedder? fedder = null;
        //    int elapsedSeconds = 0;

        //    while (fedder == null && elapsedSeconds < 30)
        //    {
        //        await Task.Delay(100); // Oczekaj 100 milisekund przed ponownym sprawdzeniem         
        //        fedder = CanGetData(response.Guid);
        //        elapsedSeconds++;
        //    }

        //    if (fedder != null)
        //    {
        //        Fedders.Remove(fedder);
        //        return new OutputMessage
        //        {
        //            Date = DateTime.Now.ToString("s"),
        //            Guid = response.Guid,
        //            Message = $"{JsonConvert.SerializeObject(fedder.PrepareSerializeObject())}",
        //            ResultJson = "Wynikowy JSON",
        //            Methods = nameof(TaskRun)
        //        };
        //    }
        //    else
        //    {
        //        return new OutputMessage
        //        {
        //            Date = DateTime.Now.ToString("s"),
        //            Guid = response.Guid,
        //            Message = $"Zainicjowano nowe zadania do kolejki operacji w XL. Dane oczekujące na przetworzenie: {GetQueueSize()}, W danym cyklu kolejki Wykonano {taskCount} Operacji.. Trwa przetwarzanie danych...",
        //            InnerMessage = "Zachowaj Guid aby przejrzeć wyniki operacji do 24h dnia roboczego. Po 24h dane operacji pozostaną usunięte z pamięci tymczasowej. Zmodyfikowane w trakcie operacji dane na bazie XL pozostaną zachowane.",
        //            Methods = nameof(TaskRun)
        //        };
        //    }
        //}

        public static async Task<OutputMessage> TaskRun(Request response)
        {
            try
            {
                EnqueueTask(new RequestTask() { Request = response });

                Fedder? fedder;
                do
                {
                    fedder = CanGetData(response.Guid);
                } while (fedder == null && (DateTime.Now - response.DateTime).TotalSeconds < 30);

                if (fedder != null)
                {
                    Fedders.Remove(fedder);
                    return new OutputMessage()
                    {
                        Date = DateTime.Now.ToString("s"),
                        Guid = response.Guid,
                        Message = $"{JsonConvert.SerializeObject(fedder.PrepareSerializeObject())}",
                        ResultJson = "Wynikowy JSON",
                        Methods = nameof(TaskRun)
                    };
                }
                else
                {
                    // Zwróć informację o zainicjowaniu i trwającej operacji przetwarzania danych
                    return new OutputMessage()
                    {
                        Date = DateTime.Now.ToString("s"),
                        Guid = response.Guid,
                        Message = $"Zainicjowano nowe zadania do kolejki operacji w XL. Dane oczekujące na przetworzenie: {GetQueueSize()}, W danym cyklu kolejki Wykonano {taskCount} Operacji.. Trwa przetwarzanie danych...",
                        InnerMessage = " Zachowaj Guid aby przejrzeć wyniki operacji do 24h dnia roboczego. Po 24h dane operacji pozostaną usunięte z pamięci tymczasowej. Zmodyfikowane w trakcie operacji dane na bazie XL pozostaną zachowane.",
                        Methods = nameof(TaskRun)
                    };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private static XLResponse? PrepareObjectAndInvokeMethod<T>(T? item, string CreateObjectInstanceName, string InvokeMethodName, ref object[] args)
        {
            XLResponse? response = null;
            var resultObject = XLReflection.CreateObjectInstance($"{CreateObjectInstanceName}_{XLMainController.Wersja}", item);
            if (resultObject != null)
            {
                if (CreateObjectInstanceName.EndsWith("XLLoginInfo") || CreateObjectInstanceName.EndsWith("XLAtrObiektInfo"))
                    args[0] = resultObject;
                else
                {
                    object[] newArgs = new object[args.Length + 1];
                    Array.Copy(args, newArgs, args.Length);
                    newArgs[^1] = resultObject;
                    args = newArgs;
                }
                int res = XLReflection.GetMethodAndInvoke(InvokeMethodName, args, ref XLMainController.CdnApiType);
                response = new XLResponse(res, resultObject);
            }
            return response;
        }
    }
}


