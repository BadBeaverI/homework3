// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
// 1 2 -> На данной позиции находиться элемент 4
Console.Clear();
void InputMatrix(double[,] matrix) // создаем метод для заполнения матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
        }
    }
}
void PrintMatrix(double[,] matrix) // создаем метод вывода заполненной матрицы
{
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
double[,] matrix = new double[5, 5];
InputMatrix(matrix);
PrintMatrix(matrix);
 Console.WriteLine("Введите координаты № строки ");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите координаты № столбца ");
 int b = Convert.ToInt32(Console.ReadLine());
  if (a < 5 && b<5)
 {
 object c = matrix.GetValue(a,b);
 Console.WriteLine($"ячейка содержит данные [{c}] ");
 }
  else
 Console.WriteLine("такой позиции в массиве нет");