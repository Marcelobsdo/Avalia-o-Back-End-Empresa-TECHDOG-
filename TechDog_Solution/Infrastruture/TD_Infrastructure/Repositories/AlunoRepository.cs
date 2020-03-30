using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TD_ApplicationCore.Entity;
using TD_ApplicationCore.Interfaces.Repository;
using TD_Infrastructure.Data;
using TD_Infrastructure.Repositories.Base;

namespace TD_Infrastructure.Repositories
{
    public class AlunoRepository : RepositoryBase, IAlunoRepository
    {
        public AlunoRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public void Cadastrar(Aluno entity)
        {
            _dataContext.Alunos.Add(entity);
            _dataContext.SaveChanges();
        }

        public void Editar(Aluno entity)
        {
            _dataContext.Alunos.Update(entity);
            _dataContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            var item = _dataContext.Alunos.Where(a => a.Id == id).Single();
            _dataContext.Alunos.Remove(item);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Aluno> Listar()
        {
            return _dataContext.Alunos.Include(c => c.Turma).ToList();
        }
    }
}