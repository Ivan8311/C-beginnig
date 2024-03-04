// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.
// Пример
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]


// void intNumber()
// {
//     while (true)
//     {
//         Console.Write("Напишите целое число: ");
//         string? num = Console.ReadLine();

//         if (num == "q")
//         {
//             break;
//         }

//         int sum = 0;
//         bool isValid = true; // Флаг, чтобы проверить, были ли введены только цифры

//         foreach (char c in num)
//         {
//             if (!char.IsDigit(c)) // Проверяем, является ли символ цифрой
//             {
//                 isValid = false; // Если не является, устанавливаем флаг в false
//                 Console.WriteLine("Вы ввели не число. Попробуйте еще раз.");
//                 break;
//             }
//             sum += int.Parse(c.ToString());
//         }

//         if (isValid) // Если все символы были цифрами, продолжаем
//         {
//             if (sum % 2 == 0)
//             {
//                 Console.WriteLine($"Сумма цифр числа {num} четная.");
//                 break;
//             }
//         }
//     }
//     Console.WriteLine("STOP");
// }

// intNumber();


// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.
// [344 452 341 125] => 2
// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] FillArray(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] mas)
// {
//     foreach (int e in mas)
//     {
//         Console.Write($"{e} ");
//     }
//     Console.WriteLine();
// }
// int[] arr = FillArray(n);
// PrintArray(arr);

// int CountNumbers(int[] col)
// {
//     int n = 0;
//     foreach(int e in col)
//     {
//         if(e % 2 == 0) 
//         {
//              n = n + 1;
//         }
//     }
//     return n;
// }
// int j = CountNumbers(arr);
// Console.WriteLine(j);

// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] FillArray(int n)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
//     return array;
// }

// void PrintArray(int[] mas)
// {
//     foreach (int e in mas)
//     {
//         Console.Write($"{e} ");
//     }
//     Console.WriteLine();
// }
// int[] arr = FillArray(n);
// PrintArray(arr);

// int[] InvertedArray(int[] col)
// {
//     int i = 0;
//     int temp_numbers;
//     while (i < col.Length / 2)
//     {
//         temp_numbers = col[i];
//         col[i] = col[col.Length - 1 - i];
//         col[col.Length - 1 - i] = temp_numbers;
//         i++;
        
//     }
//     return col;
// }
// int[] mas = InvertedArray(arr);
// PrintArray(mas);
