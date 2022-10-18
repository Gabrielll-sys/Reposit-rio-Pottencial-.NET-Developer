using System;
using System.Collections.Generic;

namespace Main.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa>Alunos { get; set; }

        public void AdicionarAluno(Pessoa Aluno)
        {
            Alunos.Add(Aluno);
            
        }  
        public int QuantidadeAlunos()
        {
            int i = Alunos.Count;
            return i ;
        } 
        public bool RemoverAluno(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
        }
        public void ListarAlunos()
        {
            
            for(int i =0;i<Alunos.Count;i++)

            {
                string texto = $"N {i+1} {Alunos[i].NomeCompleto}"; 
               Console.WriteLine(texto);
           }
        }
    }
}