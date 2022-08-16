// Используем функции выбора, метод SelectRase

class Program
{
    static void SelectRase() // Ничего не возвращает
    {
        string[] namesRase = {"Люди", "Эльфы", "Гномы", "Гоблины"};
        for (int i = 0; i < namesRase.Length - 1; i++) // Выводим все, кроме последней (ради аккуратности оформления)
        {
            Console.Write(i + 1 + " - " + namesRase[i] + ", "); 
        }
        Console.Write(namesRase.Length + " - " + namesRase[namesRase.Length - 1] + ".");
    }



static void Main(string[] args)
    {
        SelectRase();
    }
}
