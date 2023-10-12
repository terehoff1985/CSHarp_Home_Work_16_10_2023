
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

Console.WriteLine($"Целые числа от{-Number} до {Number}");

for (int i = -Number; i < Number + 1; i++)
{
  System.Console.Write(i);
  if(i < Number)
  System.Console.Write(", ");
}

    
