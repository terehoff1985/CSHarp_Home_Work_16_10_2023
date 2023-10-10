System.Console.Write("Введите число 1: ");

int Number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите число 2: ");

int Number2 = int.Parse(Console.ReadLine());

if(Number2*Number2 == Number1) 
{
    System.Console.WriteLine($"Число {Number2} является квадратом числа {Number1} ");
}
else
{
     System.Console.WriteLine($"Число {Number2} не является квадратом числа {Number1} ");
}
