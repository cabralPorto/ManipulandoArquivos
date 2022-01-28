using ManipulandoArquivos.Helper;
using System;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";

            FileHelper helper = new FileHelper();

            //helper.ListarDiretorio(caminho);

            helper.ListarAquivos(caminho);
        }
    }
}
