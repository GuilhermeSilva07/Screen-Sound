using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Verifica quais numero da lista e par, utilizando uma conta de divisão


            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};


            //Utilizando o for 
            for (int i = 0; i < numeros.Count; i++) 
            {
                if (numeros[i] % 2 == 0)      //Verifica se o número é par 
                {
                    Console.WriteLine(numeros[i]);
                }
            }


            //Utilizando o foreach
            foreach (int numero in numeros) 
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
