using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConverterDaysOfWeek();
            ArraySorting();
            CowsOfNumber();

        }

        private static void CowsOfNumber()
        {
            while (true)
            {
                Console.WriteLine("Сколько коров вы хотите купить на нашем базаре?");
                int NumberOfCows = Convert.ToInt32(Console.ReadLine());
                int LastNumber = NumberOfCows % 10;

                if (LastNumber == 1 && NumberOfCows != 11)
                {
                    Console.WriteLine($"Вы купили {NumberOfCows} корову");
                }
                else if (LastNumber >= 5 && LastNumber <= 9 || (LastNumber == 0 || NumberOfCows == 11) || (NumberOfCows >= 12 && NumberOfCows <= 19))
                {
                    Console.WriteLine($"Вы купили {NumberOfCows} коров");
                }
                else if (LastNumber >= 2 && LastNumber <= 4)
                {
                    Console.WriteLine($"Вы купили {NumberOfCows} коровы");
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
        }

        private static void ArraySorting()
        {
            int[] numbers = { 1, 5, 6, 4, 8, 5, 10, 16, 0 };

            PrintArray(numbers);
            ForInArray(numbers);
            PrintArray(numbers);
        }

        private static void ForInArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
        }

        private static void PrintArray(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write($"{numbers[i]}, ");
            }
        }

        private static void ConverterDaysOfWeek()
        {
            int DayOfWeek = ReadDayOfWeak();
            string DayName = SwitchToString(DayOfWeek);
            Console.WriteLine($"Вы ввели день недели {DayName}");
        }

        private static string SwitchToString(int DayOfWeek)
        {
            string DayName = "";
            switch (DayOfWeek)
            {
                case 1:
                    DayName = "Понедельник";
                    break;
                case 2:
                    DayName = "Вторник";
                    break;
                case 3:
                    DayName = "Среда";
                    break;
                case 4:
                    DayName = "Четверг";
                    break;
                case 5:
                    DayName = "Пятница";
                    break;
                case 6:
                    DayName = "Суббота";
                    break;
                case 7:
                    DayName = "Восскресенье";
                    break;
            }

            return DayName;
        }

        private static int ReadDayOfWeak()
        {
            int DayOfWeek = 0;
            bool IsDayCorrect = false;
            while (IsDayCorrect == false)
            {
                Console.Write("Введите день недели: ");
                DayOfWeek = Convert.ToInt32(Console.ReadLine());
                if (DayOfWeek >= 8 || DayOfWeek < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Введено неверное значение");
                    Console.WriteLine();
                }
                else
                {
                    IsDayCorrect = true;

                }
            }

            return DayOfWeek;
        }
    }
}
