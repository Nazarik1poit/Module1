Console.Write("Введите к простых чисел: ");
int k = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 2; i < k; i++)
{
    if (IsPrime(i) == true)
    {
        if (count % 8 == 0)
        {
            Console.WriteLine();
        }
        Console.Write(i + " ");
        count++;
    }
}

static bool IsPrime(int number)
{
    // Простые числа должны быть больше 1
    if (number <= 1) return false;

    // Проверяем делимость числа от 2 до квадратного корня из числа
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            return false; // Если делится без остатка, то это не простое число
        }
    }

    return true; // Если не нашлось делителя, число простое
}
