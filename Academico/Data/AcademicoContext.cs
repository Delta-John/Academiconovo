using Academico.Models;
using Microsoft.EntityFrameworkCore;

namespace Academico.Data
{
    public class AcademicoContext : DbContext
    {
        public AcademicoContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Departamento> Departamentos { get; set;}

    }
}
