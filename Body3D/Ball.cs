using System;

namespace Body3D
{
    public class Ball: Body3D
    {
        double radius;

        public Ball(double R)
        {
            Radius = R;
        }

        public double Radius {
            get {
                return radius;
            }
            private set {
                radius = value > 0 ? value : 0;
            }
        }

        public override double LenghtsOfEdges()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Square()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        public override double Volume()
        {
            return 4 / 3.0 * Math.PI * Math.Pow(Radius, 3);
        }

        public override string ToString()
        {
            return GetType() + " with radius: R = " + Radius;
                
        }
    }
}
