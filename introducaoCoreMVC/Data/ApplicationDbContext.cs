using introducaoCoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace introducaoCoreMVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Produto> Produto { get; set; }

        //protected overrIDe voID OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle("Data Source=oracle.fiap.com.br:1521/orcl;User ID=PC0323;Password=p#alexd;"); // Substitua "YourConnectionString" pela sua string de conexão com o Oracle
        //}
    }
  
}
