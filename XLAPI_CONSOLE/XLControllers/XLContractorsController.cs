using System.Threading.Tasks;
namespace XLAPI_CONSOLE.XLControllers
{
    // XL kontroller dla kontrahentów
    public class XLContractorsController : XLBaseController
    {

        //public XLContractorsController(ZarzadcaBazy zb, XLAbstractService xl) : base (zb, xl)


        public XLContractorsController() : base()
        {

        }

        internal Task AdditionalInformation()
        {
            return Task.CompletedTask;
        }
    }
}

