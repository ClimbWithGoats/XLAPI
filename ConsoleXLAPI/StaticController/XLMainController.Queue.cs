using ConsoleXLAPI.Utils.Request;
using ConsoleXLAPI.XLControllers;
using System.Collections.Concurrent;

namespace ConsoleXLAPI.StaticController
{
    //Główny plik kontrolera sterujący przepływem danych (uruchamianiem metod? )
    public static partial class XLMainController
    {
        private static readonly BlockingCollection<RequestTask> blockingCollection = new();

        private static int taskCount = 0;

        public static async void EnqueueTask(RequestTask response)
        {
            // Debug.WriteLine($"Metoda {nameof(EnqueueTask)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
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
                    // Debug.WriteLine($"Metoda {nameof(ProcessQueue)} działa na wątku o ID: {Environment.CurrentManagedThreadId}");
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
                // Debug.WriteLine($"Metoda {nameof(ExecuteResponse)} działa na wątku o ID: {Environment.CurrentManagedThreadId} > {typeName}");
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


