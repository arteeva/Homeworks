/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.
//
//[345, 897, 568, 234] -> 2
//
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int FindEvenElements(int[] array)
{
    int count = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i]%2 == 0) count++;
    }
    return count;
}

Console.WriteLine("Input size of array ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a, 100, 999);
ShowArray(myArray);
int result = FindEvenElements(myArray);
Console.WriteLine($"Количество четных чисел в массиве -> {result}");
*/



/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//
//[3, 7, 23, 12] -> 19
//
//[-4, -6, 89, 6] -> 0
//

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SumOddElements (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Input size of array ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = SumOddElements(myArray);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {result}");
*/



/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//
//[3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindMaxMin(int[] array)
{
    int i = 0;
    int max = array[i];
    int min = array[i];
    for (i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];   
    }
    return max-min;
}

Console.WriteLine("Input size of array ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min range");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max range ");
int maxRange = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(a, minRange, maxRange);
ShowArray(myArray);
int result = FindMaxMin(myArray);

Console.WriteLine($"Разница между значениями максимального и минимального элементов массива = {result}");
*/