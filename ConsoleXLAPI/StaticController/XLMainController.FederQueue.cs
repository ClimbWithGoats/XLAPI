using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using Newtonsoft.Json;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )
    public static partial class XLMainController
    {
        static readonly List<Fedder> Fedders = new();

        public static void AddNewFeeder(RequestTask resp)
        {
            Fedder fedder = new(resp);
            lock (Fedders)
            {
                Fedders.Add(fedder);
            }
        }

        public static Fedder? CanGetData(Guid guid)
        {
            Fedder? fedder = null;
            List<Fedder> tempFedders;

            lock (Fedders)
            {
                tempFedders = new(Fedders);
            }

            if (tempFedders.Any())
            {
                fedder = tempFedders.FirstOrDefault(f => !f.IsProcessing && f.ProcessGuid == guid);
            }

            return fedder;
        }

        public static void SetProccesing(Guid guid, bool value)
        {
            Fedder? fedder = Fedders.FirstOrDefault(f => f.ProcessGuid == guid);
            if (fedder != null)
                fedder.IsProcessing = value;
        }
    }

    public class Fedder
    {
        public Fedder(RequestTask request)
        {
            RequestTask = request;
            if (request != null && request.Request is Request req)
            {
                ProcessGuid = req.Guid;
            }
        }

        public Guid ProcessGuid { get; set; }
        public RequestTask RequestTask { get; set; }
        [JsonIgnore]
        public bool IsProcessing = true;

        public object PrepareSerializeObject()
        {
            List<object> resultList = new();
            if (RequestTask.Request is Request cr)
            {
                cr.SerializeToOutputMessage(resultList);
            }
            //else//if (RequestTask.Request is ContractorRequest cr)//{//    foreach (var item in cr.Json)//    {//resultList.Add(item.JsonSerializeResult());             //    }
            //}//else if (RequestTask.Request is ContractorSQLRequest crs)//{//    foreach (var item in crs.Json)//    {//resultList.Add(item.JsonSerializeResult());              //    }
            //}//else if (RequestTask.Request is CommodityResquest comreq)//{//    foreach (var item in comreq.Json)//    {//        resultList.Add(item.JsonSerializeResult());
            //    }//}//else if (RequestTask.Request is CategoriesRequest catreq)//{//    foreach (var item in catreq.Json)//    {//resultList.Add(item.JsonSerializeResult());
            //    }//}//else if (RequestTask.Request is OrderDocs ordDocReq)//{//    foreach (var item in ordDocReq.Json)//    {//resultList.Add(item.JsonSerializeResult());//    }
            //}
            return resultList;
        }


    }
}


