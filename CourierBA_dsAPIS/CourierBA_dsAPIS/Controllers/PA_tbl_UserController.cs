using CourierBA_dsAPIS.Connection;
using Newtonsoft.Json;
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
        public DataSet getPA_tbl_User(string userName)
        {
     
            DataSet dataSet = null;
            //Conexion a sql
            try
            {
                var connection = ConnectionSql.getConnection();
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXECUTE [PA_tbl_User]  4,0,{userName}", connection);

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

        [HttpPost]
        public int postPA_tbl_UserModel([FromBody] Models.PA_tbl_UserModel pA_Tbl_UserModel)
        {
            using (var connection = Connection.ConnectionSql.getConnection())
            {
                using (SqlCommand command = new SqlCommand("PA_tbl_User",connection))
                {

                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@TAccion", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Accion;
                        command.Parameters.Add("@TOpcion", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Opcion;
                        command.Parameters.Add("@pUserName", SqlDbType.VarChar).Value = pA_Tbl_UserModel.UserName;
                        command.Parameters.Add("@pPass_Key", SqlDbType.VarBinary).Value = null;
                        command.Parameters.Add("@pName", SqlDbType.VarChar).Value = pA_Tbl_UserModel.Name;
                        command.Parameters.Add("@pDescription", SqlDbType.VarChar).Value = pA_Tbl_UserModel.Description;
                        command.Parameters.Add("@pDisable", SqlDbType.Bit).Value = pA_Tbl_UserModel.Disable;
                        command.Parameters.Add("@pLanguage_ID", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Language_ID;
                        command.Parameters.Add("@pEmpresa", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Empresa;
                        command.Parameters.Add("@pFecha_Server", SqlDbType.Bit).Value = pA_Tbl_UserModel.Fecha_Server;
                        command.Parameters.Add("@pHora_Server", SqlDbType.Bit).Value = pA_Tbl_UserModel.Hora_Server;
                        command.Parameters.Add("@pMod_Fecha", SqlDbType.Bit).Value = pA_Tbl_UserModel.Mod_Fecha;
                        command.Parameters.Add("@pUpdate_Fecha", SqlDbType.Bit).Value = pA_Tbl_UserModel.Update_Fecha;
                        command.Parameters.Add("@pFecha_Usuario", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Fecha_Usuario;
                        command.Parameters.Add("@pFecha_Hora", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Fecha_Hora;
                        command.Parameters.Add("@pM_Fecha_Hora", SqlDbType.DateTime).Value = pA_Tbl_UserModel.M_Fecha_Hora;
                        command.Parameters.Add("@pM_UserName", SqlDbType.VarChar).Value = pA_Tbl_UserModel.M_UserName;
                        command.Parameters.Add("@pPeriodo", SqlDbType.SmallInt).Value = pA_Tbl_UserModel.Periodo;
                        command.Parameters.Add("@pFecha_Ini", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Fecha_Ini;
                        command.Parameters.Add("@pFecha_Fin", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Fecha_Fin;
                        command.Parameters.Add("@pAsignar_Rango_Fecha", SqlDbType.Bit).Value = pA_Tbl_UserModel.Asignar_Rango_Fecha;
                        command.Parameters.Add("@pTipo_Nomenclatura", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Tipo_Nomenclatura;
                        command.Parameters.Add("@pApplication", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Application;
                        command.Parameters.Add("@pVal_Nomenclatura_Contable", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Nomenclatura_Contable;
                        command.Parameters.Add("@pPass_Key_Len", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Pass_Key_Len;
                        command.Parameters.Add("@pPass_Key_Fecha", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Pass_Key_Fecha;
                        command.Parameters.Add("@pPass_Key_Dias", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Pass_Key_Dias;
                        command.Parameters.Add("@pVal_Serie_Documento", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Serie_Documento;
                        command.Parameters.Add("@pOcultar_SAE", SqlDbType.Bit).Value = pA_Tbl_UserModel.Ocultar_SAE;
                        command.Parameters.Add("@pPath_Reporte", SqlDbType.VarChar).Value = pA_Tbl_UserModel.Path_Reporte;
                        command.Parameters.Add("@pFecha_Ini_Valido", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Fecha_Ini_Valido;
                        command.Parameters.Add("@pFecha_Fin_Valido", SqlDbType.DateTime).Value = pA_Tbl_UserModel.Fecha_Ini_Valido;
                        command.Parameters.Add("@pVal_Rol_Poliza", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Rol_Poliza;
                        command.Parameters.Add("@pEstacion_Trabajo", SqlDbType.SmallInt).Value = pA_Tbl_UserModel.Estacion_Trabajo;
                        command.Parameters.Add("@pPermitir_CxC", SqlDbType.Bit).Value = pA_Tbl_UserModel.Permitir_CxC;
                        command.Parameters.Add("@pReportServerUrl", SqlDbType.VarChar).Value = pA_Tbl_UserModel.ReportServerUrl;
                        command.Parameters.Add("@pTipo_Entidad", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Tipo_Entidad;
                        command.Parameters.Add("@pSexo", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Sexo;
                        command.Parameters.Add("@pCelular", SqlDbType.VarChar).Value = pA_Tbl_UserModel.Celular;
                        command.Parameters.Add("@pEMail", SqlDbType.VarChar).Value = pA_Tbl_UserModel.EMail;
                        command.Parameters.Add("@pSQL_Partida_Contable", SqlDbType.VarChar).Value = pA_Tbl_UserModel.SQL_Partida_Contable;
                        command.Parameters.Add("@pCuenta_Correntista", SqlDbType.Int).Value = pA_Tbl_UserModel.Cuenta_Correntista;
                        command.Parameters.Add("@pVal_Poliza", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Poliza;
                        command.Parameters.Add("@pVal_Elemento_Asignado", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Elemento_Asignado;
                        command.Parameters.Add("@pVal_Referencia", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Referencia;
                        command.Parameters.Add("@pTarea_Nivel", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Tarea_Nivel;
                        command.Parameters.Add("@pTipo_Usuario", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Tipo_Usuario;
                        command.Parameters.Add("@pVal_IP_Address", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_IP_Address;
                        command.Parameters.Add("@pElemento_Asignado", SqlDbType.SmallInt).Value = pA_Tbl_UserModel.Elemento_Asignado;
                        command.Parameters.Add("@pTipo_Modelo", SqlDbType.TinyInt).Value = pA_Tbl_UserModel.Tipo_Modelo;
                        command.Parameters.Add("@pPIN", SqlDbType.Int).Value = pA_Tbl_UserModel.PIN;
                        command.Parameters.Add("@pVal_Tipo_Referencia", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Tipo_Referencia;
                        command.Parameters.Add("@pVal_Id_Dispositivo", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Id_Dispositivo;
                        command.Parameters.Add("@pVal_Cuenta_Bancaria", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Cuenta_Bancaria;
                        command.Parameters.Add("@pVal_Localizacion", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Localizacion;
                        command.Parameters.Add("@pVal_Tipo_Precio", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Tipo_Precio;
                        command.Parameters.Add("@pVal_Tipo_Accion_Serie_Documento", SqlDbType.Bit).Value = pA_Tbl_UserModel.Val_Tipo_Accion_Serie_Documento;

                        connection.Open();
                        command.ExecuteNonQuery();

                        return 201;

                    }
                    catch
                    {
                        return 500;

                    }
                }
            }
        }
    }
}
