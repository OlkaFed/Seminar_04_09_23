﻿//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
//[3, 7, 23, 12] => 19
//[-4, -6, 89, 6] => 0

int GetNumber(string message) //Метод указания пользователем размерности массива
{
Console.Write($"Введите размер массива {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
} 

void GetArrayRandomNumbers(int[] numbers) //Метод формирования массива случайных чисел
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
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

int GetSumNechetIndex(int[] numbers) //Метод подсчета суммы чисел стоящих на нечетных ячейках в массиве
{
    int sum = 0;
    for (int z = 1; z < numbers.Length; z+=2)
    {
        sum+=numbers[z];
    }
    return sum;
}

int size = GetNumber(" ");
int[] numbers = new int[size];
GetArrayRandomNumbers(numbers);
GetPrintArray(numbers);
Console.WriteLine($"\n всего {numbers.Length} чисел, сумма элементов cтоящих на нечётных позициях = {GetSumNechetIndex(numbers)} \n");


