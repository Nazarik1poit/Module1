using System;

class Program
{
    // Статический метод для вычисления НОД (алгоритм Евклида)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        try
        {
            // Ввод числителя и знаменателя с клавиатуры
            Console.Write("Введите числитель (неотрицательное целое число): ");
            int numerator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите знаменатель (положительное целое число): ");
            int denominator = Convert.ToInt32(Console.ReadLine());

            // Проверка на корректность ввода
            if (numerator < 0 || denominator <= 0)
            {
                Console.WriteLine("Числитель должен быть неотрицательным, а знаменатель — положительным числом.");
                return;
            }

            // Вычисление НОД числителя и знаменателя
            int gcd = GCD(numerator, denominator);

            // Сокращение дроби
            int reducedNumerator = numerator / gcd;
            int reducedDenominator = denominator / gcd;

            // Вывод сокращенной дроби
            Console.WriteLine($"Сокращенная дробь: {reducedNumerator}/{reducedDenominator}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Некорректный ввод. Введите целые числа.");
        }
    }
}
