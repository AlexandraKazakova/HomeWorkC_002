﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число -> ");
int number = int.Parse(Console.ReadLine());
int n = number / 10;
int a = n % 10;
Console.WriteLine(a);