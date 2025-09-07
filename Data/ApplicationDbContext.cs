using Microsoft.EntityFrameworkCore;
using cp_csharp.Fornecedor;
using cp_csharp.Produto;
using cp_csharp.Pedido;

namespace cp_csharp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<RM98436_FornecedorModel> RM98436_Fornecedores { get; set; }
        public DbSet<RM98436_ProdutoModel> RM98436_Produtos { get; set; }
        public DbSet<RM98436_PedidoModel> RM98436_Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("Data Source=oracle.fiap.com.br:1521/ORCL;User Id=RM98436;Password=040604;");
        }
    }
}
