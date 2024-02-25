void printsquares (int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++;
    }
}
printsquares(5);
printsquares(10);
printsquares(15);
