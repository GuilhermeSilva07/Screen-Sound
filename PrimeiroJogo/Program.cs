using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            void boasVindas ()
            {
                Console.WriteLine(@"
░░█ █▀█ █▀▀ █▀█   █▀▄ █▀▀   ▄▀█ █▀▄ █░█ █ █▄░█ █░█ ▄▀█ █▀▀ ▄▀█ █▀█
█▄█ █▄█ █▄█ █▄█   █▄▀ ██▄   █▀█ █▄▀ ▀▄▀ █ █░▀█ █▀█ █▀█ █▄▄ █▀█ █▄█");
                Console.WriteLine();

                Console.WriteLine("Seja bem vindo!");
                Console.WriteLine();
            }

            boasVindas();


            Random aleatorio = new Random();
            int numeroSecreto = aleatorio.Next(1, 101);

            do
            {
                Console.WriteLine("Digite um numero entre 1 e 100");
                int chute = int.Parse(Console.ReadLine());            //está sendo armazenado na variavel o valor inserido 

                if (chute == numeroSecreto) 
                {
                    Console.WriteLine("Parabens! Você acertou o número");
                    break;                                                  // o comando "BREAK" encerra a aplicação caso a condição seja atendida
                }
                else if (chute <= numeroSecreto) 
                {
                    Console.WriteLine("O número é maior. ");
                }
                else
                {
                    Console.WriteLine("O número é menor. ");
                }
            }while (true);  //Enquanto a condição for verdadeira 

            Console.WriteLine("O jogo acabou, você acertou o número secreto");   //Essa mensagem irá aparecer em tela caso o valor da variavel seja acertado
            Console.ReadLine();

        }
    }
}
