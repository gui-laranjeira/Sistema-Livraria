using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        
        public string CPF { get; set; }
        public int Idade { get; set; }

        public Pessoa() { }
        public Pessoa(string nome, string cpf, int idade)
        {
            Nome = nome;           
            CPF = cpf;
            Idade = idade;
        }
    }
}
