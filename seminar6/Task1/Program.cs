// Задайте массив символов (тип char []).
//  Создайте строку из символов этого массива.



string CharsOfString(char[] arr)
{
    string st = "";
    foreach (char item in arr)
    {
        st += item;
    }
    return st;
}
char[] chars = new char[] { 'a', 'b', 'c', 'd' };
Console.WriteLine(CharsOfString(chars));
 

 