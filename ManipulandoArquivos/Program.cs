using ManipulandoArquivos.Helper;
using System;
using System.IO;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";

            var caminhoPath = Path.Combine(caminho, "Pasta Teste 1");

            FileHelper helper = new FileHelper();

            //helper.ListarDiretorio(caminho);
            //helper.ListarAquivos(caminho);
            helper.ApagarDiretorio(caminhoPath, true);


        }
    }
}
