﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear(); // чистим консоль
int count = 0; // вводим счетчик положительных чисел присваем ему переменную count
Console.Write("Мы хотим посчитать сколько чисел больше 0 ввёл пользователь. Сколько цифр вы хотите ввести? : "); // даем коменду через консоль комент о просьбе ввести количество чисел
int M = Convert.ToInt32(Console.ReadLine()); // считываем количество цифр которые хочет ввести пользыватель (размерность массива)
int[] array = new int[M]; // задаем массиву размерность 
for (int i = 0; i < array.Length; i++) // ставим счетчик размерности массива от 0 и задаем ему предел , пока i меньше размера массива - будем вводить данные
    {
    Console.Write("введите число: "); // выводим на консоль просьбу ввести числа
    array[i] = Convert.ToInt32(Console.ReadLine()); // пользователь вводит данные массива
    }
for (int i = 0; i < array.Length; i++) // ставим счетчик размерности массива от 0 и задаем ему предел , пока i меньше размера массива - мы делаем сравнения элементов
    {
        if (array[i] > 0) // сравнения элементов 
        count = count+1; // в счетчик положительных чисел плюсуем если выполняется условие if (array[i] > 0)
    }
Console.WriteLine($"Количество положительных чисел в массиве : [{string.Join(", ", array)} ] -> {count}"); // выводим в консоль сам массив и посчитанные его положительные элементы