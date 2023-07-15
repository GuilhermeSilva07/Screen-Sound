using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Screen_Sound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Screen Sound

            String MensagemDeBoasVindas = "Bem vindo ao Screen Sound";

            //List<String> listaDasBandas = new List<String> {"Iron Maiden", "The Beatles", "Metalica" };   //Lista onde vai ser armazenadas as bandas que forem inseridas 

            Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
            bandasRegistradas.Add("Iron Maiden", new List<int> {10, 8, 6 });
            bandasRegistradas.Add("Link Park", new List<int> ());

            void ExibirMensagem () //Função para exibir  
            {

                Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
                Console.WriteLine();
                Console.WriteLine(MensagemDeBoasVindas);
                Console.WriteLine();
            }
         
            

            void ExibirOpçoesMenu ()
            {

                Console.WriteLine();
               ExibirMensagem ();  //Chamando a função para exibir mensagem de boas vindas

                Console.WriteLine();
                Console.WriteLine("Digite 1 para registrar uma banda");
                Console.WriteLine("Digite 2 para mostrar uma banda");
                Console.WriteLine("Digite 3 para avaliar uma banda");
                Console.WriteLine("Digite 4 exibir a média de uma banda");
                Console.WriteLine("Digite -1 para sair");
                
                Console.Write("\n Digite a sua opção: ");

                string opcaoEscolhida = Console.ReadLine();  //armezenando a opção selecionada pelo usuario 

                int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida); //Convertendo uma variavel do tipo string para int 


               switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        Registrarbanda();  //Chamando a funçaõ de registrar banda
                        break;

                    case 2:
                        mostrarBandas();
                        break;

                    case 3:
                        AvaliarBandas();
                        break;

                    case 4:
                        MediaDaBanda();
                        break;

                    default 
                        : Console.WriteLine("\n opação invalida ");
                        break;
                }
            }


            void Registrarbanda()
            {
                Console.Clear(); // Limpa o codigo 
                Console.WriteLine(@"ℝ𝕖𝕘𝕚𝕤𝕥𝕣𝕖 𝕦𝕞𝕒 𝕓𝕒𝕟𝕕𝕒");
                Console.WriteLine();

                Console.WriteLine("Registro de bandas");
                Console.Write("Digite o nome da banda que deseja registrar: ");
                string nomeDabanda = Console.ReadLine();                                      //Aqui está sendo armazenada a variavel inserida

                //listaDasBandas.Add(nomeDabanda);        //Salvando na lista a banda que foi inserida

                bandasRegistradas.Add(nomeDabanda, new List<int>());
                Console.WriteLine(); 
                Console.WriteLine($"A banda {nomeDabanda} foi resgistrada com sucesso!");    //$ {nomeDabanda} está função está pegando o que foi inserido no momento 
                Thread.Sleep(2000); //está adicioando um temporizador 

                Console.Clear();

                ExibirOpçoesMenu();    //Retornando a funçaõ menu 
                
            }


            void mostrarBandas ()
            {
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine(@"
█░░ ░▀░ █▀▀ ▀▀█▀▀ █▀▀█ 　 █▀▀▄ █▀▀█ █▀▀ 　 █▀▀▄ █▀▀█ █▀▀▄ █▀▀▄ █▀▀█ █▀▀ 
█░░ ▀█▀ ▀▀█ ░░█░░ █▄▄█ 　 █░░█ █▄▄█ ▀▀█ 　 █▀▀▄ █▄▄█ █░░█ █░░█ █▄▄█ ▀▀█ 
▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀░░▀ 　 ▀▀▀░ ▀░░▀ ▀▀▀ 　 ▀▀▀░ ▀░░▀ ▀░░▀ ▀▀▀░ ▀░░▀ ▀▀▀");
                Console.WriteLine();

                //for ( int i = 0; i < listaDasBandas.Count; i++ )    //Realizando um looping das bandas que estão dentro da variavel "ListaDasbandas"
                //{
                    //Console.WriteLine($"Banda: {listaDasBandas[i]}");    //Exibindo todas as bandas selecionadas 
                    //Console.WriteLine();
                //}


                //Utilizando outra ferramenta "Foreach"

                foreach (string banda in bandasRegistradas.Keys) 
                {
                    Console.WriteLine($"Banda: {banda}");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("Digite a tecla enter para voltar ao menu principal");

                Console.ReadKey();  // com esse comando qualquer tecla selecionada encerra o programa 
                Console.Clear();

                ExibirOpçoesMenu();
            }


            void AvaliarBandas()
            {
                Console.Clear ();

                Console.WriteLine(@"

▄▀█ █░█ ▄▀█ █░░ █ ▄▀█ █▄░█ █▀▄ █▀█   ▄▀█ █▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀█ ▀▄▀ █▀█ █▄▄ █ █▀█ █░▀█ █▄▀ █▄█   █▀█ ▄█   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
                Console.WriteLine();

                Console.Write("Digite o nome da banda que deseja avaliar: ");
                string nomeDaBanda = Console.ReadLine();

                if (bandasRegistradas.ContainsKey(nomeDaBanda))
                {
                    Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");    //pegando a nota para a banda que foi inserida
                    int nota = int.Parse(Console.ReadLine());  //convertendo o int para string e armazenando a inform~ção que foi inserida 

                    bandasRegistradas[nomeDaBanda].Add(nota);  // adicionando a nota ao nome da banda que foi selecionada
                    Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda} ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpçoesMenu();
                }
                else
                {
                    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada! ");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal") ;
                    Console.ReadKey() ;
                    Console.Clear();
                    ExibirOpçoesMenu();
                }
            }

            void MediaDaBanda()
            {
                Console.Clear () ;

                Console.WriteLine();
                Console.WriteLine(@"

█▀▄▀█ █▀▀ █▀▄ █ ▄▀█   █▀▄ █▀▀   █▄░█ █▀█ ▀█▀ ▄▀█ █▀
█░▀░█ ██▄ █▄▀ █ █▀█   █▄▀ ██▄   █░▀█ █▄█ ░█░ █▀█ ▄█");
                Console.WriteLine();

                Console.Write("Digite o nome da banda que deseja ver a média de notas: ");
                Console.WriteLine ();
                string nomedabanda = Console.ReadLine();

                if (bandasRegistradas.ContainsKey(nomedabanda))   //Se a banda estiver na nossa lista 
                {
                    double mediaBandas = bandasRegistradas[nomedabanda].Average();

                    Console.WriteLine($"\nA Média da banda {nomedabanda} e de: " + mediaBandas);
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpçoesMenu();

                }
                else
                {
                    Console.WriteLine($"\nA banda {nomedabanda} não foi encontrada! ");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    ExibirOpçoesMenu();
                }
            }

            ExibirOpçoesMenu();
           
            Console.ReadLine();
     
        }
    }
}
