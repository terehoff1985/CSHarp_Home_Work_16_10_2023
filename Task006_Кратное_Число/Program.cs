// .Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
// 34, 5 -> некратно, остаток 4
// 16, 4 -> кратно

System.Console.Write("Введите число 1: ");

int Number1 = int.Parse(Console.ReadLine());

System.Console.Write("Введите число 2: ");

int Number2 = int.Parse(Console.ReadLine());

if(Number1 == Number2 * Number2) 
{
    System.Console.WriteLine($"Число {Number2} является кратным числа {Number1} ");
}
else
{
    System.Console.WriteLine(Number1 % Number2);
     System.Console.WriteLine($"Число {Number2} не является кратным числа {Number1} ");
}
