
using System;

namespace Assi_session8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // First Project - Point3D
            // =========================

            Point3D P1 = new Point3D(10, 20, 30);
            Point3D P2 = new Point3D(10, 20, 30);

            Console.WriteLine(P1);
            Console.WriteLine(P2);

            Console.Write("Enter Point 1 X: ");
            int x1 = int.TryParse(Console.ReadLine(), out int tempX1) ? tempX1 : 0;

            Console.Write("Enter Point 1 Y: ");
            int y1 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Point 1 Z: ");
            int z1 = Convert.ToInt32(Console.ReadLine());

            Point3D UserP1 = new Point3D(x1, y1, z1);

            Console.Write("Enter Point 2 X: ");
            int x2 = int.TryParse(Console.ReadLine(), out int tempX2) ? tempX2 : 0;

            Console.Write("Enter Point 2 Y: ");
            int y2 = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Point 2 Z: ");
            int z2 = Convert.ToInt32(Console.ReadLine());

            Point3D UserP2 = new Point3D(x2, y2, z2);

            Console.WriteLine(UserP1);
            Console.WriteLine(UserP2);

            Console.WriteLine(P1 == P2);

            Point3D[] points =
            {
                new Point3D(5, 20, 10),
                new Point3D(2, 30, 15),
                new Point3D(5, 10, 20),
                new Point3D(1, 40, 5)
            };

            Array.Sort(points);

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            Point3D clonedPoint = (Point3D)P1.Clone();
            Console.WriteLine(clonedPoint);

            // =========================
            // Second Project - Maths
            // =========================

            Console.WriteLine(Maths.Add(10, 5));
            Console.WriteLine(Maths.Subtract(10, 5));
            Console.WriteLine(Maths.Multiply(10, 5));
            Console.WriteLine(Maths.Divide(10, 5));

            // =========================
            // Third Project - Duration
            // =========================

            Duration D1 = new Duration(1, 10, 15);
            Duration D2 = new Duration(7800);
            Duration D3 = new Duration(666);

            Console.WriteLine(D1);
            Console.WriteLine(D2);
            Console.WriteLine(D3);

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = ++D1;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            D1 = D1 - D2;
            Console.WriteLine(D1);

            Console.WriteLine(D1 > D2);
            Console.WriteLine(D1 <= D2);

            if (D1)
            {
                Console.WriteLine("D1 is greater than zero");
            }

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt);
        }
    }
}

