
Console.WriteLine("Введите последовательный номер дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
string Day = "";
if (DayNumber == 1) Day = "Понедельник";
if (DayNumber == 2) Day = "Вторник";
if (DayNumber == 3) Day = "Среда";
if (DayNumber == 4) Day = "Четверг";
if (DayNumber == 5) Day = "Пятница";
if (DayNumber == 6) Day = "Суббота";
if (DayNumber == 7) Day = "Воскресенье";
if (DayNumber > 7 || DayNumber < 1) Day = "Не правильно ввели цифру!!!";

Console.WriteLine(Day);