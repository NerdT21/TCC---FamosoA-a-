using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra
{
    public class ViewCompra
    {

        public int IdCompra { get; set; }

        public string FormaPag { get; set; }

        public string Data { get; set; }

        public int QTDItem{ get; set; }

        public decimal Total{ get; set; }
    }
}
