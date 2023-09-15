//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetNumber(string message) //Метод ввода числа
{
    System.Console.Write($"Введите число {message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetKolvo(int a) //Метод, который считает количество цифр в числе
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void GetSum(int n, int kolvo) // Метод подсчета суммы цифр в числе
{
    int result = 0;
    for (int i = 1; i <= kolvo; i++)
    {
        result += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр в числе = {result}"); 
}

int num = GetNumber(": ");
int kolvo = GetKolvo(num);
GetSum(num, kolvo); 