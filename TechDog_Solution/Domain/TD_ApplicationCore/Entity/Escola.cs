
using TD_ApplicationCore.Entity.ValueObjects;

namespace TD_ApplicationCore.Entity
{
    public class Escola
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Endereco Endereco { get; set; }
    }
}