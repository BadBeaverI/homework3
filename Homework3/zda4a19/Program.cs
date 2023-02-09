// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Проверка числа на палиндром, введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int etalon = number;
int rev = 0;
int dig;
while(number > 0)
  {
    dig = number % 10;
    rev = rev * 10 + dig;
    number = number/10;
    Console.WriteLine($"dig = {number} ");
    Console.WriteLine($"rev = {rev} ");
  }
if(etalon == rev)
    Console.WriteLine($"Ваше число: {etalon} - палиндром.");
else
    Console.WriteLine($"Ваше число: {etalon} - НЕ палиндром.");