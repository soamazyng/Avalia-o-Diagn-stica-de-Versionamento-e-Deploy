using System;
using System.Collections.Generic;
using System.Linq;

namespace avaliacao_diagnostica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número e aperte enter:");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Digite um número para pesquisar na lista digitada anteriormente e aperte o enter:");
            var search = Console.ReadLine();
            bool isValidNumber = numbers.Any(x => x == int.Parse(search));

            if (isValidNumber)
            {
                Console.WriteLine($"O número {search} foi encontrado!");

                if (int.Parse(search) % 2 == 0)
                {
                    Console.WriteLine($"O número {search} é par");
                }
                else
                {
                    Console.WriteLine($"O número {search} é impar");
                }
            }
            else
            {
                Console.WriteLine($"O número {search} não foi encontrado!");                
            }

        }
    }
}
