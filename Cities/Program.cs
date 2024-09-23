using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            string[] towns = { "Рейкъявик", "Уфа", "Витебск", "Борисов", "Бразилиа" };
            Console.WriteLine("Введите название города:");
            string input = Console.ReadLine();
            bool found = false;  // Флаг, чтобы отслеживать, был ли найден город
            for (int i = 0; i < towns.Length; i++)
            {
                if (input == towns[i])
                {
                    Console.WriteLine($"Вы угадали! {input} находится на {i}-й позиции в списке.");
                    found = true;
                    break;  // Выход из цикла, так как город найден
                }
            }
            if (!found)
            {
                Console.WriteLine("Вы не угадали, попробуйте ещё раз.");
            }
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey(); 
            Console.Clear();  
        }
    }
}
