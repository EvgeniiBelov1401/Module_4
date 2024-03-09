namespace Exercise_4._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            var Summ = 0;

            Console.WriteLine("Текущий массив:");
            foreach(var item in arr)
            {
                Console.Write($"{item} ");
                Summ += item;
            }

            Console.WriteLine($"\nСумма всех чисел = {Summ}");
            Console.ReadKey();
        }
    }
}
