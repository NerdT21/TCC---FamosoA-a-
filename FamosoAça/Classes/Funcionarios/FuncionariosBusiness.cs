using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Funcionarios
{
    public class FuncionariosBusiness
    {
        public int Salvar(FuncionarioDTO dto)
        {
            FuncionarioDataBase db = new FuncionarioDataBase();
            return db.Salvar(dto);
        }

        public List<FuncionarioDTO> Listar()
        {
            FuncionarioDataBase db = new FuncionarioDataBase();
            return db.Listar();
        }

        public List<FuncionarioDTO> Consultar(string nome, string cidade)
        {
            FuncionarioDataBase db = new FuncionarioDataBase();
            return db.Consultar(nome, cidade);
        }
    }
}
