using System.Collections.Generic;
using TD_ApplicationCore.Entity.ValueObjects.Base;

namespace TD_ApplicationCore.Entity.ValueObjects
{
    //Os sets das propriedades estão públicas para fins de serialização de desserialização
    public class Endereco : ValueObject
    {
        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        private Endereco() { }

        public Endereco(string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Logradouro;
            yield return Complemento;
            yield return Bairro;
            yield return Cidade;
            yield return Estado;
        }
    }
}