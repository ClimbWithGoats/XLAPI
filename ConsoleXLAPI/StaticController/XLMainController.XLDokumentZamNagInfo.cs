using ConsoleXLAPI.Models;
using ConsoleXLAPI.XLControllers;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )


    public static partial class XLMainController
    {

        public static void AddOrUpdateDoc(XLDokumentZamNagInfo orderDoc)
        {
            // Debug.WriteLine($"Metoda {nameof(AddOrUpdateDoc)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            int id = 0;
            object[] args = { Sesja, id };

            var DynamicResult = repository.FindDocumentsByFullName(orderDoc.NumerPelny);
            if (DynamicResult != null && DynamicResult.Any())
            {
                var t = DynamicResult.FirstOrDefault();
                // Debug.WriteLine(string.Format("Dokument o typie: {0} Istnieje pod GidNumer: {1} pod nazwą atrybutu {2}", t.Typ, t.GidNumer, t.Wartosc));
                return;
            }

            var result = PrepareObjectAndInvokeMethod<XLDokumentZamNagInfo>(orderDoc, $"cdn_api.{nameof(XLDokumentZamNagInfo)}", nameof(Metody.XLNowyDokumentZam), ref args);
            if (result != null && result.ResId == 0 && result.ResultObject != null)
            {
                orderDoc.GIDNumer = (int?)XLReflection.GetField(result.ResultObject, nameof(orderDoc.GIDNumer));

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
                    var posResult = PrepareObjectAndInvokeMethod<XLDokumentZamElemInfo>(position, $"cdn_api.{nameof(XLDokumentZamElemInfo)}", nameof(Metody.XLDodajPozycjeZam), ref resultArgs);
                }
                foreach (var position in orderDoc.Platnosci)
                {
                    object[] resultArgs = { args[1] };
                    var posResult = PrepareObjectAndInvokeMethod<XLDokumentZamPlatInfo>(position, $"cdn_api.{nameof(XLDokumentZamPlatInfo)}", nameof(Metody.XLDodajPlatnoscZam), ref resultArgs);
                }
                XLZamkniecieDokumentuZamInfo close = new() { TrybZamkniecia = 0 };
                var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieDokumentuZamInfo>(close, $"cdn_api.{nameof(XLZamkniecieDokumentuZamInfo)}", nameof(Metody.XLZamknijDokumentZam), ref BaseArgs);
            }
        }

        public static void AddDocuments(List<XLDokumentZamNagInfo> list, Guid guid)
        {
            // Debug.WriteLine($"Metoda {nameof(AddDocuments)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLDokumentZamNagInfo orderDoc in list)
                AddOrUpdateDoc(orderDoc);
            SetProccesing(guid, false);
        }
    }
}


