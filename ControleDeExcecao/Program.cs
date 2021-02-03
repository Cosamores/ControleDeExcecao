using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            //var idade = 35;

            //if (idade == 0)
            //    throw new Exception("Valor inválido");
                
       
            //Console.WriteLine($"Minha idade é {idade} e eu sou maior de idade");

            try
            {
                var idade = 15;

                if (idade == 0)
                    throw new Exception("Valor inválido");


                Console.WriteLine($"Minha idade é {idade} e eu sou maior de idade");
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
