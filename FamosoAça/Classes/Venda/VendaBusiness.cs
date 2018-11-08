using FamosoAça.Classes.Estoque;
using FamosoAça.Classes.Produto;
using FamosoAça.Classes.Produto.Produto_Venda;
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
            string pagto = dto.FormaDePagamento;
            int qtdpagto = pagto.Count();

            if (qtdpagto == 0)
            {
                MessageBox.Show("Defina uma forma de pagamento.","Famoso Açai",MessageBoxButton.OK);
            }

            VendaDataBase db = new VendaDataBase();
            int idCompra = db.Salvar(dto);

            ProdutoVendaBusiness buss = new ProdutoVendaBusiness();
            foreach (ProdutoDTO i in item)
            {
                ProdutoVendaDTO itemDto = new ProdutoVendaDTO();
                itemDto.IdVenda = idCompra;
                itemDto.IdProduto = i.Id;

                buss.Salvar(itemDto);

                EstoqueBusiness estoque = new EstoqueBusiness();
                estoque.Remover(1, i.Id);
            }

            return idCompra;
            
           
        }

   
        public List<ProdutoVendaView> Listar()
        {
            VendaDataBase db = new VendaDataBase();
            return db.Listar();
        }

        public List<ProdutoVendaView> Consultar(string data)
        {
            VendaDataBase db = new VendaDataBase();
            return db.Consultar(data);
        }

    }
}
