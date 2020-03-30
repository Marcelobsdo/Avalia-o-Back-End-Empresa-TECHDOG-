
namespace TD_ApplicationCore.Entity
{
    public class Turma
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Capacidade { get; set; }

        public int EscolaId { get; set; }

        public Escola Escola { get; set; }
    }
}