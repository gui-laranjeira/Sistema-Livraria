using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal class Funcionario : Pessoa
    {        
        public string Login { get; set; }
        //TODO rever
        public string Senha { get; private set; }

        public List<double> ComissoesDeVenda { get; set; } = new List<double>();
        public Funcionario(string nome, string cpf, int idade, string login, string senha) : base(nome, cpf, idade)
        {
            Login = login;
            Senha = senha;  
        }

        
        public void RegistrarComissao(double preco)
        {
            double comissao = preco * 0.05;
            ComissoesDeVenda.Add(comissao);
            Console.WriteLine($"Comissão de {comissao.ToString("0.00")}R$ adicionado ao próximo pagamento do funcionário {this.Nome}!");
        }

        public void ConsultarComissoes()
        {
            Console.Clear();
            Console.WriteLine($"Comissões de {this.Nome}:");
            double somaTotal = 0;
            foreach(double comissao in ComissoesDeVenda)
            {
                Console.WriteLine(comissao.ToString("0.00") + " R$");
                somaTotal += comissao;
            }
            Console.WriteLine($"Total: {somaTotal.ToString("0.00")} R$");
        }
    }
}
