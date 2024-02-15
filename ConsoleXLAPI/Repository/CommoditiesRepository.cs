using ConsoleXLAPI.Interfaces;

namespace ConsoleXLAPI.Repository
{
    public class CommoditiesRepository : BaseRepository, ICommoditiesRepository, IBaseRepository
    {
        public CommoditiesRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override object GetData(object name)
        {
            throw new NotImplementedException();
        }

        public override int GetItemById(object obj)
        {
            throw new NotImplementedException();
        }

        public object GetMany()
        {
            return new NotImplementedException();
        }

        public object GetSingle()
        {
            return new NotImplementedException();
        }
    }
}
