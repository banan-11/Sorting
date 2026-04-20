using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_bubbl
{
    public class Sort_bubbl
    {
        public void SortBubble<T>(T[] x) where T : IComparable<T>
        {

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x.Length - i - 1; j++)
                {
                    if (x[j].CompareTo(x[j + 1]) > 0)
                    {

                        T save = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = save;


                    }
                }
            }
        }



    }
}
