using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourierBA_dsAPIS.Models
{
    public class PA_tblReferencia2Model
    {
        public int Empresa { get; set; }
        public string Descripcion { get; set; }
        public int ReferenciaPadre { get; set; }
        public string Observacion { get; set; }
        public string UserName { get; set; }
        public float Monto { get; set; }
        public int Peso { get; set; }
        public int Pieza { get; set; }
        public int Producto { get; set; }
        public int Moneda { get; set; }
    }
}