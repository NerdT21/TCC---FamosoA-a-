using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estado
{
    class EstadoBusiness
    {
        public List<EstadoDTO> Listar()
        {
            EstadoDataBase db = new EstadoDataBase();
            return db.Listar();
        }
    }
}
