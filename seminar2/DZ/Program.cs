// Задача 1: Напишите программу, которая принимает
// на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%7 == 0 && num%23 == 0)
// {
//     Console.Write($"{num} кратно одновременно 7 и 23");
// }
// else
// {
//     Console.Write($"{num} не кратно одновременно 7 и 23");
// }



// Задача 2: Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
// и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.


// Console.WriteLine("Введите координаты X и Y: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int y = Convert.ToInt32(Console.ReadLine());
// if (x > 0 && y > 0)
// {
//     Console.Write("Координатная четверть № 1");
// }
// if (x < 0 && y > 0)
// {
//     Console.Write("Координатная четверть № 2");
// }
// if (x < 0 && y < 0)
// {
//     Console.Write("Координатная четверть № 3");
// }
// if (x > 0 && y < 0)
// {
//     Console.Write("Координатная четверть № 4");
// }


// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.


// int num = new Random().Next(10,100);
// Console.WriteLine($"{num}");

// // Console.Write($"Введите двузначное число: ");
// // int num = Convert.ToInt32(Console.ReadLine());

// if (num%10 > num/10)
// {
//     Console.WriteLine($"Наибольшая цифра числа: {num%10}");
// }
// else if (num%10 < num/10)
// {
//     Console.WriteLine($"Наибольшая цифра числа: {num/10}");
// }
// else
// {
//     Console.WriteLine($"Цифры равны!");
// }


// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.



Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    string num = number.ToString(); // Convert the number to a string
    int i = 0;

    while (num.Length > i)
    {
       if ( i == num.Length - 1)
    
       {
          Console.Write($"{num[i]} ");
       }
        
       else
       {
          Console.Write($"{num[i]}, ");
       }
       i++;
    }
}
else
{
    Console.Write("Число не натуральное");
}