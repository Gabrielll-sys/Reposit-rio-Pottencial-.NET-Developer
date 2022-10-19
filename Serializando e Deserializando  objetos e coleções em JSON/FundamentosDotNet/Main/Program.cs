using System;
using System.Collections.Generic;
using Main.models;
using System.Globalization;
using System.IO;
using Newtonsoft.Json;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
            
            //Serialiando LISTA de objetos para JSON
           DateTime dataAtual = DateTime.Now;
           Venda v1 = new Venda(1, "Mterial quarto",25.40M,dataAtual);
           Venda v2 = new Venda(2, "Mterial sala",253.40M,dataAtual);
           List<Venda> vendas = new List<Venda>();
           vendas.Add(v1);
           vendas.Add(v2);
           string serializado = JsonConvert.SerializeObject(vendas,Formatting.Indented);
           Console.WriteLine(serializado);
           
           File.WriteAllText("C:\\Reposit-rio-Pottencial-.NET-Developer\\ExemploFundamentos\\FundamentosDotNet\\Main\\arquivos\\vendas.json",serializado);


           //Deserializando a mesma lista
           string conteudoArquivo =
                File.ReadAllText(
                    "C:\\Reposit-rio-Pottencial-.NET-Developer\\ExemploFundamentos\\FundamentosDotNet\\Main\\arquivos\\vendas.json");
           List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

           foreach (var obj in listaVenda)
           {
               Console.WriteLine($"Venda id{obj.Id} produto {obj.Produto} Preço {obj.Preco} Data{obj.DataVenda}");
           }



        }
    }
}