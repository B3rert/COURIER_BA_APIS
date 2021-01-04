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
    //Estacion de trabajo
    public class PA_bsc_Estacion_Trabajo_2Controller : ApiController
    {
        [HttpGet]
        public DataSet getEstacionTrabajo(string user)
        {

            DataSet dataSet = null;
            //Conexion a sql
            try
            {
                var connection = ConnectionSql.getConnection();
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"EXEC [PA_bsc_Estacion_Trabajo_2]{user}", connection);

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
    }
}
