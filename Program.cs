﻿Console.Clear();


Ex34();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Ex34()
{
    int size = 10;
    int[] numbers = new int[size];

    LibraryHelp.Methods.FillArray(numbers, 100, 999);
    LibraryHelp.Methods.PrintArray(numbers);

    Console.WriteLine("Количество чётных чисел в массиве = " + GetQuantityEvenNum(numbers));

    int GetQuantityEvenNum(int[] num)
    {
        int quantity = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] % 2 == 0)
            {
                quantity++;
            }
        }
        return quantity;
    }
}





// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,21 7,04 22,93 -2,71 78,24] -> 75,53


