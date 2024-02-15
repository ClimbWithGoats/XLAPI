using ConsoleXLAPI.Models;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )

    public static partial class XLMainController
    {

        public static int AddClass(XLAtrKlasaNagInfoExt item, int gIDNumer)
        {
            object[] openArgs = { XLMainController.Sesja, gIDNumer };
            var closeResult = PrepareObjectAndInvokeMethod<XLAtrKlasaNagInfo>(item, $"cdn_api.{nameof(XLAtrKlasaNagInfo)}", nameof(Metody.XLAtrNowaKlasa), ref openArgs);
            return closeResult?.ResId ?? -99999;
        }

        public static void AddAttributes(object obj, List<XLAtrKlasaNagInfoExt> attributes)
        {
            XLAtrybutInfo xLAtrybut = new()
            {
                GIDTyp = (int)(obj.GetType().GetProperty(nameof(xLAtrybut.GIDTyp))?.GetValue(obj) ?? 0),
                GIDFirma = (int)(obj.GetType().GetProperty(nameof(xLAtrybut.GIDFirma))?.GetValue(obj) ?? 0),
                GIDNumer = (int)(obj.GetType().GetProperty(nameof(xLAtrybut.GIDNumer))?.GetValue(obj) ?? 0),
                GIDLp = (int)(obj.GetType().GetProperty(nameof(xLAtrybut.GIDLp))?.GetValue(obj) ?? 0),
                GIDSubLp = (int)(obj.GetType().GetProperty(nameof(xLAtrybut.GIDSubLp))?.GetValue(obj) ?? 0)
            };

            foreach (var item in attributes)
            {
                if (item == null) continue;
                var classExists = repository.FindClass(item.Nazwa) ?? new List<dynamic>();


                classExists = repository.FindClass(item.Nazwa) ?? new List<dynamic>();
                if (!classExists.Any())
                    AddClass(item, xLAtrybut?.GIDNumer ?? 0);

                classExists = repository.FindClass(item.Nazwa) ?? new List<dynamic>();
                if (classExists.Any())
                {
                    var elem = classExists.First();
                    if (xLAtrybut != null && item != null)
                    {
                        xLAtrybut.Klasa = item.Nazwa;
                        xLAtrybut.Wartosc = !string.IsNullOrEmpty(item.JsonPropertyName) ? obj.GetType().GetProperty(item.JsonPropertyName)?.GetValue(obj)?.ToString() ?? "" : "";

                        object[] Base = { XLMainController.Sesja };
                        XLResponse? xLResponse = null;
                        while (xLResponse == null || (xLResponse != null && xLResponse.ResId != 0))
                        {
                            object[] openArgs = Base;
                            xLResponse = PrepareObjectAndInvokeMethod<XLAtrybutInfo>(xLAtrybut, $"cdn_api.{nameof(XLAtrybutInfo)}", nameof(Metody.XLDodajAtrybut), ref openArgs);
                            if (xLResponse?.ResId != 0)
                            {
                                if (xLResponse?.ResId != 0)
                                    TryAddObjectToClass(xLAtrybut.GIDTyp, (int)elem?.ClassId);
                                //if (xLResponse?.ResId == 4) {
                                //    AddClass(item, xLAtrybut?.GIDNumer ?? 0);
                                //}
                            }
                        }
                    }
                }
            }
        }

        private static XLResponse? TryAddObjectToClass(int? gIDTyp, int classid)
        {

            object[] openArgs = { new XLAtrObiektInfo() { GIDTyp = gIDTyp, AtkID = classid }, 1 };
            var result = PrepareObjectAndInvokeMethod<XLAtrObiektInfo>(new XLAtrObiektInfo() { GIDTyp = gIDTyp, AtkID = classid }, $"cdn_api.{nameof(XLAtrObiektInfo)}", nameof(Metody.XLAtrObiekt), ref openArgs);

            return result;
        }

    }
    public class XLAtrKlasaNagInfoExt : XLAtrKlasaNagInfo
    {
        public string? JsonPropertyName { get; set; }
    }
}


