using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTecnico
{
    public class TotalVendas
    {
        public void AtivarTransacoes()
        {
            List<Transacao> transacoes = new List<Transacao>();

            Console.WriteLine("Exercicio de transações");

            //Continua a pedir o codigo da transacao até 5 transacoes
            while (transacoes.Count < 5)
            {
                Console.WriteLine("Digite o código da transacao: (p) ou (v)");
                string opcao = Console.ReadLine().ToLower();
                if (opcao == "p")
                {
                    Transacao transacao = new Transacao();
                    transacao.AVista = false;
                    Console.WriteLine("Digite o valor da transacao:");
                    transacao.Valor = double.Parse(Console.ReadLine());

                    //No exercicio pede a soma da primeira parcela.
                    //Então to pedindo o numero de parcelas aqui

                    Console.WriteLine("Digite o número das parcelas:");
                    transacao.Parcelas = int.Parse(Console.ReadLine());
                    transacoes.Add(transacao);
                }
                else if (opcao == "v")
                {
                    Transacao transacao = new Transacao();
                    transacao.AVista = true;
                    Console.WriteLine("Digite o valor da transacao:");
                    transacao.Valor = double.Parse(Console.ReadLine());
                    transacoes.Add(transacao);
                }
                else
                {
                    Console.WriteLine("Opcao invalida!");
                }
            }

                double totalAVista = 0;
                double totalAPrazo = 0;
                double valorPrimeiraPrestacao = 0;

              foreach (Transacao transacao in transacoes)
              {
                     //Caso seja a vista, adiciona o valor apenas
                if (transacao.AVista)
                {
                    totalAVista += transacao.Valor;
                }
                else //Se for a prazo, adicione ao total, e adicione + o valor da primeira parcela
                {
                    totalAPrazo += transacao.Valor;

                    //Se parcelas for 0 ou menor, não faça nada
                    if (transacao.Parcelas > 0)
                    {
                        valorPrimeiraPrestacao += transacao.Valor / transacao.Parcelas;
                    }
                }
               }
            Console.WriteLine($"Valor total das compras a Vista: R${totalAVista:0.00}");
            Console.WriteLine($"Valor total das compras a Prazo: R${totalAPrazo:0.00}");
            Console.WriteLine($"Valor total das compras: R${totalAVista + totalAPrazo:0.00}");
            Console.WriteLine($"Valor da soma da primeira prestação das compras a prazo: R${valorPrimeiraPrestacao:0.00}");
        }
    }
         //Classe para ajudar no processo acima
    public class Transacao
    {
        public bool AVista { get; set; }
        public double Valor { get; set; }
        public int Parcelas { get; set; }
    }

}
