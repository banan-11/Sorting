using System;
using System.Collections.Generic;
using System.Text;

namespace Sort_bubbl
{
    public class Sort_bubbl
    {
        //Создал публичный метод SortBubble с generics работающий с любыми данными T
        //where T : IComparable<T> ограничение которое разрешает использовать метод CompareTo
        public void SortBubble<T>(T[] num) where T : IComparable<T>
        {
            //Создал 2 цикла, внешний цикл проходит весь массив, а внутренний сравнивает соседние числа 
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length - i - 1; j++)
                {
                    //Тут если CompareTo вернет 1, то выполнится код внутри if и данные поменяются местами,если CompareTo вернет 0, то ниче не выполниться и цикл пойдет дальше
                    if (num[j].CompareTo(num[j + 1]) > 0)
                    {

                        T save = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = save;


                    }
                }
            }
        }



    }
}
