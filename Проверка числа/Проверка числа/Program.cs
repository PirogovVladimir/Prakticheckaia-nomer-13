using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число N: ");
        int N;

        // Проверяем, является ли ввод числом
        if (!int.TryParse(Console.ReadLine(), out N))
        {
            Console.WriteLine("Ошибка: Введите корректное целое число.");
            return;
        }

        // Вывод
        if (IsPrime(N))
        {
            Console.WriteLine($"{N} является простым числом.");
        }
        else
        {
            Console.WriteLine($"{N} не является простым числом.");
        }
    }
    // Проверки
    static bool IsPrime(int number)
    {
        // Числа меньше 2
        if (number < 2)
        {
            return false; // Не простое
        }

        // Если число равно 2
        if (number == 2)
        {
            return true; // Простое
        }

        // Если число четное и больше 2
        if (number % 2 == 0)
        {
            return false; // Не простое
        }

        // Проверяем делители от 3 до корня из числа
        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
            {
                return false; // Не простое
            }
        }

        return true; // Простое
    }
}