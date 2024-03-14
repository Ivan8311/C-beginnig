// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.

// рекурсия

int SumNum(int num)
{
    if (num == 0)
    {
        return 0;
    }
    // int sum = num % 10 + SumNum(num / 10);
    // return sum;
    return num % 10 + SumNum(num / 10);
}


Console.Write("Введите число: ");
int n  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(n));
