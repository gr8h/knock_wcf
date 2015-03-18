using System;
using System.ServiceModel;
using knockknock.Domain;
using knockknock.Model;

namespace knockknock.Service.Implementation
{
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    public class RedPill : IRedPill
    {
        //Members
        private readonly Guid _g = new Guid("c0e2e2f0-3731-475a-a213-ec0eea9c76c7");
        private const int MaxValue = 92;
        private const int MinValue = -92;

        //Methods

        //FibonacciNumber method 
        public long FibonacciNumber(long n)
        {
            if (Math.Abs(n) > MaxValue || Math.Abs(n) < MinValue) throw new ArgumentOutOfRangeException("n", n, "Integer overflow exception.");

            return Fibonacci.FibonacciNumber(n);
        }

        //ReverseWords method
        public string ReverseWords(string s)
        {
            if (s == null) throw new ArgumentNullException("s", "The input value cannot be null.");

            return ReverseWord.ReverseWordsInString(s);
        }

        //WhatShapeIsThis method
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return TriangleShape.WhatShapeIsThis(a, b, c);
        }

        //WhatIsYourToken method
        public Guid WhatIsYourToken()
        {
            return _g;
        }
    }
}
