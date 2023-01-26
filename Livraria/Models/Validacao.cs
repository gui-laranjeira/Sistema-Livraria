using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public static class Validacao
    {
        // Verifica que a string não é vazia
        public static string StringV()
        {
            string a;
            do
            {
                a = Console.ReadLine();
                if (a == String.Empty)
                    Console.Write("Não deixe esse espaço vazio! Digite novamente:");
            } while (a == String.Empty);

            return a;
        }
        //Verifica se o usuario digitou um inteiro
        public static int IntV()
        {
            int a = 0;
            bool b = false;
            do
            {
                b = int.TryParse(Console.ReadLine(), out a);
                if (b == false)
                    Console.Write("Número inválido! Digite novamente: ");
            } while (b == false);
            return a;
        }
        //Verifica se usuário digitou um Double
        public static double DoubleV()
        {
            double a = 0.0;
            bool b = false;
            do
            {
                b = double.TryParse(Console.ReadLine(), out a);
                if (b == false)
                    Console.Write("Número inválido! Digite novamente: ");
            } while (b == false);
            return a;
        }
        //Verifica se usuário digitou um Decimal 
        public static decimal DecimalV()
        {
            decimal a = 0.00M;
            bool b = false;
            do
            {
                b = decimal.TryParse(Console.ReadLine(), out a);
                if (b == false)
                    Console.Write("Número inválido! Digite novamente: ");
            } while (b == false);
            return a;
        }
        // verifica se o usuário digitou CPF com 11 digitos e retorna no formato
        public static string CPF()
        {
            string cpf;
            long converteCPF;
            bool verif;
            do
            {
                cpf = Console.ReadLine();
                verif = long.TryParse(cpf, out converteCPF);
                if (verif == false)
                    Console.Write("Digite apenas numeros do CPF: ");
                else if (cpf.Length != 11)
                    Console.Write("O CPF precisa ter 11 digitos: ");
                else
                    Console.WriteLine("CPF registrado com sucesso! ");
            } while (cpf.Length != 11 || verif == false);
            return converteCPF.ToString(@"000\.000\.000\-00");
        }
        // retorna um valor em string para representar dinheiro
        public static string Real(decimal real)
        {
            return real.ToString("C");
        }
        public static string Real(double real)
        {
            return real.ToString("C");
        }
        public static string Real(int real)
        {
            return real.ToString("C");
        }
    }
}
