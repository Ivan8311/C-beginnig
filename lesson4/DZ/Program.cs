// Считать с консоли строку, состоящую из цифр
// и латинских букв.
// Сформировать массив, состоящий из цифр
// этой строки.

// daf12kj085 => [1, 2, 0, 8, 5]

string GetDigitsFromString(string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if (char.IsAsciiDigit(e) == true)
        {
            digits = digits + e;
        }
    }
    return digits;
}
string str = Console.ReadLine();
string result = GetDigitsFromString(str);
Console.WriteLine(result);

char[] charArray = result.ToCharArray();
int[] digitsArray = new int[charArray.Length];

for (int i = 0; i < charArray.Length; i++)
{
    digitsArray[i] = int.Parse(charArray[i].ToString());
}

Console.Write("[");
for (int i = 0; i < digitsArray.Length; i++)
{
    Console.Write(digitsArray[i]);
    if (i < digitsArray.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine("]");
