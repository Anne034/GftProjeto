using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico
{
    public class Censo
    {   
       public void Ativar()
      {
            bool continuar = true;
            double totalSalario = 0;
            double maiorSalario = 0;
            int totalFilhos = 0;
            int totalPessoas = 0;
            int totalPessoasSalario350 = 0;

            Console.WriteLine("Exercicio Censo! ");

            while (continuar)
            {
                Console.WriteLine("Digite o seu salário:"); 
                double salario = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o numero de filhos:");
                int filhos = int.Parse(Console.ReadLine());

                //Gravar totais
                totalSalario += salario;
                totalFilhos += filhos;
                totalPessoas++;

                //Verifica o maior salario
                if (maiorSalario < salario)
                    maiorSalario = salario;

                //Grava pessoas com salario ate 350
                if (salario <= 350.00)
                    totalPessoasSalario350++;

                Console.WriteLine("Digite 's' para sair ou qualquer outro botão para continuar a cadastrar");
                if (Console.ReadLine() == "s")
                    continuar = false;
            }

            double mediaSalario = totalSalario / totalPessoas;
            double mediaFilhos = totalFilhos / (double)totalPessoas;
            double percentual350 = totalPessoasSalario350 / (double)totalPessoas;

            Console.WriteLine($"Media de salario: R${mediaSalario:0.00}");
            Console.WriteLine($"Media de filhos: {mediaFilhos:0.00}");
            Console.WriteLine($"Maior salário: R${maiorSalario:0.00}");
            Console.WriteLine($"Percentual de pessoas que ganham ate R$350,00: {percentual350 * 100:0.00}%");
        }
    }
} 
  