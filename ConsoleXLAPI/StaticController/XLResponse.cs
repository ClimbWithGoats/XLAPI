namespace ConsoleXLAPI.StaticController
{
    internal class XLResponse
    {


        public XLResponse(int res, object resultObject)
        {
            ResId = res;
            ResultObject = resultObject;
        }

        public int ResId { get; set; }
        public object? ResultObject { get; set; }
    }
}