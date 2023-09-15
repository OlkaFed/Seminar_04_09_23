// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNumber(string message) //Метод указания пользователем размерности массива
{
Console.Write($"Введите размер массива {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
} 

void GetArrayRandomNumbers(double[] numbers) //Формирует массив вещественных чисел 
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void GetPrintArray(double[] numbers) //Метод вывода массива
{
    Console.Write(" Массив: \n [ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}

//double min = Int32.MaxValue; //Работает без методов
//double max = Int32.MinValue;
//for (int z = 0; z < numbers.Length; z++)
//{    if (numbers[z] > max)
//        {max = numbers[z];}
//    if (numbers[z] < min)
//        {min = numbers[z];}}

double GetPosMin(double[] numbers)
{
    double min = numbers[0];
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] < min)
        {
            min = numbers[z];
        }
    } 
    return min;
}

double GetPosMax(double[] numbers)
{
    double max = numbers[0];
    for (int z = 0; z < numbers.Length; z++)
    {
        if (numbers[z] > max)
        {
            max = numbers[z];
        }
    } 
    return max;
}

int size = GetNumber(" ");
double[] numbers = new double[size];
GetArrayRandomNumbers(numbers);
GetPrintArray(numbers);
double MIN = GetPosMin(numbers);
double MAX = GetPosMax(numbers);
double REZ = Math.Round(MAX-MIN,2);

Console.WriteLine($"\n Всего {numbers.Length} чисел. " 
+ $"\n Максимальное значение = {MAX}, минимальное значение = {MIN}"
+ $"\n Разница между максимальным и минимальным значением = {REZ}");
