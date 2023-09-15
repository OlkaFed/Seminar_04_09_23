//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetNumber(string message)
{
    System.Console.Write($"Введите число {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numA = GetNumber("A = ");
int numB = GetNumber("B = "); 

double sqr = Math.Pow(numA, numB); //Возведение в степень 

Console.WriteLine($"Результат возведения числа А в степень В = {sqr}");