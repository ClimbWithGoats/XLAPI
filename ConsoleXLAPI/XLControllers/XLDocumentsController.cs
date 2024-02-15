using ConsoleXLAPI.Interfaces;
using ConsoleXLAPI.Models;

namespace ConsoleXLAPI.XLControllers
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

