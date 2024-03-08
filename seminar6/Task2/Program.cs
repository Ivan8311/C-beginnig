// На основе символов строки (тип string)
// сформировать массив символов (тип char[]).
//  Вывести массив на экран.

using System.Text; // подключение к библиотеке

char[] StringToCharArray(string inputString)
{
    char[] charArray = new char[inputString.Length];
    for (int i = 0; i < inputString.Length; i++)
    {
        charArray[i] = inputString[i];
    }
    return charArray;
}

void PrintCharArray(char[] arr)
{
    foreach (char item in arr)
    {
        Console.Write($"'{item}' ");
    }
}
Console.InputEncoding = Encoding.Unicode; // для печати
Console.OutputEncoding = Encoding.Unicode;// на русском
Console.Write("Введите строку: ");
string inputString = Console.ReadLine();
PrintCharArray(StringToCharArray(inputString));
