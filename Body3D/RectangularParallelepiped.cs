using System;
namespace Body3D
{
    public class RectangularParallelepiped: Parallelepiped
    {
        private const double angle = 0.5 * Math.PI;
        public RectangularParallelepiped(double x, double y, double z) : base(x, y, z, angle, angle, angle)
        {
            
        }

        public override double Square()
        {
            return 2 * (X * Y + X * Z + Y * Z);
        }

        public override double Volume()
        {
            return X * Y * Z;
        }

    }
}
