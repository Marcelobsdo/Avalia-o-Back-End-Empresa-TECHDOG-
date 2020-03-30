using System.Collections.Generic;
using TD_ApplicationCore.Entity;

namespace TD_ApplicationCore.Interfaces.Services
{
    public interface ITurmaService
    {
        IEnumerable<Turma> Listar();
        void Cadastrar(Turma turma);
        void Editar(Turma turma);
        void Excluir(int id);
    }
}