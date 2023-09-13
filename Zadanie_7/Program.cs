// Напишите программу, которая принимает на ввод координаты точки (X и Y), 
//причем X не = 0 и Y не = 0 и выдает номер четверти плоскости, в которой находится эта точка. 

int GetNumber(string message)
{
    System.Console.WriteLine($"Enter number {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Show(int x, int y)
{
    if(x>0 && y>0)
    {
        System.Console.WriteLine("Первая четверть");
    }
    else if(x<0 && y>0)
    {
        System.Console.WriteLine("Вторая четверть");
    }
    else if(x<0 && y<0)
    {
        System.Console.WriteLine("Третья четверть");
    }
    else if(x>0 && y<0)
    {
        System.Console.WriteLine("Четвертая четверть");
    }
    else if (x==0 || y==0)
    System.Console.WriteLine("X или Y равен 0, что противоречит условиям ");
}

int numX = GetNumber("X= ");
int numY = GetNumber("Y= "); 

Show(numX, numY);
