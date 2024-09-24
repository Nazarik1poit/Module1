int[] array = new int[10];
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,20);
    Console.WriteLine($"array[{i}] = {array[i]}");
}
int max = array[0];
int maxindex = 0;   
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
        maxindex = i;
    }
}
Console.WriteLine($"Индекс максимального элемента: {maxindex}");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Введите любое целое число");
int input = Convert.ToInt32(Console.ReadLine());
array[maxindex] = input;
Console.WriteLine("Измененный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"array[{i}] = {array[i]}");
}
