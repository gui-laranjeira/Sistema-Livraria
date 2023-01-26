using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    internal class Cliente : Pessoa
    {
        public string Endereco { get; set; }
        public string Email { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf, int idade, string endereco, string email) : base(nome, cpf, idade)
        {
            Endereco = endereco;
            Email = email;
        }
    }
}
