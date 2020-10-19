using System;

namespace Body3D
{
    class Program
    {
        static void Main(string[] args)
        {
            Body3D[] bodies = new Body3D[5];
            bodies[0] = new Tetrahedron(1, 1, 1, Math.PI / 3, Math.PI / 3, Math.PI / 3);
            bodies[1] = new Ball(5);
            bodies[2] = new RectangularParallelepiped(2,3,6);
            bodies[3] = new Parallelepiped(2, 3, 5, Math.PI / 3, Math.PI / 3, Math.PI / 3);
            bodies[4] = new Tetrahedron(5, 1, 3, Math.PI / 2, Math.PI / 2, Math.PI / 2);

            for (int i = 0; i < bodies.Length; i++) {
                Console.WriteLine("{0} : \n", bodies[i]);
                Console.WriteLine("Volume: {0: 0.00}", bodies[i].Volume());
                Console.WriteLine("Square: {0: 0.00}", bodies[i].Square());
                Console.WriteLine("Lenght of edges: {0:0.00}", bodies[i].LenghtsOfEdges());
                Console.WriteLine();
            }
        }
    }
}
