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
            bodies[3] = new Parallelepiped(1, 1, 1, Math.PI / 6, Math.PI / 6, Math.PI / 6);
            bodies[4] = new Tetrahedron(5, 1, 3, Math.PI / 2, Math.PI / 2, Math.PI / 2);

            for (int i = 0; i < bodies.Length; i++) {
                Console.WriteLine(bodies[i] + ":" + "\n");
                Console.WriteLine("Volume: " + bodies[i].Volume());
                Console.WriteLine("Square: " + bodies[i].Square());
                Console.WriteLine("Lenght of edges: " + bodies[i].LenghtsOfEdges());
                Console.WriteLine();
            }
        }
    }
}
