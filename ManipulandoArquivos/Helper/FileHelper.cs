using System;
using System.IO;

namespace ManipulandoArquivos.Helper
{
    class FileHelper
    {
        public void ListarDiretorio(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }
         public void ListarAquivos(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);

            Console.WriteLine(retorno.FullName);
           
        }
        public void CriarArquivoTexto(string caminho, string conteudo )
        {   
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
                
        }
    }
}
