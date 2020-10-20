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

        public double HeightXY {
            get {
                double Zx = Z * Math.Cos(Beta);
                double Yx = Y * Math.Cos(Alpha);
                double Yy = Y * Math.Sin(Alpha);
                double Zy = (Z * Y * Math.Cos(Gamma) - Zx * Yx) / Yy;
                double Cos = Math.Sqrt(Math.Pow(Zx, 2) + Math.Pow(Zy, 2)) / Z;
                double Sin = Math.Sqrt(1 - Math.Pow(Cos, 2));
                return Z * Sin;
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
            return HeightXY * X * Y * Math.Sin(Alpha);
        }

        public static double ParallelogramSquare(double a, double b, double alpha) {
            return a * b * Math.Sin(alpha);
        }

        public override string ToString()
        {
            return GetType().Name + " with parameters: " + "\n" +
                "x: " + X + ", y: " + Y + ", z: " + Z + "\n" +
                "alpha: " + Alpha + ", beta: " + Beta + ", gamma: " + Gamma;
        }
    }
}
