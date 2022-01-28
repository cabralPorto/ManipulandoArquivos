using ManipulandoArquivos.Helper;
using System;
using System.Collections.Generic;
using System.IO;

namespace ManipulandoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            // var caminhoArquivo = Path.Combine(caminho, "Arquivo-Teste.txt");
            var caminhoArquivo = Path.Combine(caminho, "Arquivo-Teste-Stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo-Teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo-Teste-bkp.txt");
            var NovocaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2","Arquivo-Teste-Stream.txt");
            //var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 1" );
            var ListaString = new List<string> { "Linha1", "Linha2", "Linha3" };
            var ListaStringContinuacao = new List<string> { "Linha4", "Linha5", "Linha6" };

            FileHelper helper = new FileHelper();

            // helper.ListarDiretorio(caminho);

            //var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3", "SubPastaTeste3");

            //Console.WriteLine("Criando Diretório: " + caminhoPathCombine);

            //helper.CriarDiretorio(caminhoPathCombine);

            //helper.ListarAquivos(caminho);

            //helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo. ");

            //helper.CriarArquivoTextoStream(caminhoArquivo, ListaString);

            //helper.AdcionarTextoStream(caminhoArquivo, ListaStringContinuacao);

            //helper.LerArquivoStream(caminhoArquivo);

            //helper.MoverArquivo(caminhoArquivo, NovocaminhoArquivo, false);

            helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);

        }
    }
}
