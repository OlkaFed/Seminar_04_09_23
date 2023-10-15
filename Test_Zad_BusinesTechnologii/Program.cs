/*Тестовое задание на вакансию Младший разработчик в компанию Бизнес технологии*/ 

/* 1/ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        // Сортировка вставками
        static void Main(string[] args)
        {

            int[] a = { 7, 0, -4, 3, 1, -2, 5 };

            for(int i=1; i < a.Length; i++)
            {
                int k = a[i];
                int j = i - 1;

                while(j>=0 && a[j] > k)
                {
                    a[j + 1] = a[j];
                    a[j] = k;
                    j--;
                }
            }
            
            // Распечатываем массив.
            Console.WriteLine("Сортировка вставками");
            for(int i=0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }

            Console.ReadKey();

        }
    }
}
*/

/*2. */

using System;
using System.Linq;
using System.Collections.Generic;
 
public class Example
{
    public static void Main()
    {
        List<int> values = new List<int>() { 2, 3, 4, 5 };
        int item = 1;
 
        values = values.Prepend(item).ToList();
 
        Console.WriteLine(String.Join(", ", values));        // 1, 2, 3, 4, 5
    }
}