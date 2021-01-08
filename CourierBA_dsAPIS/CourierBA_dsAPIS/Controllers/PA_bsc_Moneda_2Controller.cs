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
    public class PA_bsc_Moneda_2Controller : ApiController
    {
        [HttpGet]
        public DataSet getPA_bsc_Moneda_2(int Empresa)
        {
            DataSet dataSet = null;

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                connection.Open();

                try
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC [PA_bsc_Moneda_2] {Empresa}", connection);

                    dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    return dataSet;
                }
                catch
                {
                    return dataSet;
                }
            }
        }
    }
}
