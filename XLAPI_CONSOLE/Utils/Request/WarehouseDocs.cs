using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.Utils.Request
{
    public class WarehouseDocs : Request
    {
        public WarehouseDocs()
        {
            Json = new List<XLDokumentMagNagInfo>();
        }
        public new List<XLDokumentMagNagInfo> Json { get; set; }

        public List<XLDokumentMagNagInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLDokumentMagNagInfo>>(base.Json) ?? new List<XLDokumentMagNagInfo>();
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

        }
    }

}
