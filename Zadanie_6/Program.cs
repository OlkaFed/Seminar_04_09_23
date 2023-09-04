// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("ВВедите трехзначное число: ");
string number1 = Console.ReadLine();
int num = int.Parse(number1);

if (num<100 || num >999)
{
    System.Console.Write($"Введенное число некорректно {num}");
}
else 
{
    //int num1 = num%10; 
    //num = num-num1;
    int num2 = (num%100)/10;
    System.Console.Write($"Вторая цифра числа {num2}");
}