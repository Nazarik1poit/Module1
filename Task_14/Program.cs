using System;

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
        PrintMatrix(matrix);

        // Упорядочиваем строки по возрастанию суммы элементов
        SortMatrixRowsBySum(matrix);

        // Выводим отсортированную матрицу
        Console.WriteLine("\nОтсортированная матрица:");
        PrintMatrix(matrix);
    }

    // Метод для вывода матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0); // Получаем размер матрицы
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
    static void SortMatrixRowsBySum(int[,] matrix)
    {
        int size = matrix.GetLength(0);
        int[] rowSums = new int[size];

        // Вычисляем суммы строк
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                rowSums[i] += matrix[i, j]; // Суммируем элементы строки
            }
        }

        // Сортируем строки на основе их сумм
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (rowSums[i] > rowSums[j])
                {
                    // Меняем местами суммы
                    int tempSum = rowSums[i];
                    rowSums[i] = rowSums[j];
                    rowSums[j] = tempSum;

                    // Меняем местами строки матрицы
                    for (int k = 0; k < size; k++)
                    {
                        int tempValue = matrix[i, k];
                        matrix[i, k] = matrix[j, k];
                        matrix[j, k] = tempValue;
                    }
                }
            }
        }
    }
}
