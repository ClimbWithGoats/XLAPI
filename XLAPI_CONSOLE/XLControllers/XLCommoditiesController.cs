using System;
using System.Threading.Tasks;
using XLAPI_CONSOLE.Interfaces;

namespace XLAPI_CONSOLE.XLControllers
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

