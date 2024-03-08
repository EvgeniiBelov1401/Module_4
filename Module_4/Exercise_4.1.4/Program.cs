namespace Exercise_4._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1;
            string line2;
            bool isLine1eqLine2;

            Console.Write("Введите строку №1: ");
            line1 = Console.ReadLine();
            Console.Write("Введите строку №1: ");
            line2 = Console.ReadLine();

            isLine1eqLine2 = line1==line2;

            Console.WriteLine($"Строка1 и Строка2 равны? - {isLine1eqLine2}");
            Console.ReadKey();
        }
    }
}
