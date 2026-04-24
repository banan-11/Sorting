using Sorting;

namespace Sorting
{
    internal class Program
    {
        static void showmenu()
        {
            Console.WriteLine("Выберите алгоритм сортировки");
            Console.WriteLine("0 - Выход");
            Console.WriteLine("1 - Пузырьком");
            Console.WriteLine("2 - Выборкой");
            Console.Write("ваш выбор: ");

        }
     
        //Создал одномерный массив 
        static int[] num = new int[] { 3, 4, 2, 1, 5, 8, 10, 6 };

        static void Main(string[] args)
        {
            showmenu();
            byte choice = byte.Parse(Console.ReadLine());

            InSorter sorter = null;

            switch (choice)
            {

                case 0:

                    Console.WriteLine("Пока :(");
                    Console.ReadLine();
                    return;

                // в кейсах записываются пути в sorter
                case 1:
                    sorter = new Sort_bubbl(); 

                    break;


                case 2:
                    sorter = new Sort_select();

                    break;

            }

            //если sorter поменялась и теперь не ровна null то выводится итог
            if (sorter != null)
            {

                sorter.Sort(num, "Итог:");

            }

            else
            {
                Console.WriteLine("не та цифра");

            }

        }
    }
}