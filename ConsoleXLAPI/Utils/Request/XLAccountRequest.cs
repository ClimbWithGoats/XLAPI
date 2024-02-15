using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
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

        public async override Task<OutputMessage?> SendData() => await base.SendData(this);
    }
}


