using System;
using System.Collections.Generic;


class TaskSolver
{
    // 1.1 Дробная часть числа
    public static double Fraction(double x)
    {
        return x - Math.Truncate(x);
    }

    // 1.3 Преобразование символа в число
    public static int CharToNum(char x)
    {
        return Convert.ToChar(x);
    }

    // 1.5 Двузначное число
    public static bool Is2Digits(int x)
    {
        return x >= 10 && x <= 99 || x <= -10 && x >= -99;
    }

    // 1.7 Диапазон
    public static bool IsInRange(int a, int b, int num)
    {
        return num >= Math.Min(a, b) && num <= Math.Max(a, b);
    }

    // 1.9 Равенство трех чисел
    public static bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    // 2.1 Модуль числа
    public static int Abs(int x)
    {
        return Math.Abs(x);
    }

    // 2.3 Тридцать пять
    public static bool Is35(int x)
    {
        return (x % 3 == 0 || x % 5 == 0) && !(x % 3 == 0 && x % 5 == 0); // проверка делимости на 3 или 5, но не на оба
    }

    // 2.5 Тройной максимум
    public static int Max3(int x, int y, int z)
    {
        return Math.Max(x, Math.Max(y, z)); // находим максимальное из трех чисел
    }

    // 2.7 Двойная сумма
    public static int Sum2(int x, int y)
    {
        int sum = x + y;

        // Если сумма находится в диапазоне от 10 до 19, возвращаем 20
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }

