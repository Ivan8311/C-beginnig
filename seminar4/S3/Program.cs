// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231




Console.Write("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] FillArray(int N)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

void PrintArray(int[] mas)
{
    foreach (int e in mas)
    {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}
int[] arr = FillArray(N);
PrintArray(arr);

int num(int[] col)
{
    int n = 0;
    foreach (var item in col)
    {
        n = n * 10 + item;
    }
    return n;
}

Console.WriteLine(num(arr));
