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
            Venda v1 = new Venda(1, "Mterial quarto",25.40M);
            Venda v2 = new Venda(2, "Mterial sala",253.40M);
            List<Venda> vendas = new List<Venda>();
            vendas.Add(v1);
            vendas.Add(v2);
            string serializado = JsonConvert.SerializeObject(vendas,Formatting.Indented);
            Console.WriteLine(serializado);
        
            File.WriteAllText("C:\\Reposit-rio-Pottencial-.NET-Developer\\ExemploFundamentos\\FundamentosDotNet\\Main\\arquivos\\vendas.json",serializado);




        }
    }
}