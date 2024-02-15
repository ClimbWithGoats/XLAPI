using ConsoleXLAPI.Models;
using Newtonsoft.Json;
using System.IO.Pipes;
using System.Text;

namespace ConsoleXLAPI.Utils.Request
{

    public abstract class Request
    {
        [JsonIgnore]
        public string? PipeName { get; set; }
        public Guid Guid { get; set; }
        //public MethodName? MethodName { get; set; }
        public string? Json { get; set; }
        public DateTime DateTime { get; set; }

        public abstract void StartXlOperations();
        public abstract void SerializeToOutputMessage(List<object> list);

        public virtual T? GetT<T>(string json)
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

        public abstract Task<OutputMessage?> SendData();

        public async Task<OutputMessage?> SendData(object th)
        {
            string jsonRequest = JsonConvert.SerializeObject(th);
            
            byte[] requestBytes = Encoding.UTF8.GetBytes(jsonRequest);
            if (!string.IsNullOrEmpty(PipeName))
            {
                using (NamedPipeClientStream clientStream = new NamedPipeClientStream(".", PipeName, PipeDirection.InOut, PipeOptions.None))
                {
                    clientStream.Connect();
                    // Wyślij dane do potoku
                    byte[] newConnectByte = Encoding.UTF8.GetBytes(jsonRequest);
                    await clientStream.WriteAsync(newConnectByte, 0, requestBytes.Length);

                    // Poczekaj na zakończenie przetwarzania i uzyskaj wynik
                    //   await Task.Delay(100); // Symulacja oczekiwania

                    // Odczytaj wynik z potoku (możesz dostosować logikę odczytu)
                    byte[] responseBytes = new byte[1024 * 1024 * 10]; // 10 MB
                    int bytesRead = await clientStream.ReadAsync(responseBytes, 0, responseBytes.Length);
                    string responseData = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    OutputMessage? outputMessage = JsonConvert.DeserializeObject<OutputMessage>(responseData);
                    return outputMessage;
                }
            }
            return new OutputMessage() { Message = "Brakuje nazwy połączenia do potoku", ResultCode = -1 };
        }


    }
}
