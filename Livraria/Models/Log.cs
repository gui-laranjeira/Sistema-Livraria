using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Models
{
    public class Log
    {
        public static void ImprimirInformacoes(object obj)
        {
            Type type = obj.GetType();
            foreach(PropertyInfo prop in type.GetProperties()) 
            { 
                object propValor = prop.GetValue(obj);

                Console.WriteLine($"- {prop.Name} -- {propValor}");
            }
        }
    }
}
