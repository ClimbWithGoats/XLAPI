using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace XLAPI_CONSOLE.Utils.Request
{

    public abstract class Request
    {
        public Guid Guid { get; set; }
        //public MethodName MethodName { get; set; }
        public string Json { get; set; }
        public DateTime DateTime { get; set; }

        public abstract void StartXlOperations();
        public abstract void SerializeToOutputMessage(List<object> list);

        public virtual T GetT<T>(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                return default;
            }
        }
    }
}
