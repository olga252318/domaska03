﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] arrNum = ArrayRand();
Console.WriteLine();
printArr(arrNum);
Console.WriteLine();

int[] ArrayRand()
{
    int[] digit = new int[8];
for (int i = 0; i < 8; i++)
{
    digit[i] = new Random().Next();   
}
return digit;
}

void printArr(int []arr)
{
    for (int i = 0; i < 8; i++)
{
    Console.Write($"{arr[i]} ");    
}
}
