﻿/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int Prompt(string message)
{
    System.Console.Write($"{message}: ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int number = Prompt("Введите число >");

