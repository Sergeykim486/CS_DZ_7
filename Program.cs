// ══════════════════════════════════ Главное меню и основные функции ══════════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 47: Двухмерный массив вещественных чисел.                        ",
    "  ЗАДАЧА 50: Найти элемент в двухмерном массиве.                          ",
    "  ЗАДАЧА 52:                                                              ",
    "  ЗАДАЧА HARD SORT:                                                       ",
    "  ЗАДАЧА HARD 2:                                                          ",
    "  ВЫХОД ИЗ ПРОГРАММЫ                                                      "};
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;
void menu() // Функция выводит главное меню на экран консоли
{
    int CurrentLine = 1;
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    Console.WriteLine(choice);
    int i = 0;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("═══════════════════════  Г Л А В Н О Е   М Е Н Ю  ════════════════════════\n");
    Console.ForegroundColor = ConsoleColor.White;
    while (i < ListMenu.Length)
    {
        CurrentLine = i + 1;
        if (choice == CurrentLine)
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            Console.Write($"{ListMenu[i].ToUpper()}\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            if (i == ListMenu.Length - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.Write($"{ListMenu[i]}\n");
        }
        i++;
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n" +
    "╔════════════════════════════════════════════════════════╤═══════════════╗\n" +
    "║  Используйте [стрелки] для навигации.                  │   ▲ : Вверх   ║\n" +
    "║  [ENTER] - Выбор выделенного пункта                    │   ▼ : Вниз    ║\n" +
    "╚════════════════════════════════════════════════════════╧═══════════════╝\n");
    Console.BackgroundColor = ConsoleColor.Black;
}
int GetNum() // Запрос на ввод целого числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое число... ");
    int result1 = Convert.ToInt32(Console.ReadLine());
    return result1;
}
double GetDouble() // Запрос на ввод Вещественного числа
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("_______________________________________________\n" +
    "Введите целое или дробное число... ");
    double result1 = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
    return result1;
}
void ErrorCatch() // Функция обрабатывает ошибку, выдает сообщение и запускает программу с начала
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("" +
    "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
    "  ║  Возможно вы ввели не верные данные.                ║\n" +
    "  ║  Программа будет перезапущена...                    ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    Console.ForegroundColor = ConsoleColor.White;
    pause();
}
void pause() // Функция паузы, для чтения результатов
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("" +
    "  ╔═════════════════════════════════════════════════════╗\n" +
    "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
    "  ╚═════════════════════════════════════════════════════╝\n");
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    try
    {
        main();
    }
    catch
    {
        ErrorCatch();
    }
}
void ext() // Функция задает пользователю вопрос хочет ли он выйти из программы и закрывает ее если ответ да
{
AskAgayn:
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("  ╔═ В Ы Х О Д   И З   П Р О Г Р А М М Ы ═══════════════╗  \n" +
    "  ║      Вы уверены что хотите закрыть программу?       ║  \n" +
    "  ║              [ENTER] Да     [ESC] Нет               ║  \n" +
    "  ╚═════════════════════════════════════════════════════╝  \n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.BackgroundColor = ConsoleColor.Black;
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("" +
        "  ╔═ О Ш И Б К А  В В О Д А ════════════════════════════╗\n" +
        "  ║  Вам нужно нажать [ENTER] или [ESC].                ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("" +
        "  ╔═════════════════════════════════════════════════════╗\n" +
        "  ║  ЧТОБЫ ПРОДОЛЖИТЬ НАЖМИТЕ ЛЮБУЮ КЛАВИШУ...          ║\n" +
        "  ╚═════════════════════════════════════════════════════╝\n");
        ConsoleKeyInfo key1;
        key1 = Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        goto AskAgayn;
    }
    else if (key.Key == ConsoleKey.Escape) main();
    else if (key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        System.Environment.Exit(0);
    }
    else main();
}

// ═══════════════════════════════ ДОМАШНЕЕ ЗАДАНИЕ ═══════════════════════════════

