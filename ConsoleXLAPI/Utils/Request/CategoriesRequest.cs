using ConsoleXLAPI.Models;
using ConsoleXLAPI.StaticController;

namespace ConsoleXLAPI.Utils.Request
{
    public class CategoriesRequest : Request
    {
        public CategoriesRequest()
        {
            Json = new List<XLGrupaTwrInfo>();
        }
        public new List<XLGrupaTwrInfo> Json { get; set; }

        public List<XLGrupaTwrInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLGrupaTwrInfo>>(base.Json) ?? new List<XLGrupaTwrInfo>();
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
            XLMainController.AddCategories(Json, Guid);
        }
    }


}
