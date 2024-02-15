using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{

    public class DocNumeration
    {
        public DocNumeration(string nrDok, string nrPel, string nrStr)
        {
            NumerString = nrDok;
            NumerPelny = nrPel;
            NumerString = nrStr;

            var splitEffectNrDok = nrDok.Split('/');
            var splitNrPel = nrPel.Split('/');
            var splitEffectNrStr = nrStr.Split('/');

            var t = this.GetType();
            int howManyIgnored = 0;
            for (int i = 0; i < splitEffectNrDok.Length; i++)
            {
                try
                {
                    string text = splitEffectNrDok[i];
                    if (text.Equals("@brak"))
                    {
                        howManyIgnored++;
                        continue;
                    }
                    var propertyName = splitEffectNrDok[i].Replace("@", "");
                    var property = t.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    if (property != null)
                    {
                        var targetType = property.PropertyType;
                        var converter = TypeDescriptor.GetConverter(targetType);
                        if (converter != null)
                        {
                            try
                            {
                                var convertedValue = converter.ConvertFromString(splitNrPel[i - howManyIgnored]);
                                property.SetValue(this, convertedValue);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error converting property {propertyName} - {ex.Message}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No TypeConverter found for property {propertyName}");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error processing property: {e.Message}");
                }
            }
        }




        // rok obrachunkowy?
        public string Magazyn { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? NumerS { get; set; }
        public string Rejestr { get; set; }
        public System.Int32? Rok_kal { get; set; }
        public string Symbol { get; set; }

        public string NumeracjaDok { get; set; }
        public string NumerPelny { get; set; }
        public string NumerString { get; set; }

        public void Map(string template, string nrString, string nrPelny)
        {

        }

    }
    public static partial class XLMainController
    {
        public static void AddOrUpdateDoc(XLDokumentNagInfo orderDoc)
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
            orderDoc.MagazynD = doc.Magazyn;
            orderDoc.DokumentObcy = orderDoc.NumerPelny;


            int id = 0;
            object[] args = { Sesja, id };
            var DynamicResult = repository.FindDocumentsByFullName(orderDoc.NumerPelny);

            if (DynamicResult != null)
            {
                foreach (var dr in DynamicResult)
                {
                    var GIDTyp = dr?.Typ;
                    var GidNumer = dr?.GidNumer;
                    var Wartosc = dr?.Wartosc;
                    orderDoc.GIDNumer = GidNumer;
                    string ox = string.Format("Dokument o typie: {0} Istnieje pod GidNumer: {1} pod nazwą atrybutu {2} : {3}", GIDTyp, GidNumer, Wartosc, DateTime.Now.ToString("g"));
                    Console.WriteLine(ox);
                    return;
                }
            }

            var result = PrepareObjectAndInvokeMethod<XLDokumentNagInfo>(orderDoc, $"cdn_api.{nameof(XLDokumentNagInfo)}", nameof(Metody.XLNowyDokument), ref args);
            if (result != null && result.ResId == 0 && result.ResultObject != null)
            {
                orderDoc.GIDNumer = (int)XLReflection.GetField(result.ResultObject, nameof(orderDoc.GIDNumer));
                orderDoc.GIDTyp = (int)XLReflection.GetField(result.ResultObject, nameof(orderDoc.GIDTyp));

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
                    var posResult = PrepareObjectAndInvokeMethod<XLDokumentElemInfo>(position, $"cdn_api.{nameof(XLDokumentElemInfo)}", nameof(Metody.XLDodajPozycje), ref resultArgs);
                    if (posResult.ResId == 0)
                        countPos++;
                }
                var res = countPos;

                foreach (var position in orderDoc.Platnosci)
                {
                    object[] resultArgs = { args[1] };
                    var posResult = PrepareObjectAndInvokeMethod<XLPlatnoscInfo>(position, $"cdn_api.{nameof(XLPlatnoscInfo)}", nameof(Metody.XLDodajPlatnosc), ref resultArgs);
                }
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
                XLZamkniecieDokumentuInfo close = new XLZamkniecieDokumentuInfo() { Tryb = tryb };
                var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieDokumentuInfo>(close, $"cdn_api.{nameof(XLZamkniecieDokumentuInfo)}", nameof(Metody.XLZamknijDokument), ref BaseArgs);
            }
        }



        public static void AddDocuments(List<XLDokumentNagInfo> list, Guid guid)
        {
            // Console.WriteLine($"Metoda {nameof(AddDocuments)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLDokumentNagInfo orderDoc in list)
                AddOrUpdateDoc(orderDoc);
            SetProccesing(guid, false);
        }
    }
}


