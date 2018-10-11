using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Fornecedor
{
    public class FornecedorBusiness
    {
        public int Salvar(FornecedorDTO dto)
        {
            FornecedorDataBase db = new FornecedorDataBase();
            int id = db.Salvar(dto);
            return id;
        }

        public void Altera(FornecedorDTO dto)
        {
            FornecedorDataBase db = new FornecedorDataBase();
            db.Alterar(dto);
        }

        public void Remover(int id)
        {
            FornecedorDataBase db = new FornecedorDataBase();
            db.Remover(id);
        }


        public List<FornecedorDTO> Listar()
        {
            FornecedorDataBase db = new FornecedorDataBase();
            List<FornecedorDTO> list = db.Listar();
            return list;
        }

        public List<FornecedorDTO> Consultar(string consult, string cosultd)
        {
            FornecedorDataBase db = new FornecedorDataBase();
            return db.Consultar(consult, cosultd);
        }
    }
}
