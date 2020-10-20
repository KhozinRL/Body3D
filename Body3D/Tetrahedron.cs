using System;
namespace Body3D
{
    public class Tetrahedron: Body3D
    {
        double x, y, z;
        double alpha, beta, gamma;
        public Tetrahedron(double x, double y, double z, double alpha, double beta, double gamma)
        {
            X = x;
            Y = y;
            Z = z;
            Alpha = alpha;
            Beta = beta;
            Gamma = gamma;
        }

        public double X
        {
            get
            {
                return x;
            }
            private set
            {
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
                alpha = (value >= 0 && value <= Math.PI) ? value : 0;
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

        public double BaseSideXY {
            get {
                return LawOfCosines(X, Y, Alpha);
            }
        }
        public double BaseSideXZ
        {
            get
            {
                return LawOfCosines(X, Z, Beta);
            }
        }
        public double BaseSideYZ
        {
            get
            {
                return LawOfCosines(Y, Z, Gamma);
            }
        }

        public override double LenghtsOfEdges()
        {
            return X + Y + Z +  + BaseSideXY + BaseSideXZ + BaseSideYZ;
        }

        public override double Square()
        {
            return TriangleSquare(X, Y, Alpha) + TriangleSquare(X, Z, Beta) + TriangleSquare(Y, Z, Gamma) + HeronsFormula(BaseSideXY, BaseSideXZ, BaseSideYZ);
        }

        public override double Volume()
        {
            double D = 1 + 2 * Math.Cos(Alpha) * Math.Cos(Beta) * Math.Cos(Gamma) - Math.Pow(Math.Cos(Alpha),2) - Math.Pow(Math.Cos(Beta), 2) - Math.Pow(Math.Cos(Gamma), 2);
            return 1 / 6.0 * X * Y * Z * Math.Sqrt(D);
        }

        public static double TriangleSquare(double a, double b, double alpha) {
            return 0.5 * a * b * Math.Sin(alpha);
        }

        public static double HeronsFormula(double a, double b, double c) {
            double p = 0.5 * (a + b + c);
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override string ToString()
        {
            return String.Format("{0} with parameters: \nx: {1:0.00}, y: {2:0.00}, z: {3:0.00} \nalpha: {4:0.00}, beta: {5:0.00}, gamma: {6:0.00}", GetType().Name, X, Y, Z, Alpha, Beta, Gamma);
        }
    }
}
