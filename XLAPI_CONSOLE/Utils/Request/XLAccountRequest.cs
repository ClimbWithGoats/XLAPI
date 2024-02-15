using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;

namespace XLAPI_CONSOLE.Utils.Request
{
    public class XLAccountRequest : Request
    {
        public XLLoginInfo XLLogin { get; set; }

        public XLAccountRequest()
        {
            XLLogin = new XLLoginInfo();
        }
        public override void StartXlOperations()
        {
            XLMainController.CreateLoginObjectAndLogin(XLLogin);
        }


        public override void SerializeToOutputMessage(List<object> list)
        {
            list.Clear();
        }
    }
}


