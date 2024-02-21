// Задача 1. Создать масиив и заполнить его целыми числами
// от 1 до N (N - произвольное натуральное число).
// Вывести эдементы массива на экран.

// int n = 10;
// int[] arr = new int[n];
// int i = 0;

// while (i < arr.Length) // or => while (i < n)
// {
//     arr[i] = i + 1;
//     // Console.write(arr[i]);
//     // Console.write(' ');
//     Console.Write($"{arr[i]} ");
//     i = i + 1;
// }

// Задача 2. Создать целочисленный массив на 10
// элементов и заполнить его произвольными числами.
// Вывести на экран чётные элементы массива.

// int[] arr = { 2, 5, 3, 4, 9, 3, 1, 5, 1, 2 };
// int i = 0;

// while (i < arr.Length)
// {
//     if (arr[i] % 2 == 0) // or (arr[i] mod 2 == 0)
//     {
//         Console.Write($"{arr[i]} ");
//     }
//     i++;
// }

// Задача 3. Дано 10 гирь с разным весом в случайном порядке. 
// Определить вес самой тяжелой гири. 

// int[] arr = { 24, 5, 3, 4, 9, 3, 1, 5, 11, 2 };
// int i = 0;
// int max = arr[i];


// while (i < arr.Length)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//     }
//     i++;
// }
// Console.Write(max);



//    Цикл "for":

// int[] arr = { 24, 5, 3, 4, 9, 3, 1, 5, 11, 2 };
// int max = arr[0];
// for (int j = 0; j < arr.Length; j++)
// {
//     if (arr[j] > max)
//     {
//         max = arr[j];
//     }

// }
// Console.Write(max);



//    Цикл "foreach"

int[] array = { 24, 5, 3, 4, 9, 3, 1, 5, 11, 2 };
int max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }

}
Console.Write(max);



