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

        public int IdItemProduto { get; set; }

        public long QTDestocada { get; set; }

        public string NomeProduto { get; set; }


    }
}
