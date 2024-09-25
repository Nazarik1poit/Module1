Console.Write("Введите число: ");
int maxsumm = int.Parse(Console.ReadLine());
int[] array = new int[maxsumm*3];
int i = 0;
Random rnd = new Random();
int sum = 0;
while (true)
{
    int temp = rnd.Next(1, 10);
    if (sum + temp < maxsumm)
    {
        array[i] = temp; 
        sum += temp;
        i++;
    }
    else {
        break;
    }
}
Console.WriteLine($"Сумма: {sum}");
int[] optarray = new int[i];
for (int j = 0; j < optarray.Length; j++)
{
    optarray[j] = array[j];
    Console.WriteLine($"array[{j}] = {optarray[j]}");
}
