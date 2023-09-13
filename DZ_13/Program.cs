// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int Prompt(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите число: "); 
int fnumber(int number)
{
    while(number>999)
    {
        number /=10;
    }
    return number%10;
}
bool check(int number)
{
    if(number<100) 
    return false;
    else return true; 
}
if(check(number) != true)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine($"Третья цифра числа {fnumber(number)}");
}