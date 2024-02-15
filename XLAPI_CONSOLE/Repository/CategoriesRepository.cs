using System;
using XLAPI_CONSOLE.Interfaces;

namespace XLAPI_CONSOLE.Repository
{
    public class CategoriesRepository : BaseRepository, ICategoriesRepository, IBaseRepository
    {
        public CategoriesRepository(ConfigRoot configuration) : base(configuration)
        {

        }

        public override object GetData(object name)
        {
            throw new NotImplementedException();
        }

        public override int GetItemById(object obj)
        {
            string result = base.SingleSqlResult("");
            if (string.IsNullOrEmpty(result))
            {
                return -2;
            }
            return result.Equals("") ? -1 : int.Parse(result);
        }
        //public int ItemIsExist(string contractorName)
        //{
        //    string sql = string.Format("select knt_gidnumer from cdn.kntkarty where Knt_Akronim like '{0}' OR Knt_Nazwa1 like '{0}'", contractorName);
        //    string result = base.SingleSqlResult(sql);
        //    if (string.IsNullOrEmpty(result))
        //    {
        //        return -2;
        //    }
        //    return result.Equals("")  -1 : int.Parse(result);
        //}



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
