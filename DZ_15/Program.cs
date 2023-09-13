// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int Prompt(string msg)
{
    Console.WriteLine(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите число: "); 
string ss = "Это не день недели"; 
string check(int number)
{
    if((number>=6) && (number<8))
    ss = "Это выходной";
    if((number>=1)&&(number<6))
    ss = "Это будний день";
    return ss;
}
System.Console.WriteLine(check(number));