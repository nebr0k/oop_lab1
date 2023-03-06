using System;

//class Lab_03_1
//{
//    static void Main()
//    {
//        double x, y, A, B;
//        Console.Write("x = ");
//        x = double.Parse(Console.ReadLine());
//        A = x + 1;

//        // спосіб 1
//        if (x <= 4)
//        {
//            B = Math.Exp(Math.Log(2 + 2 * x) + 2 * x);
//        }
//        else if (x > 7)
//        {
//            B = 1 - 7 * x + x * x - 2 * x * x * x;
//        }
//        else
//        {
//            B = 1 / Math.Tan((1 + x) / 9 + 8 * x);
//        }

//        y = A + B;
//        Console.WriteLine("1) y = " + y);

//        // спосіб 2
//        if (x <= 4)
//        {
//            B = Math.Exp(Math.Log(2 + 2 * x) + 2 * x);
//        }
//        else if (x > 7)
//        {
//            B = 1 - 7 * x + x * x - 2 * x * x * x;
//        }
//        else
//        {
//            B = 1 / Math.Tan((1 + x) / 9 + 8 * x);
//        }

//        y = A + B;
//        Console.WriteLine("2) y = " + y);

//        Console.ReadLine();
//    }
//}




//class Program
//{
//    static void Main()
//    {
//        int N, i;
//        double S;

//        Console.Write("N = ");
//        N = int.Parse(Console.ReadLine());

//        // цикл while
//        S = 0;
//        i = 1;
//        while (i <= N)
//        {
//            S += (1 + 1.0 * i / N) / (1.0 * i * i);
//            i++;
//        }
//        Console.WriteLine(S);

//        // цикл do-while
//        S = 0;
//        i = 1;
//        do
//        {
//            S += (1 + 1.0 * i / N) / (1.0 * i * i);
//            i++;
//        } while (i <= N);
//        Console.WriteLine(S);

//        // цикл for
//        S = 0;
//        for (i = 1; i <= N; i++)
//        {
//            S += (1 + 1.0 * i / N) / (1.0 * i * i);
//        }
//        Console.WriteLine(S);

//        // зворотній цикл for
//        S = 0;
//        for (i = N; i >= 1; i--)
//        {
//            S += (1 + 1.0 * i / N) / (1.0 * i * i);
//        }
//        Console.WriteLine(S);

//        Console.ReadLine();
//    }
//}



//class Program
//{
//    static void Main()
//    {
//        double x, xp, xk, dx, A, B, y;
//        Console.Write("xp = "); xp = double.Parse(Console.ReadLine());
//        Console.Write("xk = "); xk = double.Parse(Console.ReadLine());
//        Console.Write("dx = "); dx = double.Parse(Console.ReadLine());

//        Console.WriteLine("---------------------------");
//        Console.WriteLine("|    x    |     y     |");
//        Console.WriteLine("---------------------------");

//        x = xp;
//        while (x <= xk)
//        {
//            A = x + 1;
//            if (x <= 4)
//                B = Math.Exp(Math.Log(2 + 2 * x) + 2 * x);
//            else if (x > 7)
//                B = 1 - 7 * x + x * x - 2 * x * x * x;
//            else
//                B = 1 / Math.Tan((1 + x) / 9 + 8 * x);
//            y = A + B;
//            Console.WriteLine("|{0,8:F2} |{1,10:F3} |", x, y);
//            x += dx;
//        }

//        Console.WriteLine("---------------------------");
//    }
//}
