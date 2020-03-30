using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Interfaces.Repository;
using TD_Infrastructure.Data;

namespace TD_Infrastructure.Repositories
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly DataContext _dataContext;

        public TurmaRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Cadastrar(Turma entity)
        {
            _dataContext.Turmas.Add(entity);
            _dataContext.SaveChanges();
        }

        public void Editar(Turma entity)
        {
            _dataContext.Turmas.Update(entity);
            _dataContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var item = _dataContext.Turmas.Where(a => a.Id == id).Single();
            _dataContext.Turmas.Remove(item);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Turma> Listar()
        {
            return _dataContext.Turmas.Include(c => c.Escola).ToList();
        }
    }
}