using System;

class Program
{
    static void Main(string[] args)
    {
        Screen(EnterUser());
    }
    static (string Name, string LastName, bool HasPet, int PetNum, string[] PetNames, int Age, string[] FavColors, int ColNum) EnterUser()

    {

        (string Name, string LastName, bool HasPet, int PetNum, string[] PetNames, int Age, string[] FavColors, int ColNum) User;


        Console.WriteLine("Введите имя: ");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите фамилию: ");
        User.LastName = Console.ReadLine();

        string age;
        int intage;
        do
        {
            Console.WriteLine("Введите ваш возраст цифрами: ");
            age = Console.ReadLine();
        }
        while (CheckNum(age, out intage));

        User.Age = intage;

        Console.WriteLine("Есть ли у вас животные? Введите да или нет: ");
        var result = Console.ReadLine();

        if (result == "да")
        {
            User.HasPet = true;

            do
            {
                Console.WriteLine("Сколько у вас питомцев?");
                result = Console.ReadLine();
            }
            while (CheckNum(result, out User.PetNum));

            User.PetNames = new string[User.PetNum];
            Console.WriteLine("Введите клички ваших питомцев: ");
            for (int i = 0; i < User.PetNames.Length; i++)
            {
                User.PetNames[i] = Console.ReadLine();
            }
        }
        else
        {
            User.HasPet = false;
            User.PetNum = 0;
            User.PetNames = new string[User.PetNum];
        }

        do
        {
            Console.WriteLine("Сколько у вас любимых цветов?");
            result = Console.ReadLine();
        }
        while (CheckNum(result, out User.ColNum));

        User.FavColors = new string[User.ColNum];

        Console.WriteLine("Введите ваши любимые цвета: ");

        for (int i = 0; i < User.FavColors.Length; i++)
        {
            User.FavColors[i] = Console.ReadLine();
        }
        return User;
    }

    static bool CheckNum(string strnum, out int intnum)
    {
        if (int.TryParse(strnum, out intnum))
        {
            if (intnum > 0)
            {
                return false;
            }
        }
            intnum = 0;
            return true;
        }
        static void Screen((string Name, string LastName, bool HasPet, int PetNum, string[] PetNames, int Age, string[] FavColors, int ColNum) User)
        {
            Console.WriteLine("Ваше имя: {0}", User.Name);
            Console.WriteLine("Ваша фамилия: {0}", User.LastName);
            Console.WriteLine("Ваш возраст: {0}", User.Age);
        if (User.PetNum > 0)
        {
            Console.WriteLine("У вас {0} питомцев", User.PetNum);
            Console.WriteLine("Ваши питомцы: ");
            for (int i = 0; i < User.PetNum; i++)
            {
                Console.WriteLine(User.PetNames[i]);
            }
        }
        else
            Console.WriteLine("У вас нет питомцев");

            Console.WriteLine("Количество ваших любимых цветов: {0}", User.ColNum);
            Console.WriteLine("Ваши любимые цвета: ");
            for (int i = 0; i < User.ColNum; i++)
            {
                Console.WriteLine(User.FavColors[i]);
            }

    }
    }

            /*
                           Console.WriteLine("Введите логин: ");
                           User.Login = Console.ReadLine();
                           User.LoginLength = User.Login.Length;


              static int[] GetArrayFromConsole()
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



