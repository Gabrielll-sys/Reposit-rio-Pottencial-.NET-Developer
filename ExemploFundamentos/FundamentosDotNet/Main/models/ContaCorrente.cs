using System;

namespace Main.models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }


        public ContaCorrente(int numeroConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
            
        }
        
        public void Sacar(decimal x )
        {

            if (x <= Saldo)
            {
                Saldo -= x;
                Console.WriteLine("Sacado");
                Console.WriteLine(Saldo);
            }
            else
            {
                Console.WriteLine("Valor de saque maior que o saldo");
            }
        }
        
         
        public void MostrarSaldo()
        {

            Console.WriteLine(Saldo);
        
        }
        
    }
   
}