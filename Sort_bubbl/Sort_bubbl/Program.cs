namespace Sort_bubbl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создал одномерный массив 
            int[] x = new int[] { 1, 6, 8, 2, 8, 4, 5, 3, 0, 9 };

            //тут сделал обьект класса Sort_bubbl и назвал его sort1, дальше снизу отправил массив x[] в метод SortBubble() находящийся в классе Sort_bubbl
            var sort1 = new Sort_bubbl();
            sort1.SortBubble(x);

            //Вывел итог сортировки через цикл foreach
            Console.WriteLine("итог:");

            foreach (int n in x)
            {

                Console.WriteLine(n + " ");
            }
        }
    }
}
