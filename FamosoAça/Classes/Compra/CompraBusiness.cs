using FamosoAça.Classes.Compra.Item;
using FamosoAça.Classes.Compra.itemCompra;
using FamosoAça.Classes.Estoque;
using FamosoAça.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Compra
{
    public class CompraBusiness
    {
        public int Salvar(CompraDTO dto, List<ItemView> item)
        {
            string pagto = dto.FormaPagto;
            int qtdPagto = pagto.Count();

            if (qtdPagto == 0)
            {
                throw new ValidacaoException("Defina uma forma de pagamento.");
            }

            CompraDataBase db = new CompraDataBase();
            int IdCompra = db.Salvar(dto);

            ItemCompraBusiness buss = new ItemCompraBusiness();
            foreach (ItemView i in item)
            {
                ItemCompraDTO itemDto = new ItemCompraDTO();
                itemDto.CompraId = IdCompra;
                itemDto.ItemId = i.Id;

                buss.Salvar(itemDto);

                EstoqueBusiness estoqueBuss = new EstoqueBusiness();
                estoqueBuss.Adicionar(1, i.Id);
            }

            return IdCompra;
        }

        public List<ItemComprasView> Listar()
        {
            CompraDataBase db = new CompraDataBase();
            return db.Listar();
        }

        public List<ItemComprasView> Consultar(string data)
        {
            CompraDataBase db = new CompraDataBase();
            return db.Consultar(data);
        }

        public List<ItemComprasView> ConsultarPorId(int id)
        {
            CompraDataBase db = new CompraDataBase();
            return db.ConsultarPorId(id);
        }
    }
}
