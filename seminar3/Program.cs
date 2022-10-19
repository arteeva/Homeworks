/*
//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

void Palindrome(int num) //12345
{
    int num5 = num % 10; //единицы             
    int curr = num / 10; 
    int num4 = curr % 10; //десятки
    int curr2 = num / 100;
    int num3 = curr2 % 10; //сотни
    int curr3 = num / 1000;
    int num2 = curr3 % 10; //десятки сотен
    int curr4 = num / 10000;
    int num1 = curr4 % 10; //сотни сотен

    if ((num5 == num1) && (num2 == num4))
        Console.WriteLine("Введенное число является палиндромом");
    else
        Console.WriteLine("Введенное число не является палиндромом");
}

Console.Write("Введите пятизначное число -> ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrome(num);
*/


/*
//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
   return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2) + Math.Pow((zb - za),2));
}
Console.WriteLine("Input xa:");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input ya:");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input za:");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input xb:");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input yb:");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input zb:");
double zb = Convert.ToDouble(Console.ReadLine());

double dist = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Distance = {dist}");
*/


/*
//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


void Square(int N)
{
    int num = 1;
    while (num <= N) 
    {
        Console.WriteLine($"Square {num} = {Math.Pow(num,3)}");
        num++;
    }
    }
Console.WriteLine("Input N ->");
int N = Convert.ToInt32(Console.ReadLine());
Square(N);
*/