using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Определяем массив на 10 элементов
        double[] arraydouble = new double[10];
        Random rand = new Random();

        // Заполняем массив случайными значениями в диапазоне [-9, 10)
        for (int i = 0; i < arraydouble.Length; i++)
        {
            arraydouble[i] = rand.NextDouble() + rand.Next(-9, 10);
            Console.WriteLine($"array[{i}] = {arraydouble[i]:F2}");
        }

        // Создаем массив индексов и сортируем их по значению массива arraydouble
        int[] indexes = arraydouble
            .Select((value, index) => new { Value = value, Index = index })
            .OrderBy(x => x.Value)
            .Select(x => x.Index)
            .ToArray();

        // Выводим массив индексов
        Console.WriteLine("\nМассив индексов в порядке возрастания значений:");
        for (int i = 0; i < indexes.Length; i++)
        {
            Console.WriteLine($"indexes[{i}] = {indexes[i]} (значение: {arraydouble[indexes[i]]:F2})");
        }
    }
}
