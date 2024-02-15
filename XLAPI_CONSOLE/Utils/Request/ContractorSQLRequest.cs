using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;

namespace XLAPI_CONSOLE.Utils.Request
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
            XLMainController.AddContractorsSQL(Json, Guid);
        }
    }
}
