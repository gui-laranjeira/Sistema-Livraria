using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Livraria.Models.Enum;

namespace Livraria.Interface
{
    public interface IProduto
    {
        int Id { get; set; }
        string Titulo { get; set; }
        string Autor { get; set; }
        string Editora { get; set; }
        int AnoPublicacao { get; set; }
        string ISBN { get; set; }
        double Preco { get; set; }
        TipoProduto tipoProduto { get; set; }

        void EnviarLivro(string endereco);
    }
}
