namespace Exercise_4._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            double X;
            double Y;
            bool isAlessBorXmoreY;

            Console.Write("Введите значение A: ");
            A=int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            B = int.Parse(Console.ReadLine());
            Console.Write("Введите значение X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            Y = double.Parse(Console.ReadLine());

            isAlessBorXmoreY = A < B | X > Y;

            Console.WriteLine($"A < B или X > Y - {isAlessBorXmoreY}");
            Console.ReadKey();
        }
    }
}
