// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 1 до N. 
//5=> 1, 4, 9, 16, 25
//2=> 1, 4

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
    System.Console.Write($"{num02*num02}, ");
    num02++;
}