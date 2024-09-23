while (true)
{
    Random random = new Random();
    int randint = random.Next(1, 11);
    Console.WriteLine("Введите рандомное число");
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Было загадано " + randint);
    if (input == randint)
    {
        Console.WriteLine("Вы угадали!");
    }
    else
    {
        Console.WriteLine("Попробуйте ещё раз");
    }
}
