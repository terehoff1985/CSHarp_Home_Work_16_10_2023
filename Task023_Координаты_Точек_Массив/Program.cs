/* напишите метод, который принимает на вход координаты двух точек X и Y 
в виде массива целых чисел,
 и возвращает расстояние между ними в 3D пространстве. */

Console.Clear();

Console.Clear();
int[] array = new int[6];


System.Console.Write("Задай координату точки A x:");
array[0] = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A y:");
array[1] = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A z:");
array[2] = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки B x:");
array[3] = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B y:");
array[4] = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B z:");
array[5] = int.Parse(Console.ReadLine());

int userAX = array[0];
int userAY = array[1];
int userAZ = array[2];
int userBX = array[3];
int userBY = array[4];
int userBZ = array[5];


//int sqrX = (userBX - userAX) * (userBX - userAX);
double sqrX = Math.Pow(userBX - userAX, 2); //Math.Pow(а, 2) функция возводит в степень (переменная, в какую степень надо возвести)
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrZ = Math.Pow(userBY - userAZ, 2);
double sqrt = Math.Sqrt(sqrX + sqrY + sqrZ); // Math.Sqrt(sqrX + sqrY) выводит квадратный корень из переменной в скобочках
System.Console.WriteLine(Math.Round(sqrt, 3)); // Math.Round(sqrt, 2) округляет десятичное число (переменная, сколько знаков после запятой оставить)

/* private static int Square(int number)
    {
        return number * number;
    }

    private static int SumSquare(int[] pointA, int[] pointB)
    {
        int sum = 0;
        for (int i = 0; i < pointA.Length; i++)
        {
            sum += Square(pointA[i] - pointB[i]);
        }
        return sum;
    }

    private static double Length(int[] pointA, int[] pointB)
    {
        double result = Math.Sqrt(SumSquare(pointA, pointB));
        return result;
    } */