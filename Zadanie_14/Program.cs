//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке 
//[1, 0, 1, 1, 0, 1, 0, 0]

int[] GetArray (int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int index = 0; index < size; index++)
    {
        array[index] = rand.Next(min, max+1); 
    }
    return array;
}

void Print(int[] arr)
{
    int length = arr.Length;
    for(int i=0; i<length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

Print(GetArray(8, 0, 1));