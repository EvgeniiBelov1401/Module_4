namespace Exercise_4._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var CounterPositiveNum = 0;


            Console.WriteLine("Текущий массив:");
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++)
                {
                    Console.Write($"{array[i,j]} ");
                    if (array[i, j] > 0)
                    {
                        CounterPositiveNum++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Кол-во положительных чисел = {CounterPositiveNum}");
            Console.ReadKey();
        }
    }
}
