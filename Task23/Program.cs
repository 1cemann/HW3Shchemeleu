//Задача 23: Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


using System;
using static System.Console;

Clear();

WriteLine("Введите число N: ");
int N = Convert.ToInt32(ReadLine());
int count = 1;

while(count<N)
{
    Write($"{Math.Pow(count,3)}, " );
    count++;
}
Write($"{Math.Pow(count,3)}." );