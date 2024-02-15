namespace XLAPI_CONSOLE.Interfaces
{
    public interface IMainControllerRepository
    {
        string SingleSqlResult(string sql);
        int FindIdContractorByAcronim(string contractorName);
    }
}
