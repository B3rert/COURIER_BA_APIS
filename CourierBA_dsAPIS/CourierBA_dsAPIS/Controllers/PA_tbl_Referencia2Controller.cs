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
    public class PA_tbl_Referencia2Controller : ApiController
    {
        [HttpGet]
        public DataSet getPA_tbl_Referencia2(int empresa,
            string descripcion,
            int referenciPadre,
            string observacion,
            string userName,
            float monto,
            int peso,
            int pieza,
            int producto,
            int moneda)
        {
            DataSet dataSet = null;

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                connection.Open();

                try
                {
                    SqlDataAdapter sqlDataAdapter
                        = new SqlDataAdapter($"EXEC [PA_tbl_Referencia]" +
                        $"  1" +
                        $", 5" +
                        $", 0" +
                        $", {empresa}" +
                        $", {descripcion}" +
                        $", ''" +
                        $", 0" +
                        $", 0" +
                        $", {referenciPadre}" +
                        $", {observacion}" +
                        $", 69" +
                        $", null" +
                        $", {userName}" +
                        $", null" +
                        $", null" +
                        $", 2" +
                        $", NULL" +
                        $", NULL" +
                        $", 1" +
                        $", NULL" +
                        $", 0" +
                        $", NULL" +
                        $", {monto}" +
                        $", NULL" +
                        $", 0" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", {peso}" +
                        $", NULL" +
                        $", NULL" +
                        $", {pieza}" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", {producto}" +
                        $", 1" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", {moneda}", connection);

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
