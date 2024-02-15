using System;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod )
    public static partial class XLMainController
    {


        public static int SprawdzWersje(int wersjaXL)
        {
            // Console.WriteLine($"Metoda {nameof(SprawdzWersje)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            object[] args = { wersjaXL };
            return XLReflection.GetMethodAndInvoke("XLSprawdzWersje", args, ref XLMainController.CdnApiType);
        }

        public static void CreateLoginObjectAndLogin(XLLoginInfo account)
        {

            // Console.WriteLine($"Metoda {nameof(CreateLoginObjectAndLogin)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            int err = SprawdzWersje(XLMainController.Wersja);
            Console.WriteLine("Wynik sprawdzania wersji: " + err);
            if (err == 0)
            {
                int res = repository.FindLastSessionIfIsActive();
                account.UtworzWlasnaSesje = res > 0 ? 0 : 1;
                int RESULT = Zaloguj(account);

                XLMainController.IsLoged = RESULT.Equals(0);
            }

        }

        public static int Zaloguj(XLLoginInfo obj)
        {
            // Console.WriteLine($"Metoda {nameof(Zaloguj)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            object[] args = { obj, 0 };
            var result = PrepareObjectAndInvokeMethod<XLLoginInfo>(obj, $"cdn_api.{nameof(XLLoginInfo)}", nameof(Metody.XLLogin), ref args);
            Sesja = (int)args[1];
            int resId = result?.ResId ?? -999999;

            if (resId != 0)
            {
                Wyloguj();
            }
            return resId;
        }

        public static string Wyloguj()
        {
            // Console.WriteLine($"Metoda {nameof(Wyloguj)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            object[] args = { Sesja };
            int result = XLReflection.GetMethodAndInvoke("XLLogout", args, ref XLMainController.CdnApiType);
            IsLoged = false;
            return result == 0 ? $"Pomyślnie wylogowano z sesji: " + XLMainController.Sesja : $"Wylogowanie z kodem błędu: {result}";
        }

        public static string PobierzIloscZdarzen()
        {
            // Console.WriteLine($"Metoda {nameof(PobierzIloscZdarzen)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");

            object[] args = Array.Empty<object>();
            var result = PrepareObjectAndInvokeMethod<XLIloscInfo>(new XLIloscInfo(), $"cdn_api.{nameof(XLIloscInfo)}", nameof(Metody.XLPobierzIloscZdarzen), ref args);

            if (result == null || result.ResId == -1)
            {
                return $"API nieaktywne lub nieprawidłowa Wersja API {result}";
            }
            else if (result.ResId == 0)
            {
                return $"Result Ok: {result.ResId}";
            }
            else if (result.ResId > 0)
            {
                return $"Liczba zdarzeń w programie XL: {result.ResId}";
            }
            else
            {
                return $"Nieoczekiwana wartość ResId: {result.ResId}";
            }
        }

    }
}


