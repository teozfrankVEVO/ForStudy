using System;
using System.Collections.Generic;

namespace testprogramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Commit add");
            Random randNum = new Random();
            Console.Write("How much enter numbers?: ");
            int Value = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int [Value];
            double summass = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter {i}th number in massiv: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                summass += numbers[i];
            }
            Console.Write("Content in numbers { ");
            int checker = numbers.Length - 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i == checker)
                    Console.WriteLine(" }");
                else
                    Console.Write(", ");
            }
            Console.WriteLine($"Summ massiv: {summass};");
            int Rnum = randNum.Next (1, 5);
            switch (Rnum) {
                case 1:
                    Console.WriteLine($"Summ massiv squaring: {summass * summass};");
                    break;
                case 2:
                    Console.WriteLine($"Summ massiv divide by {Rnum}: {summass / Rnum};");
                    break;
                case 3:
                    Console.WriteLine($"Summ massiv remain from {Rnum}: {summass % Rnum};");
                    break;
                case 4:
                    Console.WriteLine($"Summ massiv added to 100: {summass + 100};");
                    break;
            }
            Console.WriteLine($"Summ massiv multiply with {Rnum}: {summass*Rnum};" +
                $"\n/////////////////////////////////////////////");
            double Answer;
            do
            {
                Rnum = randNum.Next(1, 4);
                Console.WriteLine($"How much if you add it up {summass} and {summass / Rnum}");
                Answer = Convert.ToDouble(Console.ReadLine());
                if (Answer != (summass + summass / Rnum))
                    Console.WriteLine("Nope!");
            } while (Answer != (summass + summass / Rnum));
                Console.WriteLine("Right!");
            Console.WriteLine("Random marray:");
            Value = randNum.Next(1, 20);
            Rnum = randNum.Next(1, 20);
            int[,] testmass = new int[Value, Rnum];
            for (int i=0; i < Value; i++) { 
                for(int j = 0; j < Rnum; j++) {
                    testmass[i, j] = randNum.Next(1, 1000);
                    Console.Write($"{testmass[i, j]}  ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
