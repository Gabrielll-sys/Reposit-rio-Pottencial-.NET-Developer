using System;

namespace Main.models
{
    public class Professor:Pessoa
    {
        public decimal Salario { get; set; }


        public Professor()
        {
            
        }

        public Professor(string nome) : base(nome)
        {
        }

        public  override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("Mas eu sou professor meu parça");
        }
    }
}