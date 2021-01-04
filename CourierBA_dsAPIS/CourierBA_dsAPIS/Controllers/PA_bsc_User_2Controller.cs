using CourierBA_dsAPIS.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CourierBA_dsAPIS.Controllers
{
    //Login
    public class PA_bsc_User_2Controller : ApiController
    {
        [HttpGet]
        public int getUser(string user, string pass)
        {

            DataSet dataSet = null;
            //Conexion a sql
            try
            {
                var connection = ConnectionSql.getConnection();
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC [PA_bsc_User_2] 1,{user},{pass}", connection);

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                connection.Close();

                DataTable table = new DataTable();
                sqlDataAdapter.Fill(table);

                return table.Rows.Count;

            }
            catch
            {
                return 0;
            }

        }
    }
}
