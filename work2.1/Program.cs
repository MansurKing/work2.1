using System;

namespace work2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRepetitions;
            string messages;

            Console.Write($"Введите слово, которое будет зацикленно: ");
            messages = Console.ReadLine();
            Console.Write($"Введите кол-во повторений: ");
            numberOfRepetitions = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfRepetitions; i++)
            {
                Console.WriteLine(messages);
            }
        }
    }
}
