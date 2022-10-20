//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
int SecondNumber(int num)
{
    int dec = num / 10;
    int second = dec % 10;
    int result = second;
    return result;
}
int RandomNumber = new Random().Next(100, 1000);
int result = SecondNumber(RandomNumber);
Console.WriteLine($"Случайное число {RandomNumber}");
Console.WriteLine($"Искомое число {result}");
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6

/*
void ThirdNum(int num)
{
    string numStr = Convert.ToString(num);
    //int length = num.Length;
    if (numStr.Length >2) 
        Console.WriteLine($"Третья слева цифра есть {numStr[2]}");
    else 
        Console.WriteLine("Третьей цифры слева нет");
}

Console.Write("Input number -> ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdNum(num);
*/


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

/*
void Weekend(int num)
{
    if ((num == 6)||(num == 7)) Console.WriteLine("Cheers! It is weekend!");
    else Console.WriteLine("Work, Negro");
}
//Console.Write("Input number from 1 to 7 -> ");
//int num = Convert.ToInt32(Console.ReadLine());
//Weekend(num);

int RandomNumber = new Random().Next(1, 8);
Console.WriteLine(RandomNumber);
Weekend(RandomNumber);
*/