//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

using System;
using static System.Console;

Clear();

WriteLine("Введите координаты первой точки: ");
int x1 = int.Parse(ReadLine());
int y1 = int.Parse(ReadLine());
int z1 = int.Parse(ReadLine());

WriteLine("Введите координаты второй точки: ");
int x2 = int.Parse(ReadLine());
int y2 = int.Parse(ReadLine());
int z2 = int.Parse(ReadLine());

int sqrX=(x2-x1)*(x2-x1);
int sqrY=(y2-y1)*(y2-y1);
int sqrZ=(z2-z1)*(z2-z1);


WriteLine($"Расстояние между точками в 3D будет -> {Math.Sqrt(sqrX+sqrY+sqrZ).ToString("F" + 2)}");