// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int etalon = number;
int rev = 0;
int dig;
while(number > 0)
  {
    dig = number % 10;
    rev = rev + dig;
    number = number/10;
  }
Console.WriteLine($"Сумма цифр в числе {etalon} = {rev}");
