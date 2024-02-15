using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
{
    public class OrderDocs : Request
    {
        public OrderDocs()
        {
            Json = new List<XLDokumentZamNagInfo>();
        }
        public new List<XLDokumentZamNagInfo> Json { get; set; }

        public List<XLDokumentZamNagInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLDokumentZamNagInfo>>(base.Json) ?? new List<XLDokumentZamNagInfo>();
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
