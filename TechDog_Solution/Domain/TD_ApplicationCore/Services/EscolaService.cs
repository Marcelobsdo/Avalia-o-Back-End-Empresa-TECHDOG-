using System.Collections.Generic;
using TD_ApplicationCore.Interfaces.Repository;
using TD_ApplicationCore.Interfaces.Services;
using TD_ApplicationCore.Entity;

namespace TD_ApplicationCore.Services
{
    public class EscolaService : IEscolaService
    {
        private IEscolaRepository _EscolaRepository;

        public EscolaService(IEscolaRepository escolaRepository)
        {
            _EscolaRepository = escolaRepository;
        }
        public void Cadastrar(Escola escola)
        {
            _EscolaRepository.Cadastrar(escola);
        }

        public void Editar(Escola escola)
        {
            _EscolaRepository.Editar(escola);
        }

        public void Excluir(int id)
        {
            _EscolaRepository.Excluir(id);
        }

        public IEnumerable<Escola> Listar()
        {
            return _EscolaRepository.Listar();
        }
    }
}