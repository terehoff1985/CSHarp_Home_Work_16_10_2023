﻿Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <=5 && dayNumber > 0)
{
    System.Console.WriteLine("Это рабочий день!");
}
if (dayNumber == 6 || dayNumber ==7)
{
    System.Console.WriteLine("Ура выходной!");
}
else if (dayNumber < 1 ||  dayNumber > 7)
{
    System.Console.WriteLine("Такого дня недели не сущесьвует! ты че...");
}
