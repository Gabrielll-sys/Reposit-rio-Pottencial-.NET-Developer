﻿using System;

namespace FundamentosDotNet.models
{
/// <summary>
/// Classe de uma calculadora
/// </summary>
    public class Calculator
    {
        
        
        
        
        /// <summary>
        /// Realiza a operação de soma de da calculadora meu parça
        /// </summary>
        /// <param name="x"> O primeiro valor</param>
        /// <param name="y"> O Valor que será somado ao primeiro valor</param>
        public void Somar(int x , int y)
        {
            Console.WriteLine($"A soma entre {x} e {y} é igual {x+y}");

        }
        public void Subtrair(int x , int y)
        {
            if (x < y)
            {
                Console.WriteLine("Não pode fazer operação com valor negativo");
            }
            
            Console.WriteLine($"A subtração entre {x} e {y} é igual {x-y}");

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Retorna o valor de x multiplacado por y</returns>
        public int Multiplicar(int x , int y)
        {
            Console.WriteLine($"A soma entre {x} e {y} é igual {x+y}");
            return x * y;
        }
        public void Divisao(float x , float y)
        {
            Console.WriteLine($"A soma entre {x} e {y} é igual {x/y}");

        }
        public void Potencia(int x, int y)
        {
            
            Console.WriteLine(Math.Pow(x,y));
        
        }
        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            
            Console.WriteLine($"Seno de {angulo} é igual a {Math.Round(seno,4)}");
        
        
        
        }
        public void Cosseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            
            Console.WriteLine($"Coseno de {angulo} é igual a {Math.Round(coseno,4)}");
        
        
        
        } 
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            
            Console.WriteLine($"Coseno de {angulo} é igual a {Math.Round(tangente,4)}");
            
        }

        public void Raiz(double x)
        {
            Console.WriteLine(Math.Sqrt(x));
            
        }
    }
   
}