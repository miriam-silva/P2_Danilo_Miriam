using Microsoft.EntityFrameworkCore;
using DisciplinasApi.Models;

namespace DisciplinasApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}