        // В противном случае возвращаем сумму
        return sum;
    }

    // 2.9 День недели
    public static string DayOfWeek(int x)
    {
        switch (x)
        {
            case 1: return "Понедельник";
            case 2: return "Вторник";
            case 3: return "Среда";
            case 4: return "Четверг";
            case 5: return "Пятница";
            case 6: return "Суббота";
            case 7: return "Воскресенье";
            default: return "Это не день недели";
        }
    }

    // 3.1 Список чисел от 0 до x
    public static string ListNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++) result += i + " ";
        return result.Trim(); // возвращаем строку чисел
    }

    // 3.3 Четные числа от 0 до x
    public static string Chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i += 2) result += i + " ";
        return result.Trim(); // возвращаем строку четных чисел
    }

    // 3.5 Длина числа
    public static int NumLen(long x)
    {
        return x.ToString().Length;
    }

    // 3.7 Квадрат из символов
    public static void Square(int size)
    {
        for (int i = 0; i < size; i++)
            Console.WriteLine(new string('*', size));
    }

    // 3.9 Правый треугольник из символов
    public static void RightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
            Console.WriteLine(new string(' ', x - i) + new string('*', i));
    }

    // 4.1 Поиск первого вхождения числа
    public static int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == x) return i;
        return -1; // если не найдено
    }

    // 4.3 Поиск максимального значения по модулю
    public static int MaxAbs(int[] arr)
    {
        int maxAbsValue = Math.Abs(arr[0]);
        foreach (int num in arr)
            if (Math.Abs(num) > maxAbsValue) 
                maxAbsValue = Math.Abs(num);
        return maxAbsValue;
    }

    // 4.5 Добавление массива в массив
    public static int[] AddArray(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        Array.Copy(arr, 0, result, 0, pos);
        Array.Copy(ins, 0, result, pos, ins.Length);
        Array.Copy(arr, pos, result, pos + ins.Length, arr.Length - pos);
        return result;
    }

    // 4.7 Возвратный реверс
    public static int[] ReverseBack(int[] arr)
    {
        int[] reversed = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) 
            reversed[i] = arr[arr.Length - 1 - i];
        return reversed;
    }

    // 4.9 Все вхождения числа
    public static int[] FindAll(int[] arr, int x)
    {
        List<int> indices = new List<int>(); // список для хранения индексов

        // Идем по всем элементам массива
        for (int i = 0; i < arr.Length; i++)
        {
            // Если текущий элемент равен x, добавляем индекс в список
            if (arr[i] == x)
            {
                indices.Add(i);
            }
        }

        // Преобразуем список в массив и возвращаем его
        return indices.ToArray();
    }

    // Главный метод с выбором задачи
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nВыберите задачу для выполнения (или 0 для выхода):");
            Console.WriteLine("1. Дробная часть числа");
            Console.WriteLine("2. Преобразование символа в число");
            Console.WriteLine("3. Двузначное число");
            Console.WriteLine("4. Диапазон");
            Console.WriteLine("5. Равенство трех чисел");
            Console.WriteLine("6. Модуль числа");
            Console.WriteLine("7. Тридцать пять (делимость)");
            Console.WriteLine("8. Тройной максимум");
            Console.WriteLine("9. Двойная сумма");
            Console.WriteLine("10. День недели");
            Console.WriteLine("11. Список чисел от 0 до x");
            Console.WriteLine("12. Четные числа от 0 до x");
            Console.WriteLine("13. Длина числа");
            Console.WriteLine("14. Квадрат из символов");
            Console.WriteLine("15. Правый треугольник");
            Console.WriteLine("16. Поиск первого вхождения числа");
            Console.WriteLine("17. Поиск максимального значения по модулю");
            Console.WriteLine("18. Добавление массива в массив");
            Console.WriteLine("19. Возвратный реверс");
            Console.WriteLine("20. Все вхождения числа");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите число с дробной частью:");
                        if (double.TryParse(Console.ReadLine(), out double number))
                            Console.WriteLine($"Дробная часть числа {number} = {Fraction(number)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод числа.");
                        break;

                    case 2:
                        Console.WriteLine("Введите символ (0-9):");
                        char input = Console.ReadKey().KeyChar;
                        if (char.IsDigit(input))
                            Console.WriteLine($"\nЧисло из символа {input} = {CharToNum(input)}");
                        else
                            Console.WriteLine("\nОшибка: некорректный символ.");
                        break;

                    case 3:
                        Console.WriteLine("Введите число:");
                        if (int.TryParse(Console.ReadLine(), out int digitNumber))
                            Console.WriteLine($"Число {digitNumber} двузначное: {Is2Digits(digitNumber)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод числа.");
                        break;

                    case 4:
                        Console.WriteLine("Введите a, b и число:");
                        if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b) && int.TryParse(Console.ReadLine(), out int num))
                            Console.WriteLine($"Число {num} в диапазоне [{a}, {b}]: {IsInRange(a, b, num)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 5:
                        Console.WriteLine("Введите три числа:");
                        if (int.TryParse(Console.ReadLine(), out int x1) && int.TryParse(Console.ReadLine(), out int x2) && int.TryParse(Console.ReadLine(), out int x3))
                            Console.WriteLine($"Все три числа равны: {IsEqual(x1, x2, x3)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 6:
                        Console.WriteLine("Введите число:");
                        if (int.TryParse(Console.ReadLine(), out int absNumber))
                            Console.WriteLine($"Модуль числа {absNumber} = {Abs(absNumber)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 7:
                        Console.WriteLine("Введите число:");
                        if (int.TryParse(Console.ReadLine(), out int number35))
                            Console.WriteLine($"Число делится на 3 или 5, но не на оба: {Is35(number35)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 8:
                        Console.WriteLine("Введите три числа:");
                        if (int.TryParse(Console.ReadLine(), out int m1) && int.TryParse(Console.ReadLine(), out int m2) && int.TryParse(Console.ReadLine(), out int m3))
                            Console.WriteLine($"Максимальное из трех чисел: {Max3(m1, m2, m3)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 9:
                        Console.WriteLine("Введите два числа:");
                        if (int.TryParse(Console.ReadLine(), out int s1) && int.TryParse(Console.ReadLine(), out int s2))
                            Console.WriteLine($"Результат сложения: {Sum2(s1, s2)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 10:
                        Console.WriteLine("Введите номер дня недели (1-7):");
                        if (int.TryParse(Console.ReadLine(), out int day))
                            Console.WriteLine(DayOfWeek(day));
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 11:
                        Console.WriteLine("Введите число:");
                        if (int.TryParse(Console.ReadLine(), out int listNum))
                            Console.WriteLine($"Числа от 0 до {listNum}: {ListNums(listNum)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 12:
                        Console.WriteLine("Введите число:");
                        if (int.TryParse(Console.ReadLine(), out int chetNum))
                            Console.WriteLine($"Четные числа от 0 до {chetNum}: {Chet(chetNum)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 13:
                        Console.WriteLine("Введите число:");
                        if (long.TryParse(Console.ReadLine(), out long lenNum))
                            Console.WriteLine($"Длина числа {lenNum} = {NumLen(lenNum)}");
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 14:
                        Console.WriteLine("Введите размер квадрата:");
                        if (int.TryParse(Console.ReadLine(), out int squareSize))
                            Square(squareSize);
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 15:
                        Console.WriteLine("Введите высоту треугольника:");
                        if (int.TryParse(Console.ReadLine(), out int height))
                            RightTriangle(height);
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 16:
                        Console.WriteLine("Введите элементы массива через пробел:");
                        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine("Введите искомое число:");
                        if (int.TryParse(Console.ReadLine(), out int findFirst))
                        {
                            int index = FindFirst(arr1, findFirst);
                            Console.WriteLine(index == -1 ? "Число не найдено" : $"Первое вхождение числа {findFirst} на позиции {index}");
                        }
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 17:
                        Console.WriteLine("Введите элементы массива через пробел:");
                        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine($"Максимальное по модулю значение в массиве: {MaxAbs(arr2)}");
                        break;

                    case 18:
                        Console.WriteLine("Введите первый массив через пробел:");
                        int[] arr3 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine("Введите второй массив через пробел:");
                        int[] ins = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine("Введите позицию для вставки:");
                        if (int.TryParse(Console.ReadLine(), out int pos) && pos >= 0 && pos <= arr3.Length)
                        {
                            int[] result = AddArray(arr3, ins, pos);
                            Console.WriteLine("Результирующий массив: " + string.Join(", ", result));
                        }
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    case 19:
                        Console.WriteLine("Введите элементы массива через пробел:");
                        int[] arr4 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        int[] reversedArray = ReverseBack(arr4);
                        Console.WriteLine("Массив в обратном порядке: " + string.Join(", ", reversedArray));
                        break;

                    case 20:
                        Console.WriteLine("Введите элементы массива через пробел:");
                        int[] arr5 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                        Console.WriteLine("Введите число для поиска:");
                        if (int.TryParse(Console.ReadLine(), out int findAll))
                        {
                            int[] indices = FindAll(arr5, findAll);
                            if (indices.Length > 0)
                                Console.WriteLine("Индексы всех вхождений числа " + findAll + ": " + string.Join(", ", indices));
                            else
                                Console.WriteLine("Число не найдено.");
                        }
                        else
                            Console.WriteLine("Ошибка: некорректный ввод.");
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }
        }
    }
}
