// void PrintMessage(string message)
// {
//     Console.WriteLine(message);
// }
 
// PrintMessage("Hello work");           // Hello work
// PrintMessage("Hello METANIT.COM");    // Hello METANIT.COM
// PrintMessage("Hello C#");   

// string GetMessage()
// {
//     return "Hello";
// }
 
// string message = GetMessage();  // получаем результат метода в переменную message
// Console.WriteLine(GetMessage()); 

// Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.

// Примеры

// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3


// int NewArray(int[] arr)


int[] Random_mas(int num)
{
    int[] mas = new int[num];
    for (int i = 0; i < mas.Length; i++)
    {
           mas[i] = new Random().Next(0, 21);
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
bool prost(int num)
{
    if(num == 0 || num == 1) return false;
    else
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}

int Count(int[] col)
{
    int count = 0;
    foreach (var i in col)
    {
          if(prost(i)) 
          {
            Console.Write ($"{i} ");
            count++;
          }
    }
    Console.WriteLine();
    return count;
}

Console.Write("Задайте одномерный массив: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = Random_mas(n);
Print_mas(array);
Console.WriteLine(Count(array));


// int[] col = new int[n];

// {
//     for (int i = 0; i < col.Length; i++)
//     {
//         col[i] = new Random().Next(1, 10);
//     }
//     return col;
// }
// NewArray(arr);
// Console.Write(new int[n]);








