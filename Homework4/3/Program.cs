﻿// Петя впервые пришел на урок физкультуры в новой школе. Перед началом урока ученики выстраиваются по росту, в порядке невозрастания.
// Напишите программу, которая определит на какое место в шеренге Пете нужно встать, чтобы не нарушить традицию,
// если заранее известен рост каждого ученика и эти данные уже расположены по невозрастанию (то есть каждое следующее число не больше предыдущего).
// Если в классе есть несколько учеников с таким же ростом, как у Пети, то программа должна расположить его после них.

// Первая строка входного файла INPUT.TXT содержит натуральное число N (N ≤ 100) – количество учеников (не считая Петю). 
// Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах в порядке невозрастания. 
// Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.
Console.Clear();
int mesto = 0;
Console.Write("Введите количество учеников в классе попимо Пети: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    {
    Console.Write("Введите росты учеников в классе попимо Пети, в порядке убывания: ");
    array[i] = Convert.ToInt32(Console.ReadLine()); // [150, 200]
    }
Console.Write("Введите рост Пети: ");
int rost = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Класс полкчился : [{string.Join(", ", array)} и рост пети {rost}], каким же встанет петя?");
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= rost)
        mesto = i+1;
    }
mesto = mesto +1;
Console.WriteLine($"Петя встанет на место под номером {mesto}");
