using XLAPI_CONSOLE.Models;
using System.Diagnostics;
using System;
using System.Collections.Generic;

namespace XLAPI_CONSOLE.Utils.Trash
{
    public class FPADocRequest : Request
    {
        public FPADocRequest()
        {
            Json = new List<Contractor>();
        }
        public new List<Contractor> Json { get; set; }

        public List<Contractor> GetContractors()
        {
            try
            {
                if (!string.IsNullOrEmpty(base.Json))
                {
                    Json = base.GetT<List<Contractor>>(base.Json) ?? new List<Contractor>();
                }
            }
            catch
            {
                Debug.WriteLine("GetContractors Exception");
            }

            return Json;
        }

        public override void StartProcess()
        {
            throw new NotImplementedException();
        }
    }

}
