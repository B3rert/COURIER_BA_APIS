using CourierBA_dsAPIS.Connection;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;

namespace CourierBA_dsAPIS.Controllers
{

    //aplicacion
    public class PA_bsc_User_AplicationController : ApiController
    {
        [HttpGet]
        public DataSet getAplication(string user)
        {

            DataSet dataSet = null;
            //Conexion a sql
            try
            {
                var connection = ConnectionSql.getConnection();
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"exec [PA_bsc_User_Aplication] 1,{user}", connection);

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
