using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
{
    public class TradingDocs : Request
    {
        public TradingDocs()
        {
            Json = new List<XLDokumentNagInfo>();
        }
        public new List<XLDokumentNagInfo> Json { get; set; }

        public List<XLDokumentNagInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLDokumentNagInfo>>(base.Json) ?? new List<XLDokumentNagInfo>();
                }
            }
            catch
            {
                // Debug.WriteLine("GetContractors Exception");
            }

            return Json;
        }

        public async override Task<OutputMessage?> SendData() => await base.SendData(this);


        public override void SerializeToOutputMessage(List<object> list)
        {
            foreach (var item in Json)
            {
                list.Add(item.JsonSerializeResult());
            }
        }

        public override void StartXlOperations()
        {
            XLMainController.AddDocuments(Json, Guid);
        }
    }

}
