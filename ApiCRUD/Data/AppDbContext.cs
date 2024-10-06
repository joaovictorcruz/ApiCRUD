using ApiCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCRUD.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        public DbSet<AutorModel> Autores { get; set; } //Tabela de autores
        public DbSet<LivroModel> Livros { get; set; } //Tabela de livros
    }
}
 