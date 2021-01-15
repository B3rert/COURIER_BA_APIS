using CourierBA_dsAPIS.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace CourierBA_dsAPIS.Controllers
{
    public class UploadImageController : ApiController
    {
       public string UploadFile([FromBody] UpoloadFileModel upoload)
        {
            try
            {
               var name = upoload.Name;
               var image = StringToByteArray(upoload.ArrayByte);

                //string root = HttpContext.Current.Server.MapPath($"~/App_Data/{name}");

                string root = $"{ConfigurationManager.AppSettings["PathFile"]}{name}";

                System.IO.File.WriteAllBytes(root, image);

                return root;
            }
            catch (Exception e)
            {

                return e.Message;
            }

          //  return $"{upoload.ArrayByte} y {upoload.Name}";
        }

        private byte[] StringToByteArray(string cadena)
        {
            Int32 caracteres = cadena.Length;
            byte[] array_datos = new byte[caracteres / 2];
            for (int i = 0; i < caracteres; i += 2)
                array_datos[i / 2] = Convert.ToByte(cadena.Substring(i, 2), 16);
            return array_datos;
        }
    }
}
