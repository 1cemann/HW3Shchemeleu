//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


using System;
using static System.Console;

Clear();

Write("Введите пятизначное число: ");
int number = int.Parse(ReadLine());
int a = number;
int b = 0;

while (number != 0)
    {
        b = b * 10 + number % 10;
        number /= 10;
    }
if (a == b)
    Write($"Число {a} палиндром");
else
    Write($"Число {a} не палиндром");