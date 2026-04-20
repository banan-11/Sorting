using Сортировка_пузырьком;

namespace Сортировка_пузырьком
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[] { 1,6,8,2,8,4,5,3,0,9 };

            var sort1 = new sort_bubbl();
            sort1.SortBubble(x);

            Console.WriteLine("итог");

            foreach (int n in x)
            {

                Console.WriteLine(n + " ");
            }


        }
    }
}
