// See Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать Math.Pow();
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int B = Convert.ToInt32(Console.ReadLine());
int count = 1;
int ram = A;
while (count < B)
{
    count++; // count = count + 1;
    ram = ram * A;
}
 Console.WriteLine($"{A} ^ {B} = {ram} ");