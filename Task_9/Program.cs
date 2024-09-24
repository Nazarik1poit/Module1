Console.Write("Введите количество элементов: ");
int k = int.Parse(Console.ReadLine());
int[] array = new int[k];
Console.Clear();
Console.WriteLine("Введите диапазон A, B");
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
Random rnd = new Random();  
for  (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(A, B);
    Console.WriteLine($"array[{i}] = {array[i]}");
}
int maxindex = 0;
int minindex = 0;
for (int i = 1;i < array.Length; i++)
{
    if (array[i] > array[maxindex])
    {
        maxindex = i;
    }
    if (array[i] < array[minindex])
    {
        minindex = i;
    }
}
Console.WriteLine($"Максимальный индекс {maxindex}, минимальный: {minindex}");
Console.ReadKey();
Console.Clear();
if (maxindex < minindex)
{
    for (int i = maxindex; i <= minindex; i++)
    {
        Console.WriteLine($"newarray[{i}] = {array[i]}");
    }
}
else
{
    {
        for (int i = minindex; i <= maxindex; i++)
        {
            Console.WriteLine($"newarray[{i}] = {array[i]}");
        }
    }
}