using cp_csharp.Fornecedor;
using cp_csharp.Produto;
using cp_csharp.Pedido;

namespace cp_csharp.Data
{
    public static class DataInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            
            context.Database.EnsureCreated();

            
            if (context.RM98436_Fornecedores.Count() >= 10 &&
                context.RM98436_Produtos.Count() >= 10 &&
                context.RM98436_Pedidos.Count() >= 10)
            {
                return; 
            }


            var fornecedores = new RM98436_FornecedorModel[]
            {
                new RM98436_FornecedorModel { nrCEP = "01310-200", dsEndereco = "Av. Paulista, 1000", Estado = "SP", Cidade = "São Paulo" },
                new RM98436_FornecedorModel { nrCEP = "20050-001", dsEndereco = "Av. Rio Branco, 156", Estado = "RJ", Cidade = "Rio de Janeiro" },
                new RM98436_FornecedorModel { nrCEP = "70070-120", dsEndereco = "Esplanada dos Ministérios", Estado = "DF", Cidade = "Brasília" },
                new RM98436_FornecedorModel { nrCEP = "40020-901", dsEndereco = "Av. Sete de Setembro, 1001", Estado = "BA", Cidade = "Salvador" },
                new RM98436_FornecedorModel { nrCEP = "90010-907", dsEndereco = "Rua dos Andradas, 1234", Estado = "RS", Cidade = "Porto Alegre" },
                new RM98436_FornecedorModel { nrCEP = "80010-010", dsEndereco = "Rua XV de Novembro, 100", Estado = "PR", Cidade = "Curitiba" },
                new RM98436_FornecedorModel { nrCEP = "30130-170", dsEndereco = "Av. Afonso Pena, 1500", Estado = "MG", Cidade = "Belo Horizonte" },
                new RM98436_FornecedorModel { nrCEP = "69020-110", dsEndereco = "Av. Eduardo Ribeiro, 200", Estado = "AM", Cidade = "Manaus" },
                new RM98436_FornecedorModel { nrCEP = "50030-230", dsEndereco = "Av. Conde da Boa Vista, 800", Estado = "PE", Cidade = "Recife" },
                new RM98436_FornecedorModel { nrCEP = "66010-040", dsEndereco = "Av. Presidente Vargas, 300", Estado = "PA", Cidade = "Belém" }
            };

            context.RM98436_Fornecedores.AddRange(fornecedores);
            context.SaveChanges();

            
            var produtos = new RM98436_ProdutoModel[]
            {
                new RM98436_ProdutoModel { nmProduto = "Notebook Pro", preco = 5499.99M },
                new RM98436_ProdutoModel { nmProduto = "Smartphone X", preco = 2999.99M },
                new RM98436_ProdutoModel { nmProduto = "Monitor 4K", preco = 1899.99M },
                new RM98436_ProdutoModel { nmProduto = "Teclado Mecânico", preco = 449.99M },
                new RM98436_ProdutoModel { nmProduto = "Mouse Gamer", preco = 299.99M },
                new RM98436_ProdutoModel { nmProduto = "Headset Wireless", preco = 599.99M },
                new RM98436_ProdutoModel { nmProduto = "Webcam HD", preco = 249.99M },
                new RM98436_ProdutoModel { nmProduto = "SSD 1TB", preco = 799.99M },
                new RM98436_ProdutoModel { nmProduto = "Memória RAM 16GB", preco = 399.99M },
                new RM98436_ProdutoModel { nmProduto = "Placa de Vídeo RTX", preco = 3999.99M }
            };

            context.RM98436_Produtos.AddRange(produtos);
            context.SaveChanges();

            
            var pedidos = new RM98436_PedidoModel[]
            {
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-01"), valorTotal = 8499.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-02"), valorTotal = 3299.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-03"), valorTotal = 2349.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-04"), valorTotal = 749.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-05"), valorTotal = 899.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-06"), valorTotal = 4599.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-07"), valorTotal = 1199.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-08"), valorTotal = 999.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-09"), valorTotal = 6999.98M },
                new RM98436_PedidoModel { dataPedido = DateTime.Parse("2025-09-10"), valorTotal = 5499.98M }
            };

            context.RM98436_Pedidos.AddRange(pedidos);
            context.SaveChanges();
        }
    }
}
