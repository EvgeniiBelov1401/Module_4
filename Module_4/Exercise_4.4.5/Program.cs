namespace Exercise_4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Тип животного: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Имя животного: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Возраст животного: ");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;

            Console.WriteLine("Показать всю информацию ");
            Console.ReadKey();

            Console.WriteLine($"{Pet.Type} по имени {Pet.Name}({Pet.NameCount}), возраст: {Pet.Age}");
            Console.ReadKey();
        }
    }
}
