/* напишите метод, который принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом.
 14212 -> False
12821 -> True
234322 -> Число не пятизначное False */

/* Console.Clear();

Console.WriteLine("Введите Пятизначное число: ");

int N = Convert.ToInt32(Console.ReadLine());



if (9999 < N && N < 100000)
{
    int number1 = N % 10;
    int number2 = N % 100 / 10;
    
    
    if ((number1 == N/10000) & (number2 == N / 1000 % 10))
    {
    
    System.Console.WriteLine("Число является полиндромом!");
    
    }
    
    else
    {
        System.Console.WriteLine("Число не является полиндромом!");
    }
    
}
else
{
    System.Console.WriteLine("Число не пятизначное!!!");
} */

int Number,r,sum=0,t;
Console.Write("Введите число: ");
Number = Convert.ToInt32(Console.ReadLine());
if(Number!=0)
{
    for(t=Number;Number!=0;Number=Number/10)
    {
    r=Number % 10;
    sum=sum*10+r;
    }
    if(t==sum)
    Console.Write($"True");
    else
    Console.Write($"False");
}
else
Console.Write("Не пятизначное число!");