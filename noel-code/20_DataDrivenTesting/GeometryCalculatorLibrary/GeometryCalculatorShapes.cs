namespace GeometryCalculatorLibrary
{
    public class Circle
    {
        public static double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculatePerimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }

    public class Triangle
    {
        public static double CalculateArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double CalculatePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }
        public static double CalculateAreaHeron(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            return side1 == side2 && side1 == side3;
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            return side1 == side2 || side1 == side3 || side2 == side3;
        }

        public static bool IsScalene(double side1, double side2, double side3)
        {
            return side1 != side2 && side1 != side3 && side2 != side3;
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

    }
    public class Polygon
    {
        public static bool IsConvex(List<double> angles)
        {
            if (angles == null || angles.Count < 3)
                throw new ArgumentException("A polygon must have at least 3 angles.");

            int n = angles.Count;
            int signChanges = 0;

            for (int i = 0; i < n; i++)
            {
                double diff = angles[(i + 1) % n] - angles[i];
                if (Math.Abs(diff) > 180)
                {
                    // Adjust for reflex angles
                    diff = 360 - Math.Abs(diff);
                }

                if (Math.Abs(diff) > 0 && Math.Abs(diff) < 180)
                {
                    signChanges++;
                }
            }

            return signChanges <= 2;
        }
    }

    public class Square
    {
        public static double CalculateArea(double side)
        {
            return side * side;
        }

        public static double CalculatePerimeter(double side)
        {
            return 4 * side;
        }
    }
    public class Parallelogram
    {
        public static double CalculateArea(double baseLength, double height)
        {
            return baseLength * height;
        }

        public static double CalculatePerimeter(double side1, double side2)
        {
            return 2 * (side1 + side2);
        }
    }
    public class Pentagon
    {
        public static double CalculateArea(double side)
        {
            return 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * side * side;
        }

        public static double CalculatePerimeter(double side)
        {
            return 5 * side;
        }
    }

    public class Hexagon
    {
        public static double CalculateArea(double side)
        {
            return 3 * Math.Sqrt(3) * side * side / 2;
        }

        public static double CalculatePerimeter(double side)
        {
            return 6 * side;
        }
    }

    public class SolidGeometry
    {
        public static double CalculateCubeVolume(double sideLength)
        {
            return Math.Pow(sideLength, 3);
        }

        public static double CalculateCubeSurfaceArea(double sideLength)
        {
            return 6 * Math.Pow(sideLength, 2);
        }

        public static double CalculateSphereVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        public static double CalculateSphereSurfaceArea(double radius)
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public static double CalculateCylinderVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        public static double CalculateCylinderSurfaceArea(double radius, double height)
        {
            double lateralSurfaceArea = 2 * Math.PI * radius * height;
            double topAndBottomSurfaceArea = 2 * Math.PI * Math.Pow(radius, 2);
            return lateralSurfaceArea + topAndBottomSurfaceArea;
        }

        public static double CalculateConeVolume(double radius, double height)
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        public static double CalculateConeSurfaceArea(double radius, double height)
        {
            double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            return Math.PI * radius * (radius + slantHeight);
        }
    }
}

