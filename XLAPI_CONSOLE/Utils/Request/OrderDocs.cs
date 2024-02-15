using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;
using XLAPI_CONSOLE.StaticController;

namespace XLAPI_CONSOLE.Utils.Request
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
            XLMainController.AddDocuments(Json, Guid);
        }
    }


}
