﻿// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();

Console.Write("Координату x первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату z певрой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Координату x второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координату z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));
