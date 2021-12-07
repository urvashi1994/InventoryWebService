using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using InventoryBo;

namespace WebService
{
    public class SalesmanDA
    {
        SqlConnection _sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["InventoryConn"].ConnectionString);

        public int InsertSalesman(SalesmanBO salesman)
        {
            try
            {
                string query = $"insert into salesman (salesman_id, name, city, commission)values({salesman.SalesmanId},'{salesman.Name}','{salesman.City}',{salesman.Commission});";
                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                _sqlconnection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateSalesman(SalesmanBO salesman)
        {

            try
            {
                    string query = $"Update salesman SET name = '{salesman.Name}', city = '{salesman.City}', commission = {salesman.Commission} where salesman_id = {salesman.SalesmanId};";
                    SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                    _sqlconnection.Open();
                    int result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
        }

        public int DeleteSalesman(SalesmanBO salesman)
        {

            try
            {
                string query = $"Delete salesman where salesman_id = {salesman.SalesmanId};";
                SqlCommand cmd = new SqlCommand(query, _sqlconnection);
                _sqlconnection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return result;
            }
            catch
            {
                return 0;
            }
        }
    }
    
}