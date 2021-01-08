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
    public class PA_tbl_ReferenciaController : ApiController
    {

        [HttpGet]
        public DataSet getPA_tbl_Referencia(int empresa, string userName)
        {
            DataSet dataSet = null;

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                connection.Open();

                try
                {
                    SqlDataAdapter sqlDataAdapter 
                        = new SqlDataAdapter($"EXEC [PA_tbl_Referencia]" +
                        $"1,0,5,{empresa},'','',0,0,null,null,69,null,{userName},null,null,1", connection);

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
