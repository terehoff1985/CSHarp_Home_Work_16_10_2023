Console.WriteLine("Введите Трехзначное число: ");
 int number = Convert.ToInt32(Console.ReadLine());

string numberString = number.ToString();

if (numberString.Length == 3)
{
    
    int secondDigit = int.Parse(numberString[1].ToString());
    Console.WriteLine("Вторая цифра: " + secondDigit);
}
else
{
    Console.WriteLine("Число не является трехзначным.");
}