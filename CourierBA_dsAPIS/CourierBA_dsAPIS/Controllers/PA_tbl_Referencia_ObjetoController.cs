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
    public class PA_tbl_Referencia_ObjetoController : ApiController
    {

        [HttpGet]
        public int getPA_tbl_Referencia_Objeto(
            int pReferencia,
            string pUserName,
            string pObjeto_Nombre,
            string pObservacion_1)
        {
            
            DateTime dateTime = DateTime.Now;

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                using (SqlCommand command = new SqlCommand("PA_tbl_Referencia_Objeto", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@TAccion", SqlDbType.TinyInt).Value =1;
                        command.Parameters.Add("@TOpcion", SqlDbType.TinyInt).Value =1;
                        command.Parameters.Add("@pReferencia_Objeto", SqlDbType.BigInt).Value =0;
                        command.Parameters.Add("@pReferencia", SqlDbType.Int).Value = pReferencia;
                        command.Parameters.Add("@pFecha_Hora", SqlDbType.DateTime).Value = dateTime;
                        command.Parameters.Add("@pUserName", SqlDbType.VarChar).Value = pUserName;
                        command.Parameters.Add("@pObjeto_Data", SqlDbType.Image).Value = null;
                        command.Parameters.Add("@pObjeto_Nombre", SqlDbType.VarChar).Value = pObjeto_Nombre;
                        command.Parameters.Add("@pObject_Type", SqlDbType.TinyInt).Value = 16;
                        command.Parameters.Add("@pObservacion_1", SqlDbType.VarChar).Value = pObservacion_1;
                        command.Parameters.Add("@pEstado", SqlDbType.TinyInt).Value = 1;

                        connection.Open();
                        command.ExecuteNonQuery();


                        return 1;
                    }
                    catch (Exception)
                    {

                        return 0;
                    }

                }
            }
        }
    }
}
