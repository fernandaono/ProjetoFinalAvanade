using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAvanadeCliente.Models
{
    public class DBContexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Banking_Clientes;Data Source=localhost\MSSQLSERVER01");
            }
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}