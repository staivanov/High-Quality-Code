using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        //Take the VS solution "Cohesion-and-Coupling" and refactor its code to follow the principles of good abstraction, loose coupling and strong cohesion. Split the class Utils to other classes that have strong cohesion and are loosely coupled internally.

        static void Main()
        {
            Console.WriteLine(Utils.GetFileExtension("example"));
            Console.WriteLine(Utils.GetFileExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(Utils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Point.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Point.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Point.Width = 3;
            Point.Height = 4;
            Point.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Point.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Point.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Point.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Point.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Point.CalcDiagonalYZ());
        }
    }
}
