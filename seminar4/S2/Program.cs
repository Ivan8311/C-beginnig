// Задача 2
// Задайте массив из N случайных целых чисел
// (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1
// и делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

Console.Write("Задайте число элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] NewMas(int N)
{
    int[] mas = new int[N];
    for (int i = 0; i < N; i++)
    {
        mas[i] = new Random().Next(1, 100);
    }
    return mas;
}
void Print_mas(int[] mas)
{
    foreach (var i in mas)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
int[] array = NewMas(N);
Print_mas(array);

int count(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < N; i++)
    {
        if (arr[i] % 10 == 1 && arr[i] % 7 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}
int result = count(array);
Console.WriteLine(result);
