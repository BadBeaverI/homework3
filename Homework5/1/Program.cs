// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000); // [100, 999]
}

void ReleaseArray(int[] array)
{
  int chet = 0, nechet = 0;
  foreach (int i in array)
  {
    if (i % 2 < 1)
      chet += 1;
    else
      nechet += 1;
  }
  Console.WriteLine($"Четных чисел в массиве {chet}");
  Console.WriteLine($"Нечетных чисел в массиве {nechet}");
}


Console.Clear();
int[] array = new int[10];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);