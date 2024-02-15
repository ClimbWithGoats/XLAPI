using ConsoleXLAPI.XLControllers;

namespace ConsoleXLAPI.JsonController
{
    public class JsonCategories
    {
        private XLCategoriesController _xlCategoriesController { get; set; }
        public JsonCategories(XLCategoriesController xlCategories)
        {
            _xlCategoriesController = xlCategories;
        }

        public void SerializeCategories()
        {
        }

        public void DeserializeCategories()
        {

        }

    }

}
