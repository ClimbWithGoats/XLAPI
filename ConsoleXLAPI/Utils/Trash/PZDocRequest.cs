using ItegerXLAPI.Models;
using System.Diagnostics;

namespace ItegerXLAPI.Utils.Trash
{
    public class PZDocRequest : Request
    {
        public PZDocRequest()
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
