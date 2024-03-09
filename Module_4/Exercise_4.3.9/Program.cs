namespace Exercise_4._3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { {1,2,3},{5,6,7} };
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
