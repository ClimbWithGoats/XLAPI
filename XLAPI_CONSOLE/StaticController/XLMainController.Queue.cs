using System.Collections.Concurrent;
using System.Threading.Tasks;
using XLAPI_CONSOLE.Utils.Request;
using XLAPI_CONSOLE.XLControllers;

namespace XLAPI_CONSOLE.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod )
    public static partial class XLMainController
    {
        private static readonly BlockingCollection<RequestTask> blockingCollection = new BlockingCollection<RequestTask>();

        private static int taskCount = 0;

        public static async void EnqueueTask(RequestTask response)
        {
            // Console.WriteLine($"Metoda {nameof(EnqueueTask)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
            await Task.Run(() =>
            {
                blockingCollection.Add(response);
            });
        }



        private static void ProcessQueue()
        {
            foreach (var responseTask in blockingCollection.GetConsumingEnumerable())
            {
                RequestTask response = responseTask;
                // Przetwórz response
                if (response != null)
                {
                    // Console.WriteLine($"Metoda {nameof(ProcessQueue)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
                    AddNewFeeder(response);
                    ExecuteResponse(response);
                }
            }
        }

        private static void ExecuteResponse(RequestTask resp)
        {
            if (resp.Request is Request response)
            {
                var typeName = response.GetType().Name;
                // Console.WriteLine($"Metoda {nameof(ExecuteResponse)} działa na wątku o ID: {Environment.CurrentManagedThreadId} > {typeName}");
                response.StartXlOperations();
                taskCount++;
            }
        }


        public static int GetQueueSize()
        {
            return blockingCollection.Count;
        }





    }
}


