using ConsoleXLAPI.Models;

namespace ConsoleXLAPI.Interfaces
{
    public interface IContractorsRepository
    {
        bool IsSqlAvailable();
        List<dynamic> GetDynamicData(string query);
        List<XLKontrahentSQLInfo> GetContractorsData(string query);
        int FindIdContractorByAcronim(string contractorName);
    }
}
