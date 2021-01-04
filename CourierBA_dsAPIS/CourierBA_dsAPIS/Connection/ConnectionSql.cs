using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace CourierBA_dsAPIS.Connection
{
    public class ConnectionSql
    {
        //Retorno cadena de conexion
        public static SqlConnection getConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["courierDB"].ConnectionString);
        }
    }
}