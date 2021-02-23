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
    public class PA_tbl_Documento_Aut_dsController : ApiController
    {
        [HttpGet]
        public int getPA_tbl_Documento_Aut_ds()
        {

            using (var connection = Connection.ConnectionSql.getConnection())
            {
                using (SqlCommand command = new SqlCommand("PA_tbl_Documento_Aut_ds", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.Add("@TAccion", SqlDbType.Int).Value = 0;
                    command.Parameters.Add("@TOpcion", SqlDbType.TinyInt).Value = 0;
                    command.Parameters.Add("@pConsecutivo_Interno", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@pUserName", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pTipo_Documento", SqlDbType.TinyInt).Value = 0;
                    command.Parameters.Add("@pSerie_Documento", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pEmpresa", SqlDbType.TinyInt).Value = "";
                    command.Parameters.Add("@pLocalizacion", SqlDbType.SmallInt).Value = "";
                    command.Parameters.Add("@pEstacion_Trabajo", SqlDbType.SmallInt).Value = "";
                    command.Parameters.Add("@pCuenta_Correntista", SqlDbType.Int).Value = "";
                    command.Parameters.Add("@pCuenta_Cta", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pFecha_Documento", SqlDbType.DateTime).Value = "";
                    command.Parameters.Add("@pEstado_Documento", SqlDbType.TinyInt).Value = "";
                    command.Parameters.Add("@pDocumento_Nombre", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pDocumento_NIT", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pDocumento_Direccion", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pObservacion_1", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pFE_numeroDte", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pFE_CAE", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pFE_numeroDocumento", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pTra_M", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pTra_MM", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pTra_M_Cargo", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pTra_MM_Cargo", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pTra_M_Descuento", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pTra_MM_Descuento", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pCar_Abo_M", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pCar_Abo_MM", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pCar_Abo_M_Por_Aplicar", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pCar_Abo_MM_Por_Aplicar", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pCar_Abo_M_Cambio", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pCar_Abo_MM_Cambio", SqlDbType.Float).Value = "";
                    command.Parameters.Add("@pImpresion_Doc", SqlDbType.TinyInt).Value = "";
                    command.Parameters.Add("@pCuenta_Correntista_Ref", SqlDbType.TinyInt).Value = "";
                    command.Parameters.Add("@pRef_Id_Documento", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pGPS_Latitud", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pGPS_Longitud", SqlDbType.VarChar).Value = "";
                    command.Parameters.Add("@pFE_Fecha_Certificacion", SqlDbType.DateTime).Value = "";
                    command.Parameters.Add("@pFEL_Numero_Acceso", SqlDbType.Int).Value = "";


                    connection.Open();
                    command.ExecuteNonQuery();

                    return Convert.ToInt32(command.Parameters["@pConsecutivo_Interno"].Value);
                }
            }

        }
    }
}
