using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Practicheskaya 2");
            Console.WriteLine("viberite zadanie: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Task1();
                    break;
                case "2":
                    Task2();
                    break;
                case "3":
                    Task3();
                    break;
                case "4":
                    Task4();
                    break;
                case "5":
                    Task5();
                    break;
                case "6":
                    Task6();
                    break;
                case "7":
                    Task7();
                    break;
                case "8":
                    Task8();
                    break;
                case "9":
                    Task9();
                    break;
                case "10":
                    Task10();
                    break;
                case "11":
                    Task11();
                    break;
                case "12":
                    Task12();
                    break;
                case "13":
                    Task13();
                    break;
                case "14":
                    Task14();
                    break;
                case "15":
                    Task15();
                    break;
                case "16":
                    Task16();
                    break;
                case "17":
                    Task17();
                    break;
                case "18":
                    Task18();
                    break;
                case "19":
                    Task19();
                    break;
                case "20":
                    Task20();
                    break;
                case "21":
                    Task21();
                    break;
                case "22":
                    Task22();
                    break;
                case "23":
                    Task23();
                    break;
                case "24":
                    Task24();
                    break;
                case "25":
                    Task25();
                    break;
                case "26":
                    Task26();
                    break;
                case "27":
                    Task27();
                    break;
                case "28":
                    Task28();
                    break;
                case "29":
                    Task29();
                    break;
                case "30":
                    Task30();
                    break;

                default:
                    Console.WriteLine("Vvedite pravilnoe znachenie");

                    break;

            }
        }
        static void Task1()
        {
            Console.WriteLine("ZADANIE 1: ");

            double  G, e, y, f;
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - f");
            f = Convert.ToDouble(Console.ReadLine());

            G = (Math.Pow(e, 2 * y) + Math.Sin(f)) / (Math.Log10(3.8 * y + f));

            Console.WriteLine($"G = {G}");

        }

        static void Task2()
        { Console.WriteLine("Zadanie 2: ");
            double F, d, y;
            Console.WriteLine("vvedite znachenie - d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            F = (Math.Log10(d) + ((Math.Pow(3.5 * d, 2) + 1))) / Math.Cos(2 * y);

            Console.WriteLine($"F = {F}");
        }
        static void Task3()
        {
            Console.WriteLine("Zadanie 3: ");
            double U, k, y, e;
            Console.WriteLine("vvedite znachenie - k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());

            U = (Math.Log10(k - y)+Math.Pow(y, 4)) / (Math.Pow(e, y)+2.355*Math.Pow(k, 2));
            Console.WriteLine($"U={U}");
        }
        static void Task4()
        {
            Console.WriteLine("Zadanie 4: ");
            double G, w, y;
            Console.WriteLine("vvedite znachenie - w");
            w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            G = (9.33 * Math.Pow(w, 2) + Math.Sqrt(w)) / (Math.Log10(y + 3.5) + Math.Sqrt(y));

            Console.WriteLine($"G={G}");

        }
        static void Task5()
        {
            Console.WriteLine("Zadanie 5: ");
            double D, a, t, e, y;
            Console.WriteLine("vvedite znachenie - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            D = (7.8*Math.Pow(a, 2)+3.52*t) / (Math.Log10(a+2*y)+Math.Pow(e, y));

            Console.WriteLine($"D={D}");

        }
        static void Task6()
        {


            Console.WriteLine("Zadanie 6: ");
            double L, i, y;
            Console.WriteLine("vvedite znachenie - i");
            i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            L = (0.81*Math.Cos(i)) / (Math.Log10(y)+2*Math.Pow(i, 3));

            Console.WriteLine($"L={L}");


        }
        static void Task7()
        {
            Console.WriteLine("Zadanie 7: ");
            double N, m, y;
            Console.WriteLine("vvedite znachenie - m");
            m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            N = (Math.Pow(m, 2) + 2.8 * m + 0.355) / (Math.Cos(2 * y) + 3.6);

            Console.WriteLine($"N={N}");
        }
        static void Task8()
        {

            Console.WriteLine("Zadanie 8: ");
            double T, t, y;
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            T = (2.37*Math.Sin(t+1)) / (Math.Sqrt(4*Math.Pow(y, 2)-0.1*y+5));

            Console.WriteLine($"T={T}");
        }
        static void Task9()
        {
            Console.WriteLine("Zadanie 9: ");
            double V, y, w;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - w");
            w = Convert.ToDouble(Console.ReadLine());

            V = (Math.Pow(y + 2*w, 3)) / (Math.Log10(y + 0.75));

            Console.WriteLine($"V={V}");

        }
        static void Task10()
        {
            Console.WriteLine("Zadanie 10: ");
            double Z, t, y;
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            Z = (2 * t + y * Math.Cos(t)) / Math.Sqrt(y + 4.831);   

            Console.WriteLine($"Z={Z}");
        }
        static void Task11()
        {
            Console.WriteLine("Zadanie 11: ");
            double D, y, n;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - n");
            n = Convert.ToDouble(Console.ReadLine());

            D = (Math.Pow(y, 2)+0.5*n+4.8) / Math.Sin(y);

            Console.WriteLine($"D={D}");
           
        }
        static void Task12()
        {
            Console.WriteLine("Zadanie 12: ");
            double R, t, y;
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            R = (Math.Sin(Math.Pow(2*t+1, 2))+0.3) / (Math.Log10(t+y));

            Console.WriteLine($"R={R}");
        }
        static void Task13()
        {
            Console.WriteLine("Zadanie 13: ");
            double A, y, h, e;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - h");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());


            A = (Math.Sin(2 * y + h) + Math.Pow(h, 2)) / (Math.Pow(e, h) + y);

            Console.WriteLine($"A={A}");
        }
        static void Task14()
        {
            Console.WriteLine("Zadanie 14: ");
            double P, e, y, h;
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - h");
            h = Convert.ToDouble(Console.ReadLine());
            P = (Math.Pow(e, y + 2.5) + 7.1 * Math.Pow(h, 2)) / (Math.Pow(e, h) + y);


            Console.WriteLine($"P={P}");

        }
        static void Task15()
        {

            Console.WriteLine("Zadanie 15: ");
            double F, y, j;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - j");
            j = Convert.ToDouble(Console.ReadLine());
            F = (2*Math.Sin(0.354*y+1)) / (Math.Log10(y+2*j));


            Console.WriteLine($"F={F}");


        }
        static void Task16()
        {
            Console.WriteLine("Zadanie 16: ");
            double W, t, r, e, y;
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - r");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            W = (4 * Math.Pow(t, 3) + Math.Log10(r)) / (Math.Pow(e,y + r) + 7.2 * Math.Sin(r));


            Console.WriteLine($"W={W}");
        }
        static void Task17()
        {
            Console.WriteLine("Zadanie 17: ");
            double H, y, n;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - n");
            n = Convert.ToDouble(Console.ReadLine());
            H = (Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y)) / (23.1 * Math.Pow(n, 2) + Math.Cos(n));  


            Console.WriteLine($"H={H}");
        }
        static void Task18()
        {
            Console.WriteLine("Zadanie 18: ");
            double R, y, k;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - k");
            k = Convert.ToDouble(Console.ReadLine());
            R = (Math.Sqrt(Math.Pow(Math.Sin(y), 2)+6.835) / (Math.Log10(y+k))+3*Math.Pow(y, 2));


            Console.WriteLine($"R={R}");
        }
        static void Task19()
        {
            Console.WriteLine("Zadanie 19: ");
            double E, y, q;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - q");
            q = Convert.ToDouble(Console.ReadLine());
            E = (Math.Log10(0.7 * y + 2 * q)) / (Math.Sqrt(3 * Math.Pow(y, 2) + 0.5 * y + 4));


            Console.WriteLine($"E={E}");
        }
        static void Task20()
        {
            Console.WriteLine("Zadanie 20: ");
            double K, t, l, y, e;
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - l");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            K = (2*Math.Pow(t, 2)+3*l+7.2) /( Math.Log10(y+Math.Pow(e, 2*l)));


            Console.WriteLine($"K={K}");
        }
        static void Task21()
        {
            Console.WriteLine("Zadanie 20: ");
            double Q, k, x, d, p;
            Console.WriteLine("vvedite znachenie - k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - p");
            p = Convert.ToDouble(Console.ReadLine());
            Q = (Math.Sqrt(k + 2.6 * p * Math.Sin(k)) / (x - Math.Pow(d, 3)));

            Console.WriteLine($"Q={Q}");
        }
        static void Task22()
        {
            Console.WriteLine("Zadanie 22: ");
            double S, y, t;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());         
            S = (4.351*Math.Pow(y, 3)+2*t*Math.Log10(t)) / (Math.Sqrt(Math.Cos(2*y)+4.351));

            Console.WriteLine($"S={S}");
        }
        static void Task23()
        {
            Console.WriteLine("Zadanie 23: ");
            double R, y, d, e;
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - d");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            R = (Math.Pow(Math.Sin(y), 2) + 0.3 * d) / (Math.Pow(e, y) + Math.Log10(d));

            Console.WriteLine($"R={R}");
        }
        static void Task24()
        {
            Console.WriteLine("Zadanie 24: ");
            double U, k, e, y;
            Console.WriteLine("vvedite znachenie - k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            U = (Math.Log10(2*k+4.3)) / (Math.Pow(e, k+y)+Math.Sqrt(y));

            Console.WriteLine($"U={U}");
        }
        static void Task25()
        {
            Console.WriteLine("Zadanie 25: ");
            double L, c, t;
            Console.WriteLine("vvedite znachenie - c");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - t");
            t = Convert.ToDouble(Console.ReadLine());

            L = (Math.Pow(Math.Cos(c), 2) + (3 * Math.Pow(t, 2) + 4)) / (Math.Sqrt(c + t));

            Console.WriteLine($"L = {L}");

        }
        static void Task26()
        {
            Console.WriteLine("Zadanie 26: ");
            double T, u, y;
            Console.WriteLine("vvedite znachenie - u");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            T = (Math.Sin(2 * u)) / (Math.Log10(2 * y + u));

            Console.WriteLine($"T = {T}");

        }
        static void Task27()
        {
            Console.WriteLine("Zadanie 27: ");
            double Z, p, y;
            Console.WriteLine("vvedite znachenie - p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            Z = (Math.Sin(Math.Pow(p + 0.4, 2))) / (Math.Pow(y, 2) + 7.325 * p);

            Console.WriteLine($"Z = {Z}");

        }
        static void Task28()
        {
            Console.WriteLine("Zadanie 28: ");
            double W, v, e, y;
            Console.WriteLine("vvedite znachenie - v");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            W = (0.004 * v + Math.Pow(e, 2 * y)) / (Math.Pow(e, y / 2));

            Console.WriteLine($"W = {W}");

        }
        static void Task29()
        {
            Console.WriteLine("Zadanie 29: ");
            double T, h, e, y;
            Console.WriteLine("vvedite znachenie - h");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            T = (0.355 * Math.Pow(h, 2) - 4.355) / (Math.Pow(e, y + h) + Math.Sqrt(2.7 * y));
            Console.WriteLine($"T = {T}");
        }
        static void Task30()
        {
            Console.WriteLine("Zadanie 29: ");
            double N, p, e, y;
            Console.WriteLine("vvedite znachenie - p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("vvedite znachenie - y");
            y = Convert.ToDouble(Console.ReadLine());

            N = (3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)) / (Math.Log10(p + y) + Math.Pow(e, p));

            Console.WriteLine($"N = {N}");
        }

    }
}
