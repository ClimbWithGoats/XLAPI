using ConsoleXLAPI.Models;

namespace ConsoleXLAPI.Utils.Request
{
    public class SADDocs : Request
    {
        public SADDocs()
        {
            Json = new List<XLDokumentSadNagInfo>();
        }
        public new List<XLDokumentSadNagInfo> Json { get; set; }

        public List<XLDokumentSadNagInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLDokumentSadNagInfo>>(base.Json) ?? new List<XLDokumentSadNagInfo>();
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

        }
    }

}
