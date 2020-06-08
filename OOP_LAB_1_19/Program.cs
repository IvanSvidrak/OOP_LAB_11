using System;

namespace OOP_LAB_1_19
{

    public class Program
    {
        static public double V(int r, int h, double p)
        {
            double V = p * r * r * h;
            Console.WriteLine("об'єм = " + V.ToString());
            return V;
        }
        static public double Sb(int r, int h, double p)
        {
            double Sb = 2 * (p * r * h);
            Console.WriteLine("площа бічної сторони = " + Sb.ToString());
            return Sb;
        }
        static void Main()
        {
            int r = 3;
            int h = 10;
            double p = 3.14;
            Sb(r, h, p);
            V(r, h, p);
        }
    }

}

