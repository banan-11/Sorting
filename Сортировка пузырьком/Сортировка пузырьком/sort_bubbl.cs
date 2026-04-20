using System;
using System.Collections.Generic;
using System.Text;

namespace Сортировка_пузырьком
{
    public class sort_bubbl
    {
        public void SortBubble(int[] x)
        {

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - i - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {

                        int save = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = save;


                    }
                }
            }







        }
    }
}
