using System;
using System.Collections.Generic;
using XLAPI_CONSOLE.Interfaces;

namespace XLAPI_CONSOLE.Repository
{
    public class MainControllerRepository : BaseRepository, IMainControllerRepository, IBaseRepository
    {
        private static MainControllerRepository instance;
        public MainControllerRepository(ConfigRoot configuration) : base(configuration)
        {
        }

        public int FindIdContractorByAcronim(string contractorName)
        {
            // string sqlas = _configuration.GetSection("SqlCommunications:Contractors:FindAccronym").Value;
            string sqlas = _configuration.SqlCommunications.ContractorsSql.FindAccronym;
            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return -1;
            }
            string sql = string.Format(sqlas, contractorName);
            string result = base.SingleSqlResult(sql);
            if (string.IsNullOrEmpty(result))
            {
                return -1;
            }
            return result.Equals("") ? -1 : int.Parse(result);
        }
        public int FindIdTwrByCode(string code)
        {
            // string sqlas = _configuration.GetSection("SqlCommunications:Commodities:FindTwrByCode").Value;
            string sqlas = _configuration.SqlCommunications.CommoditiesSql.FindTwrByCode;
            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return -1;
            }
            string sql = string.Format(sqlas, code);
            string result = base.SingleSqlResult(sql);
            if (string.IsNullOrEmpty(result))
            {
                return -1;
            }
            return result.Equals("") ? -1 : int.Parse(result);
        }

        public int FindIdCategoryByCode(string code)
        {
            //string sqlas = _configuration.GetSection("SqlCommunications:Categories:FindCategory").Value;
            string sqlas = _configuration.SqlCommunications.CategoriesSql.FindCategory;
            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return -1;
            }
            string sql = string.Format(sqlas, code);
            string result = base.SingleSqlResult(sql);
            if (string.IsNullOrEmpty(result))
            {
                return -1;
            }
            return result.Equals("") ? -1 : int.Parse(result);
        }
        public dynamic GetDataForContractorsModify(string contractorName)
        {
            //     string sqlas = _configuration.GetSection("SqlCommunications:Contractors:ContractorModify").Value;
            string sqlas = _configuration.SqlCommunications.ContractorsSql.ContractorModify;

            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return null;
            }
            string sql = string.Format(sqlas, contractorName);
            var result = base.GetData(sql);
            return result ?? null;
        }
        public dynamic GetDataForTwrsModify(string contractorName)
        {
            //   string sqlas = _configuration.GetSection("SqlCommunications:commodities:TwrModify").Value;
            string sqlas = _configuration.SqlCommunications.CommoditiesSql.TwrModify;

            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return null;
            }
            string sql = string.Format(sqlas, contractorName);
            var result = base.GetData(sql);
            return result ?? null;
        }
        public dynamic FindDocumentsByFullName(string NumerPelny)
        {
            //     string sqlas = _configuration.GetSection("SqlCommunications:Documents:DocumentsIsExists").Value;
            string sqlas = _configuration.SqlCommunications.DocumentsSql.DocumentsIsExists;
            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return null;
            }
            string sql = string.Format(sqlas, NumerPelny);
            var result = base.GetData(sql);
            return result ?? null;
        }

        public List<dynamic> FindClass(string className)
        {

            //string sqlas = _configuration.GetSection("SqlCommunications:Attributes:FindClass").Value;
            string sqlas = _configuration.SqlCommunications.AttributesSql.FindClass;
            if (string.IsNullOrWhiteSpace(sqlas))
            {
                return null;
            }
            string sql = string.Format(sqlas, className);
            var result = base.GetData(sql);
            return result ?? null;
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
            throw new NotImplementedException();
        }

        public object GetSingle()
        {
            throw new NotImplementedException();
        }

        public override string SingleSqlResult(string sql)
        {
            return base.SingleSqlResult(sql);
        }

        //public static MainControllerRepository Instance
        //{
        //    //get
        //    //{
        //    //    if (instance == null)
        //    //    {
        //    //        // Tutaj uzyskaj IConfiguration, np. z AppSettings
        //    //        IConfiguration configuration = new ConfigurationBuilder()
        //    //            .SetBasePath(Directory.GetCurrentDirectory())
        //    //            .AddJsonFile("appsettings.json")
        //    //            .Build();

        //    //        instance = new MainControllerRepository(configuration);
        //    //    }
        //    //    return instance;
        //    //}
        //}
    }
}
