namespace Exercise_4._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, int age) anketa;

            Console.Write("Ваше имя:");
            anketa.name = Console.ReadLine();
            Console.Write("Ваш возраст:");
            anketa.age=int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"Ваше имя: {anketa.name}\nВаш возраст: {anketa.age}");
        }
    }
}
