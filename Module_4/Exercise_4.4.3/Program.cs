namespace Exercise_4._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var anketa=("Евгений",34);
            Console.WriteLine($"Ваше имя: {anketa.Item1}\nВаш возраст: {anketa.Item2}");
            Console.ReadKey();
            Console.WriteLine();

            Console.Write("Введите ваше имя: ");
            anketa.Item1 = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            anketa.Item2=int.Parse(Console.ReadLine());
            Console.WriteLine($"\nВаше имя: {anketa.Item1}\nВаш возраст: {anketa.Item2}");
            Console.ReadKey();
        }
    }
}
