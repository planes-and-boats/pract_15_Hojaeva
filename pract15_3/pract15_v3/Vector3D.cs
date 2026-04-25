using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract15_v3
{
    internal class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static Vector3D Add(Vector3D a, Vector3D b) => new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector3D Subtract(Vector3D a, Vector3D b) => new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        public static double Multiply(Vector3D a, Vector3D b) => a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        public double Length() => Math.Sqrt(X * X + Y * Y + Z * Z);
        public static double CosAngle(Vector3D a, Vector3D b)
        {
            double den = a.Length() * b.Length();
            return den == 0 ? 0 : Multiply(a, b) / den;
        }
        public override string ToString() => $"({X}; {Y}; {Z})";
    }
}
