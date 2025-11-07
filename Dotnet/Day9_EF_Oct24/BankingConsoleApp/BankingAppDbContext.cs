using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankingConsoleApp
{
    public class BankingAppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=localhost;Initial Catalog=Sample;User ID=sa;Password=sql_server@1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;");
        }
        public DbSet<Customer> Customers { get; set; }  
    }
}
