Console.Write("Введите размер массива: ");
int k = int.Parse(Console.ReadLine());
char[] array = new char[k];
char[] alphabet = {'а', 'А', 'б', 'Б', 'в', 'В', 'г', 'Г','е','Е', 'ё', 'Ё', 'ж', 
    'Ж', 'з', 'З', 'и', 'И','й','Й','к','К','л','Л','м','М','н','Н','о',
    'О','п','П','р','Р','с','С','т','Т','у','У','ф','Ф','х','Х','ц','Ц',
    'ч','Ч','ш','Ш','щ','Щ','ъ','Ъ', 'ы','Ы','ь','Ь','э','Э','ю','Ю','я','Я'
};
char[] consonants = { 'б', 'Б', 'в', 'В', 'г', 'Г', 'ж', 'Ж', 'з', 'З', 'й', 'Й', 
    'к', 'К','л','Л','м','М','н','Н','о','О','п','П','р','Р','с','С','т','Т','ф',
    'Ф','х','Х','ц','Ц','ч','Ч','ш','Щ','ъ','Ъ','ь','Ь'
};
Random rand = new Random();
Console.WriteLine("Массив из случайных букв:");
int count = 0; // переменная для подсчёта согласных, попавших в array
for (int i = 0; i < k; i++)
{
    array[i] = alphabet[rand.Next(0, alphabet.Length)];
    Console.Write($"{array[i]}, ");
    if (consonants.Contains(array[i]))
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Массив из согласных:");
char[] onlycons = new char[count];
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < count; j++)
    {
        if (consonants.Contains(array[i]))
        {
            onlycons[j] = array[i];
            Console.Write($"{onlycons[j]}, ");
            break;
        }
    }
}
