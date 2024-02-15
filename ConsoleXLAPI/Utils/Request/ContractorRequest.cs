using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
{
    public class ContractorRequest : Request
    {
        public ContractorRequest()
        {
            Json = new List<XLKontrahentInfo>();
        }
        public new List<XLKontrahentInfo> Json { get; set; }

        public List<XLKontrahentInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLKontrahentInfo>>(base.Json) ?? new List<XLKontrahentInfo>();
                }
            }
            catch
            {
                // Debug.WriteLine("GetContractors Exception");
            }

            return Json;
        }

        public override void StartXlOperations()
        {
            XLMainController.AddContractors(Json, Guid);
        }


        public override void SerializeToOutputMessage(List<object> list)
        {
            foreach (var item in Json)
            {
                list.Add(item.JsonSerializeResult());
            }
        }

        public async override Task<OutputMessage?> SendData() => await base.SendData(this);

    }
}
