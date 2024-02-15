using System.Threading.Tasks;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.XLControllers
{
    public abstract class XLBaseController
    {
        //public XLBaseController(ZarzadcaBazy zb, XLAbstractService xLAbstractService)

        public XLBaseController()
        {

        }

        public Task<OutputMessage> Message(string message, string methodName)
        {

            return OutputMessage.ResultOk(message, methodName);
        }
    }
}