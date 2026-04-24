using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Sort_select : InSorter
    {

        public void Sort<T>(T[] num) where T : IComparable<T>
        {

            // тут цикл 2 цикла, внешний цикл проходит весь массив, внутренний ищет минимальное значение 
            for (int i = 0; i < num.Length - 1; i++)
            {
                //временная переменная с минимальный числом для того, что бы внутренний цикл мог сравнивать min_index с дргуими числами
                int min_index = i;

                for (int j = i + 1; j < num.Length; j++)
                {
                    //обновляет индекс минимального числа если в массиве num[j] число будет меньше
                    if (num[j].CompareTo(num[min_index]) < 0)
                    {
                        min_index = j;
                    }
                }

                //тут если самый маленький элемент изменился, то число меняется меситами, а если число не изменилось, значит число и так на своем месте и менять ниче не нужно
                if (min_index != i)
                {
                    var save = num[i];
                    num[i] = num[min_index];
                    num[min_index] = save;

                }

            }

        }

        public void Sort<T>(T[] num, string message) where T : IComparable<T>
        {
            Sort(num);
            Console.WriteLine(message);

            foreach (var n in num)
            {

                Console.Write(n + " ");
            }
            Console.WriteLine();


        }

    }
}
