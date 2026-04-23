using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    internal class Sort_select
    {

        public void SortChoice(int[] num)
        {

            // тут цикл 2 цикла, внешний цикл проходит весь массив, внутренний ищет минимальное значение 
            for (int i = 0; i < num.Length - 1; i++)
            {
                //временная переменная с минимальный числом для того, что бы внутренний цикл мог сравнивать min_index с дргуими числами
                int min_index = i;

                for (int j = i + 1; j < num.Length; j++)
                {
                    //обновляет индекс минимального числа если в массиве num[j] число будет меньше
                    if (num[j] < num[min_index])
                    {

                        min_index = j;
                    }
                }

                //тут если самый маленький элемент изменился, то число меняется меситами, а если число не изменилось, значит число и так на своем месте и менять ниче не нужно
                if (min_index != i)
                {
                    int save = num[i];
                    num[i] = num[min_index];
                    num[min_index] = save;

                }

            }



        }
    }
}
