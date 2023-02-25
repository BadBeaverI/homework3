// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3// 
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
int ReleaseMatrix(int[,] matrix)
{
    int minRow = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
        minRow += matrix[0, i];

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (minRow > sumRow)
            minRow = sumRow;
    }
    return minRow;
}
Console.Clear();
Console.Write("Введите размер прямоугольного двумерного массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] == size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер прямоугольного двумерного массива: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный двумерный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"Результат: {ReleaseMatrix(matrix)}");