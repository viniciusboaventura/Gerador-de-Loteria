using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace mega_sena
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] inumerosorteado = new int[6]; // array para os numeros sorteado
            
            int[] inumerojogador = new int[6]; // array para os numeros da aposta do jogador
            
            string nomejogador; //nome do jogador

            string[] jogadornome = {"Gabriel", "Heitor", "Lucas", "Emanuel",
                "Arthur", "Samuel", "João","Gustavo", "Matheus",
                "Daniel", "Antônio", "José", "Eduardo",
                "Felipe", "Diego", "Caio", "Renan", "Ana", "Maria",
                "Luíza", "Mariana","Alice", "Laís",
                "Laísa", "Gabriela", "Elisa", "Larissa", "Olívia",
                "Eloísa", "Milena", "Lorena","Sofia", "Letícia", "Beatriz"}; //array de nomes possíveis (34)

            string[] jogadorsobrenome = {"Reis", "Góes", "Machado", "Ferreira", "Pereira",
                "Siqueira", "Da Silva", "Souza", "Santos", "Batista",
                "Silveira", "Vieira", "Lima", "Andrade", "Trindade",
            "Fernandes", "Barros", "Tomazela", "Fernandes", "Toledo",
                "Neves", "Nogueira", "Carvalho", "Tavares", "Melo",
                "Da Costa", "Vasquez", "Nascimento", "Neto", "Delgado",
            "Trindade", "Dias", "Schultz", "Schimidt"}; // array de sobrenomes possíveis (34)

            Random geranum = new Random(); //instanciando o Random


            //menu
            int x;
            string sx; //variaveis do menu

            Console.WriteLine("Vinícius Boaventura | Gerador de Loteria" +
               "\n-----------------------------------------" +
               "\n * Pressione 1 para iniciar" +
               "\n\n * Pressione Qualquer outra tecla para sair");
           
            sx = Console.ReadLine().Trim();

            int.TryParse(sx, out x);
           
            while (x == 1)
            {
                nomejogador = String.Concat(jogadornome[geranum.Next(0, 33)], " ", jogadorsobrenome[geranum.Next(0, 33)]); /* Criando o nome do jogador sorteando um nome do array
                                                                                                                  * jogadornome com um sobrenome do array jogadorsobrenome */


                // As 6 apostas do jogador
                List<int> numsorj = new List<int>();

                while (numsorj.Count < 6) // adicionando a aposta do jogador à lista
                {
                    int num = geranum.Next(1, 61);

                    if (!numsorj.Contains(num)) // checando caso um numero sorteado ja existe na lista
                    {
                        numsorj.Add(num);
                    }
                }
                numsorj.Sort(); //organizando os números em ordem crescente

                string snumsorj = string.Join(", ", numsorj); // adicionado à uma string os itens da lista



                // As 6 apostas sorteadas pelo jogo
                List<int> numsorteado = new List<int>();


                while (numsorteado.Count < 6) // adicionando o sorteio final do jogo à uma lista
                {
                    int num = geranum.Next(1, 61);

                    if (!numsorteado.Contains(num)) // checando se um numero sorteado ja existe na lista
                    {
                        numsorteado.Add(num);
                    }

                }

                numsorteado.Sort(); //organizando os números em ordem crescente

                string snumsorteado = string.Join(", ", numsorteado); //adicionando os elementos da lista à uma variavel string

                Console.WriteLine("Nome: {0}", nomejogador);
                Console.WriteLine("Aposta do jogador: {0}", string.Join(", ", snumsorj));
                Console.WriteLine("Numero Sorteado: {0}", string.Join(", ", snumsorteado));

                Console.Write("\n Gostaria de gerar mais uma aposta?\n * Digite 1 para sim\n\n Digite outra tecla para Sair\n");
                sx = Console.ReadLine().Trim();

                int.TryParse(sx, out x);
             
            }

            if (x != 1)
            {
                Console.WriteLine("Obrigado por testar meu gerador!");

            }


        }



    }


}

   