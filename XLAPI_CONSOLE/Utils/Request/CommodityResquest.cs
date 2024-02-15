using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;

namespace XLAPI_CONSOLE.Utils.Request
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
                Console.WriteLine("GetContractors Exception");
            }

            return Json;
        }
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
