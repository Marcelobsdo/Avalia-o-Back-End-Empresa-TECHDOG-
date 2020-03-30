using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Interfaces.Repository;
using TD_Infrastructure.Data;

namespace TD_Infrastructure.Repositories
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly DataContext _dataContext;

        public EscolaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Cadastrar(Escola entity)
        {
            _dataContext.Escolas.Add(entity);
            _dataContext.SaveChanges();
        }

        public void Editar(Escola entity)
        {
            _dataContext.Escolas.Update(entity);
            _dataContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var item = _dataContext.Escolas.Where(a => a.Id == id).Single();
            _dataContext.Escolas.Remove(item);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Escola> Listar()
        {
            return _dataContext.Escolas.Include(e => e.Endereco).ToList();
        }
    }
}