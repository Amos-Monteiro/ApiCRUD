using Chapter.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Chapter.webapi.Context
{
    public class ChapterContext: DbContext 
    {
        private const string ConnectionString = "User ID=sa;Password=Holymountains1;Server=AMOS\\SQLEXPRESS;Database=Chapter;-+ Trusted_connection=false;";

        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext>options) : base (options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ID=sa;Password=Holymountains1;Server=amos\\SQLEXPRESS;Database=Chapter;- + Trusted_connection=False");
            }
        }
         public DbSet<Livro> Livros {get; set;}
    } 
}