namespace Exercise_4._3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array= new[] {1,-1,2,-2,3,-3,4,-4,5,-5,6,-6,7,8,9,10,-10,11,0,12};
            var CounterPositiveNum = 0;

            foreach(var item in array)
            {
                if (item > 0)
                {
                    CounterPositiveNum++;
                }
            }
            Console.WriteLine($"Кол-во положительных чисел = {CounterPositiveNum}");
        }
    }
}
