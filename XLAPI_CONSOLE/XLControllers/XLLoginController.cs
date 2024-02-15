using XLAPI_CONSOLE.Interfaces;


namespace XLAPI_CONSOLE.XLControllers
{
    // Kontroller XL dla kategorii
    public partial class XLLoginController : XLBaseController
    {
        //public XLLoginController(ZarzadcaBazy zb, XLAbstractService xl) : base(zb, xl)
        ILoginRepository LoginRepository { get; set; }
        public XLLoginController(ILoginRepository loginRepository) : base()
        {
            //_mediator = mediator;
            //_mediator.Register("CreateLoginObjectAndLogin", HandleMessage);
            LoginRepository = loginRepository;

        }
        //private readonly Mediator _mediator;
        //private void HandleMessage(object data)
        //{

        //    if (data != null)
        //    {
        //        CreateLoginObjectAndLogin((int)data);

        //        // Zarejestruj obsługę wiadomości w mediatorze


        //    }
        //}


    }
}