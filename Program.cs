// ------------------------------------------------>
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine());
// PrintNtoOne(n);


// ------------------------------------------------>
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine());
// int sum = 0;

// Console.WriteLine("Сумма элементов: " + FindSum(m, n, sum));


// ------------------------------------------------>
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Console.WriteLine("Введите m");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите n");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("A("+m+", "+n+") = "+ Ackerman(m, n));

// ------------------------------------------------>

void PrintNtoOne(int n)
{
    Console.Write(n + " ");
    n--;
    if (n > 0)
        PrintNtoOne(n);
}

int FindSum(int m, int n, int sum)
{
    sum += m;
    m++;
    if (m <= n)
        return FindSum(m, n, sum);
    return sum;
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    
    else if((m > 0) && (n == 0))
    {
        return Ackerman(m - 1, 1);
    }
    
    else if((m > 0) && (n > 0))
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    
    else
        return n + 1;
}