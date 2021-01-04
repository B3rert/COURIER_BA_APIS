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
    public class PA_tbl_UserController : ApiController
    {
        [HttpGet]
        public DataSet getPA_tbl_User(int accion, string userName)
        {

            DataSet dataSet = null;
            //Conexion a sql
            try
            {
                var connection = ConnectionSql.getConnection();
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXECUTE [PA_tbl_User]  {accion},0,{userName}", connection);

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);

                connection.Close();

                return dataSet;

            }
            catch
            {
                return dataSet;
            }
        }

    }
}
