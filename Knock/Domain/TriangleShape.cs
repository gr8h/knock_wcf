using knockknock.Model;

namespace knockknock.Domain
{
    public static class TriangleShape
    {
        public static TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (SidesTooShort(a, b, c))
                return TriangleType.Error;
            else if (CheckForZero(a, b, c))
                return TriangleType.Error;
            else if (AllSidesEqual(a, b, c))
                return TriangleType.Equilateral;
            else if (TwoSidesEqual(a, b, c))
                return TriangleType.Isosceles;
            else
                return TriangleType.Scalene;
        }

        // Check if any side of the triangle is zero
        private static bool CheckForZero(int a, int b, int c)
        {
            return a * b * c == 0;
        }

        //Check if the three sides length can make a triangle
        private static bool SidesTooShort(int a, int b, int c)
        {
            return a >= b + c || b >= a + c || c >= a + b;
        }

        //Check if the all sides length are equal
        private static bool AllSidesEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        //Check if the two sides length are equal
        private static bool TwoSidesEqual(int a, int b, int c)
        {
            return a == b || a == c || b == c;
        }
    }
}