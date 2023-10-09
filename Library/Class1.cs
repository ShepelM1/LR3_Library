using System;

namespace GeometryLibrary
{
    public class TwoDimensionalShape
    {
        //Обчислює площу квадрата за заданою стороною.
        public static double SquareArea(double side)
        {
            return side * side;
        }

        // Обчислює площу прямокутника за заданими довжиною і шириною.
        public static double RectangleArea(double length, double width)
        {
            return length * width;
        }

        // Обчислює площу трикутника за заданою основою і висотою.
        public static double TriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        // Обчислює площу кола за заданим радіусом.
        public static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Обчислює площу паралелограма за заданою основою і висотою.
        public static double ParallelogramArea(double baseLength, double height)
        {
            return baseLength * height;
        }

        // Обчислює площу трапеції за заданими основою 1, осоновою 2 і висотою.
        public static double TrapezoidArea(double base1, double base2, double height)
        {
            return 0.5 * (base1 + base2) * height;
        }

        //Обчислює площу ромба за заданими діагоналями.
        public static double RhombusArea(double diagonal1, double diagonal2)
        {
            return 0.5 * diagonal1 * diagonal2;
        }

        //Обчислює площу сектора за заданим радіусом і кутом.
        public static double SectorArea(double radius, double angle)
        {
            return (angle / 360.0) * Math.PI * radius * radius;
        }

        //Обчислює площу правильного багатокутника за заданою довжиною сторони, апофемою і кількістю сторін.
        public static double RegularPolygonArea(double sideLength, double apothem, int numSides)
        {
            return (numSides * sideLength * apothem) / 2.0;
        }

        // Обчислює площу еліпса за заданими великой та малою віссю.
        public static double EllipseArea(double majorAxis, double minorAxis)
        {
            return Math.PI * majorAxis * minorAxis;
        }

        // Обчислює площу аннулуса (кільця) за заданими радіусом внутрішнього і зовнішнього кола.
        public static double AnnulusArea(double outerRadius, double innerRadius)
        {
            return Math.PI * (Math.Pow(outerRadius, 2) - Math.Pow(innerRadius, 2));
        }

        // Додайте інші методи для інших 2D-фігур
    }

    public class ThreeDimensionalShape
    {
        // Обчислює об'єм куба за заданим боком.
        public static double CubeVolume(double side)
        {
            return Math.Pow(side, 3);
        }

        // Обчислює об'єм прямокутного паралелепіпеда за заданими довжиною, шириною і висотою.
        public static double RectangularPrismVolume(double length, double width, double height)
        {
            return length * width * height;
        }

        // Обчислює об'єм сфери за заданим радіусом.
        public static double SphereVolume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        // Обчислює об'єм циліндра за заданими радіусом основи і висотою.
        public static double CylinderVolume(double radius, double height)
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }

        // Обчислює об'єм конуса за заданим радіусом основи і висотою.
        public static double ConeVolume(double radius, double height)
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }

        // Обчислює об'єм піраміди за заданою площею основи і висотою.
        public static double PyramidVolume(double baseArea, double height)
        {
            return (1.0 / 3.0) * baseArea * height;
        }

        // Обчислює об'єм призми за заданою площею основи і висотою.
        public static double TriangularPrismVolume(double baseArea, double height)
        {
            return baseArea * height;
        }

        // Обчислює об'єм еліпсоїда за заданими радіусами осей.
        public static double EllipsoidVolume(double radius1, double radius2, double radius3)
        {
            return (4.0 / 3.0) * Math.PI * radius1 * radius2 * radius3;
        }

        /// Обчислює об'єм еліпсоїда за заданими радіусами осей.
        public static double TorusVolume(double majorRadius, double minorRadius)
        {
            return (2.0 * Math.PI * Math.PI * Math.Pow(majorRadius, 2)) * minorRadius;
        }

        // Додайте інші методи для інших 3D-фігур
    }
}
