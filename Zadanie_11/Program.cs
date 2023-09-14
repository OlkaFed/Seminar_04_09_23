// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
//7->28
//4->10
//8->36 

int GetNumber(string message)
{
    System.Console.Write($"Введите число {message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

//Опишем метод, который будет суммировать элементы
int GetSum(int num)
{
    int sum=0;
    for(int i=1; i<=num; i++)
    {
        sum += i;
    }
    return(sum);
}

int numA = GetNumber("A = ");
int sum = GetSum(numA);
Console.WriteLine($"sum = {sum}");
