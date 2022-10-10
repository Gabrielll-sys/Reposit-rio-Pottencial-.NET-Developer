using System;
using FundamentosDotNet.models;

namespace FundamentosDotNet
{
    class Program
    {
        static void Main(string[] args)
        {

          bool tem = true;
          
          while(tem){
              Console.WriteLine("1 - Entrar");
              Console.WriteLine("2 - Editar");
              Console.WriteLine("3 - Excluir");
              Console.WriteLine("4 - Sair da aplicação");
          string opcao = Console.ReadLine();
          
          
          switch(opcao){
          case "1":
              Console.WriteLine(" 1 - Entrar");
              break;
          case "2":
              Console.WriteLine("2 - Editar");
              break;
          case "3":
              Console.WriteLine("3 - Excluir");
              break;
           case "4":
              Console.WriteLine("4 - Sair da aplicação");
              tem = false;
              break;
          
          
          }
          
                      
          
          
          
          
          }  



























            //     Console.WriteLine("Digite um letra");
            //     string letra = Console.ReadLine();
            //
            //     switch (letra)
            //     {   
            //         case "a":
            //             case "e":
            //             case "i":
            //             case "o":
            //             case "u":
            //             Console.WriteLine("É uma vogal");
            //             break;
            //             default:
            //                 Console.WriteLine("Não é ma volgal");
            //                 break;
            //     }
            // }



















            // int estoque = 2;
            // int quantidadeCompra = 0;
            // bool daPraVender = quantidadeCompra < estoque;
            // Console.WriteLine($"Quantidade em estoque {estoque}");
            // Console.WriteLine($"Quantidade de compra {quantidadeCompra}");
            //
            //
            // if (quantidadeCompra == 0)
            // {
            // Console.WriteLine("Venda invalida");
            //     
            // }
            //
            //
            // else if (daPraVender)
            // {
            //     Console.WriteLine("Venda realizada");
            //     
            // }






        }
    }
}