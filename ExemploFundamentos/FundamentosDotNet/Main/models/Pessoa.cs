using System;

namespace Main.models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }



        public Pessoa()
        {
            
        }
        public Pessoa(string nome)
        {
            Nome = nome;
        }


        public virtual void Apresentar()
        {

            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos de idade");
            
        }
     
               
    }
}