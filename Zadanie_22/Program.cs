/*Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/

int GetNumber(string message)
{
    Console.Write($"Введите значение {message}:");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int n = GetNumber("n");
int n1 = 0;
int n2 = 1;
 Console.WriteLine(n1);
Console.WriteLine(n2);
int next = 0;
for (int i = 2; i < n; i++)
{
    next = n1 + n2;
    Console.WriteLine(next);
    n1 = n2;
    n2 = next;
}
