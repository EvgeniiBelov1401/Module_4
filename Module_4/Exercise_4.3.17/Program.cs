namespace Exercise_4._3._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,]array = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            var temp = 0;

            Console.WriteLine("Текущий массив:");
            for (int i=0;i<array.GetLength(0);i++)
            {
                for (int j=0;j<array.GetLength(1);j++)
                {
                    Console.Write($"{array[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = j + 1; k < array.GetLength(1); k++)
                    {
                        if (array[i, j] > array[i, k])
                        {
                            temp = array[i, j];
                            array[i, j] = array[i, k];
                            array[i, k] = temp;
                        }
                        
                    }
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
