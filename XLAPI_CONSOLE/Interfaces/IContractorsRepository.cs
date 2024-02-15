using System.Collections.Generic;
using XLAPI_CONSOLE.Models;

namespace XLAPI_CONSOLE.Interfaces
{
    public interface IContractorsRepository
    {
        bool IsSqlAvailable();
        List<dynamic> GetDynamicData(string query);
        List<XLKontrahentSQLInfo> GetContractorsData(string query);
        int FindIdContractorByAcronim(string contractorName);
    }
}
