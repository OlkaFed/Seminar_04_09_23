//Напишите программу, которая принимает на вход пятизначное число и проверяет является ли оно палиндромом
//14212->нет
//23432->да
//12821->да

Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine();
int dlina = num.Length;

if (dlina == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"{num} - Это палиндром");
    }
    else
    {
        Console.WriteLine($"{num} - Это не палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {num} - не является пятизначным числом по условию");
}
