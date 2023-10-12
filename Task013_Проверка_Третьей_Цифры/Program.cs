Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

for (int i = number; i >= 100; i = i / 10)
{
    result = i % 10;
}
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(result);
}