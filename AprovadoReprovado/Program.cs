using System;

namespace AprovadoReprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º Declarar variáveis e respectivos tipos
            float nota = 0f;

            //2º Solicitar e ler os dados inseridos
            Console.WriteLine("Digite a nota do teste (entre 0 e 20):");
            nota = float.Parse(Console.ReadLine());

            //3º Processamento
            if (nota <= 0 || nota >= 21)
            {
                //4º Escrever o resultado
                Console.WriteLine("O número precisa ser entre 0 e 20.");
            }
            
            else
            {
                if (nota < 10)
                //4º Escrever o resultado
                Console.WriteLine("Você está reprovado.");

                else if (nota >= 10 && nota <= 12)
                //4º Escrever o resultado
                Console.WriteLine("Você está em exame.");

                else
                //4º Escrever o resultado
                Console.WriteLine("Você está aprovado!!!");
            }

            //5º Efectuar a leitura do código
            Console.ReadLine();
            Console.Clear();
        }
    }
}
