using System;

namespace Main.models
{
    public class Pessoa
    {

        private string _nome { get; set; }
        private int _idade;
        public string Nome {
            get => _nome.ToUpper();
            




            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O seu nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public int Idade
        {
            get =>  _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não poder ser menos que 0");
                }

                _idade = value;
            }
        }

        public void Deconstruct(out string nome,out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;

        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

        }
  public Pessoa()
        {
            
        }


        public void Apresentar()
        {
            Console.WriteLine("Oi meu nome é "+ NomeCompleto);
            
            
        }
    }
}