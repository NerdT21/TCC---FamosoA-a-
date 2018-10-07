using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamosoAça.PlugIn
{
    static class ImagemPlugIn
    {
        public static string ConverterParaString(Image imagem)
        {
            MemoryStream memoria = new MemoryStream();
            imagem.Save(memoria, imagem.RawFormat);
            byte[] imagemBytes = memoria.ToArray();
            string imagemEmTexto = Convert.ToBase64String(imagemBytes);
            return imagemEmTexto;
        }

        public static Image ConverterParaImagem(string imagemEmTexto)
        {
            byte[] bytes = Convert.FromBase64String(imagemEmTexto);
            Image imagem = Image.FromStream(new MemoryStream(bytes));
            return imagem;
        }
    }
}
