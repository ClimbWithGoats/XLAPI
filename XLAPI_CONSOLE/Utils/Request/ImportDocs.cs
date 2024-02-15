using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.Utils.Request
{
    public class ImportDocs : Request
    {
        public ImportDocs()
        {
            Json = new List<XLDokumentImpNagInfo>();
        }
        public new List<XLDokumentImpNagInfo> Json { get; set; }

        public List<XLDokumentImpNagInfo> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<XLDokumentImpNagInfo>>(base.Json) ?? new List<XLDokumentImpNagInfo>();
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
