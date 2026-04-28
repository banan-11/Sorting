using Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class Sort_bubbl 
    {
        public void Sort(int[] num) 
        {
            //Создал 2 цикла, внешний цикл проходит весь массив, а внутренний сравнивает соседние числа 
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                    //Тут если CompareTo вернет 1, то выполнится код внутри if и данные поменяются местами,если CompareTo вернет 0, то ниче не выполниться и цикл пойдет дальше
                    if (num[j].CompareTo(num[j + 1]) > 0)
                    {

                        int save = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = save;


                    }
                }
            }
        }


        public void Sort(string[] num)
        {

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                   
                    if (num[j].CompareTo(num[j + 1]) > 0)
                    {

                        string save = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = save;


                    }
                }
            }
        }


        public void Sort(double[] num)
        {

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                    
                    if (num[j].CompareTo(num[j + 1]) > 0)
                    {

                        double save = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = save;


                    }
                }
            }
        }


        public void Sort(char[] num)
        {
            //Создал 2 цикла, внешний цикл проходит весь массив, а внутренний сравнивает соседние числа 
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                    //Тут если CompareTo вернет 1, то выполнится код внутри if и данные поменяются местами,если CompareTo вернет 0, то ниче не выполниться и цикл пойдет дальше
                    if (num[j].CompareTo(num[j + 1]) > 0)
                    {

                        char save = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = save;


                    }
                }
            }
        }





    }
}
