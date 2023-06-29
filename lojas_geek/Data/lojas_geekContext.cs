using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lojas_geek.Models;

namespace lojas_geek.Data
{
    public class lojas_geekContext : DbContext
    {
        public lojas_geekContext (DbContextOptions<lojas_geekContext> options)
            : base(options)
        {
        }

        public DbSet<lojas_geek.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<lojas_geek.Models.Fornecedor>? Fornecedor { get; set; }

        public DbSet<lojas_geek.Models.Produto>? Produto { get; set; }

        public DbSet<lojas_geek.Models.Venda>? Venda { get; set; }

        public DbSet<lojas_geek.Models.DadosPag>? DadosPag { get; set; }

        //public DbSet<ProdutoVenda>? ProdutoVenda { get;set; }
    }
}
