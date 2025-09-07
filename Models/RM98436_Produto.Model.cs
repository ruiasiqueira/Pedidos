using System.ComponentModel.DataAnnotations;

namespace cp_csharp.Produto
{
    public class RM98436_ProdutoModel
    {
        [Key]
        public int idProduto { get; set; }

        [Required]
        public required string nmProduto { get; set; }

        [Required]
        public decimal preco { get; set; }
    }
}
