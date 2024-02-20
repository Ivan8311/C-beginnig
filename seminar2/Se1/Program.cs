// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.


// int num = new Random().Next(100,1000);
// Console.WriteLine(num);
// int s = num/100*10 + num%10;
// Console.WriteLine(s);
// Console.WriteLine(num/100 + "" + num%10);




// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.


// //int num = new Random().Next(10,1000);

// int num = Convert.ToInt32(Console.ReadLine());

// //Console.WriteLine(num);

// if (num <= 999 && num >= 100)
// {
//     int num_3 = num%10;
//     int num_2 = num/10%10; //  123/10 = 12 -> 12%10 = 2
//     // Console.WriteLine(num_2 + " " + num_3);
//     Console.WriteLine(Math.Pow(num_2, num_3));

// }
// else
// {
//     Console.WriteLine("Число не трехзачное");
// }


// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления

//моя попытка
// int num_1 = new Random(). Next(1,50);
// int num_2 = new Random(). Next(50,100);
// Console.WriteLine($"{num_1} {num_2}");
// if (num_2 % num_1 == 0)
// {
//     Console.WriteLine("первое число кратно второму");
// }

// else
// {
//     Console.WriteLine(" первое число не кратно второму ");
//     Console.WriteLine($" остаток от дедения {num_2 % num_1}");
// }
// ______________________________________________________
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num2 % num1 != 0)
// {
// Console.WriteLine($"Число {num1} не является кратным {num2}! Остаток от деления: {num2 % num1}");
// }
// else
// {
// Console.WriteLine($"Число {num1} является кратным {num2}!");
// }


// Напишите программу,
// которая выводит третью слева цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int num2 = 0;

// if (num < 100)
// {
//     Console.Write("Третьей цифры нет");
// }
// else
// {
//     while (num > 100)
//     {
//         num2 = num % 10;
//         num /= 10; // num = num / 10
//     }
//     Console.WriteLine(num2);
// }

string num = Console.ReadLine()!;
if (num.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(num[2]);
}
