Console.Clear();

System.Console.Write("Введите число 1: ");

int Number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите число 2: ");

int Number2 = int.Parse(Console.ReadLine());

if(Number2*Number2 == Number1 || Number1*Number1 == Number2) 
{
    System.Console.WriteLine("Да");
}
else
{
     System.Console.WriteLine("Нет");
}