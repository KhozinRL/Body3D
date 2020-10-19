using System;
namespace Body3D
{
    public class Parallelepiped: Body3D
    {
        double x, y, z;
        double alpha, beta, gamma;
        public Parallelepiped(double x, double y, double z, double alpha, double beta, double gamma)
        {
            X = x;
            Y = y;
            Z = z;
            Alpha = alpha;
            Beta = beta;
            Gamma = gamma;
        }

        public double X {
            get {
                return x;
            }
            private set {
                x = value >= 0 ? value : 0;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            private set
            {
                y = value >= 0 ? value : 0;
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
            private set
            {
                z = value >= 0 ? value : 0;
            }
        }

        public double Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = (value >= 0 && value <= Math.PI)  ? value : 0;
            }
        }
        public double Beta
        {
            get
            {
                return beta;
            }
            set
            {
                beta = (value >= 0 && value <= Math.PI) ? value : 0;
            }
        }
        public double Gamma
        {
            get
            {
                return gamma;
            }
            set
            {
                gamma = (value >= 0 && value <= Math.PI) ? value : 0;
            }
        }

        public override double LenghtsOfEdges()
        {
            return 4 * (X + Y + Z);
        }

        public override double Square()
        {
            return 2 * (ParallelogramSquare(X, Y, Alpha) + ParallelogramSquare(X, Z, Beta) + ParallelogramSquare(Y, Z, Gamma));
        }

        public override double Volume()
        {
            //return Math.Abs(X*Y*Z*Math.Cos(Gamma)*Math.Sin())
            return 0;
        }

        public static double ParallelogramSquare(double a, double b, double alpha) {
            return a * b * Math.Sin(alpha);
        }

        public override string ToString()
        {
            return GetType() + " with parameters: " + "\n" +
                "x: " + X + ", y: " + Y + ", z: " + Z + "\n" +
                "alpha: " + Alpha + ", beta: " + Beta + ", gamma: " + Gamma;
        }
    }
}
