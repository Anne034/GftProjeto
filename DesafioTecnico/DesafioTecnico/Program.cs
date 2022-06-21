using System;

namespace DesafioTecnico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa Censo 

            //Censo censo = new Censo();
            //censo.Ativar();
            //static void Main(string[] args)
            {
                //Censo censo = new Censo();
                //censo.Ativar();

                //Antigo teste....
                CategoriaNadador cat = new CategoriaNadador();
                Console.WriteLine(cat.RetornarCategoria(5));
                Console.WriteLine(cat.RetornarCategoria(9));
                Console.WriteLine(cat.RetornarCategoria(12));
                Console.WriteLine(cat.RetornarCategoria(15));
                Console.WriteLine(cat.RetornarCategoria(18));
                Console.WriteLine(cat.RetornarCategoria(25));

                // Falta organizar os testes aki
            }


        }
    }
}
