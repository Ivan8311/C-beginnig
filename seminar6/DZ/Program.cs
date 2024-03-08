// Задания!



// Задача 1: Задайте двумерный массив символов
// (тип char [,]). Создать строку из символов этого массива.

// a b c => “abcdef”
// d e f
// Console.Write("Введите количество строк: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int b = Convert.ToInt32(Console.ReadLine());
// string[,] array = new string[a, b];
// Console.WriteLine(array);
// char[,] chars =
// {
//     { '1', 'b', 'e' },
//     { 'g', 'l', 'm' },
//     { 'v', 't', 'b' }
// };
// string stringOfSimbols(char[,] array)
// {
//     string str = "";
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             str = str + array[i, j];
//         }
//     }
//     return str;
// }
// Console.Write(stringOfSimbols(chars));





// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

// “aBcD1ef!-” => “abcd1ef!-”

// using System.Text;

// Console.InputEncoding = Encoding.Unicode;
// Console.OutputEncoding = Encoding.Unicode;

// string str = Console.ReadLine()!;
// Console.WriteLine(str.ToLower());




// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

// Console.Write("Задайте произвольную строку: ");
// string str = Console.ReadLine()!;
// string yesNo(string str)
// {
//     string daNet = "Да";
//     for (int i = 0; i < str.Length / 2; i++)
//     {
//         if (str[i] != str[str.Length - i - 1])
//         {
//             daNet = "Нет";
//         }
//     }
//     return daNet;
// }
// Console.Write(yesNo(str));


// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”
