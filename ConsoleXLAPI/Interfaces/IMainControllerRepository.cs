namespace ConsoleXLAPI.Interfaces
{
    public interface IMainControllerRepository
    {
        string? SingleSqlResult(string sql);
        int FindIdContractorByAcronim(string contractorName);
    }
}
