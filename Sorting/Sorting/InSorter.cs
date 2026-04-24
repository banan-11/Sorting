using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public interface InSorter
    {
        //если отправиляю только массив, то выбирает этот метод
        void Sort<T>(T[] num) where T : IComparable<T>;

        //если массив и текст, то этот 
        void Sort<T>(T[] num, string message) where T : IComparable<T>;


    }
}
