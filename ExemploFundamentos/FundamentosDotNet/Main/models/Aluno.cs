using System;

namespace Main.models
{
    public sealed class Aluno:Pessoa
    {
        public double Nota { get; set; }

        public Aluno(string nome) : base(nome)
        {
            
            
        }
        
        public override void Apresentar()
        {
            base.Apresentar();
        }
    } 
}