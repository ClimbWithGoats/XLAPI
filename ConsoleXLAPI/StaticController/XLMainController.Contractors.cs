using ConsoleXLAPI.Models;
using ConsoleXLAPI.XLControllers;
using System.Reflection;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )

    public static partial class XLMainController
    {
        public static void AddContractors(List<XLKontrahentInfo> list, Guid guid)
        {
            // Debug.WriteLine($"Metoda {nameof(AddContractors)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLKontrahentInfo contractor in list)
                AddOrUpdateContractor(contractor);
            SetProccesing(guid, false);
        }
        public static void AddOrUpdateContractor(XLKontrahentInfo contractor)
        {
            // Debug.WriteLine($"Metoda {nameof(AddOrUpdateContractor)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");

            // co zwracać? True false? Czy obiekt?
            if (string.IsNullOrEmpty(contractor.Akronim))
                return;

            int? IdResult = repository.FindIdContractorByAcronim(contractor.Akronim);
            if (IdResult == -1)
            {
                int id = 0;
                object[] args = { Sesja, id };
                var result = PrepareObjectAndInvokeMethod<XLKontrahentInfo>(contractor, $"cdn_api.{nameof(XLKontrahentInfo)}", nameof(Metody.XLNowyKontrahent), ref args);

                if (result != null && result.ResId == 0 && result.ResultObject != null)
                {
                    contractor.GIDNumer = (int?)XLReflection.GetField(result.ResultObject, nameof(contractor.GIDNumer));

                    object[] BaseArgs = { args[1] };
                    XLZamkniecieKontrahentaInfo close = new() { Tryb = 0 };
                    var closeResult = PrepareObjectAndInvokeMethod<XLZamkniecieKontrahentaInfo>(close, $"cdn_api.{nameof(XLZamkniecieKontrahentaInfo)}", nameof(Metody.XLZamknijKontrahenta), ref BaseArgs);
                }
                var DynamicResult = repository.GetDataForContractorsModify(contractor.Akronim);
                if (DynamicResult != null)
                    foreach (var dr in DynamicResult)
                    {
                        contractor.GIDTyp = dr.GIDTyp;
                        contractor.GIDFirma = dr.GIDFirma;
                        contractor.GIDNumer = dr.GIDNumer;
                    }
            }
            if (IdResult > 0)
            {
                var DynamicResult = repository.GetDataForContractorsModify(contractor.Akronim);
                if (DynamicResult != null)
                    foreach (var dr in DynamicResult)
                    {
                        contractor.GIDTyp = dr.GIDTyp;
                        contractor.GIDFirma = dr.GIDFirma;
                        contractor.GIDNumer = dr.GIDNumer;
                    }
            }

            if (contractor.GIDNumer > 0)
            {
                List<XLAtrKlasaNagInfoExt>? contractorsAttributes = configuration.GetSection("Attributes:Contractors").Get<List<XLAtrKlasaNagInfoExt>>();
                if (contractorsAttributes != null && contractorsAttributes.Any())
                    AddAttributes(contractor, contractorsAttributes);
            }
        }

        public static void AddContractorsSQL(List<XLKontrahentSQLInfo> list, Guid guid)
        {
            // Debug.WriteLine($"Metoda {nameof(AddContractorsSQL)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            SetProccesing(guid, true);
            foreach (XLKontrahentSQLInfo contractor in list)
                AddOrUpdateContractorSQL(contractor);
            SetProccesing(guid, false);
        }
        public static void AddOrUpdateContractorSQL(XLKontrahentSQLInfo crSQL)
        {
            string resultMessage = "";
            // Debug.WriteLine($"Metoda {nameof(AddOrUpdateContractorSQL)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            crSQL.GrpTyp ??= crSQL.GrpTyp; // grupy maja ujemne wartosci
            crSQL.GrpFirma ??= 3;// crSQL.GIDFirma;
            crSQL.GrpNumer ??= 0;// crSQL.GIDFirma;

            // co zwracać? True false? Czy obiekt?
            if (string.IsNullOrEmpty(crSQL.Akronim))
                return;

            int? IdResult = repository.FindIdContractorByAcronim(crSQL.Akronim);
            if (IdResult == -1)
            {
                object[] args = { Sesja };
                var result = PrepareObjectAndInvokeMethod<XLKontrahentSQLInfo>(crSQL, $"cdn_api.{nameof(XLKontrahentSQLInfo)}", nameof(Metody.XLNowyKontrahentSQL), ref args);
                if (result != null && result.ResId == 0 && result.ResultObject != null)
                {
                    crSQL.GIDNumer = (int?)XLReflection.GetField(result.ResultObject, nameof(crSQL.GIDNumer));
                    object[] BaseArgs = { args[1] };
                    var closeResult = PrepareObjectAndInvokeMethod<XLModyfikacjaKntSQLInfo>(new XLModyfikacjaKntSQLInfo(), $"cdn_api.{nameof(XLModyfikacjaKntSQLInfo)}", nameof(Metody.XLZamknijKontrahentaSQL), ref BaseArgs);
                }
                var DynamicResult = repository.GetDataForContractorsModify(crSQL.Akronim);
                if (DynamicResult != null)
                    foreach (var dr in DynamicResult)
                    {
                        crSQL.GIDTyp = dr.GIDTyp;
                        crSQL.GIDFirma = dr.GIDFirma;
                        crSQL.GIDNumer = dr.GIDNumer;
                    }

            }
            else if (IdResult > 0)
            {
                var DynamicResult = repository.GetDataForContractorsModify(crSQL.Akronim);
                if (DynamicResult != null)
                {
                    foreach (var x in DynamicResult)
                    {
                        XLModyfikacjaKntSQLInfo obj = new();

                        obj.GIDTyp = crSQL.GIDTyp = x.GIDTyp;
                        obj.GIDFirma = crSQL.GIDFirma = x.GIDFirma;
                        obj.GIDNumer = crSQL.GIDNumer = x.GIDNumer;

                        object[] args = { Sesja };
                        var result = PrepareObjectAndInvokeMethod<XLModyfikacjaKntSQLInfo>(obj, $"cdn_api.{nameof(XLModyfikacjaKntSQLInfo)}", nameof(Metody.XLOtworzKontrahentaSQL), ref args);
                        if (result != null && result.ResId == 0 && result.ResultObject != null)
                        {
                            BaseContractor item = crSQL as BaseContractor;
                            var baseContractorProperties = item.GetType().BaseType?.GetProperties() ?? Array.Empty<PropertyInfo>();

                            var filteredProperties = baseContractorProperties
                                .Where(property => property.DeclaringType == typeof(BaseContractor))
                                .ToArray();
                            foreach (var property in filteredProperties)
                            {

                                object? value = property.GetValue(item);
                                if (value != null && property.Name != null && !property.Name.Equals(nameof(obj.GIDTyp)) && !property.Name.Equals(nameof(obj.GIDFirma)) && !property.Name.Equals(nameof(obj.GIDNumer)) && !property.Name.Equals(nameof(obj.Wersja)))
                                {
                                    object? res = XLReflection.GetProperty(crSQL, property.Name);
                                    object? currentValue = XLReflection.GetField(result.ResultObject, property.Name);

                                    if (res != null && (!res.Equals(currentValue)))
                                    {
                                        XLReflection.SetField(result.ResultObject, nameof(obj.NazwaPola), property.Name);
                                        XLReflection.SetField(result.ResultObject, nameof(obj.Wartosc), res.ToString() ?? "");
                                        var changedResult = PrepareObjectAndInvokeMethod<XLModyfikacjaKntSQLInfo>(obj, $"cdn_api.{nameof(XLModyfikacjaKntSQLInfo)}", nameof(Metody.XLZmienPoleKntSQL), ref args);
                                    }
                                }
                            }
                            var closeResult = PrepareObjectAndInvokeMethod<XLModyfikacjaKntSQLInfo>(obj, $"cdn_api.{nameof(XLModyfikacjaKntSQLInfo)}", nameof(Metody.XLZamknijKontrahentaSQL), ref args);
                        }
                    }
                }
            }
            if (crSQL.GIDNumer > 0)
            {
                List<XLAtrKlasaNagInfoExt>? contractorsAttributes = configuration.GetSection("Attributes:Contractors").Get<List<XLAtrKlasaNagInfoExt>>();
                if (contractorsAttributes != null && contractorsAttributes.Any())
                    AddAttributes(crSQL, contractorsAttributes);
            }

            crSQL.StatusZmiany = resultMessage;
        }

    }
}


