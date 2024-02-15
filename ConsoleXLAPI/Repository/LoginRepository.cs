using ConsoleXLAPI.Interfaces;

namespace ConsoleXLAPI.Repository
{
    public class LoginRepository : BaseRepository, ILoginRepository, IBaseRepository
    {
        public LoginRepository(IConfiguration configuration) : base(configuration)
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

        public int FindLastActiveSession()
        {
            return 0;
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
