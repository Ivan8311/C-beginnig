int n = 10;
int[] arr = new int[n];
void FillArray(int[] arr)
{
    for (int i = 0; i < n; i++)
    {
        arr[i] = i + 1;
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}
FillArray(arr);
PrintArray(arr);
Console.WriteLine();

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    foreach (int e in arr)
    {
        sum = sum + e;
    }
    Console.WriteLine($"Sum of elements = {sum}");
    return sum;
}
GetSumOfElements(arr);

int GetProductOfElements(int[] arr)
{
    int Product = 1;
    foreach (int e in arr)
    {
        Product = Product * e;
    }
    Console.WriteLine($"Product of elements = {Product}");
    return Product;
}
GetProductOfElements(arr);

// int product = GetProductOfElements(arr)
// Console.WriteLine(sum);
// Console.WriteLine(product);
