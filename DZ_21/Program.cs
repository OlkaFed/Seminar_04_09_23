//Задача 21: Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

int GetNumber(string message)
{
    System.Console.Write($"Введите число {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numX1 = GetNumber("X1= ");
int numY1 = GetNumber("Y1= "); 
int numZ1 = GetNumber("Z1= ");
int numX2 = GetNumber("X2= ");
int numY2 = GetNumber("Y2= ");
int numZ2 = GetNumber("Z2= "); 

double numX = Math.Pow((numX2 - numX1), 2); //Возведение в квадрат
double numY = Math.Pow((numY2 - numY1), 2); 
double numZ = Math.Pow((numZ2 - numZ1), 2);

double result = Math.Sqrt(numX + numY + numZ); //корень от числа 

System.Console.WriteLine($"Расстояние между точками = {Math.Round(result, 2)}"); //Количество знаков после запятой 
