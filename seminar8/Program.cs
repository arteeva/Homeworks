/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] Decrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int column = 1; column < array.GetLength(1); column++)
            {
                if(array[i,column] >= array[i,column-1])
                {
                    int temp = array[i,column-1];
                    array[i,column-1] = array[i,column];
                    array[i,column] = temp;
                }
            }
        }
    }
    return array;
        
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
Console.WriteLine();
//Decrease(myArray);
Console.WriteLine("Массив с отсортированными в порядке убывания строками -> ");
Show2DArray (Decrease(myArray));
*/



/*
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] MinSumElementsOfRow(int[,] array)
{
    int[] newArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        newArray[i] = sum;
        Console.WriteLine($"Сумма элементов {i}-той строки = {sum}");
    }
    return newArray;  
}

int FindMinOfSumElOfRows(int[] array)
{
    int min = array[0];
    int indexMinSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(array[i] < min) 
        {
            min = array[i];
            indexMinSum = i;
        }
    }
    return indexMinSum;
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
int result = FindMinOfSumElOfRows(MinSumElementsOfRow(myArray));
Console.WriteLine($"Индекс строки с наименьшей суммой элементов -> {result}.(Строка {result+1}).");
*/



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

