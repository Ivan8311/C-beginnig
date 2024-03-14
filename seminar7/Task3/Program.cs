// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.

Console.Write("Введите строку с латинскими буквами: ");
string str = Console.ReadLine()!;
void Bukvi(string str)
{
    if (str == "")
    {
        return;
    }
    string list = "aeiouyAEIOUY";
    if (!list.Contains(str[0]))
    {
        Console.Write(str[0]);
    }
    Bukvi(str[1..]);
    // Hello[2..] => llo так осуществляется срез

}
Bukvi(str);

// другой вариант

// void PrintStringWOVowels(string str, int startIndex = 0)
// {
//     string Vowels = "aeiouyAEIOUY";
//     if (startIndex == str.Length - 1)
//     { return; }
//     if (!Vowels.Contains(str[startIndex]))
//     { Console.Write($"{str[startIndex]}"); }
//     PrintStringWOVowels(str, startIndex + 1);
// }

// Console.Write("Введите строку: ");
// string inputStr = Console.ReadLine()!;
// PrintStringWOVowels(inputStr);