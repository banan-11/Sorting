using Sort_bubbl;

namespace Sort_bubbl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 1, 6, 8, 2, 8, 4, 5, 3, 0, 9 };

            var sort1 = new Sort_bubbl();
            sort1.SortBubble(x);

            Console.WriteLine("итог");

            foreach (int n in x)
            {

                Console.WriteLine(n + " ");
            }
        }
    }
}
