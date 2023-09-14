//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int GetNumber(string message)
{
    System.Console.Write($"Введите число {message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num01 = GetNumber(" = "); 
int num02 = 1; 

while(num02<=num01)
{
    System.Console.Write($"{num02*num02*num02}, ");
    num02++;
}