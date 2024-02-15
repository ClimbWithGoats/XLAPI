using ConsoleXLAPI.Models;

namespace ConsoleXLAPI.XLControllers
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