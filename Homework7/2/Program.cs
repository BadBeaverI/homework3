// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
// 1 2 -> На данной позиции находиться элемент 4

void InputMatrix(double[,] matrix) // создаем метод 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11); // [-10, 10]
        }
    }
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void Coordinates(int [,] coordinates)
    {
    for (int i = 0; i < matrix.Length; i++)
    {
    Console.Write("Введите координаты ячейки в массиве 4х4: ");
    matrix[i] = Convert.ToInt32(Console.ReadLine());
    matrix[j] = Convert.ToInt32(Console.ReadLine());
    }
    }
Console.Clear();
double[,] matrix = new double[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
Coordinates (coordinates);
Console.WriteLine($"координаты ячейки в массиве 4х4: {coordinates} ");
if i