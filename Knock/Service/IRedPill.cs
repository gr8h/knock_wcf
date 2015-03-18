using System;
using System.ServiceModel;
using knockknock.Model;

namespace knockknock.Service
{
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        string ReverseWords(string s);

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        Guid WhatIsYourToken();
    }
}
