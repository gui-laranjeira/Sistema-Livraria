using Livraria.Models;

#region INSTÂNCIAÇÕES
Funcionario funcionario = new Funcionario("João Pedro", "cpf", 21, "admin", "admin");

Cliente cliente1 = new Cliente("Guilherme Laranjeira", "41245125648", 23, "Rua Laranjais 1029", "guilr13@gmail.com");
Cliente cliente2 = new Cliente("Matheus Silva", "98584512345", 17, "Av. Paulista 2056", "matheus.silva@gmail.com");
List<Cliente> clientes = new List<Cliente>();
clientes.Add(cliente1);
clientes.Add(cliente2);

Estoque estoque = new Estoque();
estoque.CadastroInicial();
#endregion

Sistema.RealizarLogin(funcionario);

int input;
do
{
    input = Sistema.Menu();

    //MENU
    //CadastrarCliente
    //CadastrarIProduto
    //RealizarVenda
    //ConsultarEstoque
    //Consultar comissão

    switch (input)
    {
        case 0:
            break;

        case 1:
            Cliente c = Sistema.RegistrarCliente();
            clientes.Add(c);
            Console.WriteLine("\nCliente registrado com sucesso!\nDigite ENTER para continuar");
            Console.ReadKey();
            break;

        case 2:
            var produto = Sistema.InstanciarProduto();
            estoque.RegistrarProduto(produto);
            Console.ReadKey();
            break;

        case 3:                             
            estoque.RealizarVenda(clientes, funcionario, estoque);
            Console.ReadKey();                
            break;

        case 4:
            estoque.ConsultarEstoque();
            Console.ReadKey();
            break;

        case 5:
            estoque.ConsultarEstoquePorTitulo();
            Console.ReadKey();
            break;

        case 6:
            funcionario.ConsultarComissoes();
            Console.ReadKey();
            break;
    }
} while (input != 0);




