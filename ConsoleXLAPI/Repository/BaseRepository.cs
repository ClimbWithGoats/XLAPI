﻿using ConsoleXLAPI.StaticController;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace ConsoleXLAPI.Repository
{
    public abstract class BaseRepository
    {
        protected readonly IConfiguration _configuration;
        private readonly string? _connectionString;
        public BaseRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DBContext");
            if (!IsAvailable)
            {
                IsSqlAvailable();
            }
        }
        public abstract int GetItemById(object obj);
        public abstract object GetData(object name);

        public virtual string ExecuteSQL(string sql)
        {

            //string result = XLController.zarzadcaBazy.WykonajZapytanie(sql);
            //return result;
            if (IsAvailable)
            {
                try
                {
                    using SqlConnection con = new(_connectionString);
                    con.Open();
                    SqlCommand cmd = new(sql, con);
                    cmd.ExecuteNonQuery().ToString();
                    con.Close();
                    return "ok";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            else
                return "Błąd podłączenia do bazy";

        }
        public virtual DataTable TSqlDtResult(string sql)
        {
            //DataTable result = XLController.zarzadcaBazy.WykonajZapytanieTSQL(sql);
            //return result;
            DataTable t = new();
            if (IsAvailable)
            {
                try
                {
                    using SqlConnection con = new(_connectionString);
                    SqlCommand command = new(sql)
                    {
                        CommandTimeout = 10000,
                        Connection = con
                    };
                    //con.Open();
                    using SqlDataAdapter DataAdapter = new(command);
                    DataAdapter.Fill(t);
                    //con.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            else
                throw new Exception("Serwer aplikacji jest nieosiągalny. Jeśli widzisz komunikat po raz pierwszy - ponów próbę. Jeśli komunikat się powtarza sprawdź dostępność sieci firmowej.");
            return t;
        }
        public virtual string? SingleSqlResult(string sql)
        {
            //string? s = XLController.zarzadcaBazy.WykonajZapytanieSkalar(sql);
            //return s;
            String? wynik = "";
            if (IsAvailable)
            {
                try
                {
                    using SqlConnection con = new(_connectionString);
                    con.Open();
                    SqlCommand cmd = new(sql, con);
                    var tmp = cmd.ExecuteScalar();
                    if (tmp != null)
                    {
                        wynik = tmp.ToString();
                    }
                    con.Close();
                }
                catch
                {
                    return wynik;
                }
            }
            else
            {
                throw new Exception("Serwer aplikacji jest nieosiągalny. Jeśli widzisz komunikat po raz pierwszy - ponów próbę. Jeśli komunikat się powtarza sprawdź dostępność sieci firmowej.");
            }
            return wynik;
        }
        //public virtual List<dynamic> GetData(string query)
        //{
        //    var result = XLController.zarzadcaBazy.GetData(query);
        //    return result;
        //}
        //public virtual List<T> GetData<T>(string query) where T : class, new()
        //{
        //    var result = XLController.zarzadcaBazy.GetData<T>(query);
        //    return result;
        //}

        public bool IsAvailable;


        public List<dynamic> GetData(string query)
        {
            List<dynamic> dynamicList = new();
            if (IsAvailable)
            {
                try
                {
                    using SqlConnection connection = new(_connectionString);
                    connection.Open();

                    using SqlCommand command = new(query, connection);
                    using SqlDataAdapter adapter = new(command);
                    DataTable dataTable = new();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        dynamic dynamicObject = new System.Dynamic.ExpandoObject();

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            ((IDictionary<string, object>)dynamicObject)[column.ColumnName] = row[column];
                        }

                        dynamicList.Add(dynamicObject);
                    }
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);

                }
            }
            return dynamicList;
        }

        public dynamic? GetSingleDataRow(string query)
        {
            dynamic? dynamicObject = null;
            if (IsAvailable)
            {
                try
                {
                    using SqlConnection connection = new(_connectionString);
                    connection.Open();

                    using SqlCommand command = new(query, connection);
                    using SqlDataAdapter adapter = new(command);
                    DataTable dataTable = new();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        dynamicObject = new System.Dynamic.ExpandoObject();

                        foreach (DataColumn column in dataTable.Columns)
                        {
                            ((IDictionary<string, object>)dynamicObject)[column.ColumnName] = dataTable.Rows[0][column];
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return dynamicObject;
        }


        public List<T> GetData<T>(string query) where T : class, new()
        {
            List<T> resultList = new();

            if (IsAvailable)
            {
                try
                {
                    using SqlConnection connection = new(_connectionString);
                    connection.Open();

                    using SqlCommand command = new(query, connection);
                    using SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        T obj = new();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            PropertyInfo? propertyInfo = typeof(T).GetProperty(reader.GetName(i));
                            if (propertyInfo != null && reader[i] != DBNull.Value)
                            {
                                propertyInfo.SetValue(obj, reader[i]);
                            }
                        }
                        resultList.Add(obj);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }

            return resultList;
        }

        public bool IsSqlAvailable()
        {
            try
            {
                using SqlConnection connection = new(_connectionString);
                connection.Open();
                connection.Close();
                IsAvailable = true;
                return true;
            }
            catch //(Exception ex)
            {
                IsAvailable = false;
                return false;
            }
        }
        public int FindLastSessionIfIsActive()
        {
            string sql = $"Select max(SES_SesjaID) from cdn.Sesje where SES_Modul like '%TestApi' and SES_Aktywna = 0";
            int res = -1;
            if (!XLMainController.IsLoged)
            {
                string? result = SingleSqlResult(sql);
                if (!string.IsNullOrEmpty(result))
                {
                    res = result.Equals("") ? -1 : int.Parse(result);
                }
            }
            return res;
        }



    }
}