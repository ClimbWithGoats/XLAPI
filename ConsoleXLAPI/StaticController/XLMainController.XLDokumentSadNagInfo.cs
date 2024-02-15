using ConsoleXLAPI.Models;
using ConsoleXLAPI.XLControllers;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )


    public static partial class XLMainController
    {

        public static void AddOrUpdateDoc(XLDokumentSadNagInfo orderDoc)
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

            var result = PrepareObjectAndInvokeMethod<XLDokumentSadNagInfo>(orderDoc, $"cdn_api.{nameof(XLDokumentSadNagInfo)}", nameof(Metody.XLNowyDokumentSad), ref args);
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
                    var posResult = PrepareObjectAndInvokeMethod<XLDokumentSadElemInfo>(position, $"cdn_api.{nameof(XLDokumentSadElemInfo)}", nameof(Metody.XLDodajPozycjeSad), ref resultArgs);
                }

                XLZamkniecieDokumentuSadInfo close = new() { Tryb = 0 };
                var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieDokumentuSadInfo>(close, $"cdn_api.{nameof(XLZamkniecieDokumentuSadInfo)}", nameof(Metody.XLZamknijDokumentSad), ref BaseArgs);
            }
        }

        public static void AddDocuments(List<XLDokumentSadNagInfo> list, Guid guid)
        {
            // Debug.WriteLine($"Metoda {nameof(AddDocuments)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLDokumentSadNagInfo orderDoc in list)
                AddOrUpdateDoc(orderDoc);
            SetProccesing(guid, false);
        }
    }
}


