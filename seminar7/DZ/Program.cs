// Задание
// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// Console.Write("Введите M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// void NaturalDigit(int M, int N)
// {
//     if (M == N)
//     {
//         Console.Write($"{M} ");
//         return;
//     }
//     Console.Write($"{M} ");
//     NaturalDigit(M + 1, N);
// }
// NaturalDigit(M, N);




// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// n = 3, m = 2 -> A(n,m) = 29

// Console.Write("Введите n: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите m: ");
// int M = Convert.ToInt32(Console.ReadLine());

// int result = A(N, M);
// Console.WriteLine(result);

// int A(int n, int m)
// {
//     if (n == 0)
//     {
//         return m + 1;
//     }
//     else if (n > 0 && m == 0)
//     {
//         return A(n - 1, 1);
//     }
//     else if (n > 0 && m > 0)
//     {
//         return A(n - 1, A(n, m - 1));
//     }
//     else
//     {
//         Console.Write("Ошибка");
//         return -1;
//     }

// }


// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] arr = { -1, 2, 6, 89, 2, 15 };

void LastToFirstNumbers(int[] array, int i)
{
    if (i < 0)
    {
        return;
    }
    Console.Write($"{array[i]} ");
    LastToFirstNumbers(array, i - 1);
}
LastToFirstNumbers(arr, arr.Length - 1);