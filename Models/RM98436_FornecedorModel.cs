using System.ComponentModel.DataAnnotations;

namespace cp_csharp.Fornecedor
{
    public class RM98436_FornecedorModel
    {
        [Key]
        public int idFornecedor { get; set; }

        [Required]
        public required string nrCEP { get; set; }

        [Required]
        public required string dsEndereco { get; set; }

        [Required]
        public required string Estado { get; set; }

        [Required]
        public required string Cidade { get; set; }
    }
}
