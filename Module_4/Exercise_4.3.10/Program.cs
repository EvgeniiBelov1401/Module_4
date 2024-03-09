namespace Exercise_4._3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1,2,3},{5,6,7 } };
            Console.WriteLine(array.Length);
            Console.WriteLine($"Кол-во строк: { array.GetUpperBound(0)+1}");
            Console.WriteLine($"Кол-во колонок: {array.GetUpperBound(1) + 1}");
        }
    }
}
