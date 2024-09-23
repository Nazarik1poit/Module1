using System.Diagnostics;
while (true)
{
    Console.WriteLine("Введите строку");
    string textIn = Console.ReadLine();
    textIn = textIn.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "");
    int length = textIn.Length;
    bool isPalindrome = true;
    for (int i = 0; i < length / 2; i++)
    {
        if (textIn[i] != textIn[length - i - 1])
        {
            isPalindrome = false;
        }
    }
    if (isPalindrome)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
