using System;
namespace Body3D
{
    abstract public class Body3D
    {
        abstract public double Square();
        abstract public double Volume();
        abstract public double LenghtsOfEdges();

        public static double LawOfCosines(double a, double b, double alpha) {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(alpha));
        }
    }
}
