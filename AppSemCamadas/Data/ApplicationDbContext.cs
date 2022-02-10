using AppSemCamadas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppSemCamadas.Data
{
    //nao é bom usar o contexto do identity para o banco de dados em apps com camadas,
    //mas no caso desse exemplo que não usa camadas, não tem problema
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // OnModelCreating resolve o erro da migration 
        // The dependent side could not be determined for the one-to-one relationship between 'Endereco.Fornecedor' and 'Fornecedor.Endereco'.
/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .HasOne(b => b.Endereco)
                .WithOne(i => i.Fornecedor)
                .HasForeignKey<Fornecedor>(b => b.Id);
        }*/

        public DbSet<Produto> Produtos { get; set; }
        
        public DbSet<Fornecedor> Fornecedores { get; set; }
        
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
