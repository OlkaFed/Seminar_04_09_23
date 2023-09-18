/* Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

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

void ReverceArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i]; 
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] arr = GetArray(5, 0, 123);
Print(arr); 
Console.WriteLine();
ReverceArray(arr);
Print(arr);