using System;

namespace Main.models
{
    public  abstract class Conta:Object
    {
        protected decimal saldo;




        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {

            Console.WriteLine("O seu saldo é de "+saldo);
            
        }
          
        
        
        
        
    }
}