
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

/*
int FindExponentiation (int num, int n)
{
    int res = 1;
    res = Convert.ToInt32(Math.Pow(num, n));
    return res;
}

Console.Write("Input first number A -> ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number B - > ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FindExponentiation(num, n);
Console.WriteLine($"{num}^{n} = {result}");

*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

/*
int SumNumbers(int number)
{
    int sum = 0;
    while ( number > 0)
        {
            int num1 = number%10;
            sum = sum + num1;
            number = (number - num1)/10;
           
        }
        return sum;
}

Console.Write("Введите число -> ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(number);
Console.WriteLine($"Сумма цифр в числе = {result}");
*/



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//  (создать метод, который по очереди запрашивает элементы)

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
//
/*
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int index = 0; index < size; index++)
    {
        Console.Write($"Input number{index+1} of array ->");
        array[index] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < numbers.Length; i++)    
    {
        Console.Write(numbers[i] + " ");
    }
}

Console.WriteLine("Input size of array ");
int a = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(a);
PrintArray(newArray);
*/