using System;
using System.IO;

namespace Main.models
{
    public class Leitura
    {

        public (bool sucesso, string[], int qntd) LeituraArquivo(string arquivo)
        {

            try
            {
                string[] linhas = File.ReadAllLines(arquivo);

                return (true, linhas, linhas.Length);


            }
            catch (Exception)
            {

                return (false, new string[0], 0);

            }



        }
        
        
        
        
        
    }
}