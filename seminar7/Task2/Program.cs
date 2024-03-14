// рекурсия

// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

// string GetListNatNums(int N, int index = 1) Вместо строчки ниже
void GetListNatNums(int N, int index = 1)
{
    if (index == N)
    {
        Console.Write($"{index} ");
        return;
        // return Convert.ToString(index); вместо 2 - ух строчек выше
    }
    GetListNatNums(N, index + 1); // если поменять 15 и 16 . будет начинать с начала
    Console.Write($"{index} ");
    // return index + " " + GetListNatNums(N, index + 1); вместо 2 - ух строчек выше

}

Console.Write("Введите натуральное число: ");
int N = Convert.ToInt32(Console.ReadLine());
// Console.Write(GetListNatNums(N)); Вместо строчки ниже
GetListNatNums(N);
