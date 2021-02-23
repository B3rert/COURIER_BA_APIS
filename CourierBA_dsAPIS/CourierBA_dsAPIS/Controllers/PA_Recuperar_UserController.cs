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
    public class PA_Recuperar_UserController : ApiController
    {
        [HttpGet]
        public int getResetPass(string Correo)
        {
            int messege = 0;

            using (var connection = Connection.ConnectionSql.getConnection())
            {

                using (SqlCommand command = new SqlCommand("PA_Recuperar_User", connection))
                {
                    try
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@pOpcion", SqlDbType.Int).Value = 1;

                        command.Parameters.Add("@pCorreo_Electronico", SqlDbType.VarChar).Value = Correo;
                        command.Parameters.Add("@pMensaje", SqlDbType.VarChar).Value = "";
                        command.Parameters.Add("@pResultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        connection.Open();
                        command.ExecuteNonQuery();

                        int res = Convert.ToInt32(command.Parameters["@pResultado"].Value);
                        if (res == 0)
                        {
                            //messege = "Alerta! Este correo ya existe registrado, intenta recuperar tu contraseña.";
                            messege = 0;
                        }
                        else if (res == 1)
                        {
                            messege = 1;
                        }
                        else
                        {
                            messege = 3;
                        }

                        // var mess = command.Parameters["@pMensaje"].Value;
                        return messege;
                    }
                    catch (Exception e)
                    {
                        messege = 3;
                        return messege;
                    }

                }
            }

        }
    }
}
