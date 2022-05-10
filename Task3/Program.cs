using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Введите количество строк в матрице");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в матрице");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[lines, columns];
            Random r = new Random();
            ulong amount = 0; // используется тип ulong, поскольку значение может выходить за пределы int
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = r.Next();
                    Console.Write($"{matrix[i, j]} ");
                    amount += Convert.ToUInt64(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех чисел в матрице = {amount}");
            Console.ReadKey();

            //Задание 2
            Console.WriteLine("Введите длину последовательности");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int iteration = 0;
            for (int k = 0; k < length; k++)
            {
                iteration++;
                Console.WriteLine($"Введите {iteration}-е число последовательности");
                array[k] = int.Parse(Console.ReadLine());
            }
            int minNumber = int.MaxValue;
            for (int l = 0; l < length; l++)
            {
                if (minNumber > array[l])
                {
                    minNumber = array[l];
                }
            }
            Console.WriteLine($"Наименьшее чсило из введённой последовательности ={minNumber}");
            Console.ReadKey();

            // Задание 3
            Console.WriteLine("Введите максимальное число диапазона");
            int maxRandom = int.Parse(Console.ReadLine());
            Random random = new Random();
            int randNumber = random.Next(maxRandom + 1);
            string input;
            int result;
            while (true)
            {
                Console.WriteLine("Введите угадываемое число");
                input = Console.ReadLine();
                if (!int.TryParse(input, out result)) // на случай если пользователь ввёл пустую строку 
                {
                    Console.WriteLine($"Загаданное число {randNumber}, спасибо за участие");
                    break;
                }
                else if (int.Parse(input) == randNumber)
                {
                    Console.WriteLine("Поздравляю, вы угадали!");
                    break;
                }
                else if (int.Parse(input) < randNumber)
                {
                    Console.WriteLine("Загаданное число больше");
                    continue;
                }
                else if (int.Parse(input) > randNumber)
                {
                    Console.WriteLine("Загаданное число меньше");
                    continue;
                }
            }
            Console.ReadKey();

        }
    }
}


