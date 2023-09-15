//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да


int GetNumber(string message)
{
Console.Write($"Введите число {message}: ");
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int[] GetArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Print(int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetIndexSeach(int[]array, int number)
{
    for (int index = 0; index < array.Length; index++)
    {
        if(array[index] == number) 
        //Если нужно проверять только модуль числа, то условие: if(array[index] == number || array[index] == -number)
        {
            return index;
        }
    }
    return -1; //Если не нашел индекса, то ставит -1
}

int[] ar = GetArray(8, -9, 9);
Print(ar);
int num = GetNumber(" ");
int numIndex = GetIndexSeach(ar,num); 
if(numIndex == -1)
{
    Console.WriteLine($"Число {num} не найдено в массиве");
}
else Console.WriteLine($"Индекс числа {num} равен {numIndex}");