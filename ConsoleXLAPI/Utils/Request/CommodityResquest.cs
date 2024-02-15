using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
{
    public class CommodityResquest : Request
    {
        public CommodityResquest()
        {
            Json = new List<XLTowarInfo>();
        }
        public new List<XLTowarInfo> Json { get; set; }

        public List<XLTowarInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLTowarInfo>>(base.Json) ?? new List<XLTowarInfo>();
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
            XLMainController.AddCommodities(Json, Guid);
        }
    }


}
