//using ItegerXLAPI.Models;
//using ItegerXLAPI.Service;

//namespace ItegerXLAPI.Service
//{
//    public class XLService : XLAbstractService, IXLAbstractService
//    {
//        public Task<object> AddCategories()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<object> AddCategory()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<object> AddCommodities()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<object> AddCommodity()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<Contractor> AddContractor(Contractor contractor)
//        {

//            base.AddOrUpdateContractor(contractor);
//            throw new NotImplementedException();
//        }

//        public new Task<IEnumerable<Contractor>>  AddContractors(List<Contractor> list)
//        {
//            base.AddContractors(list);
//            throw new NotImplementedException();
//        }

//        public Task<OutputMessage> AdditionalInformation()
//        {
//            var result = base.PobierzIloscZdarzen();
//            return Task.FromResult(new OutputMessage() { Date = DateTime.Now.ToString("s"), Message = result, Methods = nameof(base.PobierzIloscZdarzen) });

//        }

//        public Task<object> GetCategories()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<object> GetCategory()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<object> GetCommodities()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<object> GetCommodity()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<Contractor> GetContractor()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<IEnumerable<Contractor>> GetContractors()
//        {
//            throw new NotImplementedException();
//        }

//        public Task<OutputMessage> Login()
//        {
//            var result = base.CreateLoginObjectAndLogin();
//            return Task.FromResult(new OutputMessage() { Date = DateTime.Now.ToString("s"), Message = result, Methods = nameof(base.Zaloguj) });

//        }

//        public Task<OutputMessage> Logout()
//        {
//            var result = base.Wyloguj();
//            return Task.FromResult(new OutputMessage() { Date = DateTime.Now.ToString("s"), Message = result.ToString(), Methods = nameof(base.Wyloguj) });

//        }
//    }


//}
