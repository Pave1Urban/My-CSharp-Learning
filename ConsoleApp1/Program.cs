using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ConverterDaysOfWeek();
            // ArraySorting();
            // CowsOfNumber();
            // SearchTheGame();
            Console.CursorVisible = false;
            char[,] map =
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#' },
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
            };

            int userX = 6, userY = 6;
            char[] bag = new char[1];
            Console.SetCursorPosition(0,20);
            Console.Write("Сумка: ");
            for (int i = 0; i < bag.Length; i++)
            {
                Console.Write(bag[i] + " ");
            }
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');
                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.W:
                        if (map[userX - 1, userY] != '#')
                        {
                            userX--;
                        }
                        break;
                    case ConsoleKey.S:
                        if (map[userX + 1, userY] != '#')
                        {
                            userX++;
                        }
                        break;
                    case ConsoleKey.A:
                        if (map[userX, userY - 1] != '#')
                        {
                            userY--;
                        }
                        break;
                    case ConsoleKey.D:
                        if (map[userX, userY + 1] != '#')
                        {
                            userY++;
                        }
                        break;

                }

                if (map[userX, userY] == 'X')
                {
                    map[userX, userY] = 'O';
                }
                char[] tempBag = new char[bag.Length + 1];
                for (int i = 0; i < bag.Length; i++) 
                {
                    tempBag[i] = bag[i];
                }
                tempBag[tempBag.Length - 1] = 'X';
                bag = tempBag;
                Console.Clear();
            }
        }

        private static void SearchTheGame()
        {
            bool IsOpen = true;
            string[,] games =
                {
            { "Conter Strike 2", "Valorant", "Battlefield" },
            { "GTA V", "Far Cry 3", "Watch Dogs 2" },
            { "Hitman 3", "Assasin's Creed: Unity", "The Last of Us" },
            };
            while (IsOpen)
            {
                Console.WriteLine("\n Список игр в библиотеке Steam:\n");
                for (int i = 0; i < games.GetLength(0); i++)
                {
                    for (int j = 0; j < games.GetLength(1); j++)
                    {
                        Console.Write($" {games[i, j]} | ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine(" Библиотека");
                Console.WriteLine("\n 1 - узнать название игры по индексу.\n \n 2 - найти игру по названию.\n \n 3 - выход.\n");
                Console.Write("\nВыберите пункт меню: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int line, columbn;
                        Console.Write("Введите номер строки: ");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер стобца: ");
                        columbn = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine($"Это игра {games[line, columbn]} ");
                        break;
                    case 2:
                        string game;
                        bool gameIsFound = false;
                        Console.Write("Введите игру: ");
                        game = Console.ReadLine();
                        for (int i = 0; i < games.GetLength(0); i++)
                        {
                            for (int j = 0; j < games.GetLength(1); j++)
                            {
                                if (game.ToLower() == games[i, j].ToLower())
                                {
                                    Console.Write($"Игра {games[i, j]} находится по адресу: строка {i + 1}, столбец {j + 1}.");
                                    gameIsFound = true;
                                }
                            }

                        }
                        if (gameIsFound == false)
                            Console.WriteLine("игра не найдена...");
                        break;

                    case 3:
                        IsOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда");
                        break;
                }
                if (IsOpen)
                {
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                }
                Console.ReadKey();
                Console.Clear();
            }
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
                default:
                    Console.WriteLine("Введено неверное значение");
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
            Console.ReadKey();
            Console.Clear();
            return DayOfWeek;
        }
    }
}