// 1 Задача //
void FieldSize(int leng, int size) // Чтобы таблица была ровной
{
    for (int i = 0; i < size - leng; i++)
    {
        Console.Write(" ");
    }
}
double[,] Fill2DArrayDouble(double[,] array1, double from, double to, int acc)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
        retry:
            double tempnum1 = Math.Round(from + new Random().NextDouble() * (to - from), acc);
            for (int i1 = 0; i1 < array1.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < array1.GetLength(1); j1++)
                {
                    if (tempnum1 == array1[i1, j1]) goto retry;
                }
            }
            array1[i, j] = tempnum1;
        }
    }
    return (array1);
}
void Print2DArrayDouble(double[,] array1)
{
    int lng = 8;
    FieldSize(0, lng);
    for (int jj = 0; jj < array1.GetLength(1); jj++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"<{jj}>");
        FieldSize(Convert.ToString(jj).Length, lng-2);
        Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.WriteLine();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"<{i}>");
                FieldSize(Convert.ToString(i).Length, lng-2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array1[i, j]}");
                FieldSize(Convert.ToString(array1[i, j]).Length, lng);
            }
            else
            {
                Console.Write($"{array1[i, j]}");
                FieldSize(Convert.ToString(array1[i, j]).Length, lng);
            }
        }
        Console.WriteLine();
    }
}

// 2 Задача //
int[,] Fill2dArray(int[,] result, int x, int y)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
        retry:
            int tempnum1 = new Random().Next(x, y);
            for (int i1 = 0; i1 < result.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < result.GetLength(1); j1++)
                {
                    if (tempnum1 == result[i1, j1]) goto retry;
                }
            }
            result[i, j] = tempnum1;
        }
    }
    return (result);
}
void Print2DArray(int[,] array1)
{
    int lng = 8;
    FieldSize(0, lng);
    for (int jj = 0; jj < array1.GetLength(1); jj++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"<{jj}>");
        FieldSize(Convert.ToString(jj).Length, lng-2);
        Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.WriteLine();
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"<{i}>");
                FieldSize(Convert.ToString(i).Length, lng-2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array1[i, j]}");
                FieldSize(Convert.ToString(array1[i, j]).Length, lng);
            }
            else
            {
                Console.Write($"{array1[i, j]}");
                FieldSize(Convert.ToString(array1[i, j]).Length, lng);
            }
        }
        Console.WriteLine();
    }
}

// 3 Задача //

// 4 Задача //

// ═════════════════════════════════════════════════════════════════════════════════════════════


// ═══════════════════════════════ Обработка выбранного элемента в меню ═══════════════════════════════

// ВЫПОЛНЕНИЕ ПРОГРАММЫ И ОТСЛЕЖИВАНИЕ НАЖАТИЯ КЛАВИШ
void main()
{
restart:
    menu();
    ConsoleKeyInfo key;
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (choice <= ListMenu.Length)
        {
            if (choice == 1)
            {
                choice = ListMenu.Length;
                goto restart;
            }
            else
            {
                choice = choice - 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (choice >= 1)
        {
            if (choice == ListMenu.Length)
            {
                choice = 1;
                goto restart;
            }
            else
            {
                choice = choice + 1;
                goto restart;
            }
        }
        else goto restart;
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        // Здесь объявляются функции которые программа выполнит при выборе того или иного пункта меню
        switch (choice)
        {
            case 1:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите размерность двумерного массива [m, n]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Укажите размер [m]...");
                int xm = GetNum();
                Console.WriteLine("Укажите размер [n]...");
                int xn = GetNum();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("В каком диапазоне будут генерироваться числа для заполнения массива?");
                Console.WriteLine("Укажите начало диапазона...");
                double xx = GetDouble();
                Console.WriteLine("Укажите конец диапазона...");
                double yy = GetDouble();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Задайте количество цифр после запятой для массива...");
                int Accuracy = GetNum();
                double[,] array2d = new double[xm, xn];
                array2d = Fill2DArrayDouble(array2d, xx, yy, Accuracy);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"Сгенерирован вещественных целых чисел, размером [{xm}, {xn}]\n\n");
                Print2DArrayDouble(array2d);
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                pause();
                goto restart;
            case 2:
                pause();
                goto restart;
            case 3:
                pause();
                goto restart;
            case 4:
                pause();
                goto restart;
            case 5:
                pause();
                goto restart;
            case 6:
                ext();
                goto restart;
        }
    }
    else goto restart;
}

// ═══════════════════════════════════════════════════════════════════════════════════════════════════════════

// ═══════════════════════════════ Запуск обработки меню и выбранного элемента ═══════════════════════════════

try
{
    main();
}

catch
{
    ErrorCatch();
}