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
    public class PA_Validar_ReferenciaController : ApiController
    {
        //Empresa
        [HttpGet]
        public int getValidarReferencia(string user, string descripcion, int referencia)
        {

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                using (SqlCommand command = new SqlCommand("PA_Validar_Referencia", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@pAccion", SqlDbType.TinyInt).Value = 1;
                    command.Parameters.Add("@pMensaje", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pResultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@pUserName", SqlDbType.VarChar).Value = user;
                    command.Parameters.Add("@pReferencia", SqlDbType.Int).Value = 0;
                    command.Parameters.Add("@pReferencia_Id", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pDescripcion", SqlDbType.VarChar).Value = descripcion;
                    command.Parameters.Add("@pReferencia_Padre", SqlDbType.Int).Value = referencia;
                    command.Parameters.Add("@pTipo_Referencia", SqlDbType.TinyInt).Value = 2;

                    connection.Open();
                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@pResultado"].Value);
                }
            }
           
        }
    }
}
