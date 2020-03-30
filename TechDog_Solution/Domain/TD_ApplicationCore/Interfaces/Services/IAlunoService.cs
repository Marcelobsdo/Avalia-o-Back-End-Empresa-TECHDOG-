using System.Collections.Generic;
using TD_ApplicationCore.Entity;

namespace TD_ApplicationCore.Interfaces.Services
{
    public interface IAlunoService
    {
        IEnumerable<Aluno> Listar();
        void Cadastrar(Aluno aluno);
        void Editar(Aluno aluno);
        void Excluir(int id);
    }
}