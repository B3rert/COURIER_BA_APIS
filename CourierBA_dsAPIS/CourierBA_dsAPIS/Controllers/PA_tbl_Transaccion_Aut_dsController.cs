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
    public class PA_tbl_Transaccion_Aut_dsController : ApiController
    {
        [HttpGet]
        public int getPA_tbl_Transaccion_Aut_ds()
        {

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                using (SqlCommand command = new SqlCommand("PA_tbl_Transaccion_Aut_ds", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@pAccion", SqlDbType.Int).Value = 1;
                    command.Parameters.Add("@TOpcion", SqlDbType.TinyInt).Value = 1;
                    command.Parameters.Add("@pConsecutivo_Interno", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@pUserName", SqlDbType.VarChar).Value = 1;
                    command.Parameters.Add("@pBodega", SqlDbType.SmallInt).Value = 1;
                    command.Parameters.Add("@pProducto", SqlDbType.Int).Value = 1;
                    command.Parameters.Add("@pProducto_Id", SqlDbType.VarChar).Value = 1;
                    command.Parameters.Add("@pProducto_Des", SqlDbType.VarChar).Value = 1;
                    command.Parameters.Add("@pTipo_Transaccion", SqlDbType.TinyInt).Value = 1;
                    command.Parameters.Add("@pEstado_Transaccion", SqlDbType.TinyInt).Value = 1;
                    command.Parameters.Add("@pUnidad_Medida", SqlDbType.TinyInt).Value = 1;
                    command.Parameters.Add("@pU_M_Descripcion", SqlDbType.VarChar).Value = 1;
                    command.Parameters.Add("@pTipo_Precio", SqlDbType.SmallInt).Value = 1;
                    command.Parameters.Add("@pD_Consecutivo_Interno", SqlDbType.BigInt).Value = 1;
                    command.Parameters.Add("@pFecha_Hora", SqlDbType.DateTime).Value = 1;
                    command.Parameters.Add("@pCantidad", SqlDbType.Float).Value = 1;
                    command.Parameters.Add("@pMonto", SqlDbType.Float).Value = 1;
                    command.Parameters.Add("@pMonto_Moneda", SqlDbType.Float).Value = 1;
                    command.Parameters.Add("@pObservacion_1", SqlDbType.VarChar).Value = 1;
                    command.Parameters.Add("@pConsecutivo_Interno_Padre", SqlDbType.BigInt).Value = 1;
                    command.Parameters.Add("@pAux_1", SqlDbType.VarChar).Value = 1;

                    connection.Open();
                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@pConsecutivo_Interno"].Value);
                }
            }

        }
    }
}
