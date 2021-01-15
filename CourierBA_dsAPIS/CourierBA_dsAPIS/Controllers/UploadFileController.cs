using CourierBA_dsAPIS.Models;
using System;
using System.Configuration;
using System.Web.Http;

namespace CourierBA_dsAPIS.Controllers
{
    public class UploadFileController : ApiController
    {

        [HttpPost]
        public string StringByte([FromBody]UploadByteModel byteModel)
        {
            try
            {
                var name = byteModel.Name;
                var image = byteModel.ArrayByte;

                //string root = HttpContext.Current.Server.MapPath($"~/App_Data/{name}");

                string root = $"{ConfigurationManager.AppSettings["PathFile"]}{name}";

                System.IO.File.WriteAllBytes(root, image);

                return root;
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }
    }
}
