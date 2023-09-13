// Напишите программу, которая по заданному номеру четверти 
//показывает диапазон возможных координат точек в этой четверти (X и Y).

int GetInter()
{
    System.Console.WriteLine($"Введите четверть : ");
    int quart = Convert.ToInt32(Console.ReadLine());
    return quart;
}

void Show(int quart)
{
    if(quart ==1)
    {
        System.Console.WriteLine("x>0, y>0");
    }
    else if(quart == 2)
    {
        System.Console.WriteLine("x<0, y>0");
    }
    else if(quart == 3)
    {
        System.Console.WriteLine("x<0, y<0");
    }
    else if(quart == 4)
    {
        System.Console.WriteLine("x>0, y<0");
    }
    else 
    System.Console.WriteLine("Некорректный ввод, такой четверти нет");
}


int quart = GetInter();
Show(quart);