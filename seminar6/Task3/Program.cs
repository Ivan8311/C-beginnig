// Считать строку с консоли, состоящую
// из латинских букв в нижнем регистре.
// Выяснить, сколько среди введённых букв гласных (aouei).


using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

string vowel = "aoueiAOUEIАОУЕЁИЫЮЯаоуиыёеюя";

Console.Write("Введите строку: ");
string inputString = Console.ReadLine()!;
int count = 0;
foreach (var item in inputString)
{
    foreach (var i in vowel)
    {
        if (item == i)
        {
            count++;
        }
    }
}
Console.Write($"Количество гласных символов: {count}");
