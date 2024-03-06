// Задание 3. Совместная работа
// Семинар 5. Двумерные массивы
// 20 мин
// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
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

int[,] arr = new int[m, n];
FillRandomArray(arr);
Print_arr(arr);

Console.WriteLine();

double[] arr_one = toOneArray(arr);
print_one_array(arr_one);

double[] toOneArray(int[,] arr)
{
    double[] mas = new double[arr.GetLength(0)];
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        mas[i] = sum / arr.GetLength(1);
    }
    return mas;
}
void print_one_array(double[] arr)
{
    foreach (var e in arr)
    {
        Console.Write($"{e}\t");
    }
    Console.WriteLine();
}
