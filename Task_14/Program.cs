using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер матрицы: ");
        int size = int.Parse(Console.ReadLine());

        // Создаем матрицу и заполняем ее случайными значениями от -50 до +50
        int[,] matrix = new int[size, size];
        Random rnd = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = rnd.Next(-50, 51); // Значения от -50 до 50 включительно
            }
        }

        // Выводим исходную матрицу
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix, size);

        // Упорядочиваем строки по возрастанию суммы элементов
        SortMatrixRowsBySum(ref matrix, size);

        // Выводим отсортированную матрицу
        Console.WriteLine("\nОтсортированная матрица:");
        PrintMatrix(matrix, size);
    }

    // Метод для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix, int size)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Метод для сортировки строк матрицы по суммам элементов
    static void SortMatrixRowsBySum(ref int[,] matrix, int size)
    {
        // Создаем временный массив для хранения строк и их сумм
        var rowsWithSums = new Tuple<int[], int>[size];

        for (int i = 0; i < size; i++)
        {
            int[] row = new int[size];
            for (int j = 0; j < size; j++)
            {
                row[j] = matrix[i, j];
            }
            int sum = row.Sum(); // Вычисляем сумму строки
            rowsWithSums[i] = new Tuple<int[], int>(row, sum);
        }

        // Сортируем строки по возрастанию их сумм
        var sortedRows = rowsWithSums.OrderBy(row => row.Item2).ToArray();

        // Записываем отсортированные строки обратно в матрицу
        for (int i = 0; i < size; i++)
        {
            int[] sortedRow = sortedRows[i].Item1;
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = sortedRow[j];
            }
        }
    }
}
