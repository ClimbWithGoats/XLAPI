//using ItegerXLAPI.Models;
//using Microsoft.Extensions.Logging;
//using System.Reflection;
//using System.Runtime.InteropServices;
//using cdn_api;
//using System.Diagnostics;
//using ItegerXLAPI.XLControllers;

//namespace ItegerXLAPI.Service
//{
//    public class XLAbstractService
//    {
//        //protected Logger logger = NLog.LogManager.GetCurrentClassLogger();

//        [DllImport("ClaRUN.dll")]
//        protected static extern void AttachThreadToClarion(int _flag);

//        public XLAbstractService()
//        {
//            cdnApiType = typeof(cdn_api.cdn_api);
//        }
//        protected int Wersja = 20231;
//        protected int Sesja = 0;
//        protected int FrsId = 0;

//        protected string? ProgramId { get; set; }
//        protected string? SerwerKlucza { get; set; }
//        protected string? LoginName { get; set; }
//        protected string? Password { get; set; }
//        protected string? BazaDanych { get; set; }
//        protected string? PlikLog { get; set; }

//        protected bool AttachToClarion { get; set; }

//        private readonly Type cdnApiType;


//        public object? CreateObjectInstance(string className, Dictionary<string, object> Properties)
//        {
//            object? obj = XLReflection.GetInstance(className);
//            if (obj != null)
//            {
//                foreach (var item in Properties)
//                    SetProperty(obj, item.Key, item.Value);
//            }

//            else
//            {
//                Debug.WriteLine($"Nie znaleziono metody {className} w przestrzeni nazw");
//            }

//            return obj;
//        }
//        public object? CreateObjectInstance<T>(string className, T MappingObject)
//        {
//            if (MappingObject == null)
//                return null;

//            object? obj = XLReflection.GetInstance(className);
//            if (obj != null)
//            {
//                var properties = MappingObject.GetType().GetProperties();
//                foreach (var property in properties)
//                {
//                    object? value = property.GetValue(MappingObject);
//                    if (value != null)
//                    {
//                        SetProperty(obj, property.Name, value);
//                    }
//                }
//            }

//            else
//            {
//                Debug.WriteLine($"Nie znaleziono metody {className} w przestrzeni nazw");
//            }

//            return obj;
//        }

//        public int GetMethodAndInvoke(string methodName, ref object[] args)
//        {
//            int result = -999999;
//            MethodInfo? method = cdnApiType.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public);
//            if (method != null)
//            {
//                // Wywołaj metodę XLLogin
//                var resulted = method.Invoke(null, args);
//                if (resulted != null)
//                    int.TryParse(resulted.ToString(), out result);
//            }
//            else
//            {
//                Debug.WriteLine($"Nie znaleziono metody {methodName} w klasie cdn_api");
//            }
//            return result;
//        }


//        public int SprawdzWersje(int wersjaXL)
//        {
//            int lWersja = wersjaXL;
//            object[] args = { lWersja };
//            return GetMethodAndInvoke("XLSprawdzWersje", ref args);
//        }

//        public int Zaloguj(object obj)
//        {
//            //string className = $"cdn_api.XLLoginInfo_{Wersja}";
//            //object? loginObj = XLReflection.GetInstance(className);
//            object[] args = { obj, Sesja };
//            int result = GetMethodAndInvoke("XLLogin", ref args);
//            Sesja = (int)args[1];
//            if (result != 0)
//            {
//                Wyloguj();
//                AttachThreadToClarion(0);
//            }
//            return result;
//        }

//        public int Wyloguj()
//        {
//            object[] args = { Sesja };
//            int result = GetMethodAndInvoke("XLLogout", ref args);
//            Debug.WriteLineIf(result == 0, "Pomyślnie wylogowano z sesji");
//            return result;
//        }


//        public string CreateLoginObjectAndLogin()
//        {

