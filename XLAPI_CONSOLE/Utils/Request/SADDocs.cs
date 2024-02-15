using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.Utils.Request
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
