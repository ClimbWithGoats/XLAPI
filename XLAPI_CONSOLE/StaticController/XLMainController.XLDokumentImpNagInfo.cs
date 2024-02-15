﻿using System;
using System.Collections.Generic;
using System.Linq;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{
    public static partial class XLMainController
    {
        public static void AddOrUpdateDoc(XLDokumentImpNagInfo orderDoc)
        {
            var doc = new DocNumeration(orderDoc.NumeracjaDok, orderDoc.NumerPelny, orderDoc.NumerString);

            Console.WriteLine("$$$${0}   {1}", orderDoc.NumeracjaDok, orderDoc.NumerPelny, orderDoc.NumerString);
            // Console.WriteLine($"Metoda {nameof(AddOrUpdateDoc)} działa na wątku o ID: {Environment.CurrentManagedThreadId} {orderDoc.Typ}");
            //  orderDoc.IncotermsSymbol
            // pytanie czy nie przenieść tego elementu do osobnej metody. Oraz czy nie rozbić klasy statycznej partial na własne klasy abstrakcyjne.
            // ograniczeniem jest wątkowość

            orderDoc.Numer = doc.NumerS;
            orderDoc.Miesiac = doc.Miesiac;
            orderDoc.Rok = doc.Rok_kal;
            orderDoc.Seria = doc.Rejestr;
            orderDoc.DokumentObcy = orderDoc.NumerPelny;

            // Console.WriteLine($"Metoda {nameof(AddOrUpdateDoc)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            int id = 0;
            object[] args = { Sesja, id };


            var DynamicResult = repository.FindDocumentsByFullName(orderDoc.NumerPelny + "1");
            if (DynamicResult != null && DynamicResult.Any())
            {
                var t = DynamicResult.FirstOrDefault();
                Console.WriteLine(string.Format("Dokument o typie: {0} Istnieje pod GidNumer: {1} pod nazwą atrybutu {2}", t.Typ, t.GidNumer, t.Wartosc));
                return;
            }

            var result = PrepareObjectAndInvokeMethod<XLDokumentImpNagInfo>(orderDoc, $"cdn_api.{nameof(XLDokumentImpNagInfo)}", nameof(Metody.XLNowyDokumentZam), ref args);
            if (result != null && result.ResId == 0 && result.ResultObject != null)
            {
                orderDoc.GIDNumer = (int)XLReflection.GetField(result.ResultObject, nameof(orderDoc.GIDNumer));

                if (orderDoc.GIDNumer > 0)
                {
                    //  List<XLAtrKlasaNagInfoExt> documentAttributes = configuration.GetSection("Attributes:Documents").Get<List<XLAtrKlasaNagInfoExt>>();
                    List<XLAtrKlasaNagInfoExt> documentAttributes = configuration.Attributes.Documents;
                    if (documentAttributes != null && documentAttributes.Any())
                        AddAttributes(orderDoc, documentAttributes);
                }

                object[] BaseArgs = { args[1] };

                int countPos = 0;
                foreach (var position in orderDoc.Pozycje)
                {
                    object[] resultArgs = { args[1] };
                    var posResult = PrepareObjectAndInvokeMethod<XLDokumentImpElemInfo>(position, $"cdn_api.{nameof(XLDokumentImpElemInfo)}", nameof(Metody.XLDodajPozycjeImp), ref resultArgs);
                    if (posResult.ResId == 0)
                        countPos++;
                }

                var res = countPos;

                int tryb = 0;
                if (countPos == orderDoc.Pozycje.Count)
                {
                    Console.WriteLine(string.Format("Dok {0}: Ilosc pozycji {1} <= {2}, tryb 5", orderDoc.NumerPelny, countPos, orderDoc.Pozycje.Count));

                    tryb = 0;
                }
                else if (countPos < orderDoc.Pozycje.Count)
                {
                    Console.WriteLine(string.Format("Dok {0}: Ilosc pozycji {1} <= {2}, tryb -1", orderDoc.NumerPelny, countPos, orderDoc.Pozycje.Count));
                    tryb = -1;
                }

                XLZamkniecieDokumentuImpInfo close = new XLZamkniecieDokumentuImpInfo() { Tryb = tryb };
                var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieDokumentuImpInfo>(close, $"cdn_api.{nameof(XLZamkniecieDokumentuImpInfo)}", nameof(Metody.XLZamknijDokumentImp), ref BaseArgs);
            }
        }

        public static void AddDocuments(List<XLDokumentImpNagInfo> list, Guid guid)
        {
            // Console.WriteLine($"Metoda {nameof(AddDocuments)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLDokumentImpNagInfo orderDoc in list)
                AddOrUpdateDoc(orderDoc);
            SetProccesing(guid, false);
        }
    }
}


