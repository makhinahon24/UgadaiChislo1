namespace ConsoleApp1;
internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Выберите действие: Игра \"Угадай число\", Таблица умножения, Вывод делителей числа");

        string input = Console.ReadLine();

        if (input == "1")
        {
            Ugadai();
        }
        if (input == "2")
        {
            tablica();
        }
        if (input == "3")
        {
            delitel();
        }

    }
    static void Ugadai()
    {
        Random random = new Random();
        int zagadChislo = random.Next(1, 100);

        string input1 = Console.ReadLine();
        int input2 = Convert.ToInt32(input1);
        while (input2 != zagadChislo)
        {
            if (input2 < zagadChislo)
            {
                Console.WriteLine("Число должно быть больше");
            }
            else if (input2 > zagadChislo)
            {
                Console.WriteLine("Число должно быть меньше");
            }
            input1 = Console.ReadLine();
            input2 = Convert.ToInt32(input1);

        }
    }
    static void tablica()
    {
        int[,] table1 = new int[10, 10];
        for (int m = 0; m < 10; m++)
        {
            for (int n = 0; n < 10; n++)
            {
                table1[m, n] = (m + 1) * (n + 1);   
                Console.Write( table1 [m,n] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void delitel()
    {
        int x2 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= x2; i++)
        {
            if (x2 % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}
