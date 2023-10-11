using System;

public class HelloWorld{
    public static void Main(String[] args){
        //operator penugasan
        int a = 10;

        a+=5;
        Console.WriteLine("a: " + a);
        a-=5;
        Console.WriteLine("a: " + a);
        a*=5;
        Console.WriteLine("a: " + a);
        a/=5;
        Console.WriteLine("a: " + a);
        a%=3;
        Console.WriteLine("a: " + a);
        Console.WriteLine("================");

        // Increment
        int b = 5;
        Console.WriteLine("++b : " + ++b);
        Console.WriteLine("b++ : " + b++);
        Console.WriteLine("b : " + b);
        Console.WriteLine("================");

        int c = 10;
        Console.WriteLine("--c : " + --c);
        Console.WriteLine("c-- : " + c--);
        Console.WriteLine("c : " + c);
        Console.WriteLine("================");

        // Perbandingan Operator
        int d = 10;
        int e = 5;

        Console.WriteLine(d != e);
        Console.WriteLine(d == e);
        Console.WriteLine(d > e);
        Console.WriteLine(d < e);
        Console.WriteLine(d <= e);
        Console.WriteLine(d >= e);

        Console.WriteLine("================");

        // Operator Logika
        int f = 10;
        string name = "joni";

        if (f == 10 || name == "jon")
        {
            Console.WriteLine("Benar");
        }
        else
        {
            Console.WriteLine("Salah");
        }

        Console.WriteLine("================");

        // Arrays
        string[] divisidncc = { "game", "web", "mobile", "jaringan", "fta", "mulmed" };

        for (int i = 0; i < divisidncc.Length; i++)
        {
            Console.WriteLine(divisidncc[i]);
        }

        int[,] numbers = { { 1, 2 }, { 3, 4 } };
        Console.WriteLine(numbers[0, 1]);
        Console.WriteLine(numbers[1, 0]);

        int[,,] arr = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
        Console.WriteLine(arr[0, 1, 1]);

        Console.WriteLine("================");

        // List
        var names = new List<string> { "Game", "Mobile", "Web" };
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i] + " ");
        }

        Console.WriteLine("================");

        // If-Else & ElseIf
        int nilai = 75;
        if (nilai >= 90)
        {
            Console.WriteLine("A");
        }
        else if (nilai >= 80)
        {
            Console.WriteLine("B");
        }
        else if (nilai >= 70)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D atau E");
        }

        Console.WriteLine("================");

        // Switch
        int nilais = 75;
        switch (nilais)
        {
            case > 95:
                Console.WriteLine("Memuaskan");
                break;
            case > 80:
                Console.WriteLine("Baik");
                break;
            case > 75:
                Console.WriteLine("Cukup");
                break;
            default:
                Console.WriteLine("Kurang");
                break;
        }

        Console.WriteLine("================");

        // For loop & While loop
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Perulangan ke " + i);
        }

        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("Perulangan ke " + j);
            j++;
        }
    }
}