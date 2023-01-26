using Livraria.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal class Estoque
    {
        public List<IProduto> ProdutosEmEstoque { get; set; } = new List<IProduto>();
        int id = 1;

        public void RegistrarProduto()
        {
            Console.WriteLine("(1) - Livro");
            Console.WriteLine("(2) - Ebook");
            int input = Validacao.IntV();

            if (input == 1)
            {
                Console.WriteLine("Insira o título:");
                string titulo = Validacao.StringV();

                Console.WriteLine("Insira o autor:");
                string autor = Validacao.StringV();

                Console.WriteLine("Insira a editora:");
                string editora = Validacao.StringV(); 
                
                Console.WriteLine("Insira o ano de publicação:");
                int anoPublicacao = Validacao.IntV();

                Console.WriteLine("Insira o ISBN do livro:");
                string isbn = Validacao.StringV();

                Console.WriteLine("Insira o preço do livro:");
                double preco = Validacao.DoubleV();

                IProduto produto = new Livro(id, titulo, autor , editora, anoPublicacao, isbn, preco);
                ProdutosEmEstoque.Add(produto);
                ++id;
                Console.Clear();
                Console.WriteLine($"O livro {produto.Titulo} foi adicionado.");
            }
            else if (input == 2)
            {
                Console.WriteLine("Insira o título:");
                string titulo = Validacao.StringV();

                Console.WriteLine("Insira o autor:");
                string autor = Validacao.StringV();

                Console.WriteLine("Insira a editora:");
                string editora = Validacao.StringV();

                Console.WriteLine("Insira o ano de publicação:");
                int anoPublicacao = Validacao.IntV();

                Console.WriteLine("Insira o ISBN do livro:");
                string isbn = Validacao.StringV();

                Console.WriteLine("Insira o preço do livro:");
                double preco = Validacao.DoubleV();

                IProduto produto = new Ebook(id, titulo, autor, editora, anoPublicacao, isbn, preco);
                ProdutosEmEstoque.Add(produto);
                ++id;
                Console.Clear();
                Console.WriteLine($"O ebook {produto.Titulo} foi adicionado.");
            }
            else
            {
                Console.WriteLine("Insira uma opção válida!");
            }                         
        }
        public void ConsultarEstoque()
        {
            Console.Clear();
            Console.WriteLine("Items em estoque:\n ");
            foreach(IProduto produto in ProdutosEmEstoque)
            {
                Log.ImprimirInformacoes(produto);
                Console.WriteLine();
            }
        }
        public void ConsultarEstoquePorTitulo()
        {            
            Console.WriteLine("Insira o nome do título: ");
            string nome = Validacao.StringV();
            bool v = false;
            foreach (IProduto n in ProdutosEmEstoque)
            {
                if (n.Titulo.ToUpper() == nome.ToUpper())
                {
                    Log.ImprimirInformacoes(n);
                    v = true;
                }                                 
            }
            if (v == false)
            {
                Console.WriteLine("Produto não encontrado em estoque. ");
            }
        }
        public void RealizarVenda(List<Cliente> clientes, Funcionario funcionario, Estoque estoque)
        {
            Console.WriteLine("Insira o nome do cliente: ");
            string nomeCliente = Console.ReadLine();
            bool clienteEncontrado = false;
            Cliente cliente = new();
            foreach(Cliente c in clientes)
            {
                if (nomeCliente.ToUpper() == c.Nome.ToUpper())
                {                    
                    clienteEncontrado = true;
                    cliente = c;
                }
            }
            if (clienteEncontrado == false)
            {
                Console.WriteLine("Cliente não encontrado!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Cliente {cliente.Nome} encontrado!\n");
                Console.WriteLine("Insira o título do produto: ");
                string nome = Validacao.StringV();
                bool v = false;
                foreach (IProduto n in estoque.ProdutosEmEstoque.ToList())
                {
                    if (n.Titulo.ToUpper() == nome.ToUpper())
                    {
                        v = true;
                        Console.WriteLine($"\n\nPreço do produto: {Validacao.Real(n.Preco)}");
                        Console.WriteLine("Venda concluída com sucesso");
                        if (n.tipoProduto == Enum.TipoProduto.Livro)
                        {
                            n.EnviarLivro(cliente.Endereco);
                            estoque.ProdutosEmEstoque.Remove(n);
                        }
                        else
                        {
                            n.EnviarLivro(cliente.Email);
                        }
                        funcionario.RegistrarComissao(n.Preco);                        
                    }
                }
                if (v == false)
                {
                    Console.WriteLine("Produto em falta no estoque! ");
                }
            }
            
        }

        public void CadastroInicial()
        {
            Livro l1 = new Livro(this.id, "A Era do Capital: 1848 - 1875", "Eric Hobsbawm", "Paz & Terra", 2012, "978-8577531004", 78.68);
            this.id++;
            Livro l2 = new Livro(this.id, "A Sociedade do Anel: O Senhor dos Anéis 1", "J.R.R Tolkien", "HarperCollins", 2022, "978-6555113631", 59.90);
            this.id++;
            Livro l3 = new Livro(this.id, "Fogo & Sangue vol.1", "George R.R. Martin", "Suma", 2018, "978-8556510761", 79.90);
            this.id++;
            Livro l4 = new Livro(this.id, "Torto Arado", "Itamar Vieira Junior", "Todavia", 2019, "978-6580309313", 62.90);
            this.id++;
            Ebook l5 = new Ebook(this.id, "Admirável Mundo Novo", "Aldous Huxley", "Biblioteca Azul", 2014, "978-8525056009", 26.94);
            this.id++;
            Ebook l6 = new Ebook(this.id, "Código Limpo: Habilidades práticas do Agile Software", "Robert C. Martin", "Alta Books", 2009, "978-8576082675", 84.92);
            this.id++;
            Ebook l7 = new Ebook(this.id, "Arquitetura Limpa: O guia do artesão para estrutura e design de software", "Robert C. Martin", "Alta Books", 2019, "978-8550804606", 74.22);
            this.id++;
            Ebook l8 = new Ebook(this.id, "Uma Breve História do Tempo", "Stephen Hawking", "Intrínseca", 2015, "978-8580576467", 24.90);
            this.id++;
            Livro l9 = new Livro(this.id, "A Lógica da Pesquisa Científica", "Karl Popper", "Cultrix", 2015, "978-8531612503", 55.44);
            this.id++;
            Ebook l10 = new Ebook(this.id, "Sociedade do Cansaço", "Byung-Chul Han", "Vozes", 2015, "978-8532649966", 8.99);
            this.id++;
            ProdutosEmEstoque.Add(l1);
            ProdutosEmEstoque.Add(l2);
            ProdutosEmEstoque.Add(l3);
            ProdutosEmEstoque.Add(l4);
            ProdutosEmEstoque.Add(l5);
            ProdutosEmEstoque.Add(l6);
            ProdutosEmEstoque.Add(l7);
            ProdutosEmEstoque.Add(l8);
            ProdutosEmEstoque.Add(l9);
            ProdutosEmEstoque.Add(l10);
        }
    }
   
}