//            ProgramId = "TestApi";
//            SerwerKlucza = "";
//            LoginName = "Admin";
//            Password = "";
//            BazaDanych = "Wzorcowa";
//            PlikLog = "";
//            string textResult = "";
//            int err = SprawdzWersje(Wersja);
//            if (err == 0)
//            {
//                textResult = "Poprawna wersja";
//                Debug.WriteLine(textResult);
//                Dictionary<string, object> LoginProperties = new Dictionary<string, object>
//                {
//                    { "UtworzWlasnaSesje", 1 },
//                    { "Wersja", Wersja },
//                    { "ProgramID", ProgramId },
//                    { "SerwerKlucza", SerwerKlucza },
//                    { "Winieta", -1 },
//                    { "OpeIdent", LoginName },
//                    { "OpeHaslo", Password },
//                    { "TrybWsadowy", 1 },
//                    { "PlikLog", PlikLog },
//                    { "TrybNaprawy", 0 },
//                    { "SesjaKlucza", "" },
//                    { "Baza", BazaDanych }
//                };
//                object? obj = CreateObjectInstance($"cdn_api.XLLoginInfo_{Wersja}", LoginProperties);
//                if (obj != null)
//                {
//                    int loginObject = Zaloguj(obj);
//                    Debug.WriteLineIf(loginObject == 0, $"Pomyślnie zalogowano użytkownika w XL pod numerem sesji {Sesja}");
//                }
//            }
//            else
//            {
//                textResult = "Niepoprawna wersja programu, skontaktuj się z firmą Iteger";
//                Debug.WriteLineIf(err == -1, textResult);

//            }

//            return textResult;
//        }

//        private void SetProperty(object obj, string propertyName, object value)
//        {
//            if (obj != null)
//            {
//                FieldInfo? field = obj.GetType().GetField(propertyName);
//                if (field != null)
//                    field.SetValue(obj, value);
//                else
//                {
//                    Debug.WriteLine("Nie można ustawić wartości właściwości o nazwie: " + propertyName);

//                }
//            }
//        }

//        internal string PobierzIloscZdarzen()
//        {

//            string result = "";
//            Dictionary<string, object> IloscInfoProperties = new Dictionary<string, object>
//            {
//                { "Wersja", Wersja }
//            };

//            object? obj = CreateObjectInstance($"cdn_api.XLIloscInfo_{Wersja}", IloscInfoProperties);
//            if (obj != null)
//            {
//                object[] args = { obj };
//                int res = GetMethodAndInvoke("XLPobierzIloscZdarzen", ref args);
//                if (res == 0)
//                {
//                    result = $"Result Ok: {result}";
//                }
//                else if (res == -1)
//                {
//                    result = $"API nieaktywne lub nieprawidłowa Wersja API {result}";

//                }
//                else if (res > 0)
//                {

//                    result = $"Liczba zdarzeń w programie XL: {result}";
//                }
//                Debug.WriteLineIf(res == 0, $"OK: {result}");
//                Debug.WriteLineIf(res == -1, $"API nieaktywne lub nieprawidłowa Wersja API {result}");
//                Debug.WriteLineIf(res > 0, $"Liczba zdarzeń w programie XL: {result}");

//            }
//            return result;
//        }

//        internal void AddOrUpdateContractor(Contractor contractor)
//        {

//            var resultObject = CreateObjectInstance($"cdn_api.XLKontrahentInfo_{Wersja}",contractor);
//            if (resultObject == null)
//            {
//                Debug.WriteLine($"Nie zainicjowano obiektu w XL dla {contractor.Akronim}");
//            }
//            else
//            {
//                object[] args = { resultObject, Sesja };
//                int result = GetMethodAndInvoke("XLNowyKontrahent", ref args);
//                Debug.WriteLine($"Wykonanie nowego kontrahenta w XL. Komunikat o kodzie: {result}");
//            }
//        }

//        public void AddContractors(List<Contractor> list)
//        {
//            foreach (Contractor contractor in list)
//                AddOrUpdateContractor(contractor);
            
//        }
//    }
//}
