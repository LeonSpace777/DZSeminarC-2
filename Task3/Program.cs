﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5)
{
    System.Console.WriteLine("День не является выходным");
}

else if (num >=6 && num <= 7)
{
    System.Console.WriteLine("Выходной день");
}
else
{
    System.Console.WriteLine("Такого дня не существует");
}