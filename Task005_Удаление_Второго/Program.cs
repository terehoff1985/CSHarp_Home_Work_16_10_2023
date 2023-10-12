// Напишите программу которая выводит случайное трехзначное числ, и удаляет вторую цифру.


int number = new Random().Next(100,1000);
System.Console.WriteLine(number);

int First = number / 100;
int Last = number % 10;
System.Console.WriteLine($"First);