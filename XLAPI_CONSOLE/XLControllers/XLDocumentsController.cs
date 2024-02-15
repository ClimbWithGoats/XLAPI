using System.Collections.Generic;
using System.Threading.Tasks;
using XLAPI_CONSOLE.Interfaces;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.XLControllers
{
    // XL kontroller dla kontrahentów
    public class XLDocumentsController : XLBaseController
    {

        //public XLDocumentsController(ZarzadcaBazy zb, XLAbstractService xl) : base (zb, xl)
        public IDocumentsRepository DocumentsRepository { get; set; }

        public XLDocumentsController(IDocumentsRepository DocumentsRepository) : base()
        {
            this.DocumentsRepository = DocumentsRepository;
        }
        public Task<List<XLDokumentZamNagInfo>> GetOrderDocuments()
        {
            return Task.FromResult(new List<XLDokumentZamNagInfo>());
        }
    }
}

