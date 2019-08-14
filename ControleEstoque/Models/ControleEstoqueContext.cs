using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Models
{
    public class ControleEstoqueContext : DbContext
    {
        public ControleEstoqueContext() : base("conexaoDesenvolvimento")
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
