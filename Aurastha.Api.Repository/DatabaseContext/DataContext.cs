using Aurastha.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurastha.Api.Repository.DatabaseContext
{
    public class DataContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public DataContext()
        {
            
        }

        public DataContext(DbContextOptions<DataContext> options
                           , IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-95OMLPC; user id=Aurastha; password=AurasthaPwd#1; database=aurastha; Encrypt=False;");
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeAddressDetails> EmployeeAddressDetails { get; set; }
        //public DbSet<EmployeeBankAccount> EmployeeBankAccounts { get; set; }
        //public DbSet<EmployeeReference> EmployeeReferences { get; set; }

    }
}
