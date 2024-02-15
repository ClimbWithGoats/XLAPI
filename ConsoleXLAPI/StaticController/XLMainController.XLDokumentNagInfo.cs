using ConsoleXLAPI.Models;
using ConsoleXLAPI.XLControllers;

namespace ConsoleXLAPI.StaticController
{
    public static partial class XLMainController
    {
        public static void AddOrUpdateDoc(XLDokumentNagInfo orderDoc)
        {
            // Debug.WriteLine($"Metoda {nameof(AddOrUpdateDoc)} działa na wątku o ID: {Environment.CurrentManagedThreadId} {orderDoc.Typ}");
            int id = 0;
            object[] args = { Sesja, id };
            //
            var DynamicResult = repository.FindDocumentsByFullName(orderDoc.NumerPelny);
            if (orderDoc.NumerPelny != "FA/9/2023")
            {
                if (DynamicResult != null)
                {
                    foreach (var dr in DynamicResult)
                    {
                        var GIDTyp = dr?.Typ;
                        var GidNumer = dr?.GidNumer;
                        var Wartosc = dr?.Wartosc;
                        string x = string.Format("Dokument o typie: {0} Istnieje pod GidNumer: {1} pod nazwą atrybutu {2} : {3}", GIDTyp, GidNumer, Wartosc, DateTime.Now.ToString("g"));
                        // Debug.WriteLine(x);
                        return;
                    }
                }
            }
            var result = PrepareObjectAndInvokeMethod<XLDokumentNagInfo>(orderDoc, $"cdn_api.{nameof(XLDokumentNagInfo)}", nameof(Metody.XLNowyDokument), ref args);
            if (result != null && result.ResId == 0 && result.ResultObject != null)
            {
                orderDoc.GIDNumer = (int?)XLReflection.GetField(result.ResultObject, nameof(orderDoc.GIDNumer));
                orderDoc.GIDTyp = (int?)XLReflection.GetField(result.ResultObject, nameof(orderDoc.GIDTyp));

                if (orderDoc.GIDNumer > 0)
                {
                    List<XLAtrKlasaNagInfoExt>? documentAttributes = configuration.GetSection("Attributes:Documents").Get<List<XLAtrKlasaNagInfoExt>>();
                    if (documentAttributes != null && documentAttributes.Any())
                        AddAttributes(orderDoc, documentAttributes);
                }

                object[] BaseArgs = { args[1] };

                foreach (var position in orderDoc.Pozycje)
                {
                    object[] resultArgs = { args[1] };
                    var posResult = PrepareObjectAndInvokeMethod<XLDokumentElemInfo>(position, $"cdn_api.{nameof(XLDokumentElemInfo)}", nameof(Metody.XLDodajPozycje), ref resultArgs);
                }

                foreach (var position in orderDoc.Platnosci)
                {
                    object[] resultArgs = { args[1] };
                    var posResult = PrepareObjectAndInvokeMethod<XLPlatnoscInfo>(position, $"cdn_api.{nameof(XLPlatnoscInfo)}", nameof(Metody.XLDodajPlatnosc), ref resultArgs);
                }

                XLZamkniecieDokumentuInfo close = new() { Tryb = 5 };
                var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieDokumentuInfo>(close, $"cdn_api.{nameof(XLZamkniecieDokumentuInfo)}", nameof(Metody.XLZamknijDokument), ref BaseArgs);
            }
        }



        public static void AddDocuments(List<XLDokumentNagInfo> list, Guid guid)
        {
            // Debug.WriteLine($"Metoda {nameof(AddDocuments)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLDokumentNagInfo orderDoc in list)
                AddOrUpdateDoc(orderDoc);
            SetProccesing(guid, false);
        }
    }
}


