using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Cargo
{
    public class CargoBusiness
    {
        public int Salvar(CargoDTO dto)
        {
            CargoDataBase db = new CargoDataBase();
            return db.Salvar(dto);
        }

        public List<CargoDTO> Listar()
        {
            CargoDataBase db = new CargoDataBase();
            return db.Listar();
        }

        public List<CargoDTO> Consultar(string nome)
        {
            CargoDataBase db = new CargoDataBase();
            return db.Consultar(nome);
        }
    }
}
