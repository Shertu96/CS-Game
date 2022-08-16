// Выбор расы, класса, пола персонажа

class Program
{
    static void SelectRase()
    {
        string[] namesRase = {"Люди", "Эльфы", "Гномы", "Гоблины"};
        for (int i = 0; i < namesRase.Length - 1; i++) 
        {
            Console.Write(i + 1 + " - " + namesRase[i] + ", "); 
        }
        Console.Write(namesRase.Length + " - " + namesRase[namesRase.Length - 1] + ". ");
        Console.WriteLine("Укажите Вашу расу:");
        int numberRase = Convert.ToInt32(Console.ReadLine()); // Пользователь введёт номер расы
        Console.WriteLine("Ваша раса: " + namesRase[numberRase - 1]);
    
    }

 static void SelectClass()
    {
        string[] namesClass = {"Маг", "Оборотень", "Воин", "Вор"};
        static void WriteChoice(string[] args) // Через функцию вместо цикла for, но что-то случилось с использованием

        {
            for(int i = 0; i < args.Length - 1; i++)
            {
                Console.WriteLine(i + 1 + " - " + args[i] + ", ");
            
            }
            Console.WriteLine(args.Length + " - " + args[args.Length - 1] + ". ");
        }
        Console.WriteLine("Укажите Ваш класс:");
        int numberClass = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Ваш класс: " + namesClass[numberClass - 1]);
    
    }

     static void SelectSex()
    {
        string[] namesSex = {"Женский", "Мужской"};
        for (int i = 0; i < namesSex.Length - 1; i++) 
        {
            Console.Write(i + 1 + " - " + namesSex[i] + ", "); 
        }
        Console.Write(namesSex.Length + " - " + namesSex[namesSex.Length - 1] + ". ");
        Console.WriteLine("Укажите Ваш пол:");
        int numberSex = Convert.ToInt32(Console.ReadLine()); 
        Console.WriteLine("Ваш пол: " + namesSex[numberSex - 1]);
    
    }

    static void Main(string[] args)
    {
        SelectRase();
        SelectClass();
        SelectSex();
    }
}
