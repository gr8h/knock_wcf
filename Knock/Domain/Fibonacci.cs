using System;

namespace knockknock.Domain
{
    public static class Fibonacci
    {
        //Generate Fibonacci Number using mathmatical equation
        public static long FibonacciNumber(long n)
        {
            double Phi = ((1d + Math.Sqrt(5d)) / 2d);
            double D = 1d / Math.Sqrt(5d);
            return (long)(Math.Round((Math.Pow(Phi, n) - Math.Pow(1d - Phi, n)) * D));
        }

        //Generate Fibonacci Number using for loop
        private static long FibonacciNumber2(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            long firstNumber = 0;
            long secondNumber = 1;
            long result = 0;

            for (long i = 2; i <= n; i++)
            {
                result = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }

            return result;
        }
    }
}