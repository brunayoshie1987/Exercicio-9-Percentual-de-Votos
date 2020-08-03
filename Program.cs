using System;

namespace Exercicio_9___Percentual_de_Votos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de eleitores");
            var totalEleitores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número de votos válidos");
            var nrVotosValidos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número de votos brancos");
            var nrVotosBrancos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o número de votos nulos");
            var nrVotosNulos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Percentual de Votos Válidos: " + PercVotosValidos(totalEleitores, nrVotosValidos) + "%");

            Console.WriteLine("Percentual de Votos em brancos: " + PercVotosBrancos(totalEleitores, nrVotosBrancos) + "%");

            Console.WriteLine("Percentual de Votos nulos: " + PercVotosNulos(totalEleitores, nrVotosNulos) + "%");

            Console.ReadKey();
        }

        private static double PercVotosValidos(int totalEleitores, int nrVotosValidos)
        {
            var perc = nrVotosValidos * 100.0 / totalEleitores;

            return perc;
        }

        private static double PercVotosBrancos(int totalEleitores, int nrVotosBrancos)
        {
            var perc = nrVotosBrancos * 100.0 / totalEleitores;

            return perc;
        }

        private static double PercVotosNulos(int totalEleitores, int nrVotosNulos)
        {
            var perc = nrVotosNulos * 100.0 / totalEleitores;

            return perc;
        }
    }
}
