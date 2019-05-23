using System;
using System.Collections.Generic;

namespace ParametricEquations
{
    public class Point

    {
        public double X;
        public double Y;
        public double Z;

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Point Origin => new Point(0, 0, 0);


        public void Multiply(double number)
        {
            X *= number;
            Y *= number;
            Z *= number;
        }
        public void Divide(double number)
        {
            X /= number;
            Y /= number;
            Z /= number;
        }
        public void Substract(Vector vector)
        {
            X -= vector.X;
            Y -= vector.Y;
            Z -= vector.Z;
        }
        public void Substract(Point point)
        {
            X -= point.X;
            Y -= point.Y;
            Z -= point.Z;
        }
        public void Add(Vector vector)
        {
            X += vector.X;
            Y += vector.Y;
            Z += vector.Z;
        }
        public void Add(Point point)
        {
            X += point.X;
            Y += point.Y;
            Z += point.Z;
        }

        public override string ToString()
        {
            return "Point" + "{" + X + "," + Y + "," + Z + "}";
        }
        public string PointToCSV()
        {
            return X + "," + Y + "," + Z;
        }
    }
}