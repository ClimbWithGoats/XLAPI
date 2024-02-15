using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
{
    public class ContractorSQLRequest : Request
    {
        public ContractorSQLRequest()
        {
            Json = new List<XLKontrahentSQLInfo>();
        }
        public new List<XLKontrahentSQLInfo> Json { get; set; }

        public List<XLKontrahentSQLInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLKontrahentSQLInfo>>(base.Json) ?? new List<XLKontrahentSQLInfo>();
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
            XLMainController.AddContractorsSQL(Json, Guid);
        }
    }
}
