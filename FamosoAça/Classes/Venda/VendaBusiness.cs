using FamosoAça.Classes.Estoque;
using FamosoAça.Classes.Venda.Produto;
using FamosoAça.Classes.Venda.ProdutoVendas;
using FamosoAça.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FamosoAça.Classes.Venda
{
    public class VendaBusiness
    {
        public int Salvar(VendaDTO dto, List<ProdutoDTO> item)
        {
            string pagto = dto.FormaPagto;
            int qtdPagto = pagto.Count();

            if (qtdPagto == 0)
            {
                throw new ValidacaoException("Defina uma forma de pagamento.");
            }

            VendaDataBase db = new VendaDataBase();
            int IdCompra = db.Salvar(dto);

            ProdutoVendasBusiness buss = new ProdutoVendasBusiness();
            foreach (ProdutoDTO i in item)
            {
                ProdutoVendasDTO itemDto = new ProdutoVendasDTO();
                itemDto.VendaId = IdCompra;
                itemDto.ProdutoId = i.Id;

                buss.Salvar(itemDto);

                EstoqueBusiness EstoqueBuss = new EstoqueBusiness();
                EstoqueBuss.Remover(1, i.Id);
            }

            return IdCompra;
        }

        public List<ProdutoVendasView> Listar()
        {
            VendaDataBase db = new VendaDataBase();
            return db.Listar();
        }

        public List<ProdutoVendasView> Consultar(string data)
        {
            VendaDataBase db = new VendaDataBase();
            return db.Consultar(data);
        }
    }
}
