// ══════════════════════════════════ Главное меню и основные функции ══════════════════════════════════

int choice = 1; // ТЕКУЩИЙ ВЫБРАННЫЙ ЭЛЕМЕНТ
// Список меню
string[] ListMenu = {
    "  Задача 47: Двухмерный массив вещественных чисел.                        ",
    "  ЗАДАЧА 50: Найти элемент в двухмерном массиве.                          ",
    "  ЗАДАЧА 52: Среднее арифметическое колонок массива.                      ",
    "  ЗАДАЧА HARD SORT: Сортировка двухмерного массива.                       ",
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
void PrintArray(double[] array1) // Вывести на экран массив
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"Average  ");
            Console.Write(array1[i]);
            FieldSize(Convert.ToString(array1[i]).Length, 9);
        }
        else
        {
            Console.Write(array1[i]);
            FieldSize(Convert.ToString(array1[i]).Length, 9);
        }
    }
}
int[] arraySort(int[] array1, int parameter) // Сортировка массива parameter=1 по возрастанию parameter=0 по убыванию
{
    int temp = 0;
    for (int i = 0; i < array1.Length - 1; i++)
    {
        for (int i1 = i; i1 < array1.Length; i1++)
        {
            if (parameter == 1)
            {
                if (array1[i] > array1[i1])
                {
                    temp = array1[i];
                    array1[i] = array1[i1];
                    array1[i1] = temp;
                }
            }
            else
            {
                if (array1[i] < array1[i1])
                {
                    temp = array1[i];
                    array1[i] = array1[i1];
                    array1[i1] = temp;
                }
            }
        }
    }
    return (array1);
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
        FieldSize(Convert.ToString(jj).Length, lng - 2);
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
                FieldSize(Convert.ToString(i).Length, lng - 2);
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
int[,] Fill2dArray(int m, int n, int x, int y)
{
    int[,] result = new int[m, n];
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
    int lng = 9;
    FieldSize(0, lng);
    for (int jj = 0; jj < array1.GetLength(1); jj++)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"<{jj}>");
        FieldSize(Convert.ToString(jj).Length, lng - 2);
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
                FieldSize(Convert.ToString(i).Length, lng - 2);
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
void FindElement(int[,] array1, int m, int n)
{
    if (m > array1.GetLength(0) - 1 ^ n > array1.GetLength(1) - 1)
    {
        Console.WriteLine("Такого элемента не существует!");
    }
    else
    {
        Console.WriteLine($"Элемент {m}, {n} найден, и равен {array1[m, n]}");
    }
}
// 3 Задача //
double[] AverageCoulm2DArray(int[,] array1)
{
    double[] result = new double[array1.GetLength(1)];
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            result[j] = result[j] + array1[i, j];
        }
        result[j] = Math.Round((result[j] / array1.GetLength(0)), 2);
    }
    return (result);
}
// 4 Задача //
int[,] Sort2DArray(int[,] array1)
{
    int[] sorting = new int[array1.GetLength(0) * array1.GetLength(1)];
    int sortingi = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            sorting[sortingi] = array1[i, j];
            sortingi++;
        }
    }
    int ii = 0;
    sorting = arraySort(sorting, 1);
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = sorting[ii];
            ii++;
        }
    }
    return (array1);
}

// 5 Задача //

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
                Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.\n" +
                "m = 3, n = 4.\n"+
                "0,5 7 -2 -0,2\n"+
                "1 -3,3 8 -9,9\n"+
                "8 7,8 -7,1 9\n");
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
                $"Сгенерирован массив вещественных чисел, размером [{xm}, {xn}]\n\n");
                Print2DArrayDouble(array2d);
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                pause();
                goto restart;
            case 2:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном\n" +
                "массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:\n" +
                "1 4 7 2\n" +
                "5 9 2 3\n" +
                "8 4 2 4\n" +
                "17 -> такого числа в массиве нет\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите размерность двумерного массива [m, n]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Укажите размер [m]...");
                int xm1 = GetNum();
                Console.WriteLine("Укажите размер [n]...");
                int xn1 = GetNum();
            EnterAgayn:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("В каком диапазоне будут генерироваться числа для заполнения массива?");
                Console.WriteLine("Укажите начало диапазона...");
                int xx1 = GetNum();
                Console.WriteLine("Укажите конец диапазона...");
                int yy1 = GetNum();
                if (yy1 - xx1 <= xm1 * xn1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Диапазон генерируемых чисел меньше чем размер массива. Повторите ввод...");
                    goto EnterAgayn;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите позицию искомого элемента...");
                Console.WriteLine("Позиция m...");
                int Pos1 = GetNum();
                Console.WriteLine("Позиция n...");
                int Pos2 = GetNum();
                int[,] array2d1 = Fill2dArray(xm1, xn1, xx1, yy1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"Сгенерирован вещественных целых чисел, размером [{xm1}, {xn1}]\n\n");
                Print2DArray(array2d1);
                FindElement(array2d1, Pos1, Pos2);
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                pause();
                goto restart;
            case 3:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов\n" +
                "в каждом столбце.\n" +
                "1 4 7 2\n" +
                "5 9 2 3\n" +
                "8 4 2 4\n" +
                "Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите размерность двумерного массива [m, n]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Укажите размер [m]...");
                int xm2 = GetNum();
                Console.WriteLine("Укажите размер [n]...");
                int xn2 = GetNum();
            EnterAgayn1:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("В каком диапазоне будут генерироваться числа для заполнения массива?");
                Console.WriteLine("Укажите начало диапазона...");
                int xx2 = GetNum();
                Console.WriteLine("Укажите конец диапазона...");
                int yy2 = GetNum();
                if (yy2 - xx2 <= xm2 * xn2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Диапазон генерируемых чисел меньше чем размер массива. Повторите ввод...");
                    goto EnterAgayn1;
                }
                int[,] array2d2 = Fill2dArray(xm2, xn2, xx2, yy2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"Сгенерирован вещественных целых чисел, размером [{xm2}, {xn2}]\n\n");
                Print2DArray(array2d2);
                Console.ForegroundColor = ConsoleColor.Red;
                PrintArray(AverageCoulm2DArray(array2d2));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
                pause();
                goto restart;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Задача HARD SORT. Задайте двумерный массив из целых чисел. Количество строк и столбцов\n" +
                "задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.\n" +
                "Например, задан массив:\n" +
                "1 4 7 2\n" +
                "5 9 10 3\n" +
                "После сортировки\n" +
                "1 2 3 4\n" +
                "5 7 9 10");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Укажите размерность двумерного массива [m, n]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Укажите размер [m]...");
                int xm3 = GetNum();
                Console.WriteLine("Укажите размер [n]...");
                int xn3 = GetNum();
            EnterAgayn2:
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("В каком диапазоне будут генерироваться числа для заполнения массива?");
                Console.WriteLine("Укажите начало диапазона...");
                int xx3 = GetNum();
                Console.WriteLine("Укажите конец диапазона...");
                int yy3 = GetNum();
                if (yy3 - xx3 <= xm3 * xn3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Диапазон генерируемых чисел меньше чем размер массива. Повторите ввод...");
                    goto EnterAgayn2;
                }
                int[,] array2d3 = Fill2dArray(xm3, xn3, xx3, yy3);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n" +
                $"Сгенерирован вещественных целых чисел, размером [{xm3}, {xn3}]\n\n");
                Print2DArray(array2d3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив после сортировки по возрастанию:");
                Print2DArray(Sort2DArray(array2d3));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════════════\n");
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