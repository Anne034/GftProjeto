using System;

namespace DesafioTecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Exercicios GFT");
                Console.WriteLine("Selecione um exercicio para testar:");
                Console.WriteLine("(1) Censo");
                Console.WriteLine("(2) Categoria Nadador");
                Console.WriteLine("(3) Total Vendas");
                Console.WriteLine("(4) Concessionaria");
                Console.WriteLine("(5) Sair");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Censo censo = new Censo();
                        censo.Ativar();
                        break;
                    case "2":
                        CategoriaNadador cat = new CategoriaNadador();
                        cat.RetornarCategoria();
                        break;
                    case "3":
                        TotalVendas total = new TotalVendas();
                        total.AtivarTransacoes();
                        break;
                    case "4":
                        Concessionaria concessionaria = new Concessionaria();
                        concessionaria.MostrarTabela();
                        break;
                    default:
                        continuar = false;
                        Console.WriteLine("Obrigado por usar o programa!");
                        break;

                }
            }
        }

    }
}