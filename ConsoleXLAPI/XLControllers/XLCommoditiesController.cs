using ConsoleXLAPI.Interfaces;

namespace ConsoleXLAPI.XLControllers
{
    // Kontroler XL dla towarów
    public class XLCommoditiesController : XLBaseController
    {
        ICommoditiesRepository _repository { get; set; }
        public XLCommoditiesController(Interfaces.ICommoditiesRepository commoditiesRepository) : base()
        {
            _repository = commoditiesRepository;
        }

        internal Task AdditionalInformation()
        {
            throw new NotImplementedException();
        }
    }
}

