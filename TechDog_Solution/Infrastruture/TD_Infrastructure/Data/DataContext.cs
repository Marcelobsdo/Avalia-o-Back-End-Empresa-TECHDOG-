using Microsoft.EntityFrameworkCore;
using TD_ApplicationCore.Entity;
using TD_Infrastructure.EntityConfig;

namespace TD_Infrastructure.Data
{
    public class DataContext : DbContext 
    {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Escola> Escolas { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new EscolaMap());
            modelBuilder.ApplyConfiguration(new TurmaMap());
        }
        
    }

}
