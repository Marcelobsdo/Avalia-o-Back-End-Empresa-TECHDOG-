using System.Collections.Generic;
using TD_ApplicationCore.Entity;

namespace TD_ApplicationCore.Interfaces.Services
{
    public interface IEscolaService
    {
        IEnumerable<Escola> Listar();
        void Cadastrar(Escola escola);
        void Editar(Escola escola);
        void Excluir(int id);
    }
}