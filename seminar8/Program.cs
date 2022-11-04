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



/*
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    if(array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Умножение этих матриц невозможно: количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        return newArray;
    }
    else  
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {       
                newArray[i,j]=0;       
                for (int column1 = 0; column1 < array1.GetLength(1); column1++)
                    newArray[i,j] = newArray[i,j] + array1[i,column1]*array2[column1,j];
            }
        }                                               
        return newArray;
    }
}

int[,] myArray1 = new int[2, 2];
int[,] myArray2 = new int[2, 2];
myArray1[0,0]=2;
myArray1[0,1]=4;
myArray1[1,0]=3;
myArray1[1,1]=2;

myArray2[0,0]=3;
myArray2[0,1]=4;
myArray2[1,0]=3;
myArray2[1,1]=3;

Show2DArray (myArray1);
Console.WriteLine();
Show2DArray (myArray2);
Console.WriteLine();
Console.WriteLine("Результат умножения заданных матриц -> ");
Show2DArray(MatrixMultiplication(myArray1, myArray2));
*/



/*
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DArray(int pages, int rows, int columns)
{
    int[,,] newArray = new int[pages, rows, columns];
    for (int i = 0; i < pages; i++)                      
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                newArray[i,j,k] = new Random().Next(10, 100);
            }
        }
    }
    return newArray;
}

void Show3DArray(int[,,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)                      
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите количество страниц -> ");
int p = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк -> ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов -> ");
int c = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = Create3DArray(p, r, c);
Show3DArray(myArray);
*/