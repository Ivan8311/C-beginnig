int Fact(int n) // рекурсия N!
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
    Console.WriteLine(n);
    return n * Fact(n - 1);
}
Console.Write(Fact(5));

// F11 шаг с заходом
// F10 шаг с обходом
// F5 продолжитьcd 