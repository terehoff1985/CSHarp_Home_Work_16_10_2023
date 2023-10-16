/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */
/* public bool IsPalindrome(int x)
{

if (x < 0)
{return false;}

string reversed = "";
int z = x;

while (z / 10 > 0)
{
reversed += (z % 10).ToString();
z /= 10;
}
reversed += z.ToString();

if(int.TryParse(reversed, out z))
if (z == x)
return true;

return false;
} */
Console.Clear();
Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());

Console.WriteLine($"Квадраты чисел от 1 до {Number}");

for (int i = 1; i < Number + 1; i++)
{
  System.Console.Write(Math.Pow(i, 2));
  if(i < Number)
  System.Console.Write(", ");
}

