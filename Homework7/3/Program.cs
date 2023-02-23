// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
Console.Clear();
double[,] matrix = new double[4, 2]; // задаем размер запоняемой матрицы
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