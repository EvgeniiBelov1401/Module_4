using System.Reflection.Metadata;

namespace Exercise_4._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name,string LastName, string Login, int LoginLength, bool HasPet, string[]favcolors, double Age)User;
            string pet;
            User.favcolors=new string[3];

            Console.Write("Введите Ваше имя: ");
            User.Name = Console.ReadLine();
            
            Console.Write("Введите Вашу фамилию: ");
            User.LastName = Console.ReadLine();
            
            Console.Write("Введите Ваш возраст: ");
            User.Age=double.Parse(Console.ReadLine());
            
            Console.Write("Введите Ваш Логин: ");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;
            
            Console.Write("Если есть домашнее животное, введите \"да\": ");
            pet = Console.ReadLine();
            if (pet == "да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet= false;
            }
            
            Console.WriteLine("Введите 3 любимых цвета: ");
            for (int i=0;i<User.favcolors.Length;i++)
            {
                Console.Write($"Цвет №{i + 1}: ");
                User.favcolors[i] = Console.ReadLine();
            }
            Console.ReadKey();
            Console.WriteLine("\n******** Показать всю информацию о пользователе ********\n");
            Console.ReadKey();
            Console.WriteLine($"Пользователь: {User.LastName} {User.Name}\n" +
                $"Возраст: {User.Age}\nЛогин: {User.Login}\t({User.LoginLength} символов)\n" +
                $"Домашнее животное: {User.HasPet}\nЛюбимые цвета: ");
            for(int i = 0; i < User.favcolors.Length; i++)
            {
                Console.Write($"{User.favcolors[i]} ");
            }
            Console.ReadKey();
        }
    }
}
