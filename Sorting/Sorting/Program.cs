using Sorting;

namespace Sort_bubbl
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
        // Вывод массива отдельным методом и вывел их дург за другом
        static void printmass()
        {
            foreach (int n in num)
            {

                Console.Write(n + " ");
            }
            Console.WriteLine();


        }

        //Создал одномерный массив 
        static int[] num = new int[] { 3, 4, 2, 1, 5, 8, 10, 6 };

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
                    Console.Write("До сортировки пузырьком:  ");
                    printmass();
                    // сделал обьект класса Sort_bubbl и назвал его sortb1, дальше снизу отправил массив x[] в метод SortBubble() 
                    var sortb1 = new Sort_bubbl();
                    sortb1.SortBubble(num);

                    Console.Write("После сортировки пузырьком:  ");
                    printmass();

                    break;


                case 2:
                    Console.Write("До сортировки выборкой:  ");
                    printmass();
                    // сделал обьект класса Sort_select и назвал его sorts1, дальше снизу отправил массив num[] в метод SortChoice() 
                    var sorts1 = new Sort_select();
                    sorts1.SortChoice(num);

                    Console.Write("После сортировки выборкой:  ");
                    printmass();

                    break;



            }

        }
    }
}