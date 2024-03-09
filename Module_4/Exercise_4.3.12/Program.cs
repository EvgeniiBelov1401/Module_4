namespace Exercise_4._3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr=new int[] { 5,6,9,1,2,3,4 };
            int Value;

            Console.WriteLine("Текущий массив:");
            for (int i=0; i<arr.Length;i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.ReadKey();
            Console.Clear();
            
            for (int i=0;i<arr.Length;i++)
            {
                for (int k=i+1;k<arr.Length;k++)
                {
                    if (arr[i] > arr[k])
                    {
                        Value = arr[i];
                        arr[i] = arr[k];
                        arr[k] = Value;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив:");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
