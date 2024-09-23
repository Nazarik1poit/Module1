string[] towns = ["Рейкъявик", "Уфа", "Витебск", "Борисов", "Бразилиа"];
Console.WriteLine("Введите название города");
string input = Console.ReadLine();
for (int i = 0; i < towns.Length; i++)
{
    if (input == towns[i])
    {
        Console.WriteLine($"Вы угадали! {input} находиться на {i} позиции в списке.");
        Console.ReadKey();
        Environment.Exit(0);
    }
}
Console.WriteLine("Вы не угадали, попробуйте ещё раз");
