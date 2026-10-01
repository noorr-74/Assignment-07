
using System;

namespace Assi_session8
{
    public class Point3D : IComparable, ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D() : this(0, 0, 0)
        {
        }

        public Point3D(int x) : this(x, 0, 0)
        {
        }

        public Point3D(int x, int y) : this(x, y, 0)
        {
        }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D other = (Point3D)obj!;

            if (X != other.X)
                return X.CompareTo(other.X);

            return Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}

