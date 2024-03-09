namespace Exercise_4._3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваше имя по буквам: ");
            foreach (var ch in name)
            {
                Console.Write($"{ch} ");    
            }
            Console.WriteLine($"\nПоследняя буква: {name[name.Length-1]}") ;
            Console.ReadKey();
        }
    }
}
