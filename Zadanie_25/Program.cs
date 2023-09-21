/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

int[,] GetMatrix(int rows, int columns, int min = 0, int max = 9) 
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random(); 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

int SetNumber(string message)
{
    Console.Write($"Введите количество {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
} 

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]} ");
        }
        Console.WriteLine();
    }
}

void GetMatrixSqr(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if ((i % 2 == 0) && (l % 2 == 0)) matrix[i,l] *= matrix[i,l];
        }
    }
}

int rows = SetNumber("строк "); 
int columns = SetNumber(" столбцов ");
int[,] result = GetMatrix(rows, columns);
PrintMatrix(result);
Console.WriteLine();
GetMatrixSqr(result);
PrintMatrix(result);


