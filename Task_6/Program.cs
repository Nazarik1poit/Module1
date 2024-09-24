Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
Console.Clear();
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
    Console.Clear();
}
double max = Math.Abs(array[0]);
for (int i = 1; i < length; i++)
{
    if (Math.Abs(array[i]) > max)
    {
        max = Math.Abs(array[i]);
    }
}
Console.WriteLine($"Максимальное по модулю число - {max}");
Console.WriteLine("Измененный массив:");
for (int i = 0;i < length;i++)
{
    array[i] = array[i] / max;
    Console.WriteLine($"array[{i}] = {array[i]}");
}
