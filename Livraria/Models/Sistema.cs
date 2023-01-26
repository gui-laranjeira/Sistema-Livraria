using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal static class Sistema
    {
        //TODO implementar metodo
        public static void RealizarLogin(Funcionario funcionario)
        {
            Console.Clear();
            bool checkLogin = false;
            do
            {
                Console.WriteLine("** Livraria Sinqiars **\nFaça login");
                Console.WriteLine("\nInsira o username: ");
                string login = Validacao.StringV();
                if (funcionario.Login == login)
                {
                    Console.WriteLine("Digite a senha:");
                    string senha = Console.ReadLine();
                    if (funcionario.Senha == senha)
                    {
                        Console.WriteLine("Seja bem vindo!");
                        checkLogin = true;
                    }
                    else
                    {
                        Console.WriteLine("Senha inválida, tente novamente");
                    }
                }
                else
                {
                    Console.WriteLine("Usuário incorreto! tente novamente");
                }
            } while (checkLogin == false);
        }
        
        //TODO implementar metodo
        public static Cliente RegistrarCliente()
        {
            Console.WriteLine("Insira o nome e sobrenome:");
            string nome = Validacao.StringV();            
            Console.WriteLine("Insira o cpf: (Apenas números)");
            string cpf = Validacao.CPF();
            Console.WriteLine("Insira a idade:");
            int idade = Validacao.IntV();
            Console.WriteLine("Insira o endereço:");
            string endereco = Validacao.StringV();
            Console.WriteLine("Insira o email:");
            string email = Validacao.StringV();

            Cliente cliente = new Cliente(nome, cpf, idade, endereco, email);
            
            return cliente;
        }

        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Livraria Sinqiers");
            Console.WriteLine("(1) - Cadastrar Cliente ");
            Console.WriteLine("(2) - Cadastrar Produto ");
            Console.WriteLine("(3) - Realizar venda ");
            Console.WriteLine("(4) - Consultar estoque ");
            Console.WriteLine("(5) - Consultar estoque por título ");
            Console.WriteLine("(6) - Consultar comissões do funcionario ");
            Console.WriteLine("(0) - Sair ");

            int input;
            bool checkInput;
            do
            {
                checkInput = int.TryParse(Console.ReadLine(), out input);
                if (checkInput == false)
                {
                    Console.WriteLine("Digite uma opção válida: ");
                }
                    
                else if (input > 6 && input <0)
                {
                    Console.WriteLine("Opção digitada não existe! Digite uma opção válida: ");
                    checkInput = false;
                }
            } while (!checkInput);

            return input;
        }


        //TODO Finalizar Busca cliente
        //public static Cliente ChecarClienteValido(List<Cliente> clientes)
        //{
        //    Cliente cliente = BuscarCliente(clientes);
        //    if (cliente.Nome == "")
        //    {
        //        return cliente;
        //    }
        //    else
        //    {
        //        throw new Exception("Cliente inexistente");
               
        //    }
        //}
        public static Cliente BuscarCliente(List<Cliente> clientes)
        {
           string nomeCliente;
           Cliente cliente = new Cliente();                
           Console.WriteLine("Qual o nome do cliente: (Digite SAIR para cancelar)");
           nomeCliente = Validacao.StringV();
           foreach (Cliente c in clientes)
           {
               if (c.Nome == nomeCliente)
               {
                   cliente = c;
                   return cliente;
               }                   
           }                                            
            return cliente;
        }                 
    }
}
