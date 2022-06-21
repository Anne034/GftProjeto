using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico
{
   public class Concessionaria
    {
      public void MostrarTabela()
        {
            Console.WriteLine("Exercicio da Concessionaria");
            Console.WriteLine("Digite o valor do carro:");
            double valor = double.Parse(Console.ReadLine());

            //Desconto de 20% é a mesma coisa que 80% do valor

            double precoFinalAVista = valor * 0.8;
            double precoParcela6 = valor * 1.03;
            double precoParcela12 = valor * 1.06;
            double precoParcela18 = valor * 1.09;

            Console.WriteLine("Segue os possiveis valores para o carro:");
            Console.WriteLine($"Vista: R${precoFinalAVista:0.00}");
            Console.WriteLine($"6 Parcelas: R${precoParcela6:0.00} - Cada parcela: R${precoParcela6 / 6:0.00}");
            Console.WriteLine($"12 Parcelas: R${precoParcela12:0.00} - Cada parcela: R${precoParcela12 / 12:0.00}");
            Console.WriteLine($"18 Parcelas: R${precoParcela18:0.00} - Cada parcela: R${precoParcela18 / 18:0.00}");
       }
    }
}
