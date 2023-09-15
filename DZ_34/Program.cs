// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2

void GetArrayRandomNumbers(int[] numbers) //Метод формирования массива случайных чисел
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void GetPrintArray(int[] numbers) //Метод вывода массива
{
    Console.Write(" Массив: \n [ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

int GetNumber(string message) //Метод указания пользователем размерности массива
{
Console.Write($"Введите размер массива {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
} 

int GetChetn(int[] numbers) //Метод подсчета количества четных чисел в массиве
{
    int count = 0;
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] % 2 == 0)
        count++;
    }
    return count;
}

int size = GetNumber(" ");
int[] numbers = new int[size];
GetArrayRandomNumbers(numbers);
GetPrintArray(numbers);
Console.WriteLine($"\n всего {numbers.Length} чисел, {GetChetn(numbers)} из них чётные \n");