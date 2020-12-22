using System;

namespace Module4
{
    class MainClass
    {
        public static void Main(string[] args)

        {
            
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] FavColors) User;
            for (int k = 0; k < 3; k++)
            {
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин: ");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Введите Да или Нет: ");

            var result = Console.ReadLine();

            if (result == "Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }

            Console.WriteLine("Введите ваш возраст: ");
            User.Age = double.Parse(Console.ReadLine());

            User.FavColors = new string[3];
            Console.WriteLine("Введите три ваших любимых цвета: ");

            for (int i = 0; i < User.FavColors.Length; i++)
            {
                    User.FavColors[i] = Console.ReadLine();
            }
            }
        }

        /*static int[] GetArrayFromConsole()
            {
                var result = new int[5];
                var value = GetArrayFromConsole();

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                    result[i] = int.Parse(Console.ReadLine());
                }

                int temp = 0;
                for (int i = 0; i < result.Length; i++)
                    for (int j = i + 1; j < result.Length; j++)
                        if (result[i] < result[j])
                        {
                            temp = result[i];
                            result[i] = result[j];
                            result[j] = temp;
                        }

                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine(result[i]);
                }

                return result;
            }*/

        /*
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch(color)
        {
            case "red":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is red!");
                break;

            case "green":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is green!");
                break;

            case "cyan":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Your color is cyan!");
                break;

            default:
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Your color is yellow!");
                break;
        }
        */
    }
}


