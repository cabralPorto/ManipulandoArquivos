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

            FileHelper helper = new FileHelper();

 CriarDiretorio
            // helper.ListarDiretorio(caminho);

            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "SubPastaTeste3");

            Console.WriteLine("Criando Diretório: " + caminhoPathCombine);
            
            helper.CriarDiretorio(caminhoPathCombine);
          
            helper.ListarAquivos(caminho);
 master
        }
    }
}
