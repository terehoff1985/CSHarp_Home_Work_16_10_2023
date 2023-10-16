// Напишите программу, которая по заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).


Console.Clear();


   System.Console.WriteLine("Введите номер четверти: ");
   int result = int.Parse(Console.ReadLine());

   if (result == 1)
    {
    System.Console.WriteLine("x от 0 до 30, y от 0 до 30 ");
    }
    else if (result == 2)
    {
        System.Console.WriteLine("x от 0 до 30, y от -30 до 0 ");
    }
    else if (result == 3)
    {
        System.Console.WriteLine("x от -30 до 0, y от -30 до 0 ");
    }
    else if (result == 4)
    {
        System.Console.WriteLine("x от -30 до 0, y от 0 до 30 ");
    }
    else
    {
        System.Console.WriteLine("Вы ввели не существующую четверть!!!");
    }

