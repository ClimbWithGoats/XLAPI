using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod )

    public static partial class XLMainController
    {

        public static void AddOrUpdateCategories(XLGrupaTwrInfo category)
        {
            // Console.WriteLine($"Metoda {nameof(AddOrUpdateCategories)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");

            // co zwracać True false Czy obiekt?
            if (string.IsNullOrEmpty(category.Kod))
                return;

            var IdResult1 = repository.FindIdCategoryByCode(category.Kod);
            if (IdResult1 == -1)
            {
                if (category.Typ == 0)
                {
                    category.Typ = 4;
                }
                object[] args = { Sesja };
                var result1 = PrepareObjectAndInvokeMethod<XLGrupaTwrInfo>(category, $"cdn_api.{nameof(XLGrupaTwrInfo)}", nameof(Metody.XLNowaGrupaTwr), ref args);
                var resultObject = XLReflection.CreateObjectInstance($"cdn_api.XLGrupaTwrInfo_{XLMainController.Wersja}", category);
                if (result1 != null && result1.ResId == 0 && result1.ResultObject != null)
                {
                    category.GIDNumer = (int)XLReflection.GetField(result1.ResultObject, nameof(category.GIDNumer));
                }

            }
        }

        public static void AddCategories(List<XLGrupaTwrInfo> list, Guid guid)
        {
            // Console.WriteLine($"Metoda {nameof(AddCategories)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLGrupaTwrInfo category in list)
                AddOrUpdateCategories(category);
            SetProccesing(guid, false);
        }
    }
}


