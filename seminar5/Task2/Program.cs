// Задание 2. Обсуждение решения
// Семинар 5. Двумерные массивы
// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4

void Print_arr(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillRandomArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 11);
        }
    }
    return arr;
}

int[,] arr = new int[m,n];
FillRandomArray(arr);
Print_arr(arr);
int Summa = findSumOfDiagonal(arr);
Console.WriteLine($"Сумма элементов главной диагонали: {Summa}");


int findSumOfDiagonal(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j)
            {
                sum +=arr[i,j];
            }
        }
    }
    return sum;
}



