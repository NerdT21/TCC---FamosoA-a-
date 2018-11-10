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


        public void Remover(int idfuncionario)
        {
            FuncionarioDataBase DB = new FuncionarioDataBase();
            DB.Remover(idfuncionario);
        }


        public List<ViewFuncionario> Lista()
        {
            FuncionarioDataBase db = new FuncionarioDataBase();
            List<ViewFuncionario> list = db.Listar();
            return list; 
        }

        public List<ViewFuncionario> Listar()
        {
            FuncionarioDataBase DB = new FuncionarioDataBase();
            List<ViewFuncionario> funcionario = DB.Listar();
            return funcionario;
        }

        public List<ViewFuncionario> Consultar(string nome, string cpf)
        {
            FuncionarioDataBase db = new FuncionarioDataBase();
            return db.Consultar(nome, cpf);
        }
    }
}

