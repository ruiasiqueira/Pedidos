using System.ComponentModel.DataAnnotations;

namespace cp_csharp.Pedido
{
    public class RM98436_PedidoModel
    {
        [Key]
        public int idPedido { get; set; }

        [Required]
        public DateTime dataPedido { get; set; }

        [Required]
        public decimal valorTotal { get; set; }
    }
}
