using System;
using System.Collections.Generic;
using System.Linq;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod )

    public static partial class XLMainController
    {
        public static void AddOrUpdateCommodity(XLTowarInfo commodity)
        {
            //string resultMessage = "";
            // Console.WriteLine($"Metoda {nameof(AddOrUpdateCommodity)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");

            if (string.IsNullOrEmpty(commodity.Kod))
                return;

            var IdResult = repository.FindIdTwrByCode(commodity.Kod);
            if (IdResult == -1)
            {
                if (commodity.Typ == 0)
                {
                    commodity.Typ = 4;
                }
                int id = 0;
                object[] args = { Sesja, id };
                var result1 = PrepareObjectAndInvokeMethod<XLTowarInfo>(commodity, $"cdn_api.{nameof(XLTowarInfo)}", nameof(Metody.XLNowyTowar), ref args);
                var resultObject = XLReflection.CreateObjectInstance($"cdn_api.XLTowarInfo_{XLMainController.Wersja}", commodity);
                if (result1 != null && result1.ResId == 0 && result1.ResultObject != null)
                {
                    commodity.GIDNumer = (int)XLReflection.GetField(result1.ResultObject, nameof(commodity.GIDNumer));
                    object[] BaseArgs = { args[1] };
                    var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieTowaruInfo>(new XLZamkniecieTowaruInfo(), $"cdn_api.{nameof(XLZamkniecieTowaruInfo)}", nameof(Metody.XLZamknijTowar), ref BaseArgs);
                }
                var DynamicResult = repository.GetDataForTwrsModify(commodity.Kod);
                if (DynamicResult != null)
                    foreach (var dr in DynamicResult)
                    {
                        commodity.GIDTyp = dr.GIDTyp;
                        commodity.GIDFirma = dr.GIDFirma;
                        commodity.GIDNumer = dr.GIDNumer;
                    }
            }
            if (IdResult > 0)
            {
                var DynamicResult = repository.GetDataForTwrsModify(commodity.Kod);
                if (DynamicResult != null)
                    foreach (var dr in DynamicResult)
                    {
                        commodity.GIDTyp = dr.GIDTyp;
                        commodity.GIDFirma = dr.GIDFirma;
                        commodity.GIDNumer = dr.GIDNumer;
                    }
            }
            if (commodity.GIDNumer > 0)
            {
                //List<XLAtrKlasaNagInfoExt> commoditiesAttributies = configuration.GetSection("Attributes:commodities").Get<List<XLAtrKlasaNagInfoExt>>();

                List<XLAtrKlasaNagInfoExt> commoditiesAttributies = configuration.Attributes.commodities;
                if (commoditiesAttributies != null && commoditiesAttributies.Any())
                    AddAttributes(commodity, commoditiesAttributies);
            }
        }

        public static void AddCommodities(List<XLTowarInfo> list, Guid guid)
        {
            // Console.WriteLine($"Metoda {nameof(AddCommodities)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLTowarInfo commodity in list)
                AddOrUpdateCommodity(commodity);
            SetProccesing(guid, false);
        }
    }
}


