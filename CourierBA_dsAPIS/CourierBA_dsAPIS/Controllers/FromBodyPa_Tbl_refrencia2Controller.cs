using CourierBA_dsAPIS.Models;
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
    public class FromBodyPa_Tbl_refrencia2Controller : ApiController
    {
        [HttpPost]
        public DataSet postPa_tbl_referencia2([FromBody] PA_tblReferencia2Model model)
        {
            DataSet dataSet = null;

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                connection.Open();
                string testEsp = "prueba con espacios";

                try
                {
                    SqlDataAdapter sqlDataAdapter
                        = new SqlDataAdapter($"EXEC [PA_tbl_Referencia]" +
                        $"  1" +
                        $", 5" +
                        $", 0" +
                        $", {model.Empresa}" +
                        $", {model.Descripcion}" +
                        $", ''" +
                        $", 0" +
                        $", 0" +
                        $", {model.ReferenciaPadre}" +
                        $", '{testEsp}'" +
                        $", 69" +
                        $", null" +
                        $", {model.UserName}" +
                        $", null" +
                        $", null" +
                        $", 2" +
                        $", NULL" +
                        $", NULL" +
                        $", 1" +
                        $", NULL" +
                        $", 0" +
                        $", NULL" +
                        $", {model.Monto}" +
                        $", NULL" +
                        $", 0" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", {model.Peso}" +
                        $", NULL" +
                        $", NULL" +
                        $", {model.Pieza}" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", NULL" +
                        $", {model.Producto}" +
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
                        $", {model.Moneda}", connection);

                    dataSet = new DataSet();
                    sqlDataAdapter.Fill(dataSet);

                    return dataSet;
                }
                catch (Exception ex)
                {
                    var test = ex.Message;
                    return dataSet;
                }
            }
        }
    }
}
