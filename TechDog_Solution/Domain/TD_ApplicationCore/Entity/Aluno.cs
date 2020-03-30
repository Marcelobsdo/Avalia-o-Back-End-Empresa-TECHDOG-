using System;

namespace TD_ApplicationCore.Entity
{
    
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public int TurmaId { get; set; }

        public Turma Turma { get; set; }
        
    }
}