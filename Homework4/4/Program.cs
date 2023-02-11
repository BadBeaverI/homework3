void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(-100, 101); // [-9, 9]
}


string ReleaseArray(int[] array, int k)
{
  foreach (int element in array)
  {
    if (10 < element <101 )
      summ = summ+1;
  }
  return "no";
}


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.Write("Количество элементов: ");
int summ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ReleaseArray(array, k));