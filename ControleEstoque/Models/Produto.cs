using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        [Column("Valor", TypeName = "MONEY")]
        public decimal Valor { get; set; }

        [Column("Quantidade", TypeName = "INT")]
        public int Quantidade { get; set; }
    }
}
