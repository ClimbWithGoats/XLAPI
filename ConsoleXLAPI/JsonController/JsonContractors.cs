using ConsoleXLAPI.XLControllers;

namespace ConsoleXLAPI.JsonController
{
    public class JsonContractors
    {
        private XLContractorsController _xLContractorsController { get; set; }

        public JsonContractors(XLContractorsController xLContractors)
        {
            _xLContractorsController = xLContractors;
        }
        public void SerializeContractors()
        {
        }

        public void DeserializeContractors()
        {
        }
    }

}
