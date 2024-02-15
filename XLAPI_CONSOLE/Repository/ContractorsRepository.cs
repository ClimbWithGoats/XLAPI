using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Interfaces;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.Repository
{
    public class ContractorsRepository : BaseRepository, IContractorsRepository, IBaseRepository
    {

        public ContractorsRepository(ConfigRoot configuration) : base(configuration)
        {
            IsSqlAvailable();
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

        public List<dynamic> GetDynamicData(string query)
        {
            var result = base.GetData(query);
            return result;
        }

        public List<XLKontrahentSQLInfo> GetContractorsData(string query)
        {
            var result = base.GetData<XLKontrahentSQLInfo>(query);
            return result;
        }

        public int FindIdContractorByAcronim(string contractorName)
        {
            throw new NotImplementedException();
        }
    }
}
