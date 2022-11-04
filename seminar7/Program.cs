/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)   
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    } 
    return newArray;
}

void Show2DArray (double[,] array)
{
    Console.Write("Получившийся массив -> ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}


Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение -> ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray (myArray);
*/


/*
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    } 
    return newArray;
}

void Show2DArray (int[,] array)
{
    Console.Write("Получившийся массив -> ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void ShowElement(int[,] array, int ii, int jj)
{
    object num = array[0,0];
    if (ii >= array.GetLength(0) || jj >= array.GetLength(1))
        {
            Console.Write($"Такого элемента в этом массиве нет");
        }
        else
            {
                num = array[ii,jj];
                Console.WriteLine($"Такой элемент в этом массиве есть: {num}");
            }
}
  
Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение -> ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс строки нужного элемента -> ");
int ii = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца нужного элемента -> ");
int jj = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray (myArray);
ShowElement(myArray,ii,jj);
*/



/*
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 1 4 7 2
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    } 
    return newArray;
}

void Show2DArray (int[,] array)
{
    Console.Write("Получившийся массив -> ");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void SumElementsOfColumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        double average = sum/(array.GetLength(0));
        Console.WriteLine($"Среднее арифметическое {j}-ого столбца = {average}");
        
    }
}

Console.Write("Введите количество строк -> ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение -> ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение -> ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m, n, min, max);
Show2DArray (myArray);
SumElementsOfColumn(myArray);
*/