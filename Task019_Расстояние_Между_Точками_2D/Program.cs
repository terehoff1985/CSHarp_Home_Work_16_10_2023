/* Console.Clear();
System.Console.Write("Задай координату точки A x:");
int userAX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A y:");
int userAY = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки B x:");
int userBX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B y:");
int userBY = int.Parse(Console.ReadLine());

//int sqrX = (userBX - userAX) * (userBX - userAX);
double sqrX = Math.Pow(userBX - userAX, 2); //Math.Pow(а, 2) функция возводит в степень (переменная, в какую степень надо возвести)
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrt = Math.Sqrt(sqrX + sqrY); // Math.Sqrt(sqrX + sqrY) выводит квадратный корень из переменной в скобочках
System.Console.WriteLine(Math.Round(sqrt, 2)); // Math.Round(sqrt, 2) округляет десятичное число (переменная, сколько знаков после запятой оставить)
 */


//Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в 2D пространстве.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты первой точки:");
        Console.Write("X1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВведите координаты второй точки:");
        Console.Write("X2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateDistance(x1, y1, x2, y2); //Вычисление расстояния между двумя расположениями.

        Console.WriteLine($"\nРасстояние между точками: {distance}");
    }

    static double CalculateDistance(double x1, double y1, double x2, double y2)
    {
        double deltaX = x2 - x1;
        double deltaY = y2 - y1;

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);// Возведение в квадрат.
    }
}