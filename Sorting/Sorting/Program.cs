using Sorting;
using System.Collections;

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

        static void Print(int[] num, string[] stringMass, char[] charMass)
        {

            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            foreach (string i in stringMass)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

            foreach (char i in charMass)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");

        }



        //Создал одномерный массив типа int, string и char
        static int[] num = new int[] { 3, 4, 2, 1, 5, 8, 10, 6 };
        static string[] stringMass = { "что-то там", "обезьянка", "банан" };
        static char[] charMass = { 'l', 'a', 'b', 'q' };

        static void Main(string[] args)
        {
            showmenu();
            byte choice = byte.Parse(Console.ReadLine());



            switch (choice)
            {

                case 0:

                    Console.WriteLine("Пока :(");
                    Console.ReadLine();
                    return;


                case 1:
                    Console.WriteLine("Сортировка пузырем");
                    Console.WriteLine(" ");

                    Sort_bubbl sorterb = new Sort_bubbl();
                    sorterb.Sort(num);
                    sorterb.Sort(stringMass);
                    sorterb.Sort(charMass);
                    Print(num, stringMass, charMass);

                    break;


                case 2:
                    Console.WriteLine("Сортировка выборкой");
                    Console.WriteLine(" ");

                    Sort_select sorters = new Sort_select();
                    sorters.Sort(num);
                    sorters.Sort(stringMass);
                    sorters.Sort(charMass);
                    Print(num, stringMass, charMass);

                    break;

            }



        }
    }
}