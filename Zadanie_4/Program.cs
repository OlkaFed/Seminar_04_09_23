﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
//7 и 23.

//14 -> нет 
//46 -> нет 
//161 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

int num7 = num % 7;
int num23 = num % 23; 

//if (num1 % 7 == 0 && num1 % 23 == 0) Можно вот так условие прописать
if (num7 == 0 && num23 == 0) 
{
    System.Console.WriteLine("да");
}
else 
{
    System.Console.WriteLine("нет");
}