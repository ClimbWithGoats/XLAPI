
using ConsoleXLAPI.StaticController;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace ConsoleXLAPI.Models
{
    public class XLLoginInfo : BaseXL
    {
        [JsonIgnore]
        public new int? Wersja { get => XLMainController.Wersja; set { XLMainController.Wersja = value ?? 0; } }
        public System.Int32? UtworzWlasnaSesje { get; set; }
        public System.Int32? Winieta { get; set; }
        public System.Int32? TrybWsadowy { get; set; } = 1;
        public System.Int32? TrybNaprawy { get; set; } = 0;
        public System.Int32? PortHTTPSerweraKlucza { get; set; }
        public System.Int32? RodzajSerweraKlucza { get; set; }
        [StringLength(41)]
        public System.String? ProgramID { get; set; }
        [StringLength(21)]
        public System.String? Baza { get; set; }
        [StringLength(401)]
        public System.String? OpeIdent { get; set; }
        [StringLength(128)]
        public System.String? OpeHaslo { get; set; }
        [StringLength(200)]
        public System.String? PlikLog { get; set; }
        [StringLength(101)]
        public System.String? SerwerKlucza { get; set; }
        [StringLength(37)]
        public System.String? SesjaKlucza { get; set; }
        [StringLength(129)]
        public System.String? Serwer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLLoginInfo_20231(); }
    }
    public class XLLogoutInfo : BaseXL
    {

        public System.Int32? TrybUsuwaniaDok { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLLogoutInfo_20231(); }
    }
    public class XLKomunikatInfo : BaseXL
    {

        public System.Int32? Funkcja { get; set; }
        public System.Int32? Blad { get; set; }
        public System.Int32? Ostrzezenie { get; set; }
        public System.Int32? Tryb { get; set; }
        [StringLength(2000)]
        public System.String? OpisBledu { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLKomunikatInfo_20231(); }
    }
    public class XLIloscInfo : BaseXL
    {

        public System.Int32? IloscZdarzen { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLIloscInfo_20231(); }
    }
    public class XLZdarzenieInfo : BaseXL
    {

        public System.Int32? TSWpisu { get; set; }
        public System.Int32? Status { get; set; }
        public System.Int32? Poziom { get; set; }

        [StringLength(5001)]
#pragma warning disable IDE1006 // Naming Styles
        public System.String? sOpis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZdarzenieInfo_20231(); }
    }
    public class XLGIDInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLGIDInfo_20231(); }
    }
    public class XLGIDGrupaInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? GIDGrpTyp { get; set; }
        public System.Int32? GIDGrpFirma { get; set; }
        public System.Int32? GIDGrpNumer { get; set; }
        public System.Int32? GIDGrpLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLGIDGrupaInfo_20231(); }
    }
    public class XLNumerDokumentuInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        [StringLength(51)]
        public System.String? NumerDokumentu { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLNumerDokumentuInfo_20231(); }
    }
    public class XLPolaczenieInfo : BaseXL
    {
        public System.Int32? NTMode { get; set; }
        public System.Int32? Port { get; set; }
        [StringLength(1024)]
        public System.String? Serwer { get; set; }
        [StringLength(1024)]
        public System.String? Baza { get; set; }
        [StringLength(1024)]
        public System.String? ConnectString { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPolaczenieInfo_20231(); }
    }
    public class XLZmianaKontekstuOperatora : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZmianaKontekstuOperatora_20231(); }
    }
    public class XLWydrukInfo : BaseXL
    {
        public System.Int32? Procedura { get; set; }
        public System.Int32? Kontekst { get; set; }
        public System.Int32? Zrodlo { get; set; }
        public System.Int32? Wydruk { get; set; }
        public System.Int32? Format { get; set; }
        public System.Int32? Urzadzenie { get; set; }
        public System.Int32? DrukujDoPliku { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? ObiLp { get; set; }
        public System.Int32? B2B { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? DrukujZwiazane { get; set; }
        public System.Int32? MES { get; set; }
        [StringLength(1024)]
        public System.String? Zmienne { get; set; }
        [StringLength(1024)]
        public System.String? FiltrTPS { get; set; }
        [StringLength(1024)]
        public System.String? FiltrSQL { get; set; }
        [StringLength(1024)]
        public System.String? Sortowanie { get; set; }
        [StringLength(512)]
        public System.String? Komunikat { get; set; }
        [StringLength(255)]
        public System.String? PlikDocelowy { get; set; }
        [StringLength(128)]
        public System.String? AdresEMail { get; set; }
        [StringLength(128)]
        public System.String? NazwaDrukarki { get; set; }
        [StringLength(31)]
        public System.String? DaneFormatu { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLWydrukInfo_20231(); }
    }
    public class XLRejestrInfo : BaseXL
    {
        public System.Int32? Tryb { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Okres { get; set; }
        public System.Int32? Bufor { get; set; }
        public System.Int32? ZerowanieStanu { get; set; }
        public System.Int32? GenPlatnosci { get; set; }
        public System.Int32? KNTNumer { get; set; }
        [StringLength(6)]
        public System.String? Symbol { get; set; }
        [StringLength(31)]
        public System.String? Nazwa { get; set; }
        [StringLength(31)]
        public System.String? Konto { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(6)]
        public System.String? Dziennik { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRejestrInfo_20231(); }
    }
    public class XLPrzypiszInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? Zerujaca { get; set; }
        [StringLength(6)]
        public System.String? Rejestr { get; set; }
        [StringLength(6)]
        public System.String? Operacja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPrzypiszInfo_20231(); }
    }
    public class XLRaportInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Zastrzezony { get; set; }
        public System.Int32? Numer { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? DataOtw { get; set; }
        public System.Int32? DataZam { get; set; }
        public System.Int32? DataCzasOtw { get; set; }
        public System.Int32? DataCzasZam { get; set; }
        public System.Int32? OddDokID { get; set; }
        [StringLength(6)]
        public System.String? Kasa { get; set; }
        [StringLength(21)]
        public System.String? NumerDok { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRaportInfo_20231(); }
    }
    public class XLZapisKasowyInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Bufor { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? DataCzas { get; set; }
        public System.Int32? KNTTyp { get; set; }
        public System.Int32? KNTFirma { get; set; }
        public System.Int32? KNTNumer { get; set; }
        public System.Int32? KNTLp { get; set; }
        public System.Int32? Lp { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? DataDok { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeNumerZ { get; set; }
        public System.Int32? Zaliczka { get; set; }
        public System.Int32? NieRozliczaj { get; set; }
        public System.Int32? OperatorPOS { get; set; }
        public System.Int32? BbonId { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(6)]
        public System.String? Kasa { get; set; }
        [StringLength(6)]
        public System.String? Operacja { get; set; }
        [StringLength(31)]
        public System.String? Numer { get; set; }
        [StringLength(255)]
        public System.String? Tresc { get; set; }
        [StringLength(31)]
        public System.String? Konto { get; set; }
        [StringLength(255)]
        public System.String? Opis { get; set; }
        [StringLength(4)]
        public System.String? WalutaRoz { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZapisKasowyInfo_20231(); }
    }
    public class XLGIDParaInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? GID1Typ { get; set; }
        public System.Int32? GID1Firma { get; set; }
        public System.Int32? GID1Numer { get; set; }
        public System.Int32? GID1Lp { get; set; }
        public System.Int32? GID2Typ { get; set; }
        public System.Int32? GID2Firma { get; set; }
        public System.Int32? GID2Numer { get; set; }
        public System.Int32? GID2Lp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLGIDParaInfo_20231(); }
    }
    public class XLRozliczenieInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(512)]
        public System.String? BladOpis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRozliczenieInfo_20231(); }
    }
    public class XLDekretInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? DataDokumentu { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(15)]
        public System.String? KwotaWalDT { get; set; }
        [StringLength(15)]
        public System.String? KwotaWalCT { get; set; }
        [StringLength(41)]
        public System.String? NumerDokumentu { get; set; }
        [StringLength(6)]
        public System.String? Dziennik { get; set; }
        [StringLength(6)]
        public System.String? Bufor { get; set; }
        [StringLength(31)]
        public System.String? KontoDebet { get; set; }
        [StringLength(31)]
        public System.String? KontoCredit { get; set; }
        [StringLength(31)]
        public System.String? KontoWalDT { get; set; }
        [StringLength(31)]
        public System.String? KontoWalCT { get; set; }
        [StringLength(41)]
        public System.String? Identyfikator { get; set; }
        [StringLength(81)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDekretInfo_20231(); }
    }
    public class XLDekretZbiorczyInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? DataDokumentu { get; set; }
        [StringLength(15)]
        public System.String? KwotaDebet { get; set; }
        [StringLength(15)]
        public System.String? KwotaCredit { get; set; }
        [StringLength(41)]
        public System.String? NumerDokumentu { get; set; }
        [StringLength(6)]
        public System.String? Dziennik { get; set; }
        [StringLength(6)]
        public System.String? Bufor { get; set; }
        [StringLength(41)]
        public System.String? Identyfikator { get; set; }
        [StringLength(81)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDekretZbiorczyInfo_20231(); }
    }
    public class XLNotaInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? MDNTyp { get; set; }
        public System.Int32? MDNFirma { get; set; }
        public System.Int32? MDNNumer { get; set; }
        public System.Int32? MDNLp { get; set; }
        public System.Int32? KNTTyp { get; set; }
        public System.Int32? KNTFirma { get; set; }
        public System.Int32? KNTNumer { get; set; }
        public System.Int32? KNTLp { get; set; }
        public System.Int32? KNPTyp { get; set; }
        public System.Int32? KNPFirma { get; set; }
        public System.Int32? KNPNumer { get; set; }
        public System.Int32? KNPLp { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? DataWprow { get; set; }
        public System.Int32? DataDok { get; set; }
        public System.Int32? DataOper { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? Stan { get; set; }
        public System.Int32? OperatorPOS { get; set; }
        public System.Int32? Pico { get; set; }
        [StringLength(15)]
        public System.String? KursL { get; set; }
        [StringLength(15)]
        public System.String? KursM { get; set; }
        [StringLength(15)]
        public System.String? KwotaPrz { get; set; }
        [StringLength(15)]
        public System.String? KwotaRoz { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(41)]
        public System.String? NumerDokumentu { get; set; }
        [StringLength(81)]
        public System.String? Tresc { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(512)]
        public System.String? BladOpis { get; set; }
        [StringLength(37)]
        public System.String? GUID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLNotaInfo_20231(); }
    }
    public class XLPozycjaNotyInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? KNTTyp { get; set; }
        public System.Int32? KNTFirma { get; set; }
        public System.Int32? KNTNumer { get; set; }
        public System.Int32? KNTLp { get; set; }
        public System.Int32? KNT2Typ { get; set; }
        public System.Int32? KNT2Firma { get; set; }
        public System.Int32? KNT2Numer { get; set; }
        public System.Int32? KNT2Lp { get; set; }
        public System.Int32? KKSNumerDT { get; set; }
        public System.Int32? KKSNumerCT { get; set; }
        public System.Int32? KKSNumerDTWal { get; set; }
        public System.Int32? KKSNumerCTWal { get; set; }
        public System.Int32? SymbolID { get; set; }
        public System.Int32? NieSumuj { get; set; }
        public System.Int32? DataDok { get; set; }
        public System.Int32? DataOper { get; set; }
        public System.Int32? BbonId { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(81)]
        public System.String? Opis { get; set; }
        [StringLength(18)]
        public System.String? KwotaDTWal { get; set; }
        [StringLength(18)]
        public System.String? KwotaCTWal { get; set; }
        [StringLength(4)]
        public System.String? WalutaDT { get; set; }
        [StringLength(4)]
        public System.String? WalutaCT { get; set; }
        [StringLength(41)]
        public System.String? NumerDokumentu { get; set; }
        [StringLength(512)]
        public System.String? BladOpis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPozycjaNotyInfo_20231(); }
    }
    public class XLNowyOpisInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        [StringLength(81)]
        public System.String? Tresc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLNowyOpisInfo_20231(); }
    }
    public class XLDodajLinieOpisuInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Lp { get; set; }
        public System.Int32? Kierunek { get; set; }
        public System.Int32? TypKwoty { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(15)]
        public System.String? Procent { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajLinieOpisuInfo_20231(); }
    }
    public class XLDodajWymiarOpisuInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Wymiar { get; set; }
        [StringLength(255)]
        public System.String? Sciezka { get; set; }
        [StringLength(31)]
        public System.String? Element { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajWymiarOpisuInfo_20231(); }
    }
    public class XLZamknijLinieOpisuInfo : BaseXL
    {

        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamknijLinieOpisuInfo_20231(); }
    }
    public class XLZamknijOpisInfo : BaseXL
    {

        public System.Int32? Zatwierdzony { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamknijOpisInfo_20231(); }
    }
    public class XLSrtInfo : BaseXL
    {

        public System.Int32? SrGTyp { get; set; }
        public System.Int32? SrGFirma { get; set; }
        public System.Int32? SrGNumer { get; set; }
        public System.Int32? SrGLp { get; set; }
        public System.Int32? PrcTyp { get; set; }
        public System.Int32? PrcFirma { get; set; }
        public System.Int32? PrcNumer { get; set; }
        public System.Int32? PrcLp { get; set; }
        public System.Int32? OpeTyp { get; set; }
        public System.Int32? OpeFirma { get; set; }
        public System.Int32? OpeNumer { get; set; }
        public System.Int32? OpeLp { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDFirma { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? KnDLp { get; set; }
        public System.Int32? NrInw { get; set; }
        public System.Int32? Rodzaj { get; set; }
        public System.Int32? MetodaUm { get; set; }
        public System.Int32? MetodaAm { get; set; }
        public System.Int32? Dwutorowosc { get; set; }
        public System.Int32? PodlegaAMP { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? Sezonowy { get; set; }
        public System.Int32? MsNaliczania { get; set; }
        public System.Int32? MsNaliczaniaAm { get; set; }
        public System.Int32? OdliczeniaVAT { get; set; }
        public System.Int32? OgraniczenieOdl { get; set; }
        public System.Int32? SRTNumer { get; set; }
        public System.Int32? Zestaw { get; set; }
        [StringLength(6)]
        public System.String? Ksiega { get; set; }
        [StringLength(31)]
        public System.String? NrEwid { get; set; }
        [StringLength(41)]
        public System.String? Akronim { get; set; }
        [StringLength(51)]
        public System.String? Nazwa { get; set; }
        [StringLength(21)]
        public System.String? KRST { get; set; }
        [StringLength(8)]
        public System.String? Stawka { get; set; }
        [StringLength(8)]
        public System.String? WspUmAm { get; set; }
        [StringLength(8)]
        public System.String? WspDegr { get; set; }
        [StringLength(8)]
        public System.String? StawkaAm { get; set; }
        [StringLength(8)]
        public System.String? WspAm { get; set; }
        [StringLength(8)]
        public System.String? WspDegrAm { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(21)]
        public System.String? Etykieta { get; set; }
        [StringLength(21)]
        public System.String? SposobZak { get; set; }
        [StringLength(21)]
        public System.String? SposobLikw { get; set; }
        [StringLength(31)]
        public System.String? MiejsceUzyw { get; set; }
        [StringLength(31)]
        public System.String? KontoGl { get; set; }
        [StringLength(31)]
        public System.String? KontoUm { get; set; }
        [StringLength(31)]
        public System.String? KontoAmP { get; set; }
        [StringLength(31)]
        public System.String? KontoAmB { get; set; }
        [StringLength(31)]
        public System.String? KontoSTK { get; set; }
        [StringLength(2049)]
        public System.String? Opis { get; set; }
        [StringLength(41)]
        public System.String? Atr1 { get; set; }
        [StringLength(41)]
        public System.String? Atr2 { get; set; }
        [StringLength(41)]
        public System.String? Atr3 { get; set; }
        [StringLength(41)]
        public System.String? Atr4 { get; set; }
        [StringLength(16)]
        public System.String? KwotaZlom { get; set; }
        [StringLength(16)]
        public System.String? KwotaZlomAm { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSrtInfo_20231(); }
    }
    public class XLDodajBONInfo : BaseXL
    {


        public System.Int32? DataWprow { get; set; }
        [StringLength(81)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajBONInfo_20231(); }
    }
    public class XLUsunBONInfo : BaseXL
    {


        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunBONInfo_20231(); }
    }
    public class XLDodajBOEInfo : BaseXL
    {


        public System.Int32? GIDLp { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        [StringLength(31)]
        public System.String? Konto { get; set; }
        [StringLength(81)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajBOEInfo_20231(); }
    }
    public class XLZamknijBOEInfo : BaseXL
    {


        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamknijBOEInfo_20231(); }
    }
    public class XLDodajBOSInfo : BaseXL
    {


        public System.Int32? GIDLp { get; set; }
        public System.Int32? SubGIDLp { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? Termin { get; set; }
        public System.Int32? DC { get; set; }
        public System.Int32? NrKursu { get; set; }
        [StringLength(41)]
        public System.String? NumerDokumentu { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(15)]
        public System.String? KwotaBO { get; set; }
        [StringLength(15)]
        public System.String? KwotaWal { get; set; }
        [StringLength(15)]
        public System.String? KwotaBOWal { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(15)]
        public System.String? KursL { get; set; }
        [StringLength(15)]
        public System.String? KursM { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajBOSInfo_20231(); }
    }
    public class XLSrtNagInfo : BaseXL
    {

        public System.Int32? SHNTyp { get; set; }
        public System.Int32? OPETyp { get; set; }
        public System.Int32? OPEFirma { get; set; }
        public System.Int32? OPENumer { get; set; }
        public System.Int32? OPELp { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? Nr { get; set; }
        public System.Int32? MsObow { get; set; }
        public System.Int32? MsObowAm { get; set; }
        public System.Int32? SHNNumer { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(41)]
        public System.String? PopSymbolDok { get; set; }
        [StringLength(251)]
        public System.String? CechaOpis { get; set; }
        [StringLength(257)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSrtNagInfo_20231(); }
    }
    public class XLSrtNag2Info : BaseXL
    {

        public System.Int32? SHNTyp { get; set; }
        public System.Int32? SHNFirma { get; set; }
        public System.Int32? SHNNumer { get; set; }
        public System.Int32? SHNLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSrtNag2Info_20231(); }
    }
    public class XLSrtElem2Info : BaseXL
    {

        public System.Int32? SHETyp { get; set; }
        public System.Int32? SHEFirma { get; set; }
        public System.Int32? SHENumer { get; set; }
        public System.Int32? SHELp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSrtElem2Info_20231(); }
    }
    public class XLSrtElemInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? SHETyp { get; set; }
        public System.Int32? SHEFirma { get; set; }
        public System.Int32? SHENumer { get; set; }
        public System.Int32? SHELp { get; set; }
        public System.Int32? SrtTyp { get; set; }
        public System.Int32? SrtFirma { get; set; }
        public System.Int32? SrtNumer { get; set; }
        public System.Int32? SrtLp { get; set; }
        public System.Int32? PrcTyp { get; set; }
        public System.Int32? PrcFirma { get; set; }
        public System.Int32? PrcNumer { get; set; }
        public System.Int32? PrcLp { get; set; }
        public System.Int32? KndTyp { get; set; }
        public System.Int32? KndFirma { get; set; }
        public System.Int32? KndNumer { get; set; }
        public System.Int32? KndLp { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? MetodaUm { get; set; }
        public System.Int32? MetodaAm { get; set; }
        public System.Int32? Dwutorowosc { get; set; }
        public System.Int32? Auto { get; set; }
        public System.Int32? MsObow { get; set; }
        public System.Int32? MsObowAm { get; set; }
        public System.Int32? AMPUmorzenie { get; set; }
        public System.Int32? Tor { get; set; }
        public System.Int32? WartRezd { get; set; }
        public System.Int32? PodstBilans { get; set; }
        public System.Int32? PodstPodat { get; set; }
        public System.Int32? UjecieOpisA { get; set; }
        public System.Int32? OdpisyOd { get; set; }
        public System.Int32? PrzesSHENumer { get; set; }
        public System.Int32? PrzesSHELp { get; set; }
        public System.Int32? PrzesStrona { get; set; }
        public System.Int32? SZEId { get; set; }
        public System.Int32? SrtZestNumer { get; set; }
        public System.Int32? ParGIDLp { get; set; }
        public System.Int32? SZELp { get; set; }
        public System.Int32? NaPodstElemTryb { get; set; }
        public System.Int32? Kurs { get; set; }
        [StringLength(22)]
        public System.String? KwotaInw { get; set; }
        [StringLength(22)]
        public System.String? KwotaInwWal { get; set; }
        [StringLength(22)]
        public System.String? PodstawaAm { get; set; }
        [StringLength(22)]
        public System.String? PodstawaAmWal { get; set; }
        [StringLength(22)]
        public System.String? KwotaUm { get; set; }
        [StringLength(22)]
        public System.String? KwotaAm { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(22)]
        public System.String? KwotaZlom { get; set; }
        [StringLength(22)]
        public System.String? KwotaZlomAm { get; set; }
        [StringLength(8)]
        public System.String? Stawka { get; set; }
        [StringLength(8)]
        public System.String? WspUmAm { get; set; }
        [StringLength(8)]
        public System.String? WspDegr { get; set; }
        [StringLength(8)]
        public System.String? StawkaAm { get; set; }
        [StringLength(8)]
        public System.String? WspAm { get; set; }
        [StringLength(8)]
        public System.String? WspDegrAm { get; set; }
        [StringLength(31)]
        public System.String? MiejsceUzyw { get; set; }
        [StringLength(65)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSrtElemInfo_20231(); }
    }
    public class XLEdytujULRInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ID { get; set; }
        public System.Int32? ULNId { get; set; }
        public System.Int32? ULPLp { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Termin { get; set; }
        public System.Int32? VATPlanowany { get; set; }
        [StringLength(16)]
        public System.String? Netto { get; set; }
        [StringLength(16)]
        public System.String? Kapital { get; set; }
        [StringLength(16)]
        public System.String? Odsetki { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLEdytujULRInfo_20231(); }
    }
    public class XLUsunULRInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunULRInfo_20231(); }
    }
    public class XLGenerujULRInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ULNId { get; set; }
        public System.Int32? Aneks { get; set; }
        public System.Int32? MetodaPodzialu { get; set; }
        public System.Int32? VATPlanowany { get; set; }
        public System.Int32? PodzialNaPrzedmioty { get; set; }
        public System.Int32? MetodaPodzialuRaty { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLGenerujULRInfo_20231(); }
    }
    public class XLEdycjaULNInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ULNId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLEdycjaULNInfo_20231(); }
    }
    public class XLDodajULNInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ULNID { get; set; }
        public System.Int32? PierwszaRataNaliczanie { get; set; }
        public System.Int32? OdliczeniaVat { get; set; }
        public System.Int32? OgraniczenieOdl { get; set; }
        public System.Int32? ULNNumer { get; set; }
        public System.Int32? FlagaVat { get; set; }
        public System.Int32? FRSId { get; set; }
        public System.Int32? PodmFinansTyp { get; set; }
        public System.Int32? PodmFinansNumer { get; set; }
        public System.Int32? RodzajUmowy { get; set; }
        public System.Int32? DataRozpoczecia { get; set; }
        public System.Int32? DataZakonczenia { get; set; }
        public System.Int32? OkresRaty { get; set; }
        public System.Int32? PodzRatyLeasingowej { get; set; }
        public System.Int32? DataAneksu { get; set; }
        public System.Int32? PozostawOrg { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(18)]
        public System.String? WartoscPrzedmiotu { get; set; }
        [StringLength(18)]
        public System.String? OplataWstKwota { get; set; }
        [StringLength(8)]
        public System.String? OplataWstProcent { get; set; }
        [StringLength(18)]
        public System.String? WartoscWykKwota { get; set; }
        [StringLength(8)]
        public System.String? WartoscWykProcent { get; set; }
        [StringLength(8)]
        public System.String? SumaRatNetto { get; set; }
        [StringLength(41)]
        public System.String? NrAneksu { get; set; }
        [StringLength(6)]
        public System.String? ULNSeria { get; set; }
        [StringLength(8)]
        public System.String? StawkaPod { get; set; }
        [StringLength(4001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajULNInfo_20231(); }
    }
    public class XLUsunULPInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ULNId { get; set; }
        public System.Int32? ULPLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunULPInfo_20231(); }
    }
    public class XLEdytujULPInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ULNId { get; set; }
        public System.Int32? ULPLp { get; set; }
        public System.Int32? SRTNumer { get; set; }
        public System.Int32? OdliczeniaVat { get; set; }
        public System.Int32? OgraniczenieOdl { get; set; }
        [StringLength(18)]
        public System.String? OplataWstKwota { get; set; }
        [StringLength(8)]
        public System.String? OplataWstProcent { get; set; }
        [StringLength(18)]
        public System.String? SumaRatNetto { get; set; }
        [StringLength(18)]
        public System.String? WartoscPrzedmiotu { get; set; }
        [StringLength(18)]
        public System.String? WartoscWykKwota { get; set; }
        [StringLength(8)]
        public System.String? WartoscWykProcent { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLEdytujULPInfo_20231(); }
    }
    public class XLDokumentZlcNagInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDFirma { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? KndLp { get; set; }
        public System.Int32? MaDTyp { get; set; }
        public System.Int32? MaDFirma { get; set; }
        public System.Int32? MaDNumer { get; set; }
        public System.Int32? MaDLp { get; set; }
        public System.Int32? MaZTyp { get; set; }
        public System.Int32? MaZFirma { get; set; }
        public System.Int32? MaZNumer { get; set; }
        public System.Int32? MaZLp { get; set; }
        public System.Int32? DataWystawienia { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? OpeTypW { get; set; }
        public System.Int32? OpeFirmaW { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeLpW { get; set; }
        public System.Int32? OpeTypM { get; set; }
        public System.Int32? OpeFirmaM { get; set; }
        public System.Int32? OpeNumerM { get; set; }
        public System.Int32? OpeLpM { get; set; }
        public System.Int32? RealWCalosci { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? OpiTyp { get; set; }
        public System.Int32? OpiFirma { get; set; }
        public System.Int32? OpiNumer { get; set; }
        public System.Int32? OpiLp { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(21)]
        public System.String? AkronimDocelowego { get; set; }
        [StringLength(6)]
        public System.String? ZlcSeria { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentW { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentM { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(11)]
        public System.String? MagazynD { get; set; }
        [StringLength(11)]
        public System.String? MagazynZ { get; set; }
        [StringLength(21)]
        public System.String? Cecha { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? Opiekun { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZlcNagInfo_20231(); }
    }
    public class XLDokumentZlcElemInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? ReNTyp { get; set; }
        public System.Int32? ReNFirma { get; set; }
        public System.Int32? ReNNumer { get; set; }
        public System.Int32? ReNLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? MagTyp { get; set; }
        public System.Int32? MagFirma { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? MagLp { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ProdTyp { get; set; }
        public System.Int32? ProdFirma { get; set; }
        public System.Int32? ProdNumer { get; set; }
        public System.Int32? ProdLp { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        [StringLength(41)]
        public System.String? Towar { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? Koszt { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZlcElemInfo_20231(); }
    }
    public class XLZamkniecieDokumentuZlcInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? TrybZamkniecia { get; set; }
        public System.Int32? DataPotwierdzenia { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? OpeTypP { get; set; }
        public System.Int32? OpeFirmaP { get; set; }
        public System.Int32? OpeNumerP { get; set; }
        public System.Int32? OpeLpP { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentP { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuZlcInfo_20231(); }
    }
    public class XLOtwarcieDokumentuZlcInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieDokumentuZlcInfo_20231(); }
    }
    public class XLZlecenieProdInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? Oddzial { get; set; }
        public System.Int32? Projekt { get; set; }
        public System.Int32? DataWystawienia { get; set; }
        public System.Int32? OpWNumer { get; set; }
        public System.Int32? PriorytetZlc { get; set; }
        public System.Int32? PriorytetRez { get; set; }
        public System.Int32? RezerwujZasoby { get; set; }
        public System.Int32? PlanowacOd { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(41)]
        public System.String? KntAkronim { get; set; }
        [StringLength(41)]
        public System.String? KnDAkronim { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(9)]
        public System.String? OpWIdent { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(2)]
        public System.String? WyborMagazynuNaPozycji { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZlecenieProdInfo_20231(); }
    }
    public class XLZlecenieProdElemInfo : BaseXL
    {

        public System.Int32? Typ { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? Technologia { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? Oddzial { get; set; }
        public System.Int32? PriorytetRez { get; set; }
        public System.Int32? IdZlecenia { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? PlanowacOd { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDNumer { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? NumerSeryjny { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(41)]
        public System.String? Towar { get; set; }
        [StringLength(21)]
        public System.String? KntAkronim { get; set; }
        [StringLength(21)]
        public System.String? KnDAkronim { get; set; }
        [StringLength(21)]
        public System.String? IdWzorcaNrPartii { get; set; }
        [StringLength(21)]
        public System.String? MagNumer { get; set; }
        [StringLength(2)]
        public System.String? WyborMagazynuNaPozycji { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZlecenieProdElemInfo_20231(); }
    }
    public class XLZlecenieProdZamknijInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZlecenieProdZamknijInfo_20231(); }
    }
    public class XLProdObiektInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Ojciec { get; set; }
        public System.Int32? OddzialId { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? KalendarzId { get; set; }
        public System.Int32? ZmianaCzas { get; set; }
        public System.Int32? ZmianaCzasJedn { get; set; }
        public System.Int32? ZmianaStawkaAtr { get; set; }
        public System.Int32? DopuszczaZasoby { get; set; }
        public System.Int32? RejestrowacUzycie { get; set; }
        public System.Int32? StawkaStalaAtr { get; set; }
        public System.Int32? StawkaCzasAtr { get; set; }
        public System.Int32? StawkaCzasM { get; set; }
        public System.Int32? StawkaCzasMJedn { get; set; }
        public System.Int32? StawkaIloscAtr { get; set; }
        public System.Int32? Archiwalny { get; set; }
        public System.Int32? RejestrowacZuzycie { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(41)]
        public System.String? KodOjca { get; set; }
        [StringLength(41)]
        public System.String? Oddzial { get; set; }
        [StringLength(101)]
        public System.String? Obiekt { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(41)]
        public System.String? Kalendarz { get; set; }
        [StringLength(31)]
        public System.String? Konto { get; set; }
        [StringLength(21)]
        public System.String? ZmianaStawka { get; set; }
        [StringLength(21)]
        public System.String? StawkaStala { get; set; }
        [StringLength(21)]
        public System.String? StawkaCzas { get; set; }
        [StringLength(21)]
        public System.String? StawkaIlosc { get; set; }
        [StringLength(16)]
        public System.String? StawkaIloscM { get; set; }
        [StringLength(41)]
        public System.String? KlasaStawkaAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaStalaAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaCzasAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscAtr { get; set; }
        [StringLength(101)]
        public System.String? Numer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdObiektInfo_20231(); }
    }
    public class XLProdFunkcjaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? OddzialId { get; set; }
        public System.Int32? Archiwalny { get; set; }
        public System.Int32? Zmienna { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? PlanujStrategicznie { get; set; }
        public System.Int32? CzyZrownoleglac { get; set; }
        public System.Int32? KontynuacjaPracy { get; set; }
        public System.Int32? TenSamZasobWPartii { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(41)]
        public System.String? Oddzial { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(513)]
        public System.String? Opis { get; set; }
        [StringLength(2)]
        public System.String? Planowana { get; set; }
        [StringLength(14)]
        public System.String? ZdolnoscWOkresie { get; set; }
        [StringLength(2)]
        public System.String? ZdolnoscWOkresieJedn { get; set; }
        [StringLength(7)]
        public System.String? DopuszczalneObciazenie { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdFunkcjaInfo_20231(); }
    }
    public class XLProdObiektFunkcjaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ObiektId { get; set; }
        public System.Int32? FunkcjaId { get; set; }
        public System.Int32? Grupa { get; set; }
        public System.Int32? OddzialId { get; set; }
        public System.Int32? WydajnoscCzas { get; set; }
        public System.Int32? WydajnoscCzasJedn { get; set; }
        public System.Int32? CzasJedn { get; set; }
        public System.Int32? CzyStawki { get; set; }
        public System.Int32? StawkaStalaAtr { get; set; }
        public System.Int32? StawkaCzasAtr { get; set; }
        public System.Int32? StawkaCzasM { get; set; }
        public System.Int32? StawkaCzasMJedn { get; set; }
        public System.Int32? StawkaIloscAtr { get; set; }
        public System.Int32? CzasPrzygotowaniaJedn { get; set; }
        public System.Int32? StawkaPrzygotowaniaAtr { get; set; }
        public System.Int32? CzasZakonczeniaJedn { get; set; }
        public System.Int32? StawkaZakonczeniaAtr { get; set; }
        [StringLength(14)]
        public System.String? Czas { get; set; }
        [StringLength(14)]
        public System.String? CzasPrzygotowania { get; set; }
        [StringLength(14)]
        public System.String? CzasZakonczenia { get; set; }
        [StringLength(101)]
        public System.String? Obiekt { get; set; }
        [StringLength(41)]
        public System.String? Funkcja { get; set; }
        [StringLength(41)]
        public System.String? Oddzial { get; set; }
        [StringLength(16)]
        public System.String? MinIlosc { get; set; }
        [StringLength(16)]
        public System.String? MaxIlosc { get; set; }
        [StringLength(9)]
        public System.String? Jednostka { get; set; }
        [StringLength(16)]
        public System.String? WydajnoscIlosc { get; set; }
        [StringLength(21)]
        public System.String? StawkaStala { get; set; }
        [StringLength(21)]
        public System.String? StawkaCzas { get; set; }
        [StringLength(21)]
        public System.String? StawkaIlosc { get; set; }
        [StringLength(16)]
        public System.String? StawkaIloscM { get; set; }
        [StringLength(16)]
        public System.String? StawkaPrzygotowania { get; set; }
        [StringLength(16)]
        public System.String? StawkaZakonczenia { get; set; }
        [StringLength(41)]
        public System.String? KlasaStalaAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaCzasAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaPrzygotowaniaAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaZakonczeniaAtr { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdObiektFunkcjaInfo_20231(); }
    }
    public class XLProdTechnologiaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? IDWersji { get; set; }
        public System.Int32? Projekt { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? DataWystawienia { get; set; }
        public System.Int32? DataZatwierdzenia { get; set; }
        public System.Int32? ZatwTyp { get; set; }
        public System.Int32? ZatwNumer { get; set; }
        public System.Int32? OddzialID { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? StawkaStalaAtr { get; set; }
        public System.Int32? StawkaIloscAtr { get; set; }
        public System.Int32? StawkaCzasAtr { get; set; }
        public System.Int32? StawkaCzasM { get; set; }
        public System.Int32? StawkaCzasMJedn { get; set; }
        public System.Int32? FrsId { get; set; }
        public System.Int32? GenerujZapisWTerminarzu { get; set; }
        public System.Int32? PrjId { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? WymagajPodaniaStanuOperacji { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(513)]
        public System.String? OpisWersji { get; set; }
        [StringLength(41)]
        public System.String? TwrKod { get; set; }
        [StringLength(21)]
        public System.String? KntAkronim { get; set; }
        [StringLength(21)]
        public System.String? KnDAkronim { get; set; }
        [StringLength(9)]
        public System.String? ZatwIdent { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(21)]
        public System.String? IloscMin { get; set; }
        [StringLength(21)]
        public System.String? IloscProd { get; set; }
        [StringLength(21)]
        public System.String? IloscPlan { get; set; }
        [StringLength(9)]
        public System.String? Jednostka { get; set; }
        [StringLength(41)]
        public System.String? Oddzial { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(21)]
        public System.String? StawkaStala { get; set; }
        [StringLength(21)]
        public System.String? StawkaIlosc { get; set; }
        [StringLength(16)]
        public System.String? StawkaIloscM { get; set; }
        [StringLength(21)]
        public System.String? StawkaCzas { get; set; }
        [StringLength(41)]
        public System.String? KlasaStalaAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaCzasAtr { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdTechnologiaInfo_20231(); }
    }
    public class XLProdTechnologiaCzynnoscInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? IdTechnologii { get; set; }
        public System.Int32? IdOjca { get; set; }
        public System.Int32? CzasPrzygotowawczyJedn { get; set; }
        public System.Int32? CzasPlanowanyJedn { get; set; }
        public System.Int32? CzasRozliczeniowyJedn { get; set; }
        public System.Int32? CzasRozliczeniowyAtr { get; set; }
        public System.Int32? Wymagana { get; set; }
        public System.Int32? Planowana { get; set; }
        public System.Int32? DowolneZasoby { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? IloscAtr { get; set; }
        public System.Int32? IloscMinAtr { get; set; }
        public System.Int32? IloscMaxAtr { get; set; }
        public System.Int32? IloscPlanAtr { get; set; }
        public System.Int32? OddzialID { get; set; }
        public System.Int32? StawkaStalaAtr { get; set; }
        public System.Int32? StawkaIloscAtr { get; set; }
        public System.Int32? StawkaCzasAtr { get; set; }
        public System.Int32? StawkaCzasM { get; set; }
        public System.Int32? StawkaCzasMJedn { get; set; }
        public System.Int32? WieleTerminow { get; set; }
        public System.Int32? GenerujZapisWTerminarzu { get; set; }
        public System.Int32? OdstepPo { get; set; }
        public System.Int32? OdstepPoJm { get; set; }
        public System.Int32? OdstepPrzed { get; set; }
        public System.Int32? OdstepPrzedJm { get; set; }
        public System.Int32? CzasPrzygotowawczyRozliczeniowyJedn { get; set; }
        public System.Int32? Etap { get; set; }
        public System.Int32? CzasPlanowanyAtr { get; set; }
        public System.Int32? Kooperacja { get; set; }
        public System.Int32? KontrolaJakosci { get; set; }
        public System.Int32? NiePlanujWPartiachGdyNastOpeWPartiach { get; set; }
        [StringLength(14)]
        public System.String? CzasPrzygotowawczy { get; set; }
        [StringLength(14)]
        public System.String? CzasPlanowany { get; set; }
        [StringLength(14)]
        public System.String? CzasRozliczeniowy { get; set; }
        [StringLength(41)]
        public System.String? Ojciec { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(41)]
        public System.String? KlasaCzasRozliczeniowyAtr { get; set; }
        [StringLength(41)]
        public System.String? UslKod { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscMin { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscMinAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscMax { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscMaxAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscPlan { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscPlanAtr { get; set; }
        [StringLength(9)]
        public System.String? Jednostka { get; set; }
        [StringLength(41)]
        public System.String? Oddzial { get; set; }
        [StringLength(21)]
        public System.String? StawkaStala { get; set; }
        [StringLength(21)]
        public System.String? StawkaCzas { get; set; }
        [StringLength(21)]
        public System.String? StawkaIlosc { get; set; }
        [StringLength(21)]
        public System.String? StawkaIloscM { get; set; }
        [StringLength(41)]
        public System.String? KlasaStalaAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaCzasAtr { get; set; }
        [StringLength(41)]
        public System.String? KlasaStawkaIloscAtr { get; set; }
        [StringLength(21)]
        public System.String? Narzuty { get; set; }
        [StringLength(14)]
        public System.String? CzasPrzygotowawczyRozliczeniowy { get; set; }
        [StringLength(2)]
        public System.String? StalyCzas { get; set; }
        [StringLength(14)]
        public System.String? StalyCzasDla { get; set; }
        [StringLength(41)]
        public System.String? KlasaCzasPlanowanyAtr { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdTechnologiaCzynnoscInfo_20231(); }
    }
    public class XLProdTechnologiaFunkcjaInfo : BaseXL
    {

        public System.Int32? Flagi { get; set; }
        public System.Int32? IdTechnologiaCzynnosc { get; set; }
        public System.Int32? IdFunkcji { get; set; }
        public System.Int32? LiczbaObiektow { get; set; }
        public System.Int32? Wszystkie { get; set; }
        public System.Int32? Zmienna { get; set; }
        public System.Int32? TenSamZasobWPartii { get; set; }
        [StringLength(41)]
        public System.String? KodFunkcji { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdTechnologiaFunkcjaInfo_20231(); }
    }
    public class XLProdTechnologiaZasobInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? IdTechnologiaCzynnosc { get; set; }
        public System.Int32? Zamiennik { get; set; }
        public System.Int32? TechnologiaZasob { get; set; }
        public System.Int32? ZrodloZasobu { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? IloscAtr { get; set; }
        public System.Int32? IloscMinAtr { get; set; }
        public System.Int32? IloscMaxAtr { get; set; }
        public System.Int32? IloscPomAtr { get; set; }
        public System.Int32? IloscPomMinAtr { get; set; }
        public System.Int32? IloscPomMaxAtr { get; set; }
        public System.Int32? PropIlosc { get; set; }
        public System.Int32? PropIloscPom { get; set; }
        public System.Int32? TypZasobu { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? Koszt { get; set; }
        public System.Int32? CenaAtr { get; set; }
        public System.Int32? KlasaCechyId { get; set; }
        public System.Int32? IloscFormat { get; set; }
        public System.Int32? WagaIlosc { get; set; }
        public System.Int32? EdycjaCechy { get; set; }
        public System.Int32? PlanowanyCalosciowo { get; set; }
        public System.Int32? UsuwajNiewykorzystane { get; set; }
        public System.Int32? PlanujUboczne { get; set; }
        public System.Int32? PodlegaKJ { get; set; }
        public System.Int32? MaterialKanban { get; set; }
        public System.Int32? UwzglednijWNrSeryjnym { get; set; }
        public System.Int32? IdWzorcaNrPartii { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(41)]
        public System.String? TwrKod { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscMin { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscMinAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscMax { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscMaxAtr { get; set; }
        [StringLength(9)]
        public System.String? Jednostka { get; set; }
        [StringLength(21)]
        public System.String? IloscPom { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscPomAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscPomMin { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscPomMinAtr { get; set; }
        [StringLength(21)]
        public System.String? IloscPomMax { get; set; }
        [StringLength(41)]
        public System.String? KlasaIloscPomMaxAtr { get; set; }
        [StringLength(9)]
        public System.String? JednostkaPom { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(21)]
        public System.String? Cena { get; set; }
        [StringLength(41)]
        public System.String? KlasaCenaAtr { get; set; }
        [StringLength(21)]
        public System.String? KlasaCechy { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(21)]
        public System.String? WagaKosztu { get; set; }
        [StringLength(21)]
        public System.String? DopasowanieIlosci { get; set; }
        [StringLength(1024)]
        public System.String? OpisKJ { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdTechnologiaZasobInfo_20231(); }
    }
    public class XLProdCzynnoscProcesuInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Realizuje { get; set; }
        public System.Int32? Proces { get; set; }
        public System.Int32? OddzialId { get; set; }
        public System.Int32? TechnologiaCzynnosc { get; set; }
        public System.Int32? TerminRozpoczecia { get; set; }
        public System.Int32? CzasRealizacjiJedn { get; set; }
        public System.Int32? TerminZakonczenia { get; set; }
        public System.Int32? CzasRozliczeniowyJedn { get; set; }
        public System.Int32? DataAktywacjiRez { get; set; }
        public System.Int32? DataWaznosciRez { get; set; }
        public System.Int32? PriorytetZlc { get; set; }
        public System.Int32? CzyGenerowacZasoby { get; set; }
        public System.Int32? CzyGenerowacRezerwacje { get; set; }
        public System.Int32? GenerujZapisWTerminarzu { get; set; }
        public System.Int32? OPMnumer { get; set; }
        public System.Int32? CzasModyfikacji { get; set; }
        public System.Int32? Etap { get; set; }
        public System.Int32? CzyPrzenosicZasobyITerminy { get; set; }
        [StringLength(14)]
        public System.String? CzasRealizacji { get; set; }
        [StringLength(14)]
        public System.String? CzasRozliczeniowy { get; set; }
        [StringLength(41)]
        public System.String? Oddzial { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(21)]
        public System.String? Koszt { get; set; }
        [StringLength(21)]
        public System.String? KosztProcesu { get; set; }
        [StringLength(2)]
        public System.String? CzyPrzenosicZabiegi { get; set; }
        [StringLength(2)]
        public System.String? NieZamykajRozpoczetejRealiz { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdCzynnoscProcesuInfo_20231(); }
    }
    public class XLProdZasobCzynnoscInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? IdCzynnosci { get; set; }
        public System.Int32? TechnologiaZasob { get; set; }
        public System.Int32? KosztUstalony { get; set; }
        public System.Int32? Termin { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? TypZasobu { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? Zasob { get; set; }
        public System.Int32? KlasaCechy { get; set; }
        [StringLength(41)]
        public System.String? KodTwr { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(21)]
        public System.String? IloscPom { get; set; }
        [StringLength(21)]
        public System.String? Koszt { get; set; }
        [StringLength(21)]
        public System.String? KosztSurowca { get; set; }
        [StringLength(11)]
        public System.String? MagKod { get; set; }
        [StringLength(256)]
        public System.String? NumerSeryjny { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(2)]
        public System.String? Powiazanie { get; set; }
        [StringLength(2)]
        public System.String? TypKosztu { get; set; }
        [StringLength(21)]
        public System.String? Cena { get; set; }
        [StringLength(21)]
        public System.String? RodzajUbocznegoId { get; set; }
        [StringLength(21)]
        public System.String? KodNiezgodnosciId { get; set; }
        [StringLength(2)]
        public System.String? PrzeliczajWgPomocniczej { get; set; }
        [StringLength(9)]
        public System.String? JednostkaPom { get; set; }
        [StringLength(21)]
        public System.String? IdWzorcaNrPartii { get; set; }
        [StringLength(256)]
        public System.String? DodaneWyrobyId { get; set; }
        [StringLength(256)]
        public System.String? DodaneSurowceId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZasobCzynnoscInfo_20231(); }
    }
    public class XLProdObiektCzynnoscInfo : BaseXL
    {

        public System.Int32? Flagi { get; set; }
        public System.Int32? IdCzynnosci { get; set; }
        public System.Int32? IdFunkcji { get; set; }
        public System.Int32? Idobiektu { get; set; }
        public System.Int32? IdTerminu { get; set; }
        public System.Int32? Zablokowany { get; set; }
        [StringLength(41)]
        public System.String? KodFunkcji { get; set; }
        [StringLength(41)]
        public System.String? KodObiektu { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdObiektCzynnoscInfo_20231(); }
    }
    public class XLProdTerminCzynnoscInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? IdCzynnosci { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? PCTId { get; set; }
        [StringLength(11)]
        public System.String? TerminOd { get; set; }
        [StringLength(11)]
        public System.String? TerminDo { get; set; }
        [StringLength(14)]
        public System.String? CzasRozliczeniowy { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdTerminCzynnoscInfo_20231(); }
    }
    public class XLDokumentZlcRemNagInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? KntTypO { get; set; }
        public System.Int32? KntFirmaO { get; set; }
        public System.Int32? KntNumerO { get; set; }
        public System.Int32? KntLpO { get; set; }
        public System.Int32? AdrTyp { get; set; }
        public System.Int32? AdrFirma { get; set; }
        public System.Int32? AdrNumer { get; set; }
        public System.Int32? AdrLp { get; set; }
        public System.Int32? AdrTypO { get; set; }
        public System.Int32? AdrFirmaO { get; set; }
        public System.Int32? AdrNumerO { get; set; }
        public System.Int32? AdrLpO { get; set; }
        public System.Int32? MaGTyp { get; set; }
        public System.Int32? MaGFirma { get; set; }
        public System.Int32? MaGNumer { get; set; }
        public System.Int32? MaGLp { get; set; }
        public System.Int32? KNOTypZ { get; set; }
        public System.Int32? KNOFirmaZ { get; set; }
        public System.Int32? KNONumerZ { get; set; }
        public System.Int32? KNOLpZ { get; set; }
        public System.Int32? DataZgloszenia { get; set; }
        public System.Int32? CzasZgloszenia { get; set; }
        public System.Int32? DataRozpoczecia { get; set; }
        public System.Int32? DataZakonczenia { get; set; }
        public System.Int32? DataAktywacjiRez { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? DataPotwDst { get; set; }
        public System.Int32? OpeTypW { get; set; }
        public System.Int32? OpeFirmaW { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeLpW { get; set; }
        public System.Int32? PRCTyp { get; set; }
        public System.Int32? PRCFirma { get; set; }
        public System.Int32? PRCNumer { get; set; }
        public System.Int32? PRCLp { get; set; }
        public System.Int32? FSDlaWlasciciela { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? SobTyp { get; set; }
        public System.Int32? SobFirma { get; set; }
        public System.Int32? SobNumer { get; set; }
        public System.Int32? SobLp { get; set; }
        public System.Int32? ZrdFrSID { get; set; }
        public System.Int32? MaDTyp { get; set; }
        public System.Int32? MaDFirma { get; set; }
        public System.Int32? MaDNumer { get; set; }
        public System.Int32? MaDLp { get; set; }
        public System.Int32? RealWCalosci { get; set; }
        public System.Int32? OpeTypM { get; set; }
        public System.Int32? OpeFirmaM { get; set; }
        public System.Int32? OpeNumerM { get; set; }
        public System.Int32? OpeLpM { get; set; }
        [StringLength(21)]
        public System.String? AkronimWlasciciela { get; set; }
        [StringLength(21)]
        public System.String? AkronimStacji { get; set; }
        [StringLength(6)]
        public System.String? ZlcSeria { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentW { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentM { get; set; }
        [StringLength(31)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(11)]
        public System.String? MagazynD { get; set; }
        [StringLength(21)]
        public System.String? Cecha { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZlcRemNagInfo_20231(); }
    }
    public class XLDokumentZlcRemElemInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? SSWID { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CzyPrzeglad { get; set; }
        public System.Int32? StatusZgloszenia { get; set; }
        public System.Int32? MiejsceNaprawy { get; set; }
        public System.Int32? KodUszkodzenia { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ZrdFrSID { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? ReNTyp { get; set; }
        public System.Int32? ReNFirma { get; set; }
        public System.Int32? ReNNumer { get; set; }
        public System.Int32? ReNLp { get; set; }
        public System.Int32? MagTyp { get; set; }
        public System.Int32? MagFirma { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? MagLp { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? ProdTyp { get; set; }
        public System.Int32? ProdFirma { get; set; }
        public System.Int32? ProdNumer { get; set; }
        public System.Int32? ProdLp { get; set; }
        [StringLength(41)]
        public System.String? Towar { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? Koszt { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZlcRemElemInfo_20231(); }
    }
    public class XLZamkniecieDokumentuZlcRemInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? TrybZamkniecia { get; set; }
        public System.Int32? OpeTypP { get; set; }
        public System.Int32? OpeFirmaP { get; set; }
        public System.Int32? OpeNumerP { get; set; }
        public System.Int32? OpeLpP { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? DataPotwierdzenia { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentP { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuZlcRemInfo_20231(); }
    }
    public class XLOtwarcieDokumentuZlcRemInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieDokumentuZlcRemInfo_20231(); }
    }
    public class XLSerwisNagInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KnATyp { get; set; }
        public System.Int32? KnANumer { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? AdWTyp { get; set; }
        public System.Int32? AdWNumer { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? AdPNumer { get; set; }
        public System.Int32? AdPTyp { get; set; }
        public System.Int32? DataWystawienia { get; set; }
        public System.Int32? DataRozpoczecia { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? FrsId { get; set; }
        public System.Int32? ExpoNorm { get; set; }
        public System.Int32? KnSTyp { get; set; }
        public System.Int32? KnSNumer { get; set; }
        public System.Int32? KnSLp { get; set; }
        public System.Int32? KnSTypP { get; set; }
        public System.Int32? KnSNumerP { get; set; }
        public System.Int32? KnSLpP { get; set; }
        public System.Int32? KnSTypD { get; set; }
        public System.Int32? KnSNumerD { get; set; }
        public System.Int32? KnSLpD { get; set; }
        public System.Int32? Aktywny { get; set; }
        public System.Int32? FormaNr { get; set; }
        public System.Int32? FormaRabat { get; set; }
        public System.Int32? TerminPlatnosci { get; set; }
        public System.Int32? MagZNumer { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? CenaSpr { get; set; }
        public System.Int32? RezerwujZasoby { get; set; }
        public System.Int32? PriorytetRez { get; set; }
        public System.Int32? DataAktywacjiRez { get; set; }
        public System.Int32? DataWaznosciRez { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? BlokadaEdycji { get; set; }
        [StringLength(251)]
        public System.String? CechaOpis { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(2)]
        public System.String? FlagaNB { get; set; }
        [StringLength(16)]
        public System.String? FormaNazwa { get; set; }
        [StringLength(1025)]
        public System.String? Opis { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisNagInfo_20231(); }
    }
    public class XLOtwarcieSerwisNagInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ID { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieSerwisNagInfo_20231(); }
    }
    public class XLSerwisUrzWZlcInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? SZNId { get; set; }
        public System.Int32? SrUId { get; set; }
        public System.Int32? DodajPodrzedne { get; set; }
        public System.Int32? SREId { get; set; }
        [StringLength(15)]
        public System.String? Przebieg { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisUrzWZlcInfo_20231(); }
    }
    public class XLSerwisCzynnoscInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? SZNId { get; set; }
        public System.Int32? SZUId { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? GenerujZadania { get; set; }
        public System.Int32? SprzedazKoszt { get; set; }
        public System.Int32? Zrealizowano { get; set; }
        public System.Int32? CzasWykonania { get; set; }
        public System.Int32? CzasWykonaniaJedn { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? FlagaVAT { get; set; }
        public System.Int32? CenaSpr { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(15)]
        public System.String? CenaPoczatkowa { get; set; }
        [StringLength(15)]
        public System.String? CenaPoRabacie { get; set; }
        [StringLength(15)]
        public System.String? CenaZakupu { get; set; }
        [StringLength(2)]
        public System.String? GrupaPod { get; set; }
        [StringLength(15)]
        public System.String? Ilosc { get; set; }
        [StringLength(2049)]
        public System.String? Opis { get; set; }
        [StringLength(15)]
        public System.String? WartoscPoczatkowa { get; set; }
        [StringLength(15)]
        public System.String? WartoscPoRabacie { get; set; }
        [StringLength(6)]
        public System.String? StawkaPod { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisCzynnoscInfo_20231(); }
    }
    public class XLSerwisSkladnikInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? SZNId { get; set; }
        public System.Int32? SZCId { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? SprzedazKoszt { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? FlagaVAT { get; set; }
        public System.Int32? CenaSpr { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? CzescZamienna { get; set; }
        [StringLength(2049)]
        public System.String? Opis { get; set; }
        [StringLength(15)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? CenaPoczatkowa { get; set; }
        [StringLength(15)]
        public System.String? WartoscPoczatkowa { get; set; }
        [StringLength(15)]
        public System.String? CenaZakupu { get; set; }
        [StringLength(15)]
        public System.String? CenaPoRabacie { get; set; }
        [StringLength(15)]
        public System.String? WartoscPoRabacie { get; set; }
        [StringLength(2)]
        public System.String? GrupaPod { get; set; }
        [StringLength(6)]
        public System.String? StawkaPod { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisSkladnikInfo_20231(); }
    }
    public class XLSerwisObiektInfo : BaseXL
    {

        public System.Int32? SZNId { get; set; }
        public System.Int32? SZCId { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisObiektInfo_20231(); }
    }
    public class XLSerwisTerminInfo : BaseXL
    {

        public System.Int32? SZCId { get; set; }
        public System.Int32? TerminOd { get; set; }
        public System.Int32? TerminDo { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisTerminInfo_20231(); }
    }
    public class XLSerwisParametrInfo : BaseXL
    {

        public System.Int32? SlwTyp { get; set; }
        public System.Int32? SlwNumer { get; set; }
        public System.Int32? Archiwalny { get; set; }
        public System.Int32? SUDId { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? WartoscL { get; set; }
        public System.Int32? Id { get; set; }
        [StringLength(11)]
        public System.String? Format { get; set; }
        [StringLength(51)]
        public System.String? Nazwa { get; set; }
        [StringLength(15)]
        public System.String? WartoscDec { get; set; }
        [StringLength(256)]
        public System.String? WartoscS { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisParametrInfo_20231(); }
    }
    public class XLSerwisUrzadzenieInfo : BaseXL
    {

        public System.Int32? SURId { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? WlaTyp { get; set; }
        public System.Int32? WlaNumer { get; set; }
        public System.Int32? DokTyp { get; set; }
        public System.Int32? DokNumer { get; set; }
        public System.Int32? DokLp { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? NieKopiujParametrow { get; set; }
        public System.Int32? Nadrzedny { get; set; }
        [StringLength(512)]
        public System.String? Opis { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(256)]
        public System.String? Numer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisUrzadzenieInfo_20231(); }
    }
    public class XLZamkniecieSerwisNagInfo : BaseXL
    {

        public System.Int32? SZNId { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? TrybZamkniecia { get; set; }
        public System.Int32? Drukuj { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieSerwisNagInfo_20231(); }
    }
    public abstract class Doc : BaseXL
    {
        public System.String? NumerPelny { get; set; }
        public System.String? NumeracjaDok { get; set; }
        public System.String? NumerString { get; set; }
    }

    public class XLDokumentNagInfo : Doc
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Korekta { get; set; }
        public System.Int32? Avista { get; set; }
        public System.Int32? Anulowany { get; set; }
        public System.Int32? Spinacz { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? DataSpr { get; set; }
        public System.Int32? DataVat { get; set; }
        public System.Int32? DataMag { get; set; }
        public System.Int32? Termin { get; set; }
        public System.Int32? KursNr { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? RabatReq { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? Forma { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? AdrTyp { get; set; }
        public System.Int32? AdrFirma { get; set; }
        public System.Int32? AdrNumer { get; set; }
        public System.Int32? AdrLp { get; set; }
        public System.Int32? AdwTyp { get; set; }
        public System.Int32? AdwFirma { get; set; }
        public System.Int32? AdwNumer { get; set; }
        public System.Int32? AdwLp { get; set; }
        public System.Int32? AkwTyp { get; set; }
        public System.Int32? AkwFirma { get; set; }
        public System.Int32? AkwNumer { get; set; }
        public System.Int32? AkwLp { get; set; }
        public System.Int32? OpiTyp { get; set; }
        public System.Int32? OpiFirma { get; set; }
        public System.Int32? OpiNumer { get; set; }
        public System.Int32? OpiLp { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDFirma { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? KnDLp { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamFirma { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? ZwrTyp { get; set; }
        public System.Int32? ZwrFirma { get; set; }
        public System.Int32? ZwrNumer { get; set; }
        public System.Int32? ZwrLp { get; set; }
        public System.Int32? SaNTyp { get; set; }
        public System.Int32? SaNFirma { get; set; }
        public System.Int32? SaNNumer { get; set; }
        public System.Int32? SaNLp { get; set; }
        public System.Int32? KnOTyp { get; set; }
        public System.Int32? KnOFirma { get; set; }
        public System.Int32? KnONumer { get; set; }
        public System.Int32? KnOLp { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? AdPNumer { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ExpoNorm { get; set; }
        public System.Int32? AkwizytorKntPrc { get; set; }
        public System.Int32? MagazynSklad { get; set; }
        public System.Int32? FRSID { get; set; }
        public System.Int32? GenerujPlatnosci { get; set; }
        public System.Int32? TerminRozliczeniaKaucji { get; set; }
        public System.Int32? AktualizacjaKaucji { get; set; }
        public System.Int32? KosztUstalono { get; set; }
        public System.Int32? RSDataOd { get; set; }
        public System.Int32? RSDataDo { get; set; }
        public System.Int32? MiesiacVAT { get; set; }
        public System.Int32? RokVAT { get; set; }
        public System.Int32? DeklaracjaVAT7 { get; set; }
        public System.Int32? DeklaracjaVATUE { get; set; }
        public System.Int32? RodzajCeny { get; set; }
        public System.Int32? KarNumer { get; set; }
        public System.Int32? Fiskalny { get; set; }
        public System.Int32? IDOddzial { get; set; }
        public System.Int32? Zwiazane { get; set; }
        public System.Int32? ProjektID { get; set; }
        public System.Int32? RabatyOdCenyBezKGO { get; set; }
        public System.Int32? IgnorujRodzajKnt { get; set; }
        public System.Int32? KonTyp { get; set; }
        public System.Int32? KonNumer { get; set; }
        public System.Int32? PrzywracajRezerwacje { get; set; }
        public System.Int32? IgnorujZaliczkowe { get; set; }
        public System.Int32? IgnorujMagazynowe { get; set; }
        public System.Int32? WtrID { get; set; }
        public System.Int32? WtrProgID { get; set; }
        public System.Int32? Zbiorcza { get; set; }
        public System.Int32? RodzajKor { get; set; }
        public System.Int32? TypDatyKor { get; set; }
        public System.Int32? DataOdKor { get; set; }
        public System.Int32? DataDoKor { get; set; }
        public System.Int32? RodzajZakupu { get; set; }
        public System.Int32? OdliczeniaVat { get; set; }
        public System.Int32? Rozliczac { get; set; }
        public System.Int32? Struktura { get; set; }
        public System.Int32? RozliczacP { get; set; }
        public System.Int32? WMS { get; set; }
        public System.Int32? PodstawaZW { get; set; }
        public System.Int32? VATNalOd { get; set; }
        public System.Int32? GrupujSpi { get; set; }
        public System.Int32? OptymalizacjaSpi { get; set; }
        public System.Int32? MetodaKasowa { get; set; }
        public System.Int32? OCR { get; set; }
        public System.Int32? POSOperator { get; set; }
        public System.Int32? ProceduraUproszcz { get; set; }
        public System.Int32? MPP { get; set; }
        public System.Int32? TypSumyPlatnosci { get; set; }
        public System.Int32? OplataSpozFlaga { get; set; }
        public System.Int32? TylkoKaucjonowane { get; set; }
        public System.Int32? ProceduraOSS { get; set; }
        public System.Int32? KSeFWyslij { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(21)]
        public System.String? Akwizytor { get; set; }
        [StringLength(21)]
        public System.String? Docelowy { get; set; }
        [StringLength(41)]
        public System.String? Osoba { get; set; }
        [StringLength(21)]
        public System.String? Platnik { get; set; }
        [StringLength(21)]
        public System.String? SposobDst { get; set; }
        [StringLength(2)]
        public System.String? NB { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(11)]
        public System.String? MagazynZ { get; set; }
        [StringLength(11)]
        public System.String? MagazynD { get; set; }
        [StringLength(6)]
        public System.String? Rejestr { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(251)]
        public System.String? Cecha { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransportu { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransakcji { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(5)]
        public System.String? IncotermsSymbol { get; set; }
        [StringLength(256)]
        public System.String? IncotermsMiejsce { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(256)]
        public System.String? PrzyczynaKorekty { get; set; }
        [StringLength(256)]
        public System.String? PrzyczynaZW { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        public override object JsonSerializeResult()
        {
            Console.WriteLine(string.Format("{0} : {1}", NumerPelny, NumeracjaDok));
            return new { GIDNumer, Akronim, OptimaId, StatusZmiany };
        }
        // public void GetData() { new cdn_api.XLDokumentNagInfo_20231(); }
        public List<XLDokumentElemInfo> Pozycje { get; set; } = new List<XLDokumentElemInfo>();
        public List<XLPlatnoscInfo> Platnosci { get; set; } = new List<XLPlatnoscInfo>();
    }
    public class XLDokumentElemInfo : BaseXL
    {

        public System.Int32? GIDLp { get; set; }
        public System.Int32? GIDLpOrg { get; set; }
        public System.Int32? SubLpOrg { get; set; }
        public System.Int32? PozycjaOrg { get; set; }
        public System.Int32? TypKorekty { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? WartoscOst { get; set; }
        public System.Int32? Rownanie { get; set; }
        public System.Int32? OdKsiegowych { get; set; }
        public System.Int32? PrecyzjaCeny { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? DataKursu { get; set; }
        public System.Int32? KursNr { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamFirma { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? RezIgnor { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CechaReq { get; set; }
        public System.Int32? CCh2Typ { get; set; }
        public System.Int32? CCh2Numer { get; set; }
        public System.Int32? RecTyp { get; set; }
        public System.Int32? RecFirma { get; set; }
        public System.Int32? RecNumer { get; set; }
        public System.Int32? RecLp { get; set; }
        public System.Int32? MagReq { get; set; }
        public System.Int32? SposobPobieraniaZMag { get; set; }
        public System.Int32? TwrReq { get; set; }
        public System.Int32? NiePrzeliczaj { get; set; }
        public System.Int32? KosztUstalono { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? TpaID { get; set; }
        public System.Int32? CenaSpr { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Agreguj { get; set; }
        public System.Int32? FlagaVAT { get; set; }
        public System.Int32? StawkaPod { get; set; }
        public System.Int32? PakietId { get; set; }
        public System.Int32? Gratis { get; set; }
        public System.Int32? PromocjaProgID { get; set; }
        public System.Int32? Zlom { get; set; }
        public System.Int32? StawkaPodPrzed { get; set; }
        public System.Int32? FlagaVATPrzed { get; set; }
        public System.Int32? NieKontrolujMaxRabOpe { get; set; }
        public System.Int32? DodEleZez { get; set; }
        public System.Int32? PakietIloscZastosowana { get; set; }
        public System.Int32? Optymalizuj { get; set; }
        public System.Int32? POSOperator { get; set; }
        public System.Int32? OplataSpozFlaga { get; set; }
        public System.Int32? OplataSpozFlagaDst { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? CenaP { get; set; }
        [StringLength(15)]
        public System.String? Cena { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(15)]
        public System.String? WartoscR { get; set; }
        [StringLength(41)]
        public System.String? TowarKod { get; set; }
        [StringLength(41)]
        public System.String? TowarEAN { get; set; }
        [StringLength(256)]
        public System.String? TowarNazwa { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        [StringLength(2)]
        public System.String? Vat { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(256)]
        public System.String? Cecha2 { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(10)]
        public System.String? PCN { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(15)]
        public System.String? KGO { get; set; }
        [StringLength(2)]
        public System.String? VatPrzed { get; set; }
        [StringLength(14)]
        public System.String? IloscPrzed { get; set; }
        [StringLength(15)]
        public System.String? CenaPrzed { get; set; }
        [StringLength(15)]
        public System.String? WartoscPrzed { get; set; }
        [StringLength(256)]
        public System.String? PrzyczynaKorekty { get; set; }
        [StringLength(256)]
        public System.String? BudzetPrmID { get; set; }
        [StringLength(256)]
        public System.String? BudzetID { get; set; }
        [StringLength(256)]
        public System.String? BudzetWartosc { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierStala { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierZmienna { get; set; }
        [StringLength(15)]
        public System.String? StawkaKofeina { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentElemInfo_20231(); }
    }
    public class XLDokumentSubElemInfo : BaseXL
    {

        public System.Int32? SubLp { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? EleTyp { get; set; }
        public System.Int32? EleFirma { get; set; }
        public System.Int32? EleNumer { get; set; }
        public System.Int32? EleLp { get; set; }
        public System.Int32? GIDLpOrg { get; set; }
        public System.Int32? SubLpOrg { get; set; }
        public System.Int32? PozycjaOrg { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamFirma { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? RezIgnor { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CechaReq { get; set; }
        public System.Int32? CCh2Typ { get; set; }
        public System.Int32? CCh2Numer { get; set; }
        public System.Int32? SposobPobieraniaZMag { get; set; }
        public System.Int32? KosztUstalono { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? TpaID { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? TypKorekty { get; set; }
        public System.Int32? OplataSpozFlagaDst { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(256)]
        public System.String? Cecha2 { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentSubElemInfo_20231(); }
    }
    public class XLPlatnoscInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Forma { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? KursNr { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? Rozliczaj { get; set; }
        public System.Int32? KaZTyp { get; set; }
        public System.Int32? KaZFirma { get; set; }
        public System.Int32? KaZNumer { get; set; }
        public System.Int32? KaZLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? TypVat { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? WymusGenerowaniePlatnosci { get; set; }
        public System.Int32? Status { get; set; }
        public System.Int32? RkbID { get; set; }
        public System.Int32? BbonId { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(201)]
        public System.String? Notatki { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPlatnoscInfo_20231(); }
    }
    public class XLUsunElemInfo : BaseXL
    {

        public System.Int32? Pozycja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunElemInfo_20231(); }
    }
    public class XLZamkniecieDokumentuInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GidLp { get; set; }
        public System.Int32? Fiskalny { get; set; }
        public System.Int32? LimitKnt { get; set; }
        public System.Int32? Magazynowe { get; set; }
        public System.Int32? RkbID { get; set; }
        public System.Int32? MetodaDodawaniaPlt { get; set; }
        public System.Int32? KSeF { get; set; }
        public System.Int32? Anul { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuInfo_20231(); }
    }
    public class XLDokumentMagNagInfo : Doc
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? AdrTyp { get; set; }
        public System.Int32? AdrFirma { get; set; }
        public System.Int32? AdrNumer { get; set; }
        public System.Int32? AdrLp { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Zwiazane { get; set; }
        public System.Int32? Agregacja { get; set; }
        public System.Int32? FRSID { get; set; }
        public System.Int32? NaPelneJMPom { get; set; }
        public System.Int32? TylkoKaucjonowane { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(251)]
        public System.String? Cecha { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? SposobDst { get; set; }
        [StringLength(3)]
        public System.String? LaczPozycje { get; set; }
        public List<XLDokumentMagNagInfo> Pozycje { get; set; } = new List<XLDokumentMagNagInfo>();

        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentMagNagInfo_20231(); }
    }
    public class XLDokumentMagElemInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? SubLp { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? SUBZrdLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CechaReq { get; set; }
        public System.Int32? CCh2Typ { get; set; }
        public System.Int32? CCh2Numer { get; set; }
        public System.Int32? SposobPobieraniaZMag { get; set; }
        public System.Int32? TwrReq { get; set; }
        public System.Int32? Adres { get; set; }
        public System.Int32? Dokad { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? TpaID { get; set; }
        public System.Int32? WylaczZarzadzaniePolozeniem { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? NieDodawajMaP { get; set; }
        public System.Int32? PozycjaOrg { get; set; }
        public System.Int32? JLogWMS { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? TowarKod { get; set; }
        [StringLength(41)]
        public System.String? TowarEAN { get; set; }
        [StringLength(256)]
        public System.String? TowarNazwa { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(256)]
        public System.String? Cecha2 { get; set; }
        [StringLength(7)]
        public System.String? Dlugosc { get; set; }
        [StringLength(7)]
        public System.String? Szerokosc { get; set; }
        [StringLength(7)]
        public System.String? Wysokosc { get; set; }
        [StringLength(31)]
        public System.String? JMLog { get; set; }
        [StringLength(31)]
        public System.String? JMLogDoc { get; set; }
        [StringLength(14)]
        public System.String? IloscMin { get; set; }
        [StringLength(14)]
        public System.String? IloscMax { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentMagElemInfo_20231(); }
    }
    public class XLUsunMagElemInfo : BaseXL
    {

        public System.Int32? Pozycja { get; set; }
        public System.Int32? SubPozycja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunMagElemInfo_20231(); }
    }
    public class XLZamkniecieDokumentuMagInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GidLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuMagInfo_20231(); }
    }
    public class XLKontrahentInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? GRPTyp { get; set; }
        public System.Int32? GRPFirma { get; set; }
        public System.Int32? GRPNumer { get; set; }
        public System.Int32? GRPLp { get; set; }
        public System.Int32? Akwizytor { get; set; }
        public System.Int32? OpeZTyp { get; set; }
        public System.Int32? OpeZFirma { get; set; }
        public System.Int32? OpeZNumer { get; set; }
        public System.Int32? OpeZLp { get; set; }
        public System.Int32? NRB { get; set; }
        public System.Int32? RegionCRM { get; set; }
        public System.Int32? Spedytor { get; set; }
        public System.Int32? Cena { get; set; }
        public System.Int32? FormaPl { get; set; }
        public System.Int32? PlatnikVat { get; set; }
        public System.Int32? ExpoKraj { get; set; }
        public System.Int32? PrcTyp { get; set; }
        public System.Int32? PrcFirma { get; set; }
        public System.Int32? PrcNumer { get; set; }
        public System.Int32? PrcLp { get; set; }
        public System.Int32? AutoPotwierdzenie { get; set; }
        public System.Int32? MagTyp { get; set; }
        public System.Int32? MagFirma { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? MagLp { get; set; }
        public System.Int32? KarTyp { get; set; }
        public System.Int32? KarFirma { get; set; }
        public System.Int32? KarNumer { get; set; }
        public System.Int32? KarLp { get; set; }
        public System.Int32? TerminPlSpr { get; set; }
        public System.Int32? TerminPlKa { get; set; }
        public System.Int32? FormaPlKa { get; set; }
        public System.Int32? TerminPlZak { get; set; }
        public System.Int32? FormaPlZak { get; set; }
        public System.Int32? SpTerminPlSpr { get; set; }
        public System.Int32? SpTerminPlRK { get; set; }
        public System.Int32? SpTerminPlZak { get; set; }
        public System.Int32? LimitTerminowy { get; set; }
        public System.Int32? DataWygasniecia { get; set; }
        public System.Int32? MaxDniPoTerminie { get; set; }
        public System.Int32? Koncesja { get; set; }
        public System.Int32? DataKoncesji { get; set; }
        public System.Int32? Dzialalnosc { get; set; }
        public System.Int32? AkwTyp { get; set; }
        public System.Int32? AkwFirma { get; set; }
        public System.Int32? AkwNumer { get; set; }
        public System.Int32? AkwLp { get; set; }
        public System.Int32? Dewizowe { get; set; }
        public System.Int32? BlokadaTransakcji { get; set; }
        public System.Int32? Status { get; set; }
        public System.Int32? RolaPartnera { get; set; }
        public System.Int32? Zrodlo { get; set; }
        public System.Int32? Branza { get; set; }
        public System.Int32? Rodzaj { get; set; }
        public System.Int32? AdresNieaktualny { get; set; }
        public System.Int32? DataKarty { get; set; }
        public System.Int32? TypKarty { get; set; }
        public System.Int32? Priorytet { get; set; }
        public System.Int32? NieSprPodobnych { get; set; }
        public System.Int32? PriorytetRez { get; set; }
        public System.Int32? TerminRozliczeniaKaucji { get; set; }
        public System.Int32? PlatnoscKaucji { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? KnPFormaTerminPl { get; set; }
        public System.Int32? Powiazany { get; set; }
        public System.Int32? KnGTyp { get; set; }
        public System.Int32? KnGNumer { get; set; }
        public System.Int32? OpiekunCzas { get; set; }
        public System.Int32? OpiekunDataOd { get; set; }
        public System.Int32? OpiekunDataDo { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeNumerO { get; set; }
        public System.Int32? TwrGrupaNumer { get; set; }
        public System.Int32? DataWydania { get; set; }
        public System.Int32? RolnikRyczaltowy { get; set; }
        public System.Int32? ESklep { get; set; }
        public System.Int32? OplataSpozZakup { get; set; }
        public System.Int32? OplataSpozSprzedaz { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(51)]
        public System.String? Nazwa1 { get; set; }
        [StringLength(51)]
        public System.String? Nazwa2 { get; set; }
        [StringLength(251)]
        public System.String? Nazwa3 { get; set; }
        [StringLength(11)]
        public System.String? KodP { get; set; }
        [StringLength(31)]
        public System.String? Miasto { get; set; }
        [StringLength(31)]
        public System.String? Ulica { get; set; }
        [StringLength(31)]
        public System.String? Adres { get; set; }
        [StringLength(3)]
        public System.String? NipPrefiks { get; set; }
        [StringLength(21)]
        public System.String? NipE { get; set; }
        [StringLength(21)]
        public System.String? Regon { get; set; }
        [StringLength(12)]
        public System.String? Pesel { get; set; }
        [StringLength(21)]
        public System.String? Bank { get; set; }
        [StringLength(51)]
        public System.String? NrRachunku { get; set; }
        [StringLength(13)]
        public System.String? Odleglosc { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(31)]
        public System.String? Wojewodztwo { get; set; }
        [StringLength(31)]
        public System.String? Powiat { get; set; }
        [StringLength(31)]
        public System.String? Gmina { get; set; }
        [StringLength(31)]
        public System.String? Telefon1 { get; set; }
        [StringLength(31)]
        public System.String? Telefon2 { get; set; }
        [StringLength(31)]
        public System.String? Fax { get; set; }
        [StringLength(31)]
        public System.String? Modem { get; set; }
        [StringLength(31)]
        public System.String? Telex { get; set; }
        [StringLength(256)]
        public System.String? EMail { get; set; }
        [StringLength(31)]
        public System.String? KontoDostawcy { get; set; }
        [StringLength(31)]
        public System.String? KontoOdbiorcy { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(21)]
        public System.String? CenaStr { get; set; }
        [StringLength(6)]
        public System.String? SeriaFa { get; set; }
        [StringLength(21)]
        public System.String? AkronimOpiekuna { get; set; }
        [StringLength(11)]
        public System.String? MagKod { get; set; }
        [StringLength(256)]
        public System.String? OutlookUrl { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(21)]
        public System.String? DataWygasnieciaStr { get; set; }
        [StringLength(21)]
        public System.String? DataKoncesjiStr { get; set; }
        [StringLength(21)]
        public System.String? SposobDostawy { get; set; }
        [StringLength(21)]
        public System.String? AkronimAkwizytora { get; set; }
        [StringLength(21)]
        public System.String? Platnik { get; set; }
        [StringLength(4)]
        public System.String? WalSymbol { get; set; }
        [StringLength(12)]
        public System.String? AkwProwizja { get; set; }
        [StringLength(1024)]
        public System.String? RegionCRMStr { get; set; }
        [StringLength(14)]
        public System.String? GLN { get; set; }
        [StringLength(8)]
        public System.String? Rabat { get; set; }
        [StringLength(18)]
        public System.String? MaxLimitWart { get; set; }
        [StringLength(18)]
        public System.String? LimitPoTerminie { get; set; }
        [StringLength(251)]
        public System.String? CechaOpis { get; set; }
        [StringLength(8)]
        public System.String? Marza { get; set; }
        [StringLength(256)]
        public System.String? RolaPartneraStr { get; set; }
        [StringLength(256)]
        public System.String? ZrodloStr { get; set; }
        [StringLength(256)]
        public System.String? BranzaStr { get; set; }
        [StringLength(256)]
        public System.String? RodzajStr { get; set; }
        [StringLength(4096)]
        public System.String? GrupaSciezka { get; set; }
        [StringLength(17)]
        public System.String? NumerKarty { get; set; }
        [StringLength(20)]
        public System.String? DataKartyStr { get; set; }
        [StringLength(21)]
        public System.String? TypKartyStr { get; set; }
        [StringLength(5)]
        public System.String? Pin { get; set; }
        [StringLength(41)]
        public System.String? PriorytetStr { get; set; }
        [StringLength(21)]
        public System.String? KontrahentGlowny { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? OpiekunCzasStr { get; set; }
        [StringLength(9)]
        public System.String? FppKod { get; set; }
        [StringLength(6)]
        public System.String? SeriaKaP { get; set; }
        [StringLength(101)]
        public System.String? OpeHaslo { get; set; }
        [StringLength(51)]
        public System.String? OrganWydajacy { get; set; }
        [StringLength(51)]
        public System.String? DokumentTozsamosci { get; set; }
        [StringLength(3)]
        public System.String? WSTO { get; set; }
        [StringLength(3)]
        public System.String? KSeFWyslij { get; set; }
        public override object JsonSerializeResult() => new { GIDNumer, Akronim, OptimaId, StatusZmiany };
        // public void GetData() { new cdn_api.XLKontrahentInfo_20231(); }
    }
    public class XLAdresInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Wysylkowy { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? NRB { get; set; }
        public System.Int32? RegionCRM { get; set; }
        public System.Int32? NiePublikuj { get; set; }
        public System.Int32? AdresBank { get; set; }
        public System.Int32? TypPOS { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(51)]
        public System.String? Nazwa1 { get; set; }
        [StringLength(51)]
        public System.String? Nazwa2 { get; set; }
        [StringLength(251)]
        public System.String? Nazwa3 { get; set; }
        [StringLength(11)]
        public System.String? KodP { get; set; }
        [StringLength(31)]
        public System.String? Miasto { get; set; }
        [StringLength(31)]
        public System.String? Ulica { get; set; }
        [StringLength(31)]
        public System.String? Adres { get; set; }
        [StringLength(3)]
        public System.String? NipPrefiks { get; set; }
        [StringLength(21)]
        public System.String? NipE { get; set; }
        [StringLength(21)]
        public System.String? Regon { get; set; }
        [StringLength(12)]
        public System.String? Pesel { get; set; }
        [StringLength(21)]
        public System.String? Bank { get; set; }
        [StringLength(51)]
        public System.String? NrRachunku { get; set; }
        [StringLength(13)]
        public System.String? Odleglosc { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(31)]
        public System.String? Wojewodztwo { get; set; }
        [StringLength(31)]
        public System.String? Powiat { get; set; }
        [StringLength(31)]
        public System.String? Gmina { get; set; }
        [StringLength(31)]
        public System.String? Telefon1 { get; set; }
        [StringLength(31)]
        public System.String? Telefon2 { get; set; }
        [StringLength(31)]
        public System.String? Fax { get; set; }
        [StringLength(31)]
        public System.String? Modem { get; set; }
        [StringLength(31)]
        public System.String? Telex { get; set; }
        [StringLength(256)]
        public System.String? EMail { get; set; }
        [StringLength(31)]
        public System.String? KontoDostawcy { get; set; }
        [StringLength(31)]
        public System.String? KontoOdbiorcy { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        [StringLength(41)]
        public System.String? GUIDdane { get; set; }
        [StringLength(41)]
        public System.String? GUIDTelefon { get; set; }
        [StringLength(41)]
        public System.String? GUIDEmail { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAdresInfo_20231(); }

    }
    public class XLZamkniecieKontrahentaInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GidLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieKontrahentaInfo_20231(); }
    }
    public class XLZamkniecieAdresuInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GidLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieAdresuInfo_20231(); }
    }
    public class XLRabatyComInfo : BaseXL
    {

        public System.Int32? Typ { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? ExpoNorm { get; set; }
        public System.Int32? FormaPl { get; set; }
        public System.Int32? RabatFormyPlatnosci { get; set; }
        public System.Int32? RabatGlobalny { get; set; }
        public System.Int32? LiczOdWartosciKsiegowej { get; set; }
        public System.Int32? TypDopasowania { get; set; }
        public System.Int32? IloscCenaWartosc { get; set; }
        public System.Int32? Dokladnosc { get; set; }
        public System.Int32? WymusZmianeWartosci { get; set; }
        public System.Int32? NumerKursuWaluty { get; set; }
        public System.Int32? MianownikKursuWaluty { get; set; }
        public System.Int32? LicznikKursuWaluty { get; set; }
        public System.Int32? TypRabatuKontrahentaNaTowar { get; set; }
        public System.Int32? RabatKontrahentaNaTowar { get; set; }
        public System.Int32? TypProgu { get; set; }
        public System.Int32? WartoscProgowa { get; set; }
        public System.Int32? TypRabatuProgowego { get; set; }
        public System.Int32? RabatProgowy { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? NumerCenyPoczatkowej { get; set; }
        public System.Int32? RabatEfektywny { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? ZstTyp { get; set; }
        public System.Int32? ZstFirma { get; set; }
        public System.Int32? ZstNumer { get; set; }
        public System.Int32? ZstLp { get; set; }
        [StringLength(2)]
        public System.String? FlagaNB { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? CenaTowaru { get; set; }
        [StringLength(15)]
        public System.String? CenaPoRabacie { get; set; }
        [StringLength(15)]
        public System.String? WartoscPoRabacie { get; set; }
        [StringLength(15)]
        public System.String? CenaKsiegowa { get; set; }
        [StringLength(15)]
        public System.String? WartoscKsiegowa { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(41)]
        public System.String? TowarKod { get; set; }
        [StringLength(4)]
        public System.String? WalutaTowaru { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRabatyComInfo_20231(); }
    }
    public class XLOtwarcieNagInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? TrNRok { get; set; }
        public System.Int32? TrNMiesiac { get; set; }
        public System.Int32? TrMNumer { get; set; }
        public System.Int32? TrybNaprawy { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(6)]
        public System.String? TrNSeria { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieNagInfo_20231(); }
    }
    public class XLVatInfo : BaseXL
    {

        public System.Int32? StawkaPod { get; set; }
        public System.Int32? FlagaVat { get; set; }
        public System.Int32? Zrodlowa { get; set; }
        public System.Int32? DeklRok { get; set; }
        public System.Int32? DeklMiesiac { get; set; }
        public System.Int32? RodzajZakupu { get; set; }
        public System.Int32? OdliczeniaVat { get; set; }
        public System.Int32? Rozliczac { get; set; }
        public System.Int32? Struktura { get; set; }
        public System.Int32? RozliczacP { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? IgnorujVat { get; set; }
        public System.Int32? SrtTyp { get; set; }
        public System.Int32? SrtNumer { get; set; }
        public System.Int32? ULRID { get; set; }
        public System.Int32? OgrOdl { get; set; }
        public System.Int32? VATNalOd { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(2)]
        public System.String? FlagaNB { get; set; }
        [StringLength(15)]
        public System.String? WartoscVat { get; set; }
        [StringLength(41)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLVatInfo_20231(); }
    }
    public class XLSpiInfo : BaseXL
    {

        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? TrNSubLp { get; set; }
        public System.Int32? GrupujSpi { get; set; }
        public System.Int32? OptymalizacjaSpi { get; set; }
        public System.Int32? IgnorujZaliczki { get; set; }
        public System.Int32? ZachowajDane { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSpiInfo_20231(); }
    }
    public class XLOtwarcieMagNagInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? TrNRok { get; set; }
        public System.Int32? TrNMiesiac { get; set; }
        public System.Int32? TrMNumer { get; set; }
        public System.Int32? TrybNaprawy { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(6)]
        public System.String? TrNSeria { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieMagNagInfo_20231(); }
    }
    public class XLDokumentImpNagInfo : Doc
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Anulowany { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? DataWystawienia { get; set; }
        public System.Int32? DataZakupu { get; set; }
        public System.Int32? DataWplywu { get; set; }
        public System.Int32? Forma { get; set; }
        public System.Int32? AdrTyp { get; set; }
        public System.Int32? AdrFirma { get; set; }
        public System.Int32? AdrNumer { get; set; }
        public System.Int32? AdrLp { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? AdPNumer { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamFirma { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? KursNr { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ExpoNorm { get; set; }
        public System.Int32? Korekta { get; set; }
        public System.Int32? ZwrTyp { get; set; }
        public System.Int32? ZwrNumer { get; set; }
        public System.Int32? Termin { get; set; }
        public System.Int32? ProceduraUproszcz { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(21)]
        public System.String? Platnik { get; set; }
        [StringLength(21)]
        public System.String? SposobDst { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(251)]
        public System.String? Cecha { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransportu { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransakcji { get; set; }
        [StringLength(5)]
        public System.String? IncotermsSymbol { get; set; }
        [StringLength(256)]
        public System.String? IncotermsMiejsce { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public List<XLDokumentImpElemInfo> Pozycje { get; set; } = new List<XLDokumentImpElemInfo>();

        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentImpNagInfo_20231(); }
    }
    public class XLOtwarcieImpNagInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? TrNRok { get; set; }
        public System.Int32? TrNMiesiac { get; set; }
        public System.Int32? TrMNumer { get; set; }
        public System.Int32? TrybNaprawy { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(6)]
        public System.String? TrNSeria { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieImpNagInfo_20231(); }
    }
    public class XLDokumentImpElemInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? Pozycja { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamFirma { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? PrecyzjaCeny { get; set; }
        public System.Int32? TwrReq { get; set; }
        public System.Int32? TypKorekty { get; set; }
        public System.Int32? GIDLpOrg { get; set; }
        public System.Int32? PozycjaOrg { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? TypKosztu { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? Cena { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(41)]
        public System.String? TowarKod { get; set; }
        [StringLength(41)]
        public System.String? TowarEAN { get; set; }
        [StringLength(256)]
        public System.String? TowarNazwa { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(11)]
        public System.String? PCN { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentImpElemInfo_20231(); }
    }
    public class XLZamkniecieDokumentuImpInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GidLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuImpInfo_20231(); }
    }
    public class XLUsunImpElemInfo : BaseXL
    {

        public System.Int32? Pozycja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunImpElemInfo_20231(); }
    }
    public class XLDokumentSadNagInfo : Doc
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Anulowany { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? DataZgloszeniaZakupu { get; set; }
        public System.Int32? DataWplywuWystawienia { get; set; }
        public System.Int32? DataPrzyjeciaVat { get; set; }
        public System.Int32? Forma { get; set; }
        public System.Int32? TypPlatnosci { get; set; }
        public System.Int32? TypPodmiotu { get; set; }
        public System.Int32? AdrTyp { get; set; }
        public System.Int32? AdrFirma { get; set; }
        public System.Int32? AdrNumer { get; set; }
        public System.Int32? AdrLp { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? AdPnumer { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? KursNr { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? KwotyReq { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ExpoNorm { get; set; }
        public System.Int32? Termin { get; set; }
        public System.Int32? Korekta { get; set; }
        public System.Int32? ZwrTyp { get; set; }
        public System.Int32? ZwrNumer { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(21)]
        public System.String? Urzad { get; set; }
        [StringLength(21)]
        public System.String? Platnik { get; set; }
        [StringLength(15)]
        public System.String? KwotaProforma { get; set; }
        [StringLength(15)]
        public System.String? KwotaOplataManipulacyjna { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(6)]
        public System.String? SkladCelny { get; set; }
        [StringLength(6)]
        public System.String? Rejestr { get; set; }
        [StringLength(41)]
        public System.String? NumerSAD { get; set; }
        [StringLength(251)]
        public System.String? Cecha { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransportu { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(5)]
        public System.String? IncotermsSymbol { get; set; }
        [StringLength(256)]
        public System.String? IncotermsMiejsce { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        public List<XLDokumentSadElemInfo> Pozycje { get; set; } = new List<XLDokumentSadElemInfo>();

        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentSadNagInfo_20231(); }
    }
    public class XLOtwarcieSadNagInfo : BaseXL
    {
        public System.Int32? Tryb { get; set; }
        public System.Int32? GIDLp { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? TrNRok { get; set; }
        public System.Int32? TrNMiesiac { get; set; }
        public System.Int32? TrMNumer { get; set; }
        public System.Int32? TrybNaprawy { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(6)]
        public System.String? TrNSeria { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieSadNagInfo_20231(); }
    }
    public class XLDokumentSadElemInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Pozycja { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CechaReq { get; set; }
        public System.Int32? KwotyReq { get; set; }
        public System.Int32? SposobPobieraniaZSC { get; set; }
        public System.Int32? TwrReq { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? GIDLpOrg { get; set; }
        public System.Int32? SubLpOrg { get; set; }
        public System.Int32? PozycjaOrg { get; set; }
        public System.Int32? TypKorekty { get; set; }
        [StringLength(15)]
        public System.String? KwotaKosztuKrajowego { get; set; }
        [StringLength(15)]
        public System.String? KwotaKosztuZagranicznego { get; set; }
        [StringLength(15)]
        public System.String? KwotaClo { get; set; }
        [StringLength(15)]
        public System.String? KwotaAkcyza { get; set; }
        [StringLength(15)]
        public System.String? KwotaVat { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? Objetosc { get; set; }
        [StringLength(15)]
        public System.String? WagaNetto { get; set; }
        [StringLength(15)]
        public System.String? WagaBrutto { get; set; }
        [StringLength(6)]
        public System.String? WJM { get; set; }
        [StringLength(41)]
        public System.String? TowarKod { get; set; }
        [StringLength(41)]
        public System.String? TowarEAN { get; set; }
        [StringLength(256)]
        public System.String? TowarNazwa { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(11)]
        public System.String? PCN { get; set; }
        [StringLength(4)]
        public System.String? WalutaKosztuKrajowego { get; set; }
        [StringLength(4)]
        public System.String? WalutaKosztuZagranicznego { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentSadElemInfo_20231(); }
    }
    public class XLDokumentSadSubElemInfo : BaseXL
    {
        public System.Int32? IloscReq { get; set; }
        public System.Int32? EleTyp { get; set; }
        public System.Int32? EleFirma { get; set; }
        public System.Int32? EleNumer { get; set; }
        public System.Int32? EleLp { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CechaReq { get; set; }
        public System.Int32? SposobPobieraniaZSC { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? GIDLpOrg { get; set; }
        public System.Int32? SubLpOrg { get; set; }
        public System.Int32? PozycjaOrg { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentSadSubElemInfo_20231(); }
    }
    public class XLDokumentSadKwotaDodInfo : BaseXL
    {
        public System.Int32? EleLp { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? Rodzaj { get; set; }
        public System.Int32? VAT { get; set; }
        public System.Int32? Clo { get; set; }
        public System.Int32? Akcyza { get; set; }
        public System.Int32? Pomin { get; set; }
        public System.Int32? Waluta { get; set; }
        public System.Int32? Platnosci { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(255)]
        public System.String? Opis { get; set; }
        [StringLength(81)]
        public System.String? Nazwa { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentSadKwotaDodInfo_20231(); }
    }
    public class XLZamkniecieDokumentuSadInfo : BaseXL
    {
        public System.Int32? Tryb { get; set; }
        public System.Int32? RozbijKwoty { get; set; }
        public System.Int32? GidLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuSadInfo_20231(); }
    }
    public class XLUsunSadElemInfo : BaseXL
    {
        public System.Int32? Pozycja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunSadElemInfo_20231(); }
    }
    public class XLTowarInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? CenaSpr { get; set; }
        public System.Int32? CCkTyp { get; set; }
        public System.Int32? CCkFirma { get; set; }
        public System.Int32? CCkNumer { get; set; }
        public System.Int32? CCkLp { get; set; }
        public System.Int32? CechaZakup { get; set; }
        public System.Int32? CechaSprzedaz { get; set; }
        public System.Int32? KosztUTyp { get; set; }
        public System.Int32? TwGTyp { get; set; }
        public System.Int32? TwGFirma { get; set; }
        public System.Int32? TwGNumer { get; set; }
        public System.Int32? TwGLp { get; set; }
        public System.Int32? RozliczMag { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? KgoId { get; set; }
        public System.Int32? FlagaVat { get; set; }
        public System.Int32? FlagaVatSpr { get; set; }
        public System.Int32? Koncesja { get; set; }
        public System.Int32? Zlom { get; set; }
        public System.Int32? Kaucja { get; set; }
        public System.Int32? SKNId { get; set; }
        public System.Int32? JMCalkowita { get; set; }
        public System.Int32? MobSpr { get; set; }
        public System.Int32? JMDopelnianiaMobSpr { get; set; }
        public System.Int32? OplataSpozFlaga { get; set; }
        public System.Int32? OplataSpozDostawyTyp { get; set; }
        public System.Int32? OplataSpozDostawyFlaga { get; set; }
        public System.Int32? OplataSpozNrPartii { get; set; }
        public System.Int32? OplataSpozNrPartiiAtrybut { get; set; }
        public System.Int32? Bon { get; set; }
        public System.Int32? RBoId { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(21)]
        public System.String? SWW { get; set; }
        [StringLength(41)]
        public System.String? EAN { get; set; }
        [StringLength(9)]
        public System.String? Jm { get; set; }
        [StringLength(2)]
        public System.String? GrupaPod { get; set; }
        [StringLength(2)]
        public System.String? GrupaPodSpr { get; set; }
        [StringLength(41)]
        public System.String? Symbol { get; set; }
        [StringLength(21)]
        public System.String? KlasaCechy { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(7)]
        public System.String? MarzaMin { get; set; }
        [StringLength(17)]
        public System.String? KosztUslugi { get; set; }
        [StringLength(7)]
        public System.String? Akcyza { get; set; }
        [StringLength(9)]
        public System.String? Clo { get; set; }
        [StringLength(11)]
        public System.String? PCN { get; set; }
        [StringLength(4096)]
        public System.String? TwrGrupa { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? KgoKod { get; set; }
        [StringLength(8)]
        public System.String? StawkaPod { get; set; }
        [StringLength(8)]
        public System.String? StawkaPodSpr { get; set; }
        [StringLength(8)]
        public System.String? Zrodlowa { get; set; }
        [StringLength(8)]
        public System.String? ZrodlowaSpr { get; set; }
        [StringLength(21)]
        public System.String? FPPKod { get; set; }
        [StringLength(11)]
        public System.String? SchematKaucji { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierStala { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierZmienna { get; set; }
        [StringLength(15)]
        public System.String? StawkaKofeina { get; set; }
        [StringLength(15)]
        public System.String? ZawartoscCukru { get; set; }
        [StringLength(15)]
        public System.String? OplataSpozPrzeliczL { get; set; }
        [StringLength(15)]
        public System.String? OplataSpozPrzeliczM { get; set; }
        public override object JsonSerializeResult() => new { GIDNumer, Kod, Nazwa, OptimaId, StatusZmiany };
        // public void GetData() { new cdn_api.XLTowarInfo_20231(); }
    }
    public class XLZamkniecieTowaruInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieTowaruInfo_20231(); }
    }
    public class XLCenaInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? Aktualizacja { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? TcnId { get; set; }
        public System.Int32? DataOd { get; set; }
        public System.Int32? RodzajPodstawy { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(17)]
        public System.String? Wartosc { get; set; }
        [StringLength(7)]
        public System.String? Marza { get; set; }
        [StringLength(7)]
        public System.String? Zaok { get; set; }
        [StringLength(6)]
        public System.String? Offset { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLCenaInfo_20231(); }
    }
    public class XLRecepturaInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? RodzajKosztu { get; set; }
        public System.Int32? TypReceptury { get; set; }
        public System.Int32? Godzin { get; set; }
        public System.Int32? Minut { get; set; }
        public System.Int32? TypCechy { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(41)]
        public System.String? Towar { get; set; }
        [StringLength(41)]
        public System.String? Symbol { get; set; }
        [StringLength(41)]
        public System.String? Nazwa { get; set; }
        [StringLength(13)]
        public System.String? Ilosc { get; set; }
        [StringLength(17)]
        public System.String? KosztEwid { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(11)]
        public System.String? MagProd { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? KlasaCechy { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(9)]
        public System.String? Jm { get; set; }
        [StringLength(256)]
        public System.String? Url { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRecepturaInfo_20231(); }
    }
    public class XLZamkniecieRecepturyInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieRecepturyInfo_20231(); }
    }
    public class XLSkladnikRecepturyInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? Zamienniki { get; set; }
        public System.Int32? TypPozycji { get; set; }
        public System.Int32? TypCechy { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(41)]
        public System.String? Towar { get; set; }
        [StringLength(13)]
        public System.String? Ilosc { get; set; }
        [StringLength(7)]
        public System.String? Ubytek { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(11)]
        public System.String? MagProd { get; set; }
        [StringLength(17)]
        public System.String? Koszt { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? KlasaCechy { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(9)]
        public System.String? Jm { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSkladnikRecepturyInfo_20231(); }
    }
    public class XLPracownikInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? BnkTyp { get; set; }
        public System.Int32? BnkFirma { get; set; }
        public System.Int32? BnkNumer { get; set; }
        public System.Int32? BnkLp { get; set; }
        public System.Int32? FrmID { get; set; }
        public System.Int32? Warstwa { get; set; }
        public System.Int32? FormaNr { get; set; }
        public System.Int32? Ksiegowany { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(31)]
        public System.String? Imie1 { get; set; }
        [StringLength(31)]
        public System.String? Imie2 { get; set; }
        [StringLength(51)]
        public System.String? Nazwisko { get; set; }
        [StringLength(7)]
        public System.String? KodP { get; set; }
        [StringLength(31)]
        public System.String? Miasto { get; set; }
        [StringLength(31)]
        public System.String? Ulica { get; set; }
        [StringLength(11)]
        public System.String? NrDomu { get; set; }
        [StringLength(11)]
        public System.String? NrLokalu { get; set; }
        [StringLength(21)]
        public System.String? NipE { get; set; }
        [StringLength(12)]
        public System.String? Pesel { get; set; }
        [StringLength(41)]
        public System.String? EMail { get; set; }
        [StringLength(21)]
        public System.String? Bank { get; set; }
        [StringLength(51)]
        public System.String? NrRachunku { get; set; }
        [StringLength(31)]
        public System.String? KontoKs1 { get; set; }
        [StringLength(31)]
        public System.String? KontoKs2 { get; set; }
        [StringLength(31)]
        public System.String? KontoKs3 { get; set; }
        [StringLength(31)]
        public System.String? KontoKs4 { get; set; }
        [StringLength(31)]
        public System.String? KontoKs5 { get; set; }
        [StringLength(41)]
        public System.String? Centrum { get; set; }
        [StringLength(41)]
        public System.String? Lokalizacja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPracownikInfo_20231(); }
    }
    public class XLSad2PziInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSad2PziInfo_20231(); }
    }
    public class XLAtrybutInfo : BaseXL
    {
        public System.Int32? ID { get; set; }
        public System.Int32? GIDLp { get; set; }
        public System.Int32? GIDSubLp { get; set; }
        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamRodzaj { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? AtrTyp { get; set; }
        public System.Int32? AtrFirma { get; set; }
        public System.Int32? AtrNumer { get; set; }
        public System.Int32? AtrLp { get; set; }
        public System.Int32? AtrSublp { get; set; }
        [StringLength(256)]
        public System.String? Klasa { get; set; }
        [StringLength(513)]
        public System.String? Wartosc { get; set; }
#pragma warning disable IDE1006 // Naming Styles
        [StringLength(512)]
        public System.String? sBlad { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrybutInfo_20231(); }
    }
    public class XLKontrahentSQLInfo : BaseContractor
    {
        public System.Int32? GrpTyp { get; set; }
        public System.Int32? GrpFirma { get; set; }
        public System.Int32? GrpNumer { get; set; }
        public System.Int32? OpeTyp { get; set; }
        public System.Int32? OpeFirma { get; set; }
        public System.Int32? OpeNumer { get; set; }
        public System.Int32? MaxDniPoTerminie { get; set; }
        public System.Int32? PriorytetRez { get; set; }
        public System.Int32? TerminRozliczeniaKaucji { get; set; }
        public System.Int32? PlatnoscKaucji { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? KnPFormaTerminPl { get; set; }
        public System.Int32? KnGTyp { get; set; }
        public System.Int32? KnGNumer { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeNumerO { get; set; }
        public System.Int32? TwrGrupaNumer { get; set; }
        public System.Int32? ESklep { get; set; }

        [StringLength(21)]
        public System.String? Platnik { get; set; }
        [StringLength(21)]
        public System.String? KontrahentGlowny { get; set; }
        [StringLength(1000)]
        public System.String? OpisBledu { get; set; }
        [StringLength(6)]
        public System.String? SeriaKaP { get; set; }
        [StringLength(101)]
        public System.String? OpeHaslo { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        [StringLength(41)]
        public System.String? GUIDdane { get; set; }
        public override object JsonSerializeResult() => new { GIDNumer, Akronim, OptimaId, StatusZmiany };
        // public void GetData() { new cdn_api.XLKontrahentSQLInfo_20231(); }
    }
    public class BaseContractor : BaseXL
    {
        [StringLength(21)]
        public string Akronim { get; set; } = "";
        [StringLength(31)]
        public string? AkronimFormat { get; set; }

        public int? Typ { get; set; }
        public int? Akwizytor { get; set; }
        public int? BnkTyp { get; set; }
        public int? BnkFirma { get; set; }
        public int? BnkNumer { get; set; }

        public int? LimitOkres { get; set; }
        public int? Dewizowe { get; set; }
        public int? Cena { get; set; }
        public int? FormaPl { get; set; }
        public int? TypKarty { get; set; }
        public int? DataKarty { get; set; }
        public int? ObcaKarta { get; set; }
        public int? ExpoKraj { get; set; }
        public int? PlatnikVat { get; set; }
        public int? Status { get; set; }
        public int? Koncesja { get; set; }
        public int? DataKoncesji { get; set; }
        public int? Dzialalnosc { get; set; }
        public int? AkwTyp { get; set; }
        public int? AkwFirma { get; set; }
        public int? AkwNumer { get; set; }
        public int? DataW { get; set; }
        public int? FaVATData { get; set; }
        public int? PrcTyp { get; set; }


        public int? PrcFirma { get; set; }
        public int? PrcNumer { get; set; }
        public int? AutoPotwierdzenie { get; set; }
        public int? MagTyp { get; set; }
        public int? MagFirma { get; set; }
        public int? MagNumer { get; set; }
        public int? Zrodlo { get; set; }
        public int? Branza { get; set; }
        public int? Rodzaj { get; set; }
        public int? RolaPartnera { get; set; }
        public int? KarTyp { get; set; }
        public int? KarFirma { get; set; }
        public int? KarNumer { get; set; }
        public int? NRB { get; set; }
        public int? Archiwalny { get; set; }
        public int? AdresNieAktualny { get; set; }
        public int? BlokadaTransakcji { get; set; }
        public int? RegionCRM { get; set; }
        public int? Spedytor { get; set; }
        public int? TerminPlZak { get; set; }
        public int? FormaPlZak { get; set; }
        public int? SpTerminPlSpr { get; set; }
        public int? SpTerminPlZak { get; set; }
        public int? LimitTerminowy { get; set; }
        public int? DataWygasniecia { get; set; }
        public int? Priorytet { get; set; }
        [StringLength(51)]
        public string? Nazwa1 { get; set; }
        [StringLength(51)]
        public string? Nazwa2 { get; set; }
        [StringLength(251)]
        public string? Nazwa3 { get; set; }
        [StringLength(11)]
        public string? KodP { get; set; }
        [StringLength(31)]
        public string? Miasto { get; set; }
        [StringLength(31)]
        public string? Ulica { get; set; }
        [StringLength(31)]
        public string? Adres { get; set; }
        [StringLength(3)]
        public string? NipPrefiks { get; set; }
        [StringLength(21)]
        public string? NipE { get; set; }
        [StringLength(21)]
        public string? Regon { get; set; }
        [StringLength(12)]
        public string? Pesel { get; set; }
        [StringLength(31)]
        public string? KontoDostawcy { get; set; }
        [StringLength(31)]
        public string? KontoOdbiorcy { get; set; }
        [StringLength(31)]
        public string? Telefon1 { get; set; }
        [StringLength(31)]
        public string? Telefon2 { get; set; }
        [StringLength(31)]
        public string? Fax { get; set; }
        [StringLength(31)]
        public string? Modem { get; set; }
        [StringLength(31)]
        public string? Telex { get; set; }
        [StringLength(41)]
        public string? EMail { get; set; }
        [StringLength(256)]
        public string? URL { get; set; }
        [StringLength(51)]
        public string? NrRachunku { get; set; }
        [StringLength(8)]
        public string? Rabat { get; set; }
        [StringLength(18)]
        public string? MaxLimitWart { get; set; }
        [StringLength(18)]
        public string? LimitPoTerminie { get; set; }
        [StringLength(4)]
        public string? Symbol { get; set; }
        [StringLength(8)]
        public string? Marza { get; set; }
        [StringLength(17)]
        public string? NumerKarty { get; set; }
        [StringLength(17)]
        public string? Ean { get; set; }
        [StringLength(6)]
        public string? SeriaFa { get; set; }
        [StringLength(21)]
        public string? SposobDostawy { get; set; }
        [StringLength(12)]
        public string? AkwProwizja { get; set; }
        [StringLength(31)]
        public string? Umowa { get; set; }
        [StringLength(31)]
        public string? FaVATOsw { get; set; }
        [StringLength(251)]
        public string? CechaOpis { get; set; }
        [StringLength(256)]
        public string? OutlookUrl { get; set; }
        [StringLength(3)]
        public string? Kraj { get; set; }
        [StringLength(13)]
        public string? Odleglosc { get; set; }
        [StringLength(31)]
        public string? Powiat { get; set; }
        [StringLength(31)]
        public string? Gmina { get; set; }
        [StringLength(31)]
        public string? Wojewodztwo { get; set; }
        [StringLength(13)]
        public string? GLN { get; set; }
        [StringLength(5)]
        public string? PIN { get; set; }
        [StringLength(2000)]
        public string? Opis { get; set; }
        public int? Powiazany { get; set; }

        public override object JsonSerializeResult()
        {
            return new { GIDNumer, Akronim, OptimaId, StatusZmiany };
        }

    }
    public class XLModyfikacjaKntSQLInfo : BaseXL
    {




        [StringLength(51)]
        public System.String? NazwaPola { get; set; }
        [StringLength(2000)]
        public System.String? Wartosc { get; set; }
        [StringLength(1000)]
        public System.String? OpisBledu { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikacjaKntSQLInfo_20231(); }
    }
    public class XLEANInfo : BaseXL
    {

        public System.Int32? Zakres { get; set; }
        [StringLength(41)]
        public System.String? EAN { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLEANInfo_20231(); }
    }
    public class XLAtrKlasaNagInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? ZListy { get; set; }
        public System.Int32? Zamknieta { get; set; }
        public System.Int32? Wymagany { get; set; }
        public System.Int32? Controlling { get; set; }
        public System.Int32? Automat { get; set; }
        public System.Int32? Nieaktywny { get; set; }
        public System.Int32? Historia { get; set; }
        public System.Int32? DomTyp { get; set; }
        public System.Int32? DomFirma { get; set; }
        public System.Int32? DomNumer { get; set; }
        public System.Int32? DomLp { get; set; }
        public System.Int32? DomAPITyp { get; set; }
        public System.Int32? DomAPIFirma { get; set; }
        public System.Int32? DomAPINumer { get; set; }
        public System.Int32? DomAPILp { get; set; }
        public System.Int32? TypDom { get; set; }
        public System.Int32? TypDomApi { get; set; }
        public System.Int32? CharSet { get; set; }
        public System.Int32? Okresowe { get; set; }
        public System.Int32? Wielowart { get; set; }
        public System.Int32? ReadOnly { get; set; }
        [StringLength(256)]
        public System.String Nazwa { get; set; } = "";
        [StringLength(256)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? Format { get; set; }
        [StringLength(2049)]
        public System.String? SQL { get; set; }
        [StringLength(101)]
        public System.String? Domyslna { get; set; }
        [StringLength(101)]
        public System.String? DomyslnaAPI { get; set; }
        [StringLength(2049)]
        public System.String? DomyslnaSQL { get; set; }
        [StringLength(2049)]
        public System.String? DomyslnaAPISQL { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrKlasaNagInfo_20231(); }
    }
    public class XLAtrKasujKlaseInfo : BaseXL
    {

        public System.Int32? AtkID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrKasujKlaseInfo_20231(); }
    }
    public class XLAtrObiektInfo : BaseXL
    {

        public System.Int32? AtkID { get; set; }

        public System.Int32? Element { get; set; }
        public System.Int32? Lp { get; set; }
        public System.Int32? Wymagany { get; set; }
        public System.Int32? Automat { get; set; }
        public System.Int32? ReadOnly { get; set; }
        public System.Int32? AtZID { get; set; }
        public System.Int32? Akcja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrObiektInfo_20231(); }
    }
    public class XLAtrWartoscInfo : BaseXL
    {

        public System.Int32? AtkID { get; set; }
        [StringLength(101)]
        public System.String? Wartosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrWartoscInfo_20231(); }
    }
    public class XLAtrZrodloInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? Aktywne { get; set; }
        [StringLength(41)]
        public System.String? Nazwa { get; set; }
        [StringLength(2049)]
        public System.String? SQL { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrZrodloInfo_20231(); }
    }
    public class XLAtrZrdObiektInfo : BaseXL
    {

        public System.Int32? AtZID { get; set; }

        public System.Int32? Element { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLAtrZrdObiektInfo_20231(); }
    }
    public class XLGrupaTwrInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? GrONumer { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? CzasDst { get; set; }
        public System.Int32? RozliczMag { get; set; }
        public System.Int32? Zakup { get; set; }
        public System.Int32? Sprzedaz { get; set; }
        public System.Int32? KontaktTyp { get; set; }
        public System.Int32? KontaktZa { get; set; }
        public System.Int32? KontaktJC { get; set; }
        public System.Int32? Okresowy { get; set; }
        public System.Int32? Koncesja { get; set; }
        public System.Int32? WCenniku { get; set; }
        public System.Int32? EdycjaNazwy { get; set; }
        public System.Int32? BezRabatu { get; set; }
        public System.Int32? TerminZwrotu { get; set; }
        public System.Int32? ZakupAutoryz { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? PrcNumer { get; set; }
        public System.Int32? KosztUTyp { get; set; }
        public System.Int32? CCKNumer { get; set; }
        public System.Int32? PrdTyp { get; set; }
        public System.Int32? PrdNumer { get; set; }
        public System.Int32? Archiwalny { get; set; }
        public System.Int32? JMCalkowita { get; set; }
        public System.Int32? SKNId { get; set; }
        public System.Int32? Kaucja { get; set; }
        public System.Int32? PobierzWgCech { get; set; }
        public System.Int32? RejWyposazenia { get; set; }
        public System.Int32? OkresGwarancji { get; set; }
        public System.Int32? GrupaWyposazenia { get; set; }
        public System.Int32? PartiaDataW { get; set; }
        public System.Int32? TerminW { get; set; }
        public System.Int32? PartiaDostawa { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? KgoId { get; set; }
        public System.Int32? FlagaVat { get; set; }
        public System.Int32? FlagaVatSpr { get; set; }
        public System.Int32? Zlom { get; set; }
        public System.Int32? MobSpr { get; set; }
        public System.Int32? JMDopelnianiaMobSpr { get; set; }
        public System.Int32? OplataSpozFlaga { get; set; }
        public System.Int32? OplataSpozDostawyTyp { get; set; }
        public System.Int32? OplataSpozDostawyFlaga { get; set; }
        public System.Int32? OplataSpozNrPartii { get; set; }
        public System.Int32? OplataSpozNrPartiiAtrybut { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(4096)]
        public System.String? GrupaSciezka { get; set; }
        [StringLength(41)]
        public System.String? TwrKod { get; set; }
        [StringLength(51)]
        public System.String? KodFormat { get; set; }
        [StringLength(256)]
        public System.String? TwrNazwa { get; set; }
        [StringLength(256)]
        public System.String? TwrNazwa1 { get; set; }
        [StringLength(41)]
        public System.String? Certyfikat { get; set; }
        [StringLength(21)]
        public System.String? Sww { get; set; }
        [StringLength(9)]
        public System.String? Jm { get; set; }
        [StringLength(21)]
        public System.String? Waga { get; set; }
        [StringLength(6)]
        public System.String? WJm { get; set; }
        [StringLength(16)]
        public System.String? IloscZam { get; set; }
        [StringLength(16)]
        public System.String? IloscMin { get; set; }
        [StringLength(16)]
        public System.String? IloscMax { get; set; }
        [StringLength(8)]
        public System.String? Ubytek { get; set; }
        [StringLength(2)]
        public System.String? GrupaPod { get; set; }
        [StringLength(8)]
        public System.String? Akcyza { get; set; }
        [StringLength(201)]
        public System.String? Cel { get; set; }
        [StringLength(14)]
        public System.String? Punkty { get; set; }
        [StringLength(31)]
        public System.String? KontoMag { get; set; }
        [StringLength(31)]
        public System.String? KontoSpr { get; set; }
        [StringLength(31)]
        public System.String? KontoKosztWl { get; set; }
        [StringLength(41)]
        public System.String? Symbol { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(255)]
        public System.String? Warunek { get; set; }
        [StringLength(8)]
        public System.String? ObjetoscL { get; set; }
        [StringLength(8)]
        public System.String? MarzaMin { get; set; }
        [StringLength(18)]
        public System.String? KosztUslugi { get; set; }
        [StringLength(10)]
        public System.String? Clo { get; set; }
        [StringLength(11)]
        public System.String? PCN { get; set; }
        [StringLength(3)]
        public System.String? KrajPoch { get; set; }
        [StringLength(15)]
        public System.String? WspFin { get; set; }
        [StringLength(2)]
        public System.String? GrupaPodSpr { get; set; }
        [StringLength(21)]
        public System.String? WagaBrutto { get; set; }
        [StringLength(6)]
        public System.String? WymJm { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(21)]
        public System.String? Menedzer { get; set; }
        [StringLength(21)]
        public System.String? Cecha { get; set; }
        [StringLength(21)]
        public System.String? Producent { get; set; }
        [StringLength(11)]
        public System.String? SchematKaucji { get; set; }
        [StringLength(2000)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? KgoKod { get; set; }
        [StringLength(8)]
        public System.String? StawkaPod { get; set; }
        [StringLength(8)]
        public System.String? Zrodlowa { get; set; }
        [StringLength(8)]
        public System.String? StawkaPodSpr { get; set; }
        [StringLength(8)]
        public System.String? ZrodlowaSpr { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierStala { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierZmienna { get; set; }
        [StringLength(15)]
        public System.String? StawkaKofeina { get; set; }
        [StringLength(15)]
        public System.String? ZawartoscCukru { get; set; }
        [StringLength(15)]
        public System.String? OplataSpozPrzeliczL { get; set; }
        [StringLength(15)]
        public System.String? OplataSpozPrzeliczM { get; set; }
        [StringLength(16)]
        public System.String? MrpEoq { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLGrupaTwrInfo_20231(); }
    }
    public class XLGrupaKntInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? GrONumer { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Akwizytor { get; set; }
        public System.Int32? BnkNumer { get; set; }
        public System.Int32? PrcNumer { get; set; }
        public System.Int32? AkwTyp { get; set; }
        public System.Int32? AkwNumer { get; set; }
        public System.Int32? LimitOkres { get; set; }
        public System.Int32? Dewizowe { get; set; }
        public System.Int32? Cena { get; set; }
        public System.Int32? FormaPl { get; set; }
        public System.Int32? TypKarty { get; set; }
        public System.Int32? ExpoKraj { get; set; }
        public System.Int32? PlatnikVat { get; set; }
        public System.Int32? Status { get; set; }
        public System.Int32? AutoPotwierdzenie { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? Zrodlo { get; set; }
        public System.Int32? Branza { get; set; }
        public System.Int32? Rodzaj { get; set; }
        public System.Int32? RolaPartnera { get; set; }
        public System.Int32? KarNumer { get; set; }
        public System.Int32? Spedytor { get; set; }
        public System.Int32? FormaPlZak { get; set; }
        public System.Int32? TerminPlZak { get; set; }
        public System.Int32? SpTerminPlZak { get; set; }
        public System.Int32? SpTerminSpr { get; set; }
        public System.Int32? LimitTerminowy { get; set; }
        public System.Int32? DataWygasniecia { get; set; }
        public System.Int32? MaxDniPoTerminie { get; set; }
        public System.Int32? Controlling { get; set; }
        public System.Int32? RolnikRyczaltowy { get; set; }
        public System.Int32? PriorytetRez { get; set; }
        public System.Int32? Powiazany { get; set; }
        public System.Int32? Archiwalny { get; set; }
        public System.Int32? TerminRozliczeniaKaucji { get; set; }
        public System.Int32? PlatnoscKaucji { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? KnPParam { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeNumerO { get; set; }
        public System.Int32? TwrGrupaNumer { get; set; }
        public System.Int32? Koncesja { get; set; }
        public System.Int32? ESklep { get; set; }
        public System.Int32? OplataSpozZakup { get; set; }
        public System.Int32? OplataSpozSprzedaz { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(4096)]
        public System.String? GrupaSciezka { get; set; }
        [StringLength(51)]
        public System.String? Nazwa1 { get; set; }
        [StringLength(51)]
        public System.String? Nazwa2 { get; set; }
        [StringLength(251)]
        public System.String? Nazwa3 { get; set; }
        [StringLength(21)]
        public System.String? KnWAkronim { get; set; }
        [StringLength(11)]
        public System.String? KodP { get; set; }
        [StringLength(31)]
        public System.String? Miasto { get; set; }
        [StringLength(31)]
        public System.String? Ulica { get; set; }
        [StringLength(31)]
        public System.String? Adres { get; set; }
        [StringLength(21)]
        public System.String? Nip { get; set; }
        [StringLength(3)]
        public System.String? NipPrefiks { get; set; }
        [StringLength(21)]
        public System.String? Regon { get; set; }
        [StringLength(31)]
        public System.String? Wojewodztwo { get; set; }
        [StringLength(31)]
        public System.String? Gmina { get; set; }
        [StringLength(31)]
        public System.String? Powiat { get; set; }
        [StringLength(12)]
        public System.String? Pesel { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(31)]
        public System.String? AkronimFormat { get; set; }
        [StringLength(8)]
        public System.String? AkwProwizja { get; set; }
        [StringLength(8)]
        public System.String? Rabat { get; set; }
        [StringLength(18)]
        public System.String? MaxLimitWart { get; set; }
        [StringLength(18)]
        public System.String? LimitPoTerminie { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(6)]
        public System.String? SeriaFa { get; set; }
        [StringLength(21)]
        public System.String? SposobDostawy { get; set; }
        [StringLength(251)]
        public System.String? CechaOpis { get; set; }
        [StringLength(21)]
        public System.String? Platnik { get; set; }
        [StringLength(21)]
        public System.String? Bank { get; set; }
        [StringLength(21)]
        public System.String? AkwAkronim { get; set; }
        [StringLength(21)]
        public System.String? Opiekun { get; set; }
        [StringLength(6)]
        public System.String? Rejestr { get; set; }
        [StringLength(6)]
        public System.String? SeriaKaP { get; set; }
        [StringLength(101)]
        public System.String? OpeHaslo { get; set; }
        [StringLength(1024)]
        public System.String? RegionCRMStr { get; set; }
        [StringLength(3)]
        public System.String? WSTO { get; set; }
        [StringLength(3)]
        public System.String? KSeFWyslij { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLGrupaKntInfo_20231(); }
    }
    public class XLDokumentPrmNagInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? DataOd { get; set; }
        public System.Int32? DataDo { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Priorytet { get; set; }
        public System.Int32? SposobStosowania { get; set; }
        public System.Int32? PominPozostale { get; set; }
        public System.Int32? Dokument { get; set; }
        public System.Int32? PriorytetLp { get; set; }
        public System.Int32? Cykliczna { get; set; }
        [StringLength(201)]
        public System.String? Akronim { get; set; }
        [StringLength(513)]
        public System.String? Uwagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentPrmNagInfo_20231(); }
    }
    public class XLZamkniecieDokumentuPrmInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? Stan { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Flagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuPrmInfo_20231(); }
    }
    public class XLKontrahentPrmInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? PrmID { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLKontrahentPrmInfo_20231(); }
    }
    public class XLTowarPrmInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? PrmID { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? RodzajCeny { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(20)]
        public System.String? Wartosc { get; set; }
        [StringLength(20)]
        public System.String? Prog { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(2)]
        public System.String? FlagaNB { get; set; }
        [StringLength(201)]
        public System.String? Notatki { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLTowarPrmInfo_20231(); }
    }
    public class XLFrsPrmInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? PrmID { get; set; }
        public System.Int32? FrsID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLFrsPrmInfo_20231(); }
    }
    public class XLModyfikacjaPrmInfo : BaseXL
    {

        public System.Int32? PrmID { get; set; }
        [StringLength(51)]
        public System.String? NazwaPola { get; set; }
        [StringLength(2000)]
        public System.String? Wartosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikacjaPrmInfo_20231(); }
    }
    public class XLDokumentMagSubElemInfo : BaseXL
    {

        public System.Int32? SubLp { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? EleLp { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? SUBZrdLp { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? SposobPobieraniaZMag { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? RezIgnor { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentMagSubElemInfo_20231(); }
    }
    public class XLUsunMagSubElemInfo : BaseXL
    {

        public System.Int32? Lp { get; set; }
        public System.Int32? SubLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunMagSubElemInfo_20231(); }
    }
    public class XLDokumentMapSubElemInfo : BaseXL
    {

        public System.Int32? SubLp { get; set; }
        public System.Int32? IloscReq { get; set; }
        public System.Int32? EleLp { get; set; }
        public System.Int32? Adres { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? WylaczZarzadzaniePolozeniem { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(7)]
        public System.String? Dlugosc { get; set; }
        [StringLength(7)]
        public System.String? Szerokosc { get; set; }
        [StringLength(7)]
        public System.String? Wysokosc { get; set; }
        [StringLength(31)]
        public System.String? JMLog { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentMapSubElemInfo_20231(); }
    }
    public class XLUsunMapSubElemInfo : BaseXL
    {

        public System.Int32? Lp { get; set; }
        public System.Int32? SubLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunMapSubElemInfo_20231(); }
    }
    public class XLOdczytInwInfo : BaseXL
    {

        public System.Int32? InOID { get; set; }
        public System.Int32? InAID { get; set; }
        public System.Int32? PrzepiszIlosciZArkusza { get; set; }
        [StringLength(31)]
        public System.String? Nazwa { get; set; }
        [StringLength(255)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOdczytInwInfo_20231(); }
    }
    public class XLPozycjaOdczytuInwInfo : BaseXL
    {

        public System.Int32? InOId { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? CCKNumer { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? MgAID { get; set; }
        public System.Int32? IOTID { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? InTId { get; set; }
        public System.Int32? TPaId { get; set; }
        [StringLength(41)]
        public System.String? TwrKod { get; set; }
        [StringLength(41)]
        public System.String? TwrEAN { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(26)]
        public System.String? Polozenie { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? TPaEAN { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPozycjaOdczytuInwInfo_20231(); }
    }
    public class XLZamknijOdczytInwInfo : BaseXL
    {

        public System.Int32? InOID { get; set; }
        public System.Int32? OdczytZamkniety { get; set; }
        public System.Int32? TrybWsadowy { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamknijOdczytInwInfo_20231(); }
    }
    public class XLOtworzOdczytInwInfo : BaseXL
    {

        public System.Int32? InOID { get; set; }
        public System.Int32? InAID { get; set; }
        public System.Int32? OdczytWEdycji { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtworzOdczytInwInfo_20231(); }
    }
    public class XLZwiazanyDokInfo : BaseXL
    {



        public System.Int32? Akcja { get; set; }
        public System.Int32? IloscRekordow { get; set; }
        public System.Int32? GIDLp { get; set; }
        public System.Int32? SUBLp { get; set; }
        [StringLength(16)]
        public System.String? Ilosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZwiazanyDokInfo_20231(); }
    }
    public class XLPaczkaInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? KnATyp { get; set; }
        public System.Int32? KnAFirma { get; set; }
        public System.Int32? KnANumer { get; set; }
        public System.Int32? KnALp { get; set; }
        public System.Int32? DataUtw { get; set; }
        public System.Int32? NaKoszt { get; set; }
        public System.Int32? TrasaID { get; set; }
        public System.Int32? NieAtrybuty { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? FRSID { get; set; }
        public System.Int32? WysPozycja { get; set; }
        [StringLength(21)]
        public System.String? Objetosc { get; set; }
        [StringLength(21)]
        public System.String? WagaNetto { get; set; }
        [StringLength(21)]
        public System.String? WagaBrutto { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(21)]
        public System.String? AkronimTra { get; set; }
        [StringLength(6)]
        public System.String? WJm { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(251)]
        public System.String? CechaOpis { get; set; }
        [StringLength(2000)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPaczkaInfo_20231(); }
    }
    public class XLZamknieciePaczkiInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? Tryb { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamknieciePaczkiInfo_20231(); }
    }
    public class XLWysylkaInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? SpeTyp { get; set; }
        public System.Int32? SpeFirma { get; set; }
        public System.Int32? SpeNumer { get; set; }
        public System.Int32? SpeLp { get; set; }
        public System.Int32? KieTyp { get; set; }
        public System.Int32? KieFirma { get; set; }
        public System.Int32? KieNumer { get; set; }
        public System.Int32? KieLp { get; set; }
        public System.Int32? IlePaczek { get; set; }
        public System.Int32? TSWysylki { get; set; }
        public System.Int32? TSDostarczeniaOd { get; set; }
        public System.Int32? TSDostarczeniaDo { get; set; }
        public System.Int32? RozliczenieKosztow { get; set; }
        public System.Int32? TrasaId { get; set; }
        public System.Int32? SamId { get; set; }
        public System.Int32? NieAtrybuty { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? FRSID { get; set; }
        public System.Int32? Kurier { get; set; }
        public System.Int32? StanPrzesylki { get; set; }
        [StringLength(21)]
        public System.String? Objetosc { get; set; }
        [StringLength(21)]
        public System.String? WagaNetto { get; set; }
        [StringLength(21)]
        public System.String? WagaBrutto { get; set; }
        [StringLength(21)]
        public System.String? Ubezpieczenie { get; set; }
        [StringLength(21)]
        public System.String? Pobranie { get; set; }
        [StringLength(21)]
        public System.String? DlugoscTrasy { get; set; }
        [StringLength(21)]
        public System.String? Akronim { get; set; }
        [StringLength(20)]
        public System.String? AkronimKie { get; set; }
        [StringLength(10)]
        public System.String? SamNrRej { get; set; }
        [StringLength(20)]
        public System.String? AkronimTra { get; set; }
        [StringLength(6)]
        public System.String? WJm { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(151)]
        public System.String? NumerObcy { get; set; }
        [StringLength(251)]
        public System.String? CechaOpis { get; set; }
        [StringLength(2000)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? LinkPrzesylki { get; set; }
        [StringLength(41)]
        public System.String? ZNPnr { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLWysylkaInfo_20231(); }
    }
    public class XLDodajKosztDoWysylkiInfo : BaseXL
    {

        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        [StringLength(17)]
        public System.String? Wartosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajKosztDoWysylkiInfo_20231(); }
    }
    public class XLZamkniecieWysylkiInfo : BaseXL
    {

        public System.Int32? WysTyp { get; set; }
        public System.Int32? WysFirma { get; set; }
        public System.Int32? WysNumer { get; set; }
        public System.Int32? WysLp { get; set; }
        public System.Int32? Tryb { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieWysylkiInfo_20231(); }
    }
    public class XLModyfikujElemInfo : BaseXL
    {

        public System.Int32? EleLp { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? StawkaPod { get; set; }
        public System.Int32? FlagaVAT { get; set; }
        public System.Int32? SpinaczEle { get; set; }
        public System.Int32? PakietIloscZastosowana { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? CenaP { get; set; }
        [StringLength(15)]
        public System.String? Cena { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(15)]
        public System.String? KGO { get; set; }
        [StringLength(2)]
        public System.String? Vat { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(11)]
        public System.String? PCN { get; set; }
        [StringLength(2)]
        public System.String? IloscReq { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujElemInfo_20231(); }
    }
    public class XLModyfikujPlatnoscInfo : BaseXL
    {

        public System.Int32? PltLp { get; set; }
        public System.Int32? Forma { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Status { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(201)]
        public System.String? Notatki { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujPlatnoscInfo_20231(); }
    }
    public class XLModyfikujMagElemInfo : BaseXL
    {

        public System.Int32? EleLp { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? TPaID { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CCh2Numer { get; set; }
        public System.Int32? DataW { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(14)]
        public System.String? IlMaS { get; set; }
        [StringLength(14)]
        public System.String? IlMaP { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(256)]
        public System.String? Cecha2 { get; set; }
        [StringLength(41)]
        public System.String? EAN { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujMagElemInfo_20231(); }
    }
    public class XLOperatorInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? FrmId { get; set; }
        public System.Int32? StanowiskoId { get; set; }
        [StringLength(9)]
        public System.String? Akronim { get; set; }
        [StringLength(31)]
        public System.String? Nazwisko { get; set; }
        [StringLength(41)]
        public System.String? Centrum { get; set; }
        [StringLength(31)]
        public System.String? StanowiskoNazwa { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOperatorInfo_20231(); }
    }
    public class XLLicencjaInfo : BaseXL
    {

        public System.Int32? Licencja { get; set; }
        public System.Int32? Odswiez { get; set; }
        public System.Int32? Stan { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLLicencjaInfo_20231(); }
    }
    public class XLZmianaHaslaInfo : BaseXL
    {

        [StringLength(17)]
        public System.String? NoweHaslo { get; set; }
        [StringLength(17)]
        public System.String? StareHaslo { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZmianaHaslaInfo_20231(); }
    }
    public class XLTransakcjaInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? TransakcjaAktywna { get; set; }
        [StringLength(256)]
        public System.String? Token { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
    }
    public class XLDokumentZamNagInfo : Doc
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? AdrTyp { get; set; }
        public System.Int32? AdrFirma { get; set; }
        public System.Int32? AdrNumer { get; set; }
        public System.Int32? AdrLp { get; set; }
        public System.Int32? AdwTyp { get; set; }
        public System.Int32? AdwFirma { get; set; }
        public System.Int32? AdwNumer { get; set; }
        public System.Int32? AdwLp { get; set; }
        public System.Int32? AkwTyp { get; set; }
        public System.Int32? AkwFirma { get; set; }
        public System.Int32? AkwNumer { get; set; }
        public System.Int32? AkwLp { get; set; }
        public System.Int32? MagTyp { get; set; }
        public System.Int32? MagFirma { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? MagLp { get; set; }
        public System.Int32? FormaPl { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? TypKursu { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? DataWystawienia { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? OpeTypW { get; set; }
        public System.Int32? OpeFirmaW { get; set; }
        public System.Int32? OpeNumerW { get; set; }
        public System.Int32? OpeLpW { get; set; }
        public System.Int32? OpeTypM { get; set; }
        public System.Int32? OpeFirmaM { get; set; }
        public System.Int32? OpeNumerM { get; set; }
        public System.Int32? OpeLpM { get; set; }
        public System.Int32? RealWCalosci { get; set; }
        public System.Int32? AkwizytorKntPrc { get; set; }
        public System.Int32? ExpoNorm { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Wewnetrzne { get; set; }
        public System.Int32? KnDTyp { get; set; }
        public System.Int32? KnDFirma { get; set; }
        public System.Int32? KnDNumer { get; set; }
        public System.Int32? KnDLp { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? MagWTyp { get; set; }
        public System.Int32? MagWFirma { get; set; }
        public System.Int32? MagWNumer { get; set; }
        public System.Int32? MagWLp { get; set; }
        public System.Int32? PotwierdzenieOferty { get; set; }
        public System.Int32? DataPotwierdzeniaOferty { get; set; }
        public System.Int32? DataAktywacjiRezerwacji { get; set; }
        public System.Int32? DokZwiazane { get; set; }
        public System.Int32? TerminPlatnosci { get; set; }
        public System.Int32? RabatReq { get; set; }
        public System.Int32? OpiTyp { get; set; }
        public System.Int32? OpiFirma { get; set; }
        public System.Int32? OpiNumer { get; set; }
        public System.Int32? OpiLp { get; set; }
        public System.Int32? KnPTyp { get; set; }
        public System.Int32? KnPNumer { get; set; }
        public System.Int32? AdPNumer { get; set; }
        public System.Int32? RezerwujZasoby { get; set; }
        public System.Int32? OddDokId { get; set; }
        public System.Int32? FrsID { get; set; }
        public System.Int32? RodzajCeny { get; set; }
        public System.Int32? KarNumer { get; set; }
        public System.Int32? WspolnaWaluta { get; set; }
        public System.Int32? ProjektID { get; set; }
        public System.Int32? RabatyOdCenyBezKGO { get; set; }
        public System.Int32? IgnorujRodzajKnt { get; set; }
        public System.Int32? RezerwacjeNaNiepotwierdzonym { get; set; }
        public System.Int32? GenerujWieleZam { get; set; }
        public System.Int32? WTRID { get; set; }
        public System.Int32? WTRProgID { get; set; }
        public System.Int32? PodstawaZW { get; set; }
        public System.Int32? GodzinaWystawienia { get; set; }
        public System.Int32? KontrolujIlosciPrzyGenZam { get; set; }
        public System.Int32? OperatorPOS { get; set; }
        public System.Int32? OstatniaModyfikacjaPOS { get; set; }
        public System.Int32? StatusPlatnosciPOSId { get; set; }
        public System.Int32? StatusRealizacjiId { get; set; }
        [StringLength(10)]
        public System.String? DomyslnyDokRealizacja { get; set; }
        [StringLength(21)]
        public System.String Akronim { get; set; } = "";
        [StringLength(21)]
        public System.String? Akwizytor { get; set; }
        [StringLength(6)]
        public System.String? ZamSeria { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentW { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentM { get; set; }
        [StringLength(41)]
        public System.String? DokumentObcy { get; set; }
        [StringLength(21)]
        public System.String? SposobDst { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(251)]
        public System.String? Cecha { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? AkronimDocelowego { get; set; }
        [StringLength(15)]
        public System.String? RabatNaglowka { get; set; }
        [StringLength(11)]
        public System.String? MagazynW { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(2)]
        public System.String? FlagaNB { get; set; }
        [StringLength(21)]
        public System.String? Opiekun { get; set; }
        [StringLength(3)]
        public System.String? Kraj { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransportu { get; set; }
        [StringLength(3)]
        public System.String? KodRodzajuTransakcji { get; set; }
        [StringLength(5)]
        public System.String? IncotermsSymbol { get; set; }
        [StringLength(256)]
        public System.String? IncotermsMiejsce { get; set; }
        [StringLength(256)]
        public System.String? PrzyczynaZW { get; set; }
        [StringLength(2)]
        public System.String? OplataSpozFlaga { get; set; }
        [StringLength(37)]
        public System.String? GUIDPOS { get; set; }
        [StringLength(256)]
        public System.String? ZrodloPochodzeniaESklep { get; set; }
        [StringLength(51)]
        public System.String? EAN { get; set; }
        public override object JsonSerializeResult() => new { GIDNumer, Akronim, OptimaId, StatusZmiany };
        public List<XLDokumentZamElemInfo> Pozycje { get; set; } = new List<XLDokumentZamElemInfo>();
        public List<XLDokumentZamPlatInfo> Platnosci { get; set; } = new List<XLDokumentZamPlatInfo>();

        // public void GetData() { new cdn_api.XLDokumentZamNagInfo_20231(); }
    }
    public class XLDokumentZamElemInfo : BaseXL
    {
        public System.Int32? GIDLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? MagTyp { get; set; }
        public System.Int32? MagFirma { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? MagLp { get; set; }
        public System.Int32? ReETyp { get; set; }
        public System.Int32? ReEFirma { get; set; }
        public System.Int32? ReENumer { get; set; }
        public System.Int32? ReELp { get; set; }
        public System.Int32? KursL { get; set; }
        public System.Int32? KursM { get; set; }
        public System.Int32? DataWaznosciRezerwacji { get; set; }
        public System.Int32? DataPotwierdzeniaDostawy { get; set; }
        public System.Int32? DataAktywacjiRezerwacji { get; set; }
        public System.Int32? RabatReq { get; set; }
        public System.Int32? JmFormat { get; set; }
        public System.Int32? TypJm { get; set; }
        public System.Int32? PrzeliczM { get; set; }
        public System.Int32? PrzeliczL { get; set; }
        public System.Int32? CenaSpr { get; set; }
        public System.Int32? PrecyzjaCeny { get; set; }
        public System.Int32? Rownanie { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? FlagaVat { get; set; }
        public System.Int32? PakietId { get; set; }
        public System.Int32? PromocjaProgID { get; set; }
        public System.Int32? Gratis { get; set; }
        public System.Int32? Zlom { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? ZrdFirma { get; set; }
        public System.Int32? ZrdNumer { get; set; }
        public System.Int32? ZrdLp { get; set; }
        public System.Int32? IgnorujJmTwr { get; set; }
        public System.Int32? RezMagPulpitKnt { get; set; }
        public System.Int32? NieKontrolujMaxRabOpe { get; set; }
        public System.Int32? OddElemId { get; set; }
        public System.Int32? PakietIloscZastosowana { get; set; }
        public System.Int32? ZstNumer { get; set; }
        public System.Int32? ZstLp { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(41)]
        public System.String? Towar { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(2)]
        public System.String? GrupaVAT { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(15)]
        public System.String? Rabat { get; set; }
        [StringLength(41)]
        public System.String? TowarEAN { get; set; }
        [StringLength(15)]
        public System.String? CenaOferowana { get; set; }
        [StringLength(15)]
        public System.String? CenaKatalogowa { get; set; }
        [StringLength(9)]
        public System.String? JmZ { get; set; }
        [StringLength(15)]
        public System.String? KGO { get; set; }
        [StringLength(6)]
        public System.String? StawkaVAT { get; set; }
        [StringLength(14)]
        public System.String? IloscMin { get; set; }
        [StringLength(14)]
        public System.String? IloscMax { get; set; }
        [StringLength(256)]
        public System.String? BudzetPrmID { get; set; }
        [StringLength(256)]
        public System.String? BudzetID { get; set; }
        [StringLength(256)]
        public System.String? BudzetWartosc { get; set; }
        [StringLength(2)]
        public System.String? OplataSpozFlaga { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierStala { get; set; }
        [StringLength(15)]
        public System.String? StawkaCukierZmienna { get; set; }
        [StringLength(15)]
        public System.String? StawkaKofeina { get; set; }
        [StringLength(37)]
        public System.String? GUIDPOS { get; set; }
        [StringLength(15)]
        public System.String? CenaUzgodniona { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZamElemInfo_20231(); }
    }
    public class XLDokumentZamPlatInfo : BaseXL
    {

        public System.Int32? TerminOffset { get; set; }
        public System.Int32? TerminData { get; set; }
        public System.Int32? FormaPl { get; set; }
        public System.Int32? Procent { get; set; }
        public System.Int32? Zaliczka { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(201)]
        public System.String? Notatki { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZamPlatInfo_20231(); }
    }
    public class XLZamkniecieDokumentuZamInfo : BaseXL
    {

        public System.Int32? ZamTyp { get; set; }
        public System.Int32? ZamFirma { get; set; }
        public System.Int32? ZamNumer { get; set; }
        public System.Int32? ZamLp { get; set; }
        public System.Int32? TrybZamkniecia { get; set; }
        public System.Int32? DataPotwierdzenia { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? OpeTypP { get; set; }
        public System.Int32? OpeFirmaP { get; set; }
        public System.Int32? OpeNumerP { get; set; }
        public System.Int32? OpeLpP { get; set; }
        public System.Int32? Odrzucenie { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? CoKasowac { get; set; }
        public System.Int32? PICO { get; set; }
        [StringLength(6)]
        public System.String? PomSeria { get; set; }
        [StringLength(9)]
        public System.String? OpeIdentP { get; set; }
        [StringLength(31)]
        public System.String? DokumentObcyP { get; set; }
        [StringLength(2001)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? PrzyczynaFiasko { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieDokumentuZamInfo_20231(); }
    }
    public class XLOtwarcieDokumentuZamInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ZaNTyp { get; set; }
        public System.Int32? ZaNFirma { get; set; }
        public System.Int32? ZaNNumer { get; set; }
        public System.Int32? ZaNLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOtwarcieDokumentuZamInfo_20231(); }
    }
    public class XLUsunZamElemInfo : BaseXL
    {

        public System.Int32? Pozycja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunZamElemInfo_20231(); }
    }
    public class XLDokumentZamElemModInfo : BaseXL
    {

        public System.Int32? EleLp { get; set; }
        public System.Int32? Rabat { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? FlagaVat { get; set; }
        public System.Int32? PakietIloscZastosowana { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(15)]
        public System.String? CenaP { get; set; }
        [StringLength(15)]
        public System.String? Cena { get; set; }
        [StringLength(15)]
        public System.String? Wartosc { get; set; }
        [StringLength(15)]
        public System.String? KGO { get; set; }
        [StringLength(2)]
        public System.String? Vat { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(6)]
        public System.String? StawkaVAT { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokumentZamElemModInfo_20231(); }
    }
    public class XLRezNagInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrFirma { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? TwrLp { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntFirma { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? MagTyp { get; set; }
        public System.Int32? MagFirma { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? MagLp { get; set; }
        public System.Int32? FrsID { get; set; }
        public System.Int32? DataRealizacji { get; set; }
        public System.Int32? DataWaznosci { get; set; }
        public System.Int32? Priorytet { get; set; }
        [StringLength(41)]
        public System.String? TwrKod { get; set; }
        [StringLength(21)]
        public System.String? KntAkronim { get; set; }
        [StringLength(11)]
        public System.String? Magazyn { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRezNagInfo_20231(); }
    }
    public class XLRezUsunInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRezUsunInfo_20231(); }
    }
    public class XLRezDstInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? DstTyp { get; set; }
        public System.Int32? DstFirma { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DstLp { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? RozbijajRezerwacje { get; set; }
        public System.Int32? Pico { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRezDstInfo_20231(); }
    }
    public class XLZasobRezPrzypnijInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZasobRezPrzypnijInfo_20231(); }
    }
    public class XLZmienBOEInfo : BaseXL
    {


        public System.Int32? GIDLp { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? Status { get; set; }
        [StringLength(31)]
        public System.String? Konto { get; set; }
        [StringLength(81)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZmienBOEInfo_20231(); }
    }
    public class XLKsiegujInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }



        public System.Int32? GIDLp { get; set; }
        public System.Int32? SCHTyp { get; set; }
        public System.Int32? SCHFirma { get; set; }
        public System.Int32? SCHNumer { get; set; }
        public System.Int32? SCHLp { get; set; }
        public System.Int32? NadpiszSchemat { get; set; }
        public System.Int32? NadpiszDziennik { get; set; }
        public System.Int32? NadpiszDateKsiegowania { get; set; }
        public System.Int32? DataKsiegowania { get; set; }
        [StringLength(6)]
        public System.String? Dziennik { get; set; }
        [StringLength(512)]
        public System.String? BladOpis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLKsiegujInfo_20231(); }
    }
    public class XLDodajOpeMagElemInfo : BaseXL
    {

        public System.Int32? EleLp { get; set; }
        public System.Int32? OpeTyp { get; set; }
        public System.Int32? OpeFirma { get; set; }
        public System.Int32? OpeNumer { get; set; }
        public System.Int32? OpeLp { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Zwiazane { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajOpeMagElemInfo_20231(); }
    }
    public class XLDodajZasMagElemInfo : BaseXL
    {

        public System.Int32? EleLp { get; set; }
        public System.Int32? POBID { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? Zwiazane { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDodajZasMagElemInfo_20231(); }
    }
    public class XLRealizujPozycjeMagInfo : BaseXL
    {

        public System.Int32? EleNr { get; set; }
        public System.Int32? EleLp { get; set; }
        public System.Int32? BezEdycji { get; set; }
        public System.Int32? Nadpisywanie { get; set; }
        public System.Int32? CChTyp { get; set; }
        public System.Int32? CChFirma { get; set; }
        public System.Int32? CChNumer { get; set; }
        public System.Int32? CChLp { get; set; }
        public System.Int32? CCh2Typ { get; set; }
        public System.Int32? CCh2Numer { get; set; }
        public System.Int32? Adres { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? EAN { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(256)]
        public System.String? Cecha2 { get; set; }
        [StringLength(7)]
        public System.String? Dlugosc { get; set; }
        [StringLength(7)]
        public System.String? Szerokosc { get; set; }
        [StringLength(7)]
        public System.String? Wysokosc { get; set; }
        [StringLength(31)]
        public System.String? JMLog { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRealizujPozycjeMagInfo_20231(); }
    }
    public class XLSerwisUrzRodzParInfo : BaseXL
    {

        public System.Int32? SURId { get; set; }
        public System.Int32? SUDId { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? Lp { get; set; }
        [StringLength(41)]
        public System.String? SURKod { get; set; }
        [StringLength(51)]
        public System.String? SUDNazwa { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisUrzRodzParInfo_20231(); }
    }
    public class XLSerwisUrzRodzajInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? JednostkaPrzebiegu { get; set; }
        public System.Int32? Nadrzedny { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisUrzRodzajInfo_20231(); }
    }
    public class XLProdObiektyDoPowiazaniaInfo : BaseXL
    {



        public System.Int32? Akcja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdObiektyDoPowiazaniaInfo_20231(); }
    }
    public class XLPolaczOperacjePolproduktamiInfo : BaseXL
    {

        public System.Int32? Typ { get; set; }
        public System.Int32? Tryb { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPolaczOperacjePolproduktamiInfo_20231(); }
    }
    public class XLSzeInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? SrtZestNumer { get; set; }
        public System.Int32? SrtNumer { get; set; }
        public System.Int32? Rodzaj { get; set; }
        public System.Int32? DataPrzylaczenia { get; set; }
        public System.Int32? DataOdlaczenia { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? RodzajAkcji { get; set; }
        [StringLength(41)]
        public System.String? SrtZestAkronim { get; set; }
        [StringLength(41)]
        public System.String? SrtAkronim { get; set; }
        [StringLength(51)]
        public System.String? Nazwa { get; set; }
        [StringLength(18)]
        public System.String? PodstawaBilansowa { get; set; }
        [StringLength(18)]
        public System.String? PodstawaPodatkowa { get; set; }
        [StringLength(18)]
        public System.String? PodstawaBilansowaSys { get; set; }
        [StringLength(18)]
        public System.String? PodstawaPodatkowaSys { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(10)]
        public System.String? KursL { get; set; }
        [StringLength(5)]
        public System.String? KursM { get; set; }
        [StringLength(4001)]
        public System.String? Opis { get; set; }
        [StringLength(18)]
        public System.String? AmortBilansowa { get; set; }
        [StringLength(18)]
        public System.String? AmortBilansowaSys { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSzeInfo_20231(); }
    }
    public class XLPartiaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? CCKNumer { get; set; }
        public System.Int32? DstNumer { get; set; }
        public System.Int32? DataW { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? WMS { get; set; }
        [StringLength(41)]
        public System.String? TowarKod { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(41)]
        public System.String? Ean { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPartiaInfo_20231(); }
    }
    public class XLCennikInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? NrKursu { get; set; }
        public System.Int32? Aktualizacja { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? TcnId { get; set; }
        public System.Int32? DataOd { get; set; }
        public System.Int32? RodzajPodstawy { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? DataUtworzenia { get; set; }
        public System.Int32? OpeWNumer { get; set; }
        public System.Int32? Tryb { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(17)]
        public System.String? Wartosc { get; set; }
        [StringLength(7)]
        public System.String? Marza { get; set; }
        [StringLength(7)]
        public System.String? Zaok { get; set; }
        [StringLength(6)]
        public System.String? Offset { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(256)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLCennikInfo_20231(); }
    }
    public class XLZamkniecieCennikaInfo : BaseXL
    {

        public System.Int32? TcnId { get; set; }
        public System.Int32? Tryb { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZamkniecieCennikaInfo_20231(); }
    }
    public class XLKosztDodDokInfo : BaseXL
    {

        public System.Int32? Akcja { get; set; }


        public System.Int32? GIDLp { get; set; }
        [StringLength(17)]
        public System.String? Biezacy { get; set; }
        [StringLength(17)]
        public System.String? Inne { get; set; }
        [StringLength(17)]
        public System.String? Naliczono { get; set; }
        [StringLength(17)]
        public System.String? DoNaliczenia { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLKosztDodDokInfo_20231(); }
    }
    public class XLRozbicieKDZInfo : BaseXL
    {

        public System.Int32? TrybRozbicia { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRozbicieKDZInfo_20231(); }
    }
    public class XLProdOkresInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? Dostepny { get; set; }
        public System.Int32? OkresOd { get; set; }
        public System.Int32? OkresDo { get; set; }
        public System.Int32? CzasPrzerwy { get; set; }
        public System.Int32? Okres { get; set; }
        public System.Int32? TypOkresu { get; set; }
        public System.Int32? Dni { get; set; }
        public System.Int32? PriorytetOkresu { get; set; }
        public System.Int32? Przestoj { get; set; }
        public System.Int32? PlanowanyPrzestoj { get; set; }
        public System.Int32? DataOd { get; set; }
        public System.Int32? DataDo { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(11)]
        public System.String? PrzyczynaPrzestoju { get; set; }
        [StringLength(11)]
        public System.String? StatusId { get; set; }
        [StringLength(2)]
        public System.String? GenerujZSR { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdOkresInfo_20231(); }
    }
    public class XLTwDInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? KlasaKnt { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? Data { get; set; }
        public System.Int32? Czas { get; set; }
        public System.Int32? ProponowanyDst { get; set; }
        public System.Int32? OplataSpozZakup { get; set; }
        [StringLength(41)]
        public System.String? TwrKod { get; set; }
        [StringLength(21)]
        public System.String? KntAkronim { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(17)]
        public System.String? Cena { get; set; }
        [StringLength(41)]
        public System.String? KodKnt { get; set; }
        [StringLength(9)]
        public System.String? KodJmZ { get; set; }
        [StringLength(201)]
        public System.String? Notatki { get; set; }
        [StringLength(41)]
        public System.String? KodDodatkowyKnt { get; set; }
        [StringLength(256)]
        public System.String? NazwaKnt { get; set; }
        [StringLength(16)]
        public System.String? MrpEoq { get; set; }
        [StringLength(16)]
        public System.String? IloscZam { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLTwDInfo_20231(); }
    }
    public class XLSerwisRealizujCzynnoscInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? Flagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisRealizujCzynnoscInfo_20231(); }
    }
    public class XLIlosciNaMagazynachInwInfo : BaseXL
    {

        public System.Int32? Akcja { get; set; }
        public System.Int32? MagNumer { get; set; }
        [StringLength(16)]
        public System.String? Ilosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLIlosciNaMagazynachInwInfo_20231(); }
    }
    public class XLRozbijIloscNaMagazynyInwInfo : BaseXL
    {

        public System.Int32? InTId { get; set; }
        public System.Int32? InAID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRozbijIloscNaMagazynyInwInfo_20231(); }
    }
    public class XLProdRealizacjaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? OperacjaId { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? SposobRealizacji { get; set; }
        public System.Int32? CzasZakonczenia { get; set; }
        public System.Int32? NieGenerujDokAutomat { get; set; }
        public System.Int32? NieKonczUruchomionych { get; set; }
        [StringLength(2)]
        public System.String? PrzypiszOperatora { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdRealizacjaInfo_20231(); }
    }
    public class XLProdRealizacjaIloscInfo : BaseXL
    {

        public System.Int32? RealizacjaId { get; set; }
        public System.Int32? TypZmiany { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdRealizacjaIloscInfo_20231(); }
    }
    public class XLProdZasobRealizacjaInfo : BaseXL
    {

        public System.Int32? PZAId { get; set; }
        public System.Int32? TypZmiany { get; set; }
        public System.Int32? AktualizujCecheNaDok { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(11)]
        public System.String? MagNumer { get; set; }
        [StringLength(21)]
        public System.String? RodzajUbocznegoId { get; set; }
        [StringLength(21)]
        public System.String? KodNiezgodnosciId { get; set; }
        [StringLength(21)]
        public System.String? KlasaCechy { get; set; }
        [StringLength(256)]
        public System.String? Cecha { get; set; }
        [StringLength(2)]
        public System.String? PrzeliczajWgPomocniczej { get; set; }
        [StringLength(21)]
        public System.String? IloscPom { get; set; }
        [StringLength(9)]
        public System.String? JednostkaPom { get; set; }
        [StringLength(21)]
        public System.String? IdWzorcaNrPartii { get; set; }
        [StringLength(256)]
        public System.String? NumerSeryjny { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZasobRealizacjaInfo_20231(); }
    }
    public class XLProdGenerujDokumentInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? TypDokumentu { get; set; }
        public System.Int32? TypObiektu { get; set; }
        public System.Int32? TrybZamykaniaDok { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? CzyZPlanu { get; set; }
        [StringLength(256)]
        public System.String? DokId { get; set; }
        [StringLength(11)]
        public System.String? MagNumer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdGenerujDokumentInfo_20231(); }
    }
    public class XLProdSpinajDokumentInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? TypObiektu { get; set; }
        public System.Int32? TypDokumentu { get; set; }
        public System.Int32? TypOperacji { get; set; }
        public System.Int32? Flagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdSpinajDokumentInfo_20231(); }
    }
    public class XLProdObiektyDoDokumentowInfo : BaseXL
    {



        public System.Int32? Akcja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdObiektyDoDokumentowInfo_20231(); }
    }
    public class XLProdObiektUzycieInfo : BaseXL
    {

        public System.Int32? Obiekt { get; set; }
        public System.Int32? Akcja { get; set; }
        public System.Int32? PrcNumer { get; set; }
        public System.Int32? TerminData { get; set; }
        public System.Int32? TerminCzas { get; set; }
        public System.Int32? TerminZwrotuData { get; set; }
        public System.Int32? TerminZwrotuCzas { get; set; }
        public System.Int32? StatusNarzedzia { get; set; }
        public System.Int32? PrzyczynaLikwidacji { get; set; }
        public System.Int32? InformujOPrzekroczeniu { get; set; }
        public System.Int32? ObiektPrzyjmujacy { get; set; }
        [StringLength(256)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdObiektUzycieInfo_20231(); }
    }
    public class XLProdZmienObiektOperacjiInfo : BaseXL
    {

        public System.Int32? PCOId { get; set; }
        public System.Int32? Akcja { get; set; }
        [StringLength(10)]
        public System.String? Termin { get; set; }
        [StringLength(2)]
        public System.String? Zablokowany { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZmienObiektOperacjiInfo_20231(); }
    }
    public class XLRozrachunekInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? Dekret1Numer { get; set; }
        public System.Int32? Dekret1Lp { get; set; }
        public System.Int32? Dekret1DC { get; set; }
        public System.Int32? Dekret2Numer { get; set; }
        public System.Int32? Dekret2Lp { get; set; }
        public System.Int32? Dekret2DC { get; set; }
        public System.Int32? BezRozliczenia { get; set; }
        public System.Int32? RozID { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(512)]
        public System.String? BladOpis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRozrachunekInfo_20231(); }
    }
    public class XLZabiegInfo : BaseXL
    {

        public System.Int32? Flagi { get; set; }
        public System.Int32? TechnologiaCzynnosc { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? Lp { get; set; }
        [StringLength(14)]
        public System.String? Ilosc { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(4096)]
        public System.String? Opis { get; set; }
        [StringLength(51)]
        public System.String? NrInstrukcji { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZabiegInfo_20231(); }
    }
    public class XLProdNowyZabiegRealizacjaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? PCZId { get; set; }
        public System.Int32? PZZId { get; set; }
        public System.Int32? PowielaniePoz { get; set; }
        public System.Int32? NiePrzepisujDanychZabiegu { get; set; }
        public System.Int32? Wykonany { get; set; }
        public System.Int32? DataW { get; set; }
        public System.Int32? OpeW { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(20)]
        public System.String? Ilosc { get; set; }
        [StringLength(4096)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdNowyZabiegRealizacjaInfo_20231(); }
    }
    public class XLProdWykonajZabiegInfo : BaseXL
    {

        public System.Int32? Akcja { get; set; }
        public System.Int32? PZZId { get; set; }
        public System.Int32? DataW { get; set; }
        public System.Int32? OpeW { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdWykonajZabiegInfo_20231(); }
    }
    public class XLZgodaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiLp { get; set; }
        public System.Int32? RodzajZgody { get; set; }
        public System.Int32? DataUdzielenia { get; set; }
        public System.Int32? DataWycofania { get; set; }
        public System.Int32? ZrodloUdzielenia { get; set; }
        public System.Int32? Regulamin { get; set; }
        public System.Int32? PowodWycofania { get; set; }
        public System.Int32? ZrodloWycofania { get; set; }
        public System.Int32? ESklepSync { get; set; }
        public System.Int32? FormaKontaktu { get; set; }
        [StringLength(101)]
        public System.String? IP { get; set; }
        [StringLength(256)]
        public System.String? URL { get; set; }
        [StringLength(1001)]
        public System.String? Szczegoly { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZgodaInfo_20231(); }
    }
    public class XLModyfikujZgodeInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        [StringLength(11)]
        public System.String? DataWycofania { get; set; }
        [StringLength(11)]
        public System.String? PowodWycofania { get; set; }
        [StringLength(11)]
        public System.String? ZrodloWycofania { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujZgodeInfo_20231(); }
    }
    public class XLModyfikujNaglowekInfo : BaseXL
    {

        public System.Int32? DataMag { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(11)]
        public System.String? MagazynZ { get; set; }
        [StringLength(11)]
        public System.String? MagazynD { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujNaglowekInfo_20231(); }
    }
    public class XLRealizacjaZlcInfo : BaseXL
    {



        public System.Int32? Akcja { get; set; }
        public System.Int32? TrybGenerowaniaDok { get; set; }
        public System.Int32? Tryb { get; set; }
        [StringLength(3)]
        public System.String? DomyslneOdp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLRealizacjaZlcInfo_20231(); }
    }
    public class XLNowyRachunekInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiLp { get; set; }
        public System.Int32? TypRachunku { get; set; }
        public System.Int32? Domyslny { get; set; }
        public System.Int32? KntAdres { get; set; }
        [StringLength(4)]
        public System.String? Waluta { get; set; }
        [StringLength(51)]
        public System.String? NrRachunku { get; set; }
        [StringLength(21)]
        public System.String? BankKod { get; set; }
        [StringLength(256)]
        public System.String? Uwagi { get; set; }
        [StringLength(2)]
        public System.String? NRB { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLNowyRachunekInfo_20231(); }
    }
    public class XLTwrGidInfo : BaseXL
    {



        public System.Int32? Akcja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLTwrGidInfo_20231(); }
    }
    public class XLPodmienTwrNaArkuszuInwInfo : BaseXL
    {

        public System.Int32? InAID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLPodmienTwrNaArkuszuInwInfo_20231(); }
    }
    public class XLProdPKJNagInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Numer { get; set; }
        public System.Int32? Rok { get; set; }
        public System.Int32? Miesiac { get; set; }
        public System.Int32? OpWNumer { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? PTZNumer { get; set; }
        public System.Int32? CzyUboczny { get; set; }
        public System.Int32? MagNumer { get; set; }
        public System.Int32? ObiLp { get; set; }
        public System.Int32? ObiSubLp { get; set; }
        public System.Int32? Obszar { get; set; }
        public System.Int32? Stan { get; set; }
        public System.Int32? NiePrzepisujSubelementow { get; set; }
        public System.Int32? WKJId { get; set; }
        [StringLength(21)]
        public System.String? StatusId { get; set; }
        [StringLength(21)]
        public System.String? PrzyczynaOdrzuceniaId { get; set; }
        [StringLength(21)]
        public System.String? WynikKJId { get; set; }
        [StringLength(6)]
        public System.String? Seria { get; set; }
        [StringLength(256)]
        public System.String? Opis { get; set; }
        [StringLength(9)]
        public System.String? OpWIdent { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(21)]
        public System.String? IloscZgodnych { get; set; }
        [StringLength(21)]
        public System.String? IloscNiezgodnych { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdPKJNagInfo_20231(); }
    }
    public class XLProdParametrKJObiektuInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? PKJId { get; set; }
        public System.Int32? ObiTyp { get; set; }
        public System.Int32? ObiNumer { get; set; }
        public System.Int32? Tryb { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(251)]
        public System.String? Jednostka { get; set; }
        [StringLength(513)]
        public System.String? Wartosc { get; set; }
        [StringLength(256)]
        public System.String? Url { get; set; }
        [StringLength(16)]
        public System.String? WynikIlosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdParametrKJObiektuInfo_20231(); }
    }
    public class XLProdParametrKJNormaInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? PPKOId { get; set; }
        public System.Int32? Zgodna { get; set; }
        public System.Int32? Domyslna { get; set; }
        [StringLength(513)]
        public System.String? Wartosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdParametrKJNormaInfo_20231(); }
    }
    public class XLProdParametrKJInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Archiwalny { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Zamknieta { get; set; }
        public System.Int32? PPKOId { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(31)]
        public System.String? Format { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        [StringLength(251)]
        public System.String? Jednostka { get; set; }
        [StringLength(256)]
        public System.String? Url { get; set; }
        [StringLength(21)]
        public System.String? ZakresOd { get; set; }
        [StringLength(21)]
        public System.String? ZakresDo { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdParametrKJInfo_20231(); }
    }
    public class XLProdWzorzecKJInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Archiwalny { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(101)]
        public System.String? Nazwa { get; set; }
        [StringLength(1025)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? Url { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdWzorzecKJInfo_20231(); }
    }
    public class XLProdWzorzecKJTowarInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? WKJId { get; set; }
        public System.Int32? Domyslny { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdWzorzecKJTowarInfo_20231(); }
    }
    public class XLOsobaKntInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? KntLp { get; set; }
        public System.Int32? KntTyp { get; set; }
        public System.Int32? KntNumer { get; set; }
        public System.Int32? UpowaznionaHan { get; set; }
        public System.Int32? UpowaznionaZam { get; set; }
        public System.Int32? UpowaznionaKon { get; set; }
        public System.Int32? UpowaznionaPla { get; set; }
        public System.Int32? RolaDecyzyjna { get; set; }
        public System.Int32? AdresId { get; set; }
        [StringLength(513)]
        public System.String? Komunikat { get; set; }
        [StringLength(41)]
        public System.String? Dzial { get; set; }
        [StringLength(41)]
        public System.String? Stanowisko { get; set; }
        [StringLength(41)]
        public System.String? Tytul { get; set; }
        [StringLength(41)]
        public System.String? Nazwa { get; set; }
        [StringLength(31)]
        public System.String? Telefon { get; set; }
        [StringLength(31)]
        public System.String? TelefonK { get; set; }
        [StringLength(31)]
        public System.String? Fax { get; set; }
        [StringLength(256)]
        public System.String? EMail { get; set; }
        [StringLength(1025)]
        public System.String? Notatki { get; set; }
        [StringLength(41)]
        public System.String? GUID { get; set; }
        [StringLength(41)]
        public System.String? GUID2 { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOsobaKntInfo_20231(); }
    }
    public class XLJPKV7Info : BaseXL
    {

        public System.Int32? TrNTyp { get; set; }
        public System.Int32? TrNFirma { get; set; }
        public System.Int32? TrNNumer { get; set; }
        public System.Int32? TrNLp { get; set; }
        public System.Int32? SpiNumer { get; set; }
        public System.Int32? Typ { get; set; }
        public System.Int32? Rodzaj { get; set; }
        public System.Int32? Flagi { get; set; }
        [StringLength(51)]
        public System.String? Wartosc { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLJPKV7Info_20231(); }
    }
    public class XLProdZmienZabiegRealizacjaInfo : BaseXL
    {

        public System.Int32? PZZId { get; set; }
        public System.Int32? Akcja { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(20)]
        public System.String? Ilosc { get; set; }
        [StringLength(4096)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZmienZabiegRealizacjaInfo_20231(); }
    }
    public class XLProdZmienPKJNagInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? Akcja { get; set; }
        [StringLength(256)]
        public System.String? Opis { get; set; }
        [StringLength(21)]
        public System.String? StatusId { get; set; }
        [StringLength(21)]
        public System.String? Ilosc { get; set; }
        [StringLength(21)]
        public System.String? IloscZgodnych { get; set; }
        [StringLength(21)]
        public System.String? IloscNiezgodnych { get; set; }
        [StringLength(21)]
        public System.String? WynikKJId { get; set; }
        [StringLength(21)]
        public System.String? Stan { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZmienPKJNagInfo_20231(); }
    }
    public class XLProdUsunParametrZObiektuInfo : BaseXL
    {

        public System.Int32? PPKOId { get; set; }
        public System.Int32? Tryb { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdUsunParametrZObiektuInfo_20231(); }
    }
    public class XLProdZmienWynikKJDlaParametruInfo : BaseXL
    {

        public System.Int32? PPKOId { get; set; }
        public System.Int32? Tryb { get; set; }
        [StringLength(513)]
        public System.String? Wartosc { get; set; }
        [StringLength(21)]
        public System.String? WynikIlosc { get; set; }
        [StringLength(1024)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZmienWynikKJDlaParametruInfo_20231(); }
    }
    public class XLZasobRezUsunInfo : BaseXL
    {

        public System.Int32? RezTyp { get; set; }
        public System.Int32? RezFirma { get; set; }
        public System.Int32? RezNumer { get; set; }
        public System.Int32? RezLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZasobRezUsunInfo_20231(); }
    }
    public class XLUsunSubElemInfo : BaseXL
    {

        public System.Int32? Lp { get; set; }
        public System.Int32? SubLp { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunSubElemInfo_20231(); }
    }
    public class XLProdRejestrujPominiecieOperacjiInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? PCZId { get; set; }
        public System.Int32? Przyczyna { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdRejestrujPominiecieOperacjiInfo_20231(); }
    }
    public class XLProdPKJSubelemInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? PKJNId { get; set; }
        public System.Int32? SubLp { get; set; }
        public System.Int32? Akcja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdPKJSubelemInfo_20231(); }
    }
    public class XLObiGidsInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        public System.Int32? SubGIDLp { get; set; }
        public System.Int32? Akcja { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLObiGidsInfo_20231(); }
    }
    public class XLProdGenerujPKJInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? ZrdTyp { get; set; }
        public System.Int32? Stan { get; set; }
        public System.Int32? Flagi { get; set; }
        public System.String? DokId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdGenerujPKJInfo_20231(); }
    }
    public class XLProdAktualizujNrSeryjnyNaDokInfo : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? TypObiektu { get; set; }
        [StringLength(1024)]
        public System.String? ZaktualizowaneWyroby { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdAktualizujNrSeryjnyNaDokInfo_20231(); }
    }
    public class XLBlokujDstNaPKJInfo : BaseXL
    {

        public System.Int32? PKJNId { get; set; }
        public System.Int32? DstNumer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLBlokujDstNaPKJInfo_20231(); }
    }
    public class XLOdblokujDstNaPKJInfo : BaseXL
    {

        public System.Int32? PKJNId { get; set; }
        public System.Int32? DstNumer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLOdblokujDstNaPKJInfo_20231(); }
    }
    public class XLSerwisPrzegladUrzadzeniaInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? SrUId { get; set; }
        public System.Int32? STPId { get; set; }
        public System.Int32? Cykliczny { get; set; }
        public System.Int32? CzasCyklu { get; set; }
        public System.Int32? CzasCykluJedn { get; set; }
        public System.Int32? Terminarz { get; set; }
        public System.Int32? CzasPrzypomnienia { get; set; }
        public System.Int32? CzasPrzypomnieniaJedn { get; set; }
        public System.Int32? OpeNumerO { get; set; }
        public System.Int32? DataOst { get; set; }
        public System.Int32? DataNast { get; set; }
        public System.Int32? AutoNastepnyPrzeglad { get; set; }
        public System.Int32? AutoPrzegladZrodlo { get; set; }
        [StringLength(256)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisPrzegladUrzadzeniaInfo_20231(); }
    }
    public class XLModyfikujSerwisPrzegladUrzadzeniaInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? Cykliczny { get; set; }
        public System.Int32? CzasCyklu { get; set; }
        public System.Int32? CzasCykluJedn { get; set; }
        public System.Int32? Terminarz { get; set; }
        public System.Int32? CzasPrzypomnienia { get; set; }
        public System.Int32? CzasPrzypomnieniaJedn { get; set; }
        public System.Int32? DataOst { get; set; }
        public System.Int32? DataNast { get; set; }
        public System.Int32? AutoNastepnyPrzeglad { get; set; }
        public System.Int32? AutoPrzegladZrodlo { get; set; }
        [StringLength(256)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujSerwisPrzegladUrzadzeniaInfo_20231(); }
    }
    public class XLModyfikujSerwisParametrInfo : BaseXL
    {

        public System.Int32? SlwTyp { get; set; }
        public System.Int32? SlwNumer { get; set; }
        public System.Int32? WartoscL { get; set; }
        public System.Int32? Id { get; set; }
        [StringLength(11)]
        public System.String? Format { get; set; }
        [StringLength(256)]
        public System.String? WartoscS { get; set; }
        [StringLength(15)]
        public System.String? WartoscDec { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujSerwisParametrInfo_20231(); }
    }
    public class XLModyfkujSerwisUrzadzenieInfo : BaseXL
    {

        public System.Int32? SURId { get; set; }
        public System.Int32? Id { get; set; }
        public System.Int32? Nadrzedny { get; set; }
        [StringLength(41)]
        public System.String? Kod { get; set; }
        [StringLength(256)]
        public System.String? Nazwa { get; set; }
        [StringLength(512)]
        public System.String? Opis { get; set; }
        [StringLength(256)]
        public System.String? Numer { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfkujSerwisUrzadzenieInfo_20231(); }
    }
    public class XLUsunSerwisUrzZlcInfo : BaseXL
    {

        public System.Int32? SrUId { get; set; }
        public System.Int32? SZNId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLUsunSerwisUrzZlcInfo_20231(); }
    }
    public class XLZapytanie : BaseXL
    {

        [StringLength(1024)]
        public System.String? Zapytanie { get; set; }
        [StringLength(2048)]
        public System.String? Kolumny { get; set; }
        [StringLength(512)]
        public System.String? Komunikat { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZapytanie_20231(); }
    }
    public class XLWynikZapytania : BaseXL
    {

        [StringLength(512)]
        public System.String? Kolumna1 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna2 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna3 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna4 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna5 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna6 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna7 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna8 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna9 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna10 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna11 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna12 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna13 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna14 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna15 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna16 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna17 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna18 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna19 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna20 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna21 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna22 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna23 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna24 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna25 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna26 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna27 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna28 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna29 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna30 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna31 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna32 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna33 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna34 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna35 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna36 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna37 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna38 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna39 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna40 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna41 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna42 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna43 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna44 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna45 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna46 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna47 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna48 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna49 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna50 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna51 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna52 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna53 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna54 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna55 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna56 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna57 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna58 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna59 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna60 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna61 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna62 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna63 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna64 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna65 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna66 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna67 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna68 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna69 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna70 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna71 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna72 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna73 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna74 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna75 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna76 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna77 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna78 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna79 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna80 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna81 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna82 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna83 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna84 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna85 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna86 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna87 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna88 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna89 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna90 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna91 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna92 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna93 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna94 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna95 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna96 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna97 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna98 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna99 { get; set; }
        [StringLength(512)]
        public System.String? Kolumna100 { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLWynikZapytania_20231(); }
    }
    public class XLBon : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? RBoId { get; set; }
        public System.Int32? TerminOd { get; set; }
        public System.Int32? TerminDo { get; set; }
        [StringLength(51)]
        public System.String? Numer { get; set; }
        [StringLength(15)]
        public System.String? Kwota { get; set; }
        [StringLength(501)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLBon_20231(); }
    }
    public class XLProdRedukujIlosciZasobow : BaseXL
    {

        public System.Int32? Tryb { get; set; }
        public System.Int32? TypElementu { get; set; }
        public System.Int32? TypObiektu { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdRedukujIlosciZasobow_20231(); }
    }
    public class XLProdGenerujZSRDoPrzestoju : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? POKId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdGenerujZSRDoPrzestoju_20231(); }
    }
    public class XLDokSpiDokInfo : BaseXL
    {

        public System.Int32? TypSpi { get; set; }
        public System.Int32? GID1Typ { get; set; }
        public System.Int32? GID1Firma { get; set; }
        public System.Int32? GID1Numer { get; set; }
        public System.Int32? GID1Lp { get; set; }
        public System.Int32? GID2Typ { get; set; }
        public System.Int32? GID2Firma { get; set; }
        public System.Int32? GID2Numer { get; set; }
        public System.Int32? GID2Lp { get; set; }
        public System.Int32? Flagi { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLDokSpiDokInfo_20231(); }
    }
    public class XLSerwisDodajCzescZamiennaInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? TwrId { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? SruId { get; set; }
        [StringLength(1025)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisDodajCzescZamiennaInfo_20231(); }
    }
    public class XLSerwisUsunCzescZamiennaInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisUsunCzescZamiennaInfo_20231(); }
    }
    public class XLSerwisModyfikujCzescZamiennaInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        public System.Int32? TwrId { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? SruId { get; set; }
        [StringLength(1025)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLSerwisModyfikujCzescZamiennaInfo_20231(); }
    }
    public class XLZwrocZaznaczeniaUruchomionejFormatki : BaseXL
    {

        [StringLength(61)]
        public System.String? Identyfikator { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZwrocZaznaczeniaUruchomionejFormatki_20231(); }
    }
    public class XLStawkaVatInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? FlagaVat { get; set; }
        [StringLength(4096)]
        public System.String? TwrKod { get; set; }
        [StringLength(4)]
        public System.String? KrajKod { get; set; }
        [StringLength(3)]
        public System.String? GrupaPod { get; set; }
        [StringLength(12)]
        public System.String? StawkaPod { get; set; }
        [StringLength(12)]
        public System.String? Zrodlowa { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLStawkaVatInfo_20231(); }
    }
    public class XLZmienStawkeVatInfo : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? TwrTyp { get; set; }
        public System.Int32? TwrNumer { get; set; }
        public System.Int32? FlagaVat { get; set; }
        [StringLength(4096)]
        public System.String? TwrKod { get; set; }
        [StringLength(4)]
        public System.String? KrajKod { get; set; }
        [StringLength(3)]
        public System.String? GrupaPod { get; set; }
        [StringLength(12)]
        public System.String? StawkaPod { get; set; }
        [StringLength(12)]
        public System.String? Zrodlowa { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLZmienStawkeVatInfo_20231(); }
    }
    public class XLModyfikujBonInfo : BaseXL
    {

        public System.Int32? ID { get; set; }
        [StringLength(15)]
        public System.String? KwotaZrealizowana { get; set; }
        [StringLength(501)]
        public System.String? Opis { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLModyfikujBonInfo_20231(); }
    }
    public class XLTowarModyfikacjaInfo : BaseXL
    {




        public System.Int32? GIDLp { get; set; }
        [StringLength(12)]
        public System.String? WszystkoPlID { get; set; }
        [StringLength(12)]
        public System.String? WszystkoPlNr { get; set; }
        [StringLength(513)]
        public System.String? WszystkoPlLink { get; set; }
        [StringLength(101)]
        public System.String? WszystkoPlStatus { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLTowarModyfikacjaInfo_20231(); }
    }
    public class XLProdDodajPauze : BaseXL
    {

        public System.Int32? Id { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? PCZId { get; set; }
        public System.Int32? TerminStart { get; set; }
        public System.Int32? TerminKoniec { get; set; }
        [StringLength(21)]
        public System.String? PrzyczynaPauzyId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdDodajPauze_20231(); }
    }
    public class XLProdZmienPauze : BaseXL
    {

        public System.Int32? PPYId { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? TerminStart { get; set; }
        public System.Int32? TerminKoniec { get; set; }
        [StringLength(14)]
        public System.String? CzasRozliczeniowy { get; set; }
        [StringLength(21)]
        public System.String? PrzyczynaPauzyId { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZmienPauze_20231(); }
    }
    public class XLProdZakonczPauze : BaseXL
    {

        public System.Int32? PPYId { get; set; }
        public System.Int32? Tryb { get; set; }
        public System.Int32? TerminKoniec { get; set; }
        [StringLength(14)]
        public System.String? CzasRozliczeniowy { get; set; }
        public override object JsonSerializeResult() { throw new NotImplementedException(); }
        // public void GetData() { new cdn_api.XLProdZakonczPauze_20231(); }
    }


    public static class Metody
    {
        public static System.Int32? XLDodajCzynnoscDoProcesuProd(System.Int32? _lSesjaID, XLProdCzynnoscProcesuInfo _lProdCzynnoscProcesuInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajKontrahentaDoPromocji(System.Int32? _lSesjaID, XLKontrahentPrmInfo _lKontrahentPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajNote(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, XLNotaInfo _lNota) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujUrzadzenieSerwis(XLModyfkujSerwisUrzadzenieInfo _ModyfkujSerwisUrzadzenieInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentImp(System.Int32? lDokumentID, XLZamkniecieDokumentuImpInfo lZamknijDokumentImp) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujPrzedmiotUML(System.Int32? _lSesjaID, XLEdytujULPInfo _lULPInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLSprawdzLicencje(XLLicencjaInfo _lLicencja) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienCene(XLCenaInfo _lCena) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyOdczytInw(System.Int32? _lSesjaID, ref System.Int32? _lOdczytId, XLOdczytInwInfo _lOdczytInwInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajAtrybut(System.Int32? _SesjaID, XLAtrybutInfo _lDodajAtrybut) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunZasobZRezerwacji(System.Int32? _SesjaID, XLZasobRezUsunInfo _UsunZasobZRez) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentZlc(System.Int32? _lDokumentID, XLZamkniecieDokumentuZlcInfo _lZamknijDokumentZlc) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijPozycjeBO(System.Int32? _lSesjaID, XLZamknijBOEInfo _lZamknijPozycjeBO) { throw new NotImplementedException(); }
        public static System.Int32? XLNoweZlecenieSerwis(System.Int32? _lSesjaID, ref System.Int32? _lDokument, XLSerwisNagInfo _lSerNZInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzKontrahentaSQL(System.Int32? _lSesjaID, XLModyfikacjaKntSQLInfo _lModyfikacjaKntSQL) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyRodzajUrzadzeniaSerwis(XLSerwisUrzRodzajInfo _lSerNoweUrzRodzajInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokumentZam(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLOtwarcieDokumentuZamInfo _lOtworzDokumentZam) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDoZleceniaProd(System.Int32? _lSesjaID, XLZlecenieProdElemInfo _lZlecElem) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajZasobDoCzynnosciProd(System.Int32? _lSesjaID, XLProdZasobCzynnoscInfo _lProdZasobCzynnoscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeZleceniaSR(System.Int32? _lDokID, XLDokumentZlcRemElemInfo _lPozycjaZlcRem) { throw new NotImplementedException(); }
        public static System.Int32? XLAtrSkasujKlase(XLAtrKasujKlaseInfo _lAtrKasujKlase) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijPaczke(System.Int32? _lDokument, XLZamknieciePaczkiInfo _lZamknieciePaczkiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLKasujNote(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, XLNotaInfo _lNota) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPozycjeDokSRT(System.Int32? _lSesjaID, XLSrtElem2Info _lSrtElem2Info) { throw new NotImplementedException(); }
        public static System.Int32? XLGenerujUNM(System.Int32? _lSesjaID, System.Int32? _lGenerujUNM) { throw new NotImplementedException(); }
        public static System.Int32? XLProdAktualizujNrSeryjnyNaDok(System.Int32? _lSesjaID, XLProdAktualizujNrSeryjnyNaDokInfo _ProdAktualizujNrSeryjnyNaDokInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzOdczytInw(System.Int32? _lSesjaID, ref System.Int32? _lOdczytId, XLOtworzOdczytInwInfo _lOtworzOdczytInwInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunKosztZWysylki(System.Int32? _lDokument, XLSpiInfo _lSpiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPlatnoscZam(System.Int32? _lDokumentID, XLDokumentZamPlatInfo _lDokumantZamPlat) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaPaczka(System.Int32? _lSesjaID, ref System.Int32? _lDokument, XLPaczkaInfo _lPaczkaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunRezerwacje(System.Int32? _lSesjaID, ref System.Int32? _lDokumentId, XLRezUsunInfo _lUsunRez) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyZasobCzynnoscTechnologia(System.Int32? _lSesjaID, XLProdTechnologiaZasobInfo _lProdTechnologiaZasobInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeZKolejki(System.Int32? _lDokumentID) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaGrupaTwr(System.Int32? _lSesjaID, XLGrupaTwrInfo _lGrupaTwr) { throw new NotImplementedException(); }
        public static System.Int32? XLProdRedukujIlosciZasobow(XLProdRedukujIlosciZasobow _RedukujIlosciZasobow) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajParametrUrzadzeniaSerwis(XLSerwisParametrInfo _lSerUrzParamInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLAtrZrodlo(XLAtrZrodloInfo _lZrodlo, System.Int32? _lAkcja) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentZam(System.Int32? _lDokumentID, XLZamkniecieDokumentuZamInfo _lZamknijDokumentZam) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokumentImp(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLOtwarcieImpNagInfo _lOtworzDokumentImp) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDoSpinacza(System.Int32? _lDokumentID, XLSpiInfo _lSpinacz) { throw new NotImplementedException(); }
        public static System.Int32? XLDolaczDefinicjeParametruDoRodzajuUrzadzeniaSerwis(XLSerwisUrzRodzParInfo _lSerwisUrzRodzParInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentZlc(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentZlcNagInfo _lDokumentZlcNag) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajSubPozycjeMag(System.Int32? _lDokumentID, XLDokumentMagSubElemInfo _lDokumentMagSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijTowar(System.Int32? lTowarID, XLZamkniecieTowaruInfo lZamknijTowar) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunDokumentBO(System.Int32? _lSesjaID, XLUsunBONInfo _lUsunDokumentBO) { throw new NotImplementedException(); }
        public static System.Int32? XLProdGenerujZSRDoPrzestoju(XLProdGenerujZSRDoPrzestoju _GenerujZSR) { throw new NotImplementedException(); }
        public static System.Int32? XLRejestrujUzycieNarzedzia(System.Int32? _lSesjaID, XLProdObiektUzycieInfo _lProdObiektUzycieInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujVat(System.Int32? _lDokumentID, XLVatInfo _gStareDaneVat, XLVatInfo _gNoweDaneVat) { throw new NotImplementedException(); }
        public static System.Int32? XLSprawdzKluczHasp() { throw new NotImplementedException(); }
        public static System.Int32? XLKosztyDodDok(XLKosztDodDokInfo _lKosztDodDok) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyOperator(System.Int32? _lSesjaID, XLOperatorInfo _lOperator) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeImp(System.Int32? _lDokumentID, XLDokumentImpElemInfo _lDokumentImpElem) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajKwotePozycjiBO(System.Int32? _lSesjaID, XLDodajBOSInfo _lDodajKwotePozycjiBO) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzPromocje(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentPrmNagInfo _lNowaPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujPrzegladSerwis(XLModyfikujSerwisPrzegladUrzadzeniaInfo _ModyfikujSerwisPrzegladUrzadzeniaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeOdczytuInw(System.Int32? _lSesjaID, System.Int32? _lOdczytId, XLPozycjaOdczytuInwInfo _lPozycjaOdczytInwInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLProdZmienSubelemPKJ(System.Int32? _sesjaID, XLProdPKJSubelemInfo _PKJSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLZwrocZaznaczeniaUruchomionejFormatki(XLZwrocZaznaczeniaUruchomionejFormatki _GID) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijZlecenieProd(System.Int32? _lSesjaID, XLZlecenieProdZamknijInfo _lZlecProdZamknij) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienPozycjeBO(System.Int32? _lSesjaID, XLZmienBOEInfo _lzmienPozycjeBO) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujParametryUrzadzeniaSerwis(XLModyfikujSerwisParametrInfo _ModyfikujSerwisParametrInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienPromocje(System.Int32? _lSesjaID, XLModyfikacjaPrmInfo _lZmienPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajRejestr(System.Int32? _lSesjaID, XLRejestrInfo _lRejestr) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajVAT(System.Int32? _lDokumentID, XLVatInfo _lVat) { throw new NotImplementedException(); }
        public static System.Int32? XLLogoutEx(XLLogoutInfo _lLogoutInfo, System.Int32? _lSesjaID) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijLinieOpisu(System.Int32? _ID, XLZamknijLinieOpisuInfo _lZamknijLinieOpisu) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijOpis(System.Int32? _ID, XLZamknijOpisInfo _lZamknijOpis) { throw new NotImplementedException(); }
        public static System.Int32? XLKJUsunParametrZObiektu(System.Int32? _sesjaID, XLProdUsunParametrZObiektuInfo _ProdUsunParametrZObiektu) { throw new NotImplementedException(); }
        public static System.Int32? XLZepnijDokumenty(XLDokSpiDokInfo _DokSpi) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajTerminDoCzynnosciProd(System.Int32? _lSesjaID, XLProdTerminCzynnoscInfo _lProdTerminCzynnoscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLWykonajPodanyWydruk(XLWydrukInfo _lWydrukInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLProdGenerujDokumentyDlaObiektow(System.Int32? _lSesjaID, XLProdGenerujDokumentInfo _lProdGenerujDokumentInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajSkladnikSerwis(ref System.Int32? _lDokument, XLSerwisSkladnikInfo _lSerSklInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLSumujDekretZbiorczy(System.Int32? _lSesjaID, XLDekretZbiorczyInfo _lDekretZbiorczy) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeZlc(System.Int32? _lDokumentID, XLDokumentZlcElemInfo _lDokumentZlcElem) { throw new NotImplementedException(); }
        public static System.Int32? XLKsiegujDokument(System.Int32? _lSesjaID, XLKsiegujInfo _lKsiegujInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycje(System.Int32? _lDokumentID, XLDokumentElemInfo _lDokumentElem) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaCzynnoscTechnologia(System.Int32? _lSesjaID, XLProdTechnologiaCzynnoscInfo _lProdTechnologiaCzynnoscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajSubPozycjeSad(System.Int32? _lDokumentID, XLDokumentSadSubElemInfo _lDokumentSadSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzWysylke(System.Int32? _lSesjaID, ref System.Int32? _lDokument, XLOtwarcieNagInfo _lOtwarcieNagInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLAtrWartosc(XLAtrWartoscInfo _lWartosc, System.Int32? _lAkcja) { throw new NotImplementedException(); }
        public static System.Int32? XLPolaczenie(XLPolaczenieInfo _gPolaczenie) { throw new NotImplementedException(); }
        public static System.Int32? XLZrealizujCzynnoscSerwis(System.Int32? _lDokumentId, XLSerwisRealizujCzynnoscInfo _lSerwisRealizujCzynnosc) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaReceptura(System.Int32? _lSesjaID, ref System.Int32? _lRecepturaID, XLRecepturaInfo _lReceptura) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajAneksUML(System.Int32? _lSesjaID, XLDodajULNInfo _lULNInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPlatnosc(System.Int32? _lDokumentID, XLPlatnoscInfo _lPlatnosc) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajZasobDoMag(System.Int32? _lDokumentID, XLDodajZasMagElemInfo _lZasDoMag) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokumentSad(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLOtwarcieSadNagInfo _lOtworzDokumentSad) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunKodJPKV7(System.Int32? _dokumentID, XLJPKV7Info _JPKV7) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokument(System.Int32? lDokumentID, XLZamkniecieDokumentuInfo lZamknijDokument) { throw new NotImplementedException(); }
        public static System.Int32? XLRealizujZlc(System.Int32? _SesjaID, XLRealizacjaZlcInfo _RealizacjaZlc) { throw new NotImplementedException(); }
        public static System.Int32? XLPobierzIloscPZI(XLIloscInfo _gIlosc) { throw new NotImplementedException(); }
        public static System.Int32? XLRozbijKDZ(System.Int32? _lDokument, XLRozbicieKDZInfo _lRozbijKDZ) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajLinieOpisu(System.Int32? _ID, XLDodajLinieOpisuInfo _lDodajLinieOpisu) { throw new NotImplementedException(); }
        public static System.Int32? XLPobierzIloscZdarzen(XLIloscInfo _gIloscZdarzen) { throw new NotImplementedException(); }
        public static System.Int32? XLRozbijIloscNaMagazynyInw(System.Int32? _lSesjaID, XLRozbijIloscNaMagazynyInwInfo _lRozbijIloscNaMag) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijKontrahenta(System.Int32? lKontrahentID, XLZamkniecieKontrahentaInfo lZamknijKontrahenta) { throw new NotImplementedException(); }
        public static System.Int32? XLProdDodajParametrDoObiektu(System.Int32? _sesjaID, XLProdParametrKJObiektuInfo _parametrKJObiektuInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLAtrObiekt(XLAtrObiektInfo _lAtrObiekt, System.Int32? _lAkcja) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzZlecenieSR(System.Int32? _lSesjaID, ref System.Int32? _lDokID, XLOtwarcieDokumentuZlcRemInfo _lOtwarcieDokumentuSR) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokument(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLOtwarcieNagInfo _lOtworzDokument) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunCentrumZPromocji(System.Int32? _lSesjaID, XLFrsPrmInfo _lFrsPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaZgoda(System.Int32? _lSesjaID, ref System.Int32? _lZgodaID, XLZgodaInfo _lZgoda) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDekretSkladowy(System.Int32? _lSesjaID, XLDekretInfo _lDekret) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPrzegladDoUrzadzeniaSerwis(XLSerwisPrzegladUrzadzeniaInfo _SerwisPrzegladUrzadzeniaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyWzorzecKJ(System.Int32? _sesjaID, XLProdWzorzecKJInfo _wzorzecKJInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyObiektFunkcjaProd(System.Int32? _lSesjaID, XLProdObiektFunkcjaInfo _lProdObiektFunkcjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDekretZbiorczy(System.Int32? _lSesjaID, XLDekretZbiorczyInfo _lDekretZbiorczy) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyOkresProd(System.Int32? _lSesjaID, XLProdOkresInfo _lProdOkresInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLKasujDekret(System.Int32? _lSesjaID, XLDekretInfo _lDekret) { throw new NotImplementedException(); }
        public static System.Byte CzyNumerWersjiPoprawny(System.Int32? _lNumerWersji, System.String? _sNazwaFunkcji) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDostawce(System.Int32? _lSesjaID, XLTwDInfo _lDostawca) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujPozycje(System.Int32? _lDokumentID, XLModyfikujElemInfo _lModyfikujElem) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentSad(System.Int32? lDokumentID, XLZamkniecieDokumentuSadInfo lZamknijDokumentSad) { throw new NotImplementedException(); }
        public static System.Int32? XLIlosciNaMagazynachInw(XLIlosciNaMagazynachInwInfo _lIlosciNaMag) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDokumentSRT(System.Int32? _lSesjaID, XLSrtNagInfo _lSrtNagInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienPoleKntSQL(System.Int32? _lSesjaID, XLModyfikacjaKntSQLInfo _lModyfikacjaKntSQL) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaFunkcjaProd(System.Int32? _lSesjaID, XLProdFunkcjaInfo _lProdFunkcjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijWysylke(System.Int32? _lDokument, XLZamkniecieWysylkiInfo _lZamkniecieWysylkiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLProdZmienDaneZabieguNaRealizacji(System.Int32? _SesjaID, XLProdZmienZabiegRealizacjaInfo _ProdZmienZabiegRealizacjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajCzynnoscSerwis(ref System.Int32? _lDokument, XLSerwisCzynnoscInfo _lSerCzynnoscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokumentZlc(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLOtwarcieDokumentuZlcInfo _lOtworzDokumentZlc) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPozycje(System.Int32? _lDokumentID, XLUsunElemInfo _lUsunElem) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajKosztDoWysylki(System.Int32? _lDokument, XLDodajKosztDoWysylkiInfo _lKosztDoWysylkiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajTerminCzynnosciSerwis(ref System.Int32? _lDokument, XLSerwisTerminInfo _lSerTerminInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDekretPojedynczy(System.Int32? _lSesjaID, XLDekretInfo _lDekret) { throw new NotImplementedException(); }
        public static System.Int32? XLGenerujPKJDlaObiektow(System.Int32? _sesjaID, XLProdGenerujPKJInfo _GenerujPKJ) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentNoThreading(System.Int32? lDokumentID, XLZamkniecieDokumentuInfo lZamknijDokument) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzPaczke(System.Int32? _lSesjaID, ref System.Int32? _lDokument, XLOtwarcieNagInfo _lOtwarcieNagInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienNaglowekPKJ(System.Int32? _sesjaID, XLProdZmienPKJNagInfo _zmienPKJNag) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPozycjeMag(System.Int32? _lDokumentID, XLUsunMagElemInfo _lUsunMagElem) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajOsobeKontrahenta(System.Int32? _sesjaID, ref System.Int32? _KnSID, XLOsobaKntInfo _OsobaKnt) { throw new NotImplementedException(); }
        public static System.Int32? XLGenerujRatyUML(System.Int32? _SesjaID, XLGenerujULRInfo _lRataGenerujInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyPracownik(System.Int32? _lSesjaID, ref System.Int32? _lPrcID, XLPracownikInfo _lPracownik) { throw new NotImplementedException(); }
        public static System.Int32? XLNoweUrzadzenieSerwis(XLSerwisUrzadzenieInfo _lSerNoweUrzInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLRozrachuj(System.Int32? _lSesjaID, XLRozrachunekInfo _lRozrachunek) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijPromocje(System.Int32? _lSesjaID, System.Int32? _lDokumentID, XLZamkniecieDokumentuPrmInfo _lPrmZam) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunRateUML(System.Int32? _SesjaID, XLUsunULRInfo _lRataUsunInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentUML(System.Int32? _lSesjaID, XLDodajULNInfo _lULNInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunZeSpinacza(System.Int32? _lDokumentID, XLSpiInfo _lSpinacz) { throw new NotImplementedException(); }
        public static System.Int32? XLDokumentyZwiazane(XLZwiazanyDokInfo _lZwiazanyDok) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienWynikKJDlaParametru(System.Int32? _sesjaID, XLProdZmienWynikKJDlaParametruInfo _zmienWynikKJDlaParametru) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentPKJ(System.Int32? _sesjaID, XLProdPKJNagInfo _PKJNagInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunDokumentZPaczki(System.Int32? _lDokument, XLSpiInfo _lSpiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeSad(System.Int32? _lDokumentID, XLDokumentSadElemInfo _lDokumentSadElem) { throw new NotImplementedException(); }
        public static System.Int32? XLProdZmienPauze(XLProdZmienPauze _ZmienPauze) { throw new NotImplementedException(); }
        public static System.Int32? XLRealizujPozycjeMag(System.Int32? _lDokumentID, XLRealizujPozycjeMagInfo _lRealPozycjeMag) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijRecepture(System.Int32? lRecepturaID, XLZamkniecieRecepturyInfo lZamknijRecepture) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeMag(System.Int32? _lDokumentID, XLDokumentMagElemInfo _lDokumentMagElem) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyCennik(System.Int32? _lSesjaID, ref System.Int32? _lCennikID, XLCennikInfo _lCennik) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeZam(System.Int32? lDokumentID, XLDokumentZamElemInfo _lDokumentZamElem) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPozycjeSad(System.Int32? _lDokumentID, XLUsunSadElemInfo _lUsunSADElem) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunElementZestawuSrt(System.Int32? _lSesjaId, System.Int32? _gSZE2Info) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijRaport(System.Int32? _lSesjaID, System.Int32? _lRaportID, XLRaportInfo _lRaport) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajBon(XLBon _bon) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajSubPozycje(System.Int32? _lDokumentID, XLDokumentSubElemInfo _lDokumentSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeBO(System.Int32? _lSesjaID, XLDodajBOEInfo _lDodajPozycjeBO) { throw new NotImplementedException(); }
        public static System.Int32? XLPobierzNumerPZI(System.Int32? _lNumer, XLGIDInfo _gGID) { throw new NotImplementedException(); }
        public static System.Int32? XLOpisBledu(XLKomunikatInfo _lKomunikatInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujZgode(System.Int32? _sesjaID, XLModyfikujZgodeInfo _modyfikujZgode) { throw new NotImplementedException(); }
        public static System.Int32? XLProdRealizacjaZmianaPZA(System.Int32? _lSesjaID, XLProdZasobRealizacjaInfo _lPZA) { throw new NotImplementedException(); }
        public static System.Int32? XLNowySrt(System.Int32? _lSesjaID, XLSrtInfo _lSrtInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunUrzadzenieZlcSerwis(XLUsunSerwisUrzZlcInfo _UsunSerwisUrzZlcInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPaczkeDoWysylki(System.Int32? _lDokument, XLSpiInfo _lSpiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPozycjeZam(System.Int32? _lDokumentID, XLUsunZamElemInfo _UsunPozycjeZam) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienObiektOperacjiProd(System.Int32? _lSesjaID, XLProdZmienObiektOperacjiInfo _lProdZmienObiektOperacjiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDekretZbiorczy(System.Int32? _lSesjaID, XLDekretZbiorczyInfo _lDekretZbiorczy) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzZlecenieSerwis(System.Int32? _lSesjaID, ref System.Int32? _lDokument, XLOtwarcieSerwisNagInfo _lSerOZInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZablokujDostaweNaPKJ(System.Int32? _sesjaID, XLBlokujDstNaPKJInfo _BlokujDstNaPKJ) { throw new NotImplementedException(); }
        public static System.Int32? XLProdDodajPauze(XLProdDodajPauze _DodajPauze) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajRezerwacje(System.Int32? _lSesjaID, ref System.Int32? _lDokumentId, XLRezNagInfo _lNowaRez) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujPozycjeZam(System.Int32? _lDokumentID, XLDokumentZamElemModInfo _lDokumentZamElemModyf) { throw new NotImplementedException(); }
        public static System.Int32? XLPobierzNumerDokumentu(XLNumerDokumentuInfo _gNumerDok) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeNoty(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, XLPozycjaNotyInfo _lPozycjaNoty) { throw new NotImplementedException(); }
        public static System.Int32? XLPartia(System.Int32? _lSesjaID, XLPartiaInfo _lPartiaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyKontrahent(System.Int32? _lSesjaID, ref System.Int32? _lKontrahentID, XLKontrahentInfo _lKontrahent) { throw new NotImplementedException(); }
        public static System.Int32? XLProdZmienIloscRealizacji(System.Int32? _lSesjaID, XLProdRealizacjaIloscInfo _lProdRealizacjaIloscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujCzescZamiennaSerwis(XLSerwisModyfikujCzescZamiennaInfo _SerwisModyfikujCzescZamienna) { throw new NotImplementedException(); }
        public static System.Int32? XLPobierzZdarzenie(System.Int32? _lNumer, XLZdarzenieInfo _gZdarzenie) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajSkladnikReceptury(ref System.Int32? _lRecepturaID, XLSkladnikRecepturyInfo _lSkladnik) { throw new NotImplementedException(); }
        public static System.Int32? XLPrzeliczRabat(XLRabatyComInfo _gPrzeliczRabat) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPrzedmiotUML(System.Int32? _lSesjaID, XLEdytujULPInfo _lULPInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunDokumentUML(System.Int32? _lSesjaID, XLEdycjaULNInfo _lULNEdycjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyParametrKJ(System.Int32? _sesjaID, XLProdParametrKJInfo _parametrKJInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPrzedmiotUML(System.Int32? _lSesjaID, XLUsunULPInfo _lULPUsunInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienTerminOperacjiProd(System.Int32? _lSesjaID, XLProdTerminCzynnoscInfo _lProdTerminCzynnoscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunSubPozycjeMag(System.Int32? _lDokumentID, XLUsunMagSubElemInfo _lUsunMagSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajRaport(System.Int32? _SesjaID, ref System.Int32? _lRaportID, XLRaportInfo _lRaport) { throw new NotImplementedException(); }
        public static System.Int32? XLAtrNowaKlasa(System.Int32? _lSesjaID, ref System.Int32? _lDokID, XLAtrKlasaNagInfo _lAtrKlasa) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujBon(XLModyfikujBonInfo _ModyfikujBon) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujNaglowek(System.Int32? _lDokumentID, XLModyfikujNaglowekInfo _lModyfikujNag) { throw new NotImplementedException(); }
        public static System.Int32? XLTransakcja(System.Int32? _lSesjaID, XLTransakcjaInfo _lTransakcja) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentMag(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentMagNagInfo _lDokumentMag) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaPromocja(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentPrmNagInfo _lNowaPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajWymiarOpisu(System.Int32? _ID, XLDodajWymiarOpisuInfo _lDodajWymiarOpisu) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunRealizacjeMag(System.Int32? _lDokumentID, System.Int32? _lNumer, System.Int32? _lLp, System.Int32? _lSubLp) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunTowarZPromocji(System.Int32? _lSesjaID, XLTowarPrmInfo _lTowarPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunKontrahentaZPromocji(System.Int32? _lSesjaID, XLKontrahentPrmInfo _lKontrahentPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentUML(System.Int32? _lSesjaID, XLEdycjaULNInfo _lULNEdycjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLProdZakonczPauze(XLProdZakonczPauze _ZakonczPauze) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajZapis(System.Int32? _lSesjaID, System.Int32? _lRaportID, XLZapisKasowyInfo _lZapis) { throw new NotImplementedException(); }
        public static System.Int32? XLLogout(System.Int32? _lSesjaID) { throw new NotImplementedException(); }
        public static System.Int32? XLKasujRozliczenie(System.Int32? _lSesjaID, XLRozliczenieInfo _lRozliczenie) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyRachunek(System.Int32? _sesja, ref System.Int32? _obiekt, XLNowyRachunekInfo _dane) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyAdres(System.Int32? _lSesjaID, ref System.Int32? _lAdresID, XLAdresInfo _lAdres) { throw new NotImplementedException(); }
        public static System.Int32? XLPrzeksztalcSADwPZI(System.Int32? _lSesjaID, XLSad2PziInfo _lSAD2PZI) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajUrzadzenieSerwis(ref System.Int32? _lDokument, XLSerwisUrzWZlcInfo _lSerUrzInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijZlecenieSerwis(ref System.Int32? _lDokument, XLZamkniecieSerwisNagInfo _lSerZZInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentSad(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentSadNagInfo _lDokumentSad) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaFunkcjaCzynnoscTechnologia(System.Int32? _lSesjaID, XLProdTechnologiaFunkcjaInfo _lProdTechnologiaFunkcjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijOdczytInw(System.Int32? _lSesjaID, System.Int32? _lOdczytId, XLZamknijOdczytInwInfo _lZamknijOdczytInwInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLPolaczOperacjePolproduktami(System.Int32? _lSesjaID, XLPolaczOperacjePolproduktamiInfo _lPolaczOperacjePolproduktamiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienStawkeVAT(System.Int32? _lSesjaID, XLZmienStawkeVatInfo _zmienStawkeVAT) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeDokSRT(System.Int32? _lSesjaID, XLSrtElemInfo _lSrtElemInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLSprawdzWersje(ref System.Int32? _lWersja) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajRealizacjeOperacjiProd(System.Int32? _lSesjaID, XLProdRealizacjaInfo _lOperacja) { throw new NotImplementedException(); }
        public static System.Int32? XLProdWykonajZabieg(System.Int32? _lSesjaID, XLProdWykonajZabiegInfo _lProdWykonajZabiegInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLWykonajZapytanie(XLZapytanie _zapytanie) { throw new NotImplementedException(); }
        public static System.Int32? XLLogin(XLLoginInfo _lLoginInfo, ref System.Int32? _lSesjaID) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijCennik(System.Int32? _lCennikID, XLZamkniecieCennikaInfo _lZamknijCennik) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPaczkeZWysylki(System.Int32? _lDokument, XLSpiInfo _lSpiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujPlatnosc(System.Int32? _lDokumentID, XLModyfikujPlatnoscInfo _lModyfikujPlat) { throw new NotImplementedException(); }
        public static System.Int32? XLAtrZrodloObiekt(XLAtrZrdObiektInfo _lZrdOb, System.Int32? _lAkcja) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienHaslo(XLZmianaHaslaInfo _lZmianaHasla) { throw new NotImplementedException(); }
        public static System.Int32? XLZmienAdres(XLAdresInfo _lAdres) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyObiektProd(System.Int32? _lSesjaID, XLProdObiektInfo _lProdObiektInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajOpiekunaDoMag(System.Int32? _lDokumentID, XLDodajOpeMagElemInfo _lOpiekunDoMag) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijRealizacjeMag(System.Int32? _lDokumentID, System.Int32? _lNumer, System.Int32? _lLp) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujTowar(System.Int32? _lSesjaID, XLTowarModyfikacjaInfo _modyfikujTwr) { throw new NotImplementedException(); }
        public static System.Int32? XLObiektyDoGenerowania(XLObiGidsInfo _obiGids) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajZasobDoRezerwacji(System.Int32? _lSesjaID, ref System.Int32? _lDokumentId, XLRezDstInfo _lZasobRez) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaGrupaKnt(System.Int32? _lSesjaID, XLGrupaKntInfo _lGrupaKnt) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentImp(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentImpNagInfo _lDokumentImp) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyZabiegProd(System.Int32? _lSesjaID, XLZabiegInfo _lZabiegInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajCentrumDoPromocji(System.Int32? _lSesjaID, XLFrsPrmInfo _lFrsPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaWysylka(System.Int32? _lSesjaID, ref System.Int32? _lDokument, XLWysylkaInfo _lWysylkaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZmianaKontekstuOperatora(XLZmianaKontekstuOperatora _lZmienKontekst) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijKontrahentaSQL(System.Int32? _lSesjaID, XLModyfikacjaKntSQLInfo _lModyfikacjaKntSQL) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajObiektSerwis(ref System.Int32? _lDokument, XLSerwisObiektInfo _lSerObiektInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajKodJPKV7(System.Int32? _dokumentID, XLJPKV7Info _JPKV7) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijZlecenieSR(System.Int32? _lDokID, XLZamkniecieDokumentuZlcRemInfo _lZamknieteZRN) { throw new NotImplementedException(); }
        public static System.Int32? XLProdObiektyDoDokumentow(XLProdObiektyDoDokumentowInfo _lObiekty) { throw new NotImplementedException(); }
        public static System.Int32? XLModyfikujPozycjeMag(System.Int32? _lDokument, XLModyfikujMagElemInfo _lMagElemInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentMag(System.Int32? lDokumentID, XLZamkniecieDokumentuMagInfo lZamknijDokumentMag) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijDokumentSRT(System.Int32? _lSesjaID, XLSrtNag2Info _lSrtNag2Info) { throw new NotImplementedException(); }
        public static System.Int32? XLProdSpinajZasobyZDokumentami(System.Int32? _lSesjaID, XLProdSpinajDokumentInfo _lProdSpinajDokumentInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLProdObiektyDoPowiazania(XLProdObiektyDoPowiazaniaInfo _lDoZwiazania) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunDokumentSRT(System.Int32? _lSesjaID, XLSrtNag2Info _lSrtNag2Info) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajElementDoZestawuSrt(System.Int32? _lSesjaId, XLSzeInfo _gSzeInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLUruchomFormatkeWgGID(XLGIDGrupaInfo _gGID2GID) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajCzescZamiennaSerwis(XLSerwisDodajCzescZamiennaInfo _SerwisDodajCzescZamienna) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunSubPozycje(System.Int32? _dokumentID, XLUsunSubElemInfo _usunSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLProdDodajZabiegNaRealizacje(System.Int32? _lSesjaID, XLProdNowyZabiegRealizacjaInfo _lProdNowyZabiegRealizacjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyKontrahentSQL(System.Int32? _lSesjaID, XLKontrahentSQLInfo _lKontrahentSQL) { throw new NotImplementedException(); }
        public static System.Int32? XLOdblokujDostaweNaPKJ(System.Int32? _sesjaID, XLOdblokujDstNaPKJInfo _OdblokujDstNaPKJ) { throw new NotImplementedException(); }
        public static System.Int32? XLNoweZlecenieSR(System.Int32? _lSesjaID, ref System.Int32? _lDokID, XLDokumentZlcRemNagInfo _lDokumentSRNag) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunPozycjeImp(System.Int32? _lDokumentID, XLUsunImpElemInfo _lUsunImpElem) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyOpis(System.Int32? _SesjaID, ref System.Int32? _id, XLNowyOpisInfo _lNowyOpis) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunCzescZamiennaSerwis(XLSerwisUsunCzescZamiennaInfo _SerwisUsunCzescZamienna) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijAdres(System.Int32? lAdresID, XLZamkniecieAdresuInfo lZamknijAdres) { throw new NotImplementedException(); }
        public static System.Int32? XLRozliczaj(System.Int32? _lSesjaID, XLGIDParaInfo _lGIDPara, XLRozliczenieInfo _lRozliczenie) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokument(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentNagInfo _lDokumentNag) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajRateUML(System.Int32? _SesjaID, XLEdytujULRInfo _lRataInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowaTechnologia(System.Int32? _lSesjaID, XLProdTechnologiaInfo _lProdTechnologiaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNastepnyRekordZapytania(XLWynikZapytania _wynikZapytania) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokumentMag(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLOtwarcieMagNagInfo _lOtworzDokumentMag) { throw new NotImplementedException(); }
        public static System.Int32? XLNoweZlecenieProd(System.Int32? _lSesjaID, XLZlecenieProdInfo _lZlecProd) { throw new NotImplementedException(); }
        public static System.Int32? XLPrzypiszZasobyDoRezerwacji(XLZasobRezPrzypnijInfo _lPrzypnijRez) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajDokumentDoPaczki(System.Int32? _lDokument, XLSpiInfo _lSpiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentBO(System.Int32? _lSesjaID, XLDodajBONInfo _lNowyDokumentBO) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyTowar(System.Int32? _lSesjaID, ref System.Int32? _lTowarID, XLTowarInfo _lTowar) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajKwoteDodSad(System.Int32? _lDokumentID, XLDokumentSadKwotaDodInfo _lDokumentKwotaDodSad) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajTowarDoPromocji(System.Int32? _lSesjaID, XLTowarPrmInfo _lTowarPrm) { throw new NotImplementedException(); }
        public static System.Int32? XLProdDodajWzorzecKJDoTowaru(System.Int32? _sesjaID, XLProdWzorzecKJTowarInfo _wzorzecKJTowarInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLOtworzDokumentUML(System.Int32? _lSesjaID, XLEdycjaULNInfo _lULNEdycjaInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajStawkeVAT(System.Int32? _lSesjaID, XLStawkaVatInfo _dodajStawkeVat) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajSubPozycjeMap(System.Int32? _lDokumentID, XLDokumentMapSubElemInfo _lDokumentMapSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLGenerujEAN(XLEANInfo _lEAN) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajCene(System.Int32? _lSesjaID, XLCenaInfo _lCena) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajPozycjeDoKolejki(XLDokumentElemInfo _lDokumentElem) { throw new NotImplementedException(); }
        public static System.Int32? XLNowyDokumentZam(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, XLDokumentZamNagInfo _lDokumentZamNag) { throw new NotImplementedException(); }
        public static System.Int32? XLUsunSubPozycjeMap(System.Int32? _lDokumentID, XLUsunMapSubElemInfo _lUsunMapSubElem) { throw new NotImplementedException(); }
        public static System.Int32? XLZamknijNote(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, XLNotaInfo _lNota) { throw new NotImplementedException(); }
        public static System.Int32? XLRejestrujPominiecieOperacji(System.Int32? _sesjaID, XLProdRejestrujPominiecieOperacjiInfo _prodRejestrujPominiecieOperacjiInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLPrzypiszOperacje(System.Int32? _lSesjaID, XLPrzypiszInfo _lPrzypisz) { throw new NotImplementedException(); }
        public static System.Int32? XLDodajObiektDoCzynnosciProd(System.Int32? _lSesjaID, XLProdObiektCzynnoscInfo _lProdObiektCzynnoscInfo) { throw new NotImplementedException(); }
        public static System.Int32? XLProdDodajNormeDoParam(System.Int32? _sesjaID, XLProdParametrKJNormaInfo _parametrKJNormaInfo) { throw new NotImplementedException(); }
    }
    //public class Metody1
    //{
    //    public System.Int32? XLDodajCzynnoscDoProcesuProd(System.Int32? _lSesjaID, cdn_api.XLProdCzynnoscProcesuInfo_20231 _lProdCzynnoscProcesuInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajKontrahentaDoPromocji(System.Int32? _lSesjaID, cdn_api.XLKontrahentPrmInfo_20231 _lKontrahentPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajNote(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, cdn_api.XLNotaInfo_20231 _lNota) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujUrzadzenieSerwis(cdn_api.XLModyfkujSerwisUrzadzenieInfo_20231 _ModyfkujSerwisUrzadzenieInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentImp(System.Int32? lDokumentID, cdn_api.XLZamkniecieDokumentuImpInfo_20231 lZamknijDokumentImp) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujPrzedmiotUML(System.Int32? _lSesjaID, cdn_api.XLEdytujULPInfo_20231 _lULPInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLSprawdzLicencje(cdn_api.XLLicencjaInfo_20231 _lLicencja) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienCene(cdn_api.XLCenaInfo_20231 _lCena) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyOdczytInw(System.Int32? _lSesjaID, ref System.Int32? _lOdczytId, cdn_api.XLOdczytInwInfo_20231 _lOdczytInwInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajAtrybut(System.Int32? _SesjaID, cdn_api.XLAtrybutInfo_20231 _lDodajAtrybut) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunZasobZRezerwacji(System.Int32? _SesjaID, cdn_api.XLZasobRezUsunInfo_20231 _UsunZasobZRez) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentZlc(System.Int32? _lDokumentID, cdn_api.XLZamkniecieDokumentuZlcInfo_20231 _lZamknijDokumentZlc) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijPozycjeBO(System.Int32? _lSesjaID, cdn_api.XLZamknijBOEInfo_20231 _lZamknijPozycjeBO) { throw new NotImplementedException(); }
    //    public System.Int32? XLNoweZlecenieSerwis(System.Int32? _lSesjaID, ref System.Int32? _lDokument, cdn_api.XLSerwisNagInfo_20231 _lSerNZInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzKontrahentaSQL(System.Int32? _lSesjaID, cdn_api.XLModyfikacjaKntSQLInfo_20231 _lModyfikacjaKntSQL) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyRodzajUrzadzeniaSerwis(cdn_api.XLSerwisUrzRodzajInfo_20231 _lSerNoweUrzRodzajInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokumentZam(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLOtwarcieDokumentuZamInfo_20231 _lOtworzDokumentZam) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDoZleceniaProd(System.Int32? _lSesjaID, cdn_api.XLZlecenieProdElemInfo_20231 _lZlecElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajZasobDoCzynnosciProd(System.Int32? _lSesjaID, cdn_api.XLProdZasobCzynnoscInfo_20231 _lProdZasobCzynnoscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeZleceniaSR(System.Int32? _lDokID, cdn_api.XLDokumentZlcRemElemInfo_20231 _lPozycjaZlcRem) { throw new NotImplementedException(); }
    //    public System.Int32? XLAtrSkasujKlase(cdn_api.XLAtrKasujKlaseInfo_20231 _lAtrKasujKlase) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijPaczke(System.Int32? _lDokument, cdn_api.XLZamknieciePaczkiInfo_20231 _lZamknieciePaczkiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLKasujNote(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, cdn_api.XLNotaInfo_20231 _lNota) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPozycjeDokSRT(System.Int32? _lSesjaID, cdn_api.XLSrtElem2Info_20231 _lSrtElem2Info) { throw new NotImplementedException(); }
    //    public System.Int32? XLGenerujUNM(System.Int32? _lSesjaID, System.Int32? _lGenerujUNM) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdAktualizujNrSeryjnyNaDok(System.Int32? _lSesjaID, cdn_api.XLProdAktualizujNrSeryjnyNaDokInfo_20231 _ProdAktualizujNrSeryjnyNaDokInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzOdczytInw(System.Int32? _lSesjaID, ref System.Int32? _lOdczytId, cdn_api.XLOtworzOdczytInwInfo_20231 _lOtworzOdczytInwInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunKosztZWysylki(System.Int32? _lDokument, cdn_api.XLSpiInfo_20231 _lSpiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPlatnoscZam(System.Int32? _lDokumentID, cdn_api.XLDokumentZamPlatInfo_20231 _lDokumantZamPlat) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaPaczka(System.Int32? _lSesjaID, ref System.Int32? _lDokument, cdn_api.XLPaczkaInfo_20231 _lPaczkaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunRezerwacje(System.Int32? _lSesjaID, ref System.Int32? _lDokumentId, cdn_api.XLRezUsunInfo_20231 _lUsunRez) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyZasobCzynnoscTechnologia(System.Int32? _lSesjaID, cdn_api.XLProdTechnologiaZasobInfo_20231 _lProdTechnologiaZasobInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeZKolejki(System.Int32? _lDokumentID) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaGrupaTwr(System.Int32? _lSesjaID, cdn_api.XLGrupaTwrInfo_20231 _lGrupaTwr) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdRedukujIlosciZasobow(cdn_api.XLProdRedukujIlosciZasobow_20231 _RedukujIlosciZasobow) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajParametrUrzadzeniaSerwis(cdn_api.XLSerwisParametrInfo_20231 _lSerUrzParamInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLAtrZrodlo(cdn_api.XLAtrZrodloInfo_20231 _lZrodlo, System.Int32? _lAkcja) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentZam(System.Int32? _lDokumentID, cdn_api.XLZamkniecieDokumentuZamInfo_20231 _lZamknijDokumentZam) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokumentImp(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLOtwarcieImpNagInfo_20231 _lOtworzDokumentImp) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDoSpinacza(System.Int32? _lDokumentID, cdn_api.XLSpiInfo_20231 _lSpinacz) { throw new NotImplementedException(); }
    //    public System.Int32? XLDolaczDefinicjeParametruDoRodzajuUrzadzeniaSerwis(cdn_api.XLSerwisUrzRodzParInfo_20231 _lSerwisUrzRodzParInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentZlc(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentZlcNagInfo_20231 _lDokumentZlcNag) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajSubPozycjeMag(System.Int32? _lDokumentID, cdn_api.XLDokumentMagSubElemInfo_20231 _lDokumentMagSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijTowar(System.Int32? lTowarID, cdn_api.XLZamkniecieTowaruInfo_20231 lZamknijTowar) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunDokumentBO(System.Int32? _lSesjaID, cdn_api.XLUsunBONInfo_20231 _lUsunDokumentBO) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdGenerujZSRDoPrzestoju(cdn_api.XLProdGenerujZSRDoPrzestoju_20231 _GenerujZSR) { throw new NotImplementedException(); }
    //    public System.Int32? XLRejestrujUzycieNarzedzia(System.Int32? _lSesjaID, cdn_api.XLProdObiektUzycieInfo_20231 _lProdObiektUzycieInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujVat(System.Int32? _lDokumentID, cdn_api.XLVatInfo_20231 _gStareDaneVat, cdn_api.XLVatInfo_20231 _gNoweDaneVat) { throw new NotImplementedException(); }
    //    public System.Int32? XLSprawdzKluczHasp() { throw new NotImplementedException(); }
    //    public System.Int32? XLKosztyDodDok(cdn_api.XLKosztDodDokInfo_20231 _lKosztDodDok) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyOperator(System.Int32? _lSesjaID, cdn_api.XLOperatorInfo_20231 _lOperator) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeImp(System.Int32? _lDokumentID, cdn_api.XLDokumentImpElemInfo_20231 _lDokumentImpElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajKwotePozycjiBO(System.Int32? _lSesjaID, cdn_api.XLDodajBOSInfo_20231 _lDodajKwotePozycjiBO) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzPromocje(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentPrmNagInfo_20231 _lNowaPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujPrzegladSerwis(cdn_api.XLModyfikujSerwisPrzegladUrzadzeniaInfo_20231 _ModyfikujSerwisPrzegladUrzadzeniaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeOdczytuInw(System.Int32? _lSesjaID, System.Int32? _lOdczytId, cdn_api.XLPozycjaOdczytuInwInfo_20231 _lPozycjaOdczytInwInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdZmienSubelemPKJ(System.Int32? _sesjaID, cdn_api.XLProdPKJSubelemInfo_20231 _PKJSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLZwrocZaznaczeniaUruchomionejFormatki(cdn_api.XLZwrocZaznaczeniaUruchomionejFormatki_20231 _GID) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijZlecenieProd(System.Int32? _lSesjaID, cdn_api.XLZlecenieProdZamknijInfo_20231 _lZlecProdZamknij) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienPozycjeBO(System.Int32? _lSesjaID, cdn_api.XLZmienBOEInfo_20231 _lzmienPozycjeBO) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujParametryUrzadzeniaSerwis(cdn_api.XLModyfikujSerwisParametrInfo_20231 _ModyfikujSerwisParametrInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienPromocje(System.Int32? _lSesjaID, cdn_api.XLModyfikacjaPrmInfo_20231 _lZmienPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajRejestr(System.Int32? _lSesjaID, cdn_api.XLRejestrInfo_20231 _lRejestr) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajVAT(System.Int32? _lDokumentID, cdn_api.XLVatInfo_20231 _lVat) { throw new NotImplementedException(); }
    //    public System.Int32? XLLogoutEx(cdn_api.XLLogoutInfo_20231 _lLogoutInfo, System.Int32? _lSesjaID) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijLinieOpisu(System.Int32? _ID, cdn_api.XLZamknijLinieOpisuInfo_20231 _lZamknijLinieOpisu) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijOpis(System.Int32? _ID, cdn_api.XLZamknijOpisInfo_20231 _lZamknijOpis) { throw new NotImplementedException(); }
    //    public System.Int32? XLKJUsunParametrZObiektu(System.Int32? _sesjaID, cdn_api.XLProdUsunParametrZObiektuInfo_20231 _ProdUsunParametrZObiektu) { throw new NotImplementedException(); }
    //    public System.Int32? XLZepnijDokumenty(cdn_api.XLDokSpiDokInfo_20231 _DokSpi) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajTerminDoCzynnosciProd(System.Int32? _lSesjaID, cdn_api.XLProdTerminCzynnoscInfo_20231 _lProdTerminCzynnoscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLWykonajPodanyWydruk(cdn_api.XLWydrukInfo_20231 _lWydrukInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdGenerujDokumentyDlaObiektow(System.Int32? _lSesjaID, cdn_api.XLProdGenerujDokumentInfo_20231 _lProdGenerujDokumentInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajSkladnikSerwis(ref System.Int32? _lDokument, cdn_api.XLSerwisSkladnikInfo_20231 _lSerSklInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLSumujDekretZbiorczy(System.Int32? _lSesjaID, cdn_api.XLDekretZbiorczyInfo_20231 _lDekretZbiorczy) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeZlc(System.Int32? _lDokumentID, cdn_api.XLDokumentZlcElemInfo_20231 _lDokumentZlcElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLKsiegujDokument(System.Int32? _lSesjaID, cdn_api.XLKsiegujInfo_20231 _lKsiegujInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycje(System.Int32? _lDokumentID, cdn_api.XLDokumentElemInfo_20231 _lDokumentElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaCzynnoscTechnologia(System.Int32? _lSesjaID, cdn_api.XLProdTechnologiaCzynnoscInfo_20231 _lProdTechnologiaCzynnoscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajSubPozycjeSad(System.Int32? _lDokumentID, cdn_api.XLDokumentSadSubElemInfo_20231 _lDokumentSadSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzWysylke(System.Int32? _lSesjaID, ref System.Int32? _lDokument, cdn_api.XLOtwarcieNagInfo_20231 _lOtwarcieNagInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLAtrWartosc(cdn_api.XLAtrWartoscInfo_20231 _lWartosc, System.Int32? _lAkcja) { throw new NotImplementedException(); }
    //    public System.Int32? XLPolaczenie(cdn_api.XLPolaczenieInfo_20231 _gPolaczenie) { throw new NotImplementedException(); }
    //    public System.Int32? XLZrealizujCzynnoscSerwis(System.Int32? _lDokumentId, cdn_api.XLSerwisRealizujCzynnoscInfo_20231 _lSerwisRealizujCzynnosc) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaReceptura(System.Int32? _lSesjaID, ref System.Int32? _lRecepturaID, cdn_api.XLRecepturaInfo_20231 _lReceptura) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajAneksUML(System.Int32? _lSesjaID, cdn_api.XLDodajULNInfo_20231 _lULNInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPlatnosc(System.Int32? _lDokumentID, cdn_api.XLPlatnoscInfo_20231 _lPlatnosc) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajZasobDoMag(System.Int32? _lDokumentID, cdn_api.XLDodajZasMagElemInfo_20231 _lZasDoMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokumentSad(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLOtwarcieSadNagInfo_20231 _lOtworzDokumentSad) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunKodJPKV7(System.Int32? _dokumentID, cdn_api.XLJPKV7Info_20231 _JPKV7) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokument(System.Int32? lDokumentID, cdn_api.XLZamkniecieDokumentuInfo_20231 lZamknijDokument) { throw new NotImplementedException(); }
    //    public System.Int32? XLRealizujZlc(System.Int32? _SesjaID, cdn_api.XLRealizacjaZlcInfo_20231 _RealizacjaZlc) { throw new NotImplementedException(); }
    //    public System.Int32? XLPobierzIloscPZI(cdn_api.XLIloscInfo_20231 _gIlosc) { throw new NotImplementedException(); }
    //    public System.Int32? XLRozbijKDZ(System.Int32? _lDokument, cdn_api.XLRozbicieKDZInfo_20231 _lRozbijKDZ) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajLinieOpisu(System.Int32? _ID, cdn_api.XLDodajLinieOpisuInfo_20231 _lDodajLinieOpisu) { throw new NotImplementedException(); }
    //    public System.Int32? XLPobierzIloscZdarzen(cdn_api.XLIloscInfo_20231 _gIloscZdarzen) { throw new NotImplementedException(); }
    //    public System.Int32? XLRozbijIloscNaMagazynyInw(System.Int32? _lSesjaID, cdn_api.XLRozbijIloscNaMagazynyInwInfo_20231 _lRozbijIloscNaMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijKontrahenta(System.Int32? lKontrahentID, cdn_api.XLZamkniecieKontrahentaInfo_20231 lZamknijKontrahenta) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdDodajParametrDoObiektu(System.Int32? _sesjaID, cdn_api.XLProdParametrKJObiektuInfo_20231 _parametrKJObiektuInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLAtrObiekt(cdn_api.XLAtrObiektInfo_20231 _lAtrObiekt, System.Int32? _lAkcja) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzZlecenieSR(System.Int32? _lSesjaID, ref System.Int32? _lDokID, cdn_api.XLOtwarcieDokumentuZlcRemInfo_20231 _lOtwarcieDokumentuSR) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokument(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLOtwarcieNagInfo_20231 _lOtworzDokument) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunCentrumZPromocji(System.Int32? _lSesjaID, cdn_api.XLFrsPrmInfo_20231 _lFrsPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaZgoda(System.Int32? _lSesjaID, ref System.Int32? _lZgodaID, cdn_api.XLZgodaInfo_20231 _lZgoda) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDekretSkladowy(System.Int32? _lSesjaID, cdn_api.XLDekretInfo_20231 _lDekret) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPrzegladDoUrzadzeniaSerwis(cdn_api.XLSerwisPrzegladUrzadzeniaInfo_20231 _SerwisPrzegladUrzadzeniaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyWzorzecKJ(System.Int32? _sesjaID, cdn_api.XLProdWzorzecKJInfo_20231 _wzorzecKJInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyObiektFunkcjaProd(System.Int32? _lSesjaID, cdn_api.XLProdObiektFunkcjaInfo_20231 _lProdObiektFunkcjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDekretZbiorczy(System.Int32? _lSesjaID, cdn_api.XLDekretZbiorczyInfo_20231 _lDekretZbiorczy) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyOkresProd(System.Int32? _lSesjaID, cdn_api.XLProdOkresInfo_20231 _lProdOkresInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLKasujDekret(System.Int32? _lSesjaID, cdn_api.XLDekretInfo_20231 _lDekret) { throw new NotImplementedException(); }
    //    public System.Byte CzyNumerWersjiPoprawny(System.Int32? _lNumerWersji, System.String? _sNazwaFunkcji) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDostawce(System.Int32? _lSesjaID, cdn_api.XLTwDInfo_20231 _lDostawca) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujPozycje(System.Int32? _lDokumentID, cdn_api.XLModyfikujElemInfo_20231 _lModyfikujElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentSad(System.Int32? lDokumentID, cdn_api.XLZamkniecieDokumentuSadInfo_20231 lZamknijDokumentSad) { throw new NotImplementedException(); }
    //    public System.Int32? XLIlosciNaMagazynachInw(cdn_api.XLIlosciNaMagazynachInwInfo_20231 _lIlosciNaMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDokumentSRT(System.Int32? _lSesjaID, cdn_api.XLSrtNagInfo_20231 _lSrtNagInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienPoleKntSQL(System.Int32? _lSesjaID, cdn_api.XLModyfikacjaKntSQLInfo_20231 _lModyfikacjaKntSQL) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaFunkcjaProd(System.Int32? _lSesjaID, cdn_api.XLProdFunkcjaInfo_20231 _lProdFunkcjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijWysylke(System.Int32? _lDokument, cdn_api.XLZamkniecieWysylkiInfo_20231 _lZamkniecieWysylkiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdZmienDaneZabieguNaRealizacji(System.Int32? _SesjaID, cdn_api.XLProdZmienZabiegRealizacjaInfo_20231 _ProdZmienZabiegRealizacjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajCzynnoscSerwis(ref System.Int32? _lDokument, cdn_api.XLSerwisCzynnoscInfo_20231 _lSerCzynnoscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokumentZlc(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLOtwarcieDokumentuZlcInfo_20231 _lOtworzDokumentZlc) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPozycje(System.Int32? _lDokumentID, cdn_api.XLUsunElemInfo_20231 _lUsunElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajKosztDoWysylki(System.Int32? _lDokument, cdn_api.XLDodajKosztDoWysylkiInfo_20231 _lKosztDoWysylkiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajTerminCzynnosciSerwis(ref System.Int32? _lDokument, cdn_api.XLSerwisTerminInfo_20231 _lSerTerminInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDekretPojedynczy(System.Int32? _lSesjaID, cdn_api.XLDekretInfo_20231 _lDekret) { throw new NotImplementedException(); }
    //    public System.Int32? XLGenerujPKJDlaObiektow(System.Int32? _sesjaID, cdn_api.XLProdGenerujPKJInfo_20231 _GenerujPKJ) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentNoThreading(System.Int32? lDokumentID, cdn_api.XLZamkniecieDokumentuInfo_20231 lZamknijDokument) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzPaczke(System.Int32? _lSesjaID, ref System.Int32? _lDokument, cdn_api.XLOtwarcieNagInfo_20231 _lOtwarcieNagInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienNaglowekPKJ(System.Int32? _sesjaID, cdn_api.XLProdZmienPKJNagInfo_20231 _zmienPKJNag) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPozycjeMag(System.Int32? _lDokumentID, cdn_api.XLUsunMagElemInfo_20231 _lUsunMagElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajOsobeKontrahenta(System.Int32? _sesjaID, ref System.Int32? _KnSID, cdn_api.XLOsobaKntInfo_20231 _OsobaKnt) { throw new NotImplementedException(); }
    //    public System.Int32? XLGenerujRatyUML(System.Int32? _SesjaID, cdn_api.XLGenerujULRInfo_20231 _lRataGenerujInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyPracownik(System.Int32? _lSesjaID, ref System.Int32? _lPrcID, cdn_api.XLPracownikInfo_20231 _lPracownik) { throw new NotImplementedException(); }
    //    public System.Int32? XLNoweUrzadzenieSerwis(cdn_api.XLSerwisUrzadzenieInfo_20231 _lSerNoweUrzInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLRozrachuj(System.Int32? _lSesjaID, cdn_api.XLRozrachunekInfo_20231 _lRozrachunek) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijPromocje(System.Int32? _lSesjaID, System.Int32? _lDokumentID, cdn_api.XLZamkniecieDokumentuPrmInfo_20231 _lPrmZam) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunRateUML(System.Int32? _SesjaID, cdn_api.XLUsunULRInfo_20231 _lRataUsunInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentUML(System.Int32? _lSesjaID, cdn_api.XLDodajULNInfo_20231 _lULNInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunZeSpinacza(System.Int32? _lDokumentID, cdn_api.XLSpiInfo_20231 _lSpinacz) { throw new NotImplementedException(); }
    //    public System.Int32? XLDokumentyZwiazane(cdn_api.XLZwiazanyDokInfo_20231 _lZwiazanyDok) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienWynikKJDlaParametru(System.Int32? _sesjaID, cdn_api.XLProdZmienWynikKJDlaParametruInfo_20231 _zmienWynikKJDlaParametru) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentPKJ(System.Int32? _sesjaID, cdn_api.XLProdPKJNagInfo_20231 _PKJNagInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunDokumentZPaczki(System.Int32? _lDokument, cdn_api.XLSpiInfo_20231 _lSpiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeSad(System.Int32? _lDokumentID, cdn_api.XLDokumentSadElemInfo_20231 _lDokumentSadElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdZmienPauze(cdn_api.XLProdZmienPauze_20231 _ZmienPauze) { throw new NotImplementedException(); }
    //    public System.Int32? XLRealizujPozycjeMag(System.Int32? _lDokumentID, cdn_api.XLRealizujPozycjeMagInfo_20231 _lRealPozycjeMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijRecepture(System.Int32? lRecepturaID, cdn_api.XLZamkniecieRecepturyInfo_20231 lZamknijRecepture) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeMag(System.Int32? _lDokumentID, cdn_api.XLDokumentMagElemInfo_20231 _lDokumentMagElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyCennik(System.Int32? _lSesjaID, ref System.Int32? _lCennikID, cdn_api.XLCennikInfo_20231 _lCennik) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeZam(System.Int32? lDokumentID, cdn_api.XLDokumentZamElemInfo_20231 _lDokumentZamElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPozycjeSad(System.Int32? _lDokumentID, cdn_api.XLUsunSadElemInfo_20231 _lUsunSADElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunElementZestawuSrt(System.Int32? _lSesjaId, System.Int32? _gSZE2Info) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijRaport(System.Int32? _lSesjaID, System.Int32? _lRaportID, cdn_api.XLRaportInfo_20231 _lRaport) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajBon(cdn_api.XLBon_20231 _bon) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajSubPozycje(System.Int32? _lDokumentID, cdn_api.XLDokumentSubElemInfo_20231 _lDokumentSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeBO(System.Int32? _lSesjaID, cdn_api.XLDodajBOEInfo_20231 _lDodajPozycjeBO) { throw new NotImplementedException(); }
    //    public System.Int32? XLPobierzNumerPZI(System.Int32? _lNumer, cdn_api.XLGIDInfo_20231 _gGID) { throw new NotImplementedException(); }
    //    public System.Int32? XLOpisBledu(cdn_api.XLKomunikatInfo_20231 _lKomunikatInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujZgode(System.Int32? _sesjaID, cdn_api.XLModyfikujZgodeInfo_20231 _modyfikujZgode) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdRealizacjaZmianaPZA(System.Int32? _lSesjaID, cdn_api.XLProdZasobRealizacjaInfo_20231 _lPZA) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowySrt(System.Int32? _lSesjaID, cdn_api.XLSrtInfo_20231 _lSrtInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunUrzadzenieZlcSerwis(cdn_api.XLUsunSerwisUrzZlcInfo_20231 _UsunSerwisUrzZlcInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPaczkeDoWysylki(System.Int32? _lDokument, cdn_api.XLSpiInfo_20231 _lSpiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPozycjeZam(System.Int32? _lDokumentID, cdn_api.XLUsunZamElemInfo_20231 _UsunPozycjeZam) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienObiektOperacjiProd(System.Int32? _lSesjaID, cdn_api.XLProdZmienObiektOperacjiInfo_20231 _lProdZmienObiektOperacjiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDekretZbiorczy(System.Int32? _lSesjaID, cdn_api.XLDekretZbiorczyInfo_20231 _lDekretZbiorczy) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzZlecenieSerwis(System.Int32? _lSesjaID, ref System.Int32? _lDokument, cdn_api.XLOtwarcieSerwisNagInfo_20231 _lSerOZInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZablokujDostaweNaPKJ(System.Int32? _sesjaID, cdn_api.XLBlokujDstNaPKJInfo_20231 _BlokujDstNaPKJ) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdDodajPauze(cdn_api.XLProdDodajPauze_20231 _DodajPauze) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajRezerwacje(System.Int32? _lSesjaID, ref System.Int32? _lDokumentId, cdn_api.XLRezNagInfo_20231 _lNowaRez) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujPozycjeZam(System.Int32? _lDokumentID, cdn_api.XLDokumentZamElemModInfo_20231 _lDokumentZamElemModyf) { throw new NotImplementedException(); }
    //    public System.Int32? XLPobierzNumerDokumentu(cdn_api.XLNumerDokumentuInfo_20231 _gNumerDok) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeNoty(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, cdn_api.XLPozycjaNotyInfo_20231 _lPozycjaNoty) { throw new NotImplementedException(); }
    //    public System.Int32? XLPartia(System.Int32? _lSesjaID, cdn_api.XLPartiaInfo_20231 _lPartiaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyKontrahent(System.Int32? _lSesjaID, ref System.Int32? _lKontrahentID, cdn_api.XLKontrahentInfo_20231 _lKontrahent) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdZmienIloscRealizacji(System.Int32? _lSesjaID, cdn_api.XLProdRealizacjaIloscInfo_20231 _lProdRealizacjaIloscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujCzescZamiennaSerwis(cdn_api.XLSerwisModyfikujCzescZamiennaInfo_20231 _SerwisModyfikujCzescZamienna) { throw new NotImplementedException(); }
    //    public System.Int32? XLPobierzZdarzenie(System.Int32? _lNumer, cdn_api.XLZdarzenieInfo_20231 _gZdarzenie) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajSkladnikReceptury(ref System.Int32? _lRecepturaID, cdn_api.XLSkladnikRecepturyInfo_20231 _lSkladnik) { throw new NotImplementedException(); }
    //    public System.Int32? XLPrzeliczRabat(cdn_api.XLRabatyComInfo_20231 _gPrzeliczRabat) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPrzedmiotUML(System.Int32? _lSesjaID, cdn_api.XLEdytujULPInfo_20231 _lULPInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunDokumentUML(System.Int32? _lSesjaID, cdn_api.XLEdycjaULNInfo_20231 _lULNEdycjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyParametrKJ(System.Int32? _sesjaID, cdn_api.XLProdParametrKJInfo_20231 _parametrKJInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPrzedmiotUML(System.Int32? _lSesjaID, cdn_api.XLUsunULPInfo_20231 _lULPUsunInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienTerminOperacjiProd(System.Int32? _lSesjaID, cdn_api.XLProdTerminCzynnoscInfo_20231 _lProdTerminCzynnoscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunSubPozycjeMag(System.Int32? _lDokumentID, cdn_api.XLUsunMagSubElemInfo_20231 _lUsunMagSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajRaport(System.Int32? _SesjaID, ref System.Int32? _lRaportID, cdn_api.XLRaportInfo_20231 _lRaport) { throw new NotImplementedException(); }
    //    public System.Int32? XLAtrNowaKlasa(System.Int32? _lSesjaID, ref System.Int32? _lDokID, cdn_api.XLAtrKlasaNagInfo_20231 _lAtrKlasa) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujBon(cdn_api.XLModyfikujBonInfo_20231 _ModyfikujBon) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujNaglowek(System.Int32? _lDokumentID, cdn_api.XLModyfikujNaglowekInfo_20231 _lModyfikujNag) { throw new NotImplementedException(); }
    //    public System.Int32? XLTransakcja(System.Int32? _lSesjaID, cdn_api.XLTransakcjaInfo_20231 _lTransakcja) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentMag(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentMagNagInfo_20231 _lDokumentMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaPromocja(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentPrmNagInfo_20231 _lNowaPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajWymiarOpisu(System.Int32? _ID, cdn_api.XLDodajWymiarOpisuInfo_20231 _lDodajWymiarOpisu) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunRealizacjeMag(System.Int32? _lDokumentID, System.Int32? _lNumer, System.Int32? _lLp, System.Int32? _lSubLp) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunTowarZPromocji(System.Int32? _lSesjaID, cdn_api.XLTowarPrmInfo_20231 _lTowarPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunKontrahentaZPromocji(System.Int32? _lSesjaID, cdn_api.XLKontrahentPrmInfo_20231 _lKontrahentPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentUML(System.Int32? _lSesjaID, cdn_api.XLEdycjaULNInfo_20231 _lULNEdycjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdZakonczPauze(cdn_api.XLProdZakonczPauze_20231 _ZakonczPauze) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajZapis(System.Int32? _lSesjaID, System.Int32? _lRaportID, cdn_api.XLZapisKasowyInfo_20231 _lZapis) { throw new NotImplementedException(); }
    //    public System.Int32? XLLogout(System.Int32? _lSesjaID) { throw new NotImplementedException(); }
    //    public System.Int32? XLKasujRozliczenie(System.Int32? _lSesjaID, cdn_api.XLRozliczenieInfo_20231 _lRozliczenie) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyRachunek(System.Int32? _sesja, ref System.Int32? _obiekt, cdn_api.XLNowyRachunekInfo_20231 _dane) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyAdres(System.Int32? _lSesjaID, ref System.Int32? _lAdresID, cdn_api.XLAdresInfo_20231 _lAdres) { throw new NotImplementedException(); }
    //    public System.Int32? XLPrzeksztalcSADwPZI(System.Int32? _lSesjaID, cdn_api.XLSad2PziInfo_20231 _lSAD2PZI) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajUrzadzenieSerwis(ref System.Int32? _lDokument, cdn_api.XLSerwisUrzWZlcInfo_20231 _lSerUrzInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijZlecenieSerwis(ref System.Int32? _lDokument, cdn_api.XLZamkniecieSerwisNagInfo_20231 _lSerZZInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentSad(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentSadNagInfo_20231 _lDokumentSad) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaFunkcjaCzynnoscTechnologia(System.Int32? _lSesjaID, cdn_api.XLProdTechnologiaFunkcjaInfo_20231 _lProdTechnologiaFunkcjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijOdczytInw(System.Int32? _lSesjaID, System.Int32? _lOdczytId, cdn_api.XLZamknijOdczytInwInfo_20231 _lZamknijOdczytInwInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLPolaczOperacjePolproduktami(System.Int32? _lSesjaID, cdn_api.XLPolaczOperacjePolproduktamiInfo_20231 _lPolaczOperacjePolproduktamiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienStawkeVAT(System.Int32? _lSesjaID, cdn_api.XLZmienStawkeVatInfo_20231 _zmienStawkeVAT) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeDokSRT(System.Int32? _lSesjaID, cdn_api.XLSrtElemInfo_20231 _lSrtElemInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLSprawdzWersje(ref System.Int32? _lWersja) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajRealizacjeOperacjiProd(System.Int32? _lSesjaID, cdn_api.XLProdRealizacjaInfo_20231 _lOperacja) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdWykonajZabieg(System.Int32? _lSesjaID, cdn_api.XLProdWykonajZabiegInfo_20231 _lProdWykonajZabiegInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLWykonajZapytanie(cdn_api.XLZapytanie_20231 _zapytanie) { throw new NotImplementedException(); }
    //    public System.Int32? XLLogin(cdn_api.XLLoginInfo_20231 _lLoginInfo, ref System.Int32? _lSesjaID) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijCennik(System.Int32? _lCennikID, cdn_api.XLZamkniecieCennikaInfo_20231 _lZamknijCennik) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPaczkeZWysylki(System.Int32? _lDokument, cdn_api.XLSpiInfo_20231 _lSpiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujPlatnosc(System.Int32? _lDokumentID, cdn_api.XLModyfikujPlatnoscInfo_20231 _lModyfikujPlat) { throw new NotImplementedException(); }
    //    public System.Int32? XLAtrZrodloObiekt(cdn_api.XLAtrZrdObiektInfo_20231 _lZrdOb, System.Int32? _lAkcja) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienHaslo(cdn_api.XLZmianaHaslaInfo_20231 _lZmianaHasla) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmienAdres(cdn_api.XLAdresInfo_20231 _lAdres) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyObiektProd(System.Int32? _lSesjaID, cdn_api.XLProdObiektInfo_20231 _lProdObiektInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajOpiekunaDoMag(System.Int32? _lDokumentID, cdn_api.XLDodajOpeMagElemInfo_20231 _lOpiekunDoMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijRealizacjeMag(System.Int32? _lDokumentID, System.Int32? _lNumer, System.Int32? _lLp) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujTowar(System.Int32? _lSesjaID, cdn_api.XLTowarModyfikacjaInfo_20231 _modyfikujTwr) { throw new NotImplementedException(); }
    //    public System.Int32? XLObiektyDoGenerowania(cdn_api.XLObiGidsInfo_20231 _obiGids) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajZasobDoRezerwacji(System.Int32? _lSesjaID, ref System.Int32? _lDokumentId, cdn_api.XLRezDstInfo_20231 _lZasobRez) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaGrupaKnt(System.Int32? _lSesjaID, cdn_api.XLGrupaKntInfo_20231 _lGrupaKnt) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentImp(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentImpNagInfo_20231 _lDokumentImp) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyZabiegProd(System.Int32? _lSesjaID, cdn_api.XLZabiegInfo_20231 _lZabiegInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajCentrumDoPromocji(System.Int32? _lSesjaID, cdn_api.XLFrsPrmInfo_20231 _lFrsPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaWysylka(System.Int32? _lSesjaID, ref System.Int32? _lDokument, cdn_api.XLWysylkaInfo_20231 _lWysylkaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZmianaKontekstuOperatora(cdn_api.XLZmianaKontekstuOperatora_20231 _lZmienKontekst) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijKontrahentaSQL(System.Int32? _lSesjaID, cdn_api.XLModyfikacjaKntSQLInfo_20231 _lModyfikacjaKntSQL) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajObiektSerwis(ref System.Int32? _lDokument, cdn_api.XLSerwisObiektInfo_20231 _lSerObiektInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajKodJPKV7(System.Int32? _dokumentID, cdn_api.XLJPKV7Info_20231 _JPKV7) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijZlecenieSR(System.Int32? _lDokID, cdn_api.XLZamkniecieDokumentuZlcRemInfo_20231 _lZamknieteZRN) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdObiektyDoDokumentow(cdn_api.XLProdObiektyDoDokumentowInfo_20231 _lObiekty) { throw new NotImplementedException(); }
    //    public System.Int32? XLModyfikujPozycjeMag(System.Int32? _lDokument, cdn_api.XLModyfikujMagElemInfo_20231 _lMagElemInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentMag(System.Int32? lDokumentID, cdn_api.XLZamkniecieDokumentuMagInfo_20231 lZamknijDokumentMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijDokumentSRT(System.Int32? _lSesjaID, cdn_api.XLSrtNag2Info_20231 _lSrtNag2Info) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdSpinajZasobyZDokumentami(System.Int32? _lSesjaID, cdn_api.XLProdSpinajDokumentInfo_20231 _lProdSpinajDokumentInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdObiektyDoPowiazania(cdn_api.XLProdObiektyDoPowiazaniaInfo_20231 _lDoZwiazania) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunDokumentSRT(System.Int32? _lSesjaID, cdn_api.XLSrtNag2Info_20231 _lSrtNag2Info) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajElementDoZestawuSrt(System.Int32? _lSesjaId, cdn_api.XLSzeInfo_20231 _gSzeInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLUruchomFormatkeWgGID(cdn_api.XLGIDGrupaInfo_20231 _gGID2GID) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajCzescZamiennaSerwis(cdn_api.XLSerwisDodajCzescZamiennaInfo_20231 _SerwisDodajCzescZamienna) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunSubPozycje(System.Int32? _dokumentID, cdn_api.XLUsunSubElemInfo_20231 _usunSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdDodajZabiegNaRealizacje(System.Int32? _lSesjaID, cdn_api.XLProdNowyZabiegRealizacjaInfo_20231 _lProdNowyZabiegRealizacjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyKontrahentSQL(System.Int32? _lSesjaID, cdn_api.XLKontrahentSQLInfo_20231 _lKontrahentSQL) { throw new NotImplementedException(); }
    //    public System.Int32? XLOdblokujDostaweNaPKJ(System.Int32? _sesjaID, cdn_api.XLOdblokujDstNaPKJInfo_20231 _OdblokujDstNaPKJ) { throw new NotImplementedException(); }
    //    public System.Int32? XLNoweZlecenieSR(System.Int32? _lSesjaID, ref System.Int32? _lDokID, cdn_api.XLDokumentZlcRemNagInfo_20231 _lDokumentSRNag) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunPozycjeImp(System.Int32? _lDokumentID, cdn_api.XLUsunImpElemInfo_20231 _lUsunImpElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyOpis(System.Int32? _SesjaID, ref System.Int32? _id, cdn_api.XLNowyOpisInfo_20231 _lNowyOpis) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunCzescZamiennaSerwis(cdn_api.XLSerwisUsunCzescZamiennaInfo_20231 _SerwisUsunCzescZamienna) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijAdres(System.Int32? lAdresID, cdn_api.XLZamkniecieAdresuInfo_20231 lZamknijAdres) { throw new NotImplementedException(); }
    //    public System.Int32? XLRozliczaj(System.Int32? _lSesjaID, cdn_api.XLGIDParaInfo_20231 _lGIDPara, cdn_api.XLRozliczenieInfo_20231 _lRozliczenie) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokument(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentNagInfo_20231 _lDokumentNag) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajRateUML(System.Int32? _SesjaID, cdn_api.XLEdytujULRInfo_20231 _lRataInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowaTechnologia(System.Int32? _lSesjaID, cdn_api.XLProdTechnologiaInfo_20231 _lProdTechnologiaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNastepnyRekordZapytania(cdn_api.XLWynikZapytania_20231 _wynikZapytania) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokumentMag(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLOtwarcieMagNagInfo_20231 _lOtworzDokumentMag) { throw new NotImplementedException(); }
    //    public System.Int32? XLNoweZlecenieProd(System.Int32? _lSesjaID, cdn_api.XLZlecenieProdInfo_20231 _lZlecProd) { throw new NotImplementedException(); }
    //    public System.Int32? XLPrzypiszZasobyDoRezerwacji(cdn_api.XLZasobRezPrzypnijInfo_20231 _lPrzypnijRez) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajDokumentDoPaczki(System.Int32? _lDokument, cdn_api.XLSpiInfo_20231 _lSpiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentBO(System.Int32? _lSesjaID, cdn_api.XLDodajBONInfo_20231 _lNowyDokumentBO) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyTowar(System.Int32? _lSesjaID, ref System.Int32? _lTowarID, cdn_api.XLTowarInfo_20231 _lTowar) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajKwoteDodSad(System.Int32? _lDokumentID, cdn_api.XLDokumentSadKwotaDodInfo_20231 _lDokumentKwotaDodSad) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajTowarDoPromocji(System.Int32? _lSesjaID, cdn_api.XLTowarPrmInfo_20231 _lTowarPrm) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdDodajWzorzecKJDoTowaru(System.Int32? _sesjaID, cdn_api.XLProdWzorzecKJTowarInfo_20231 _wzorzecKJTowarInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLOtworzDokumentUML(System.Int32? _lSesjaID, cdn_api.XLEdycjaULNInfo_20231 _lULNEdycjaInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajStawkeVAT(System.Int32? _lSesjaID, cdn_api.XLStawkaVatInfo_20231 _dodajStawkeVat) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajSubPozycjeMap(System.Int32? _lDokumentID, cdn_api.XLDokumentMapSubElemInfo_20231 _lDokumentMapSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLGenerujEAN(cdn_api.XLEANInfo_20231 _lEAN) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajCene(System.Int32? _lSesjaID, cdn_api.XLCenaInfo_20231 _lCena) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajPozycjeDoKolejki(cdn_api.XLDokumentElemInfo_20231 _lDokumentElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLNowyDokumentZam(System.Int32? _lSesjaID, ref System.Int32? _lDokumentID, cdn_api.XLDokumentZamNagInfo_20231 _lDokumentZamNag) { throw new NotImplementedException(); }
    //    public System.Int32? XLUsunSubPozycjeMap(System.Int32? _lDokumentID, cdn_api.XLUsunMapSubElemInfo_20231 _lUsunMapSubElem) { throw new NotImplementedException(); }
    //    public System.Int32? XLZamknijNote(System.Int32? _lSesjaID, ref System.Int32? _lNotaID, cdn_api.XLNotaInfo_20231 _lNota) { throw new NotImplementedException(); }
    //    public System.Int32? XLRejestrujPominiecieOperacji(System.Int32? _sesjaID, cdn_api.XLProdRejestrujPominiecieOperacjiInfo_20231 _prodRejestrujPominiecieOperacjiInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLPrzypiszOperacje(System.Int32? _lSesjaID, cdn_api.XLPrzypiszInfo_20231 _lPrzypisz) { throw new NotImplementedException(); }
    //    public System.Int32? XLDodajObiektDoCzynnosciProd(System.Int32? _lSesjaID, cdn_api.XLProdObiektCzynnoscInfo_20231 _lProdObiektCzynnoscInfo) { throw new NotImplementedException(); }
    //    public System.Int32? XLProdDodajNormeDoParam(System.Int32? _sesjaID, cdn_api.XLProdParametrKJNormaInfo_20231 _parametrKJNormaInfo) { throw new NotImplementedException(); }
    //}
}