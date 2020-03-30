using System.Collections.Generic;

namespace TD_ApplicationCore.Interfaces.Repository.Base
{
    public interface IRepository<T>
    {
            IEnumerable<T> Listar();
            void Cadastrar(T entity);
            void Editar(T entity);
            void Excluir(int id);
    }
}