//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2Д пространстве
//А(3,6) В(2,1) => 5,09 
//А(7,-5) В(1,-1) => 7,21 

int GetNumber(string message)
{
    System.Console.Write($"Введите число {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numX1 = GetNumber("X1= ");
int numY1 = GetNumber("Y1= "); 
int numX2 = GetNumber("X2= ");
int numY2 = GetNumber("Y2= ");

double numX = Math.Pow((numX2 - numX1), 2); //Возведение в квадрат
double numY = Math.Pow((numY2 - numY1), 2); 

double result = Math.Sqrt(numX + numY); //корень от числа 

System.Console.WriteLine($"Расстояние между точками = {Math.Round(result,2)}"); //Количество знаков после запятой 