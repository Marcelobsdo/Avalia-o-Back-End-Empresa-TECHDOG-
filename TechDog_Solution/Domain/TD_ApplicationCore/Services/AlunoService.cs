using System.Collections.Generic;
using TD_ApplicationCore.Interfaces.Services;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Interfaces.Repository;

namespace TD_ApplicationCore.Services
{
    public class AlunoService : IAlunoService
    {
        private IAlunoRepository _AlunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _AlunoRepository = alunoRepository;
        }
        public void Cadastrar(Aluno aluno)
        {
            _AlunoRepository.Cadastrar(aluno);
        }

        public void Editar(Aluno aluno)
        {
            _AlunoRepository.Editar(aluno);
        }

        public void Excluir(int id)
        {
            _AlunoRepository.Excluir(id);
        }

        public IEnumerable<Aluno> Listar()
        {
            return _AlunoRepository.Listar();
        }
    }
}