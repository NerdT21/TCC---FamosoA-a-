﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.Classes.Estoque
{
    public class EstoqueDTO
    {
        public int Id { get; set; }

        public int ItemProdutoId { get; set; }

        public string Produto { get; set; }

        public int QtdEstocado { get; set; }
    }
}
