/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int CounterZero(int m)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Input number {i+1} -> ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count++;
    }
    return count;
}
Console.Write("Input count of number M -> ");
int m = Convert.ToInt32(Console.ReadLine());
int result = CounterZero(m);
Console.Write($"The count of positive integer -> {result}");
*/


/*
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] Intersection(double b1, double k1, double b2, double k2)
{
    double[] myArray = new double[2];
    double x = (b2-b1)/(k1-k2);
    double y = b1 + k1*(b2-b1)/(k1-k2);
    myArray[0] = x;
    myArray[1] = y;
    return myArray;
}

Console.Write("Input b1 ->");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1 ->");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2 ->");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2 ->");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] result = Intersection(b1, k1, b2, k2);

Console.WriteLine($"Точка пересечения двух заданных прямых -> {(result[0], result[1])}");
*/
