using System;

namespace DesafioWarren02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("limite  minimo de alunos");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine("Tempo de chegada?");

            string[] valores = Console.ReadLine().Split(' ');
            int aluno1 = int.Parse(valores[0]);
            int aluno2 = int.Parse(valores[1]);
            int aluno3 = int.Parse(valores[2]);
            int aluno4 = int.Parse(valores[3]);
            int aluno5 = int.Parse(valores[4]);

            int tempoChegada = 0;

            if (limite >= 3 & tempoChegada <= 0)
            {
                Console.WriteLine("Aula normal");
            }
            else
            {
                Console.WriteLine("Aula cancelada");
            }





        }
    }
}
