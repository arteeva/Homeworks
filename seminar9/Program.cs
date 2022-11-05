/*
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumber(int n)
{
    if (n<=0) Console.Write("Это число не натуральное");
    else
        {
            Console.Write(n + " ");
            if (n>1) ShowNumber(n-1);
        }
}

ShowNumber(-10);
*/



/*
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int CalculateSum(int m, int n)
{
    if (n != m)
    {
        if (n > m) return (n + CalculateSum(m, n-1));
        else return (m + CalculateSum(m-1, n) + n);
    }
    else return n;
}

Console.WriteLine(CalculateSum(1,15));
*/



/*
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkermana(int n, int m)
{
    if (n == 0) return (m + 1);
    if (m == 0) return FunctionAkkermana(n - 1, 1);
    else return FunctionAkkermana(n - 1, FunctionAkkermana(n, m - 1));
}

Console.WriteLine(FunctionAkkermana(3,2));
*/