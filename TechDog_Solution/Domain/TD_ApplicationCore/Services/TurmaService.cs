using System.Collections.Generic;
using TD_ApplicationCore.Interfaces.Repository;
using TD_ApplicationCore.Interfaces.Services;
using TD_ApplicationCore.Entity;

namespace TD_ApplicationCore.Services
{
    public class TurmaService : ITurmaService
    {
        private ITurmaRepository _TurmaRepository;
        public TurmaService(ITurmaRepository turmaRepository)
        {
            _TurmaRepository = turmaRepository;
        }
        public void Cadastrar(Turma turma)
        {
            _TurmaRepository.Cadastrar(turma);
        }

        public void Editar(Turma turma)
        {
            _TurmaRepository.Editar(turma);
        }

        public void Excluir(int id)
        {
            _TurmaRepository.Excluir(id);
        }

        public IEnumerable<Turma> Listar()
        {
            return _TurmaRepository.Listar();
        }
    }
}