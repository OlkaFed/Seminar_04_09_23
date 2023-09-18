/*Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10*/

int take()
{
                  Console.WriteLine("Enter number");
                  int number = Convert.ToInt32(Console.ReadLine());
                  return number;
}
int[] Convertation(int number)
{
                  int[] array = new int[32];
                  for (int i = 0; number > 0; i++)
                  {
                                    array[array.Length - 1 - i] = number % 2;
                                    number /= 2;
                  }
                  return array;
}
Console.WriteLine();
int number = take();
string print = string.Join(", ", Convertation(number));
Console.WriteLine(print);