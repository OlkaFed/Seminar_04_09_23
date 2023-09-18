/*Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.*/

int GetNumber(string message)
{
Console.Write($"Введите число {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

bool GetStorTreyg(int a1, int a2, int a3)
{
    return (a1<a2+a3) && (a2<a1+a3) && (a3<a1+a2);    
}

int num1 = GetNumber(" первое ");
int num2 = GetNumber(" второе ");
int num3 = GetNumber(" третье"); 
if (GetStorTreyg(num1, num2, num3))
{
    Console.WriteLine("Треугольник с такими сторонами может существовать ");
}
else 
{ 
    Console.WriteLine("Такого треугольника не существует");
}

