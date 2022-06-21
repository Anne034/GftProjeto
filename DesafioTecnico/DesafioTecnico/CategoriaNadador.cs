using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico
{
    public class CategoriaNadador
    {
        public void RetornarCategoria()
        {
            Console.WriteLine("Exercicio categorias de Nadador");
            Console.WriteLine("Digite uma idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade >= 14)
            {
                Console.WriteLine("Juvenil B");
            }
            else if (idade >= 11)
            {
                Console.WriteLine("Juvenil A");
            }
            else if (idade >= 8)
            {
                Console.WriteLine("Infantil B");
            }
            else
            {
                Console.WriteLine("Infantil A");
            }
        }
    }
}