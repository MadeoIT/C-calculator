using System;

namespace CSharpPlayground
{
    public class Division : IOperation
    {
        public string OperationName 
        { 
            get {return "division"; } 
        }
        public int Operation(int numA, int numB)
        {
            if (numB == 0) { Console.WriteLine("You cannot divide by 0");}
            int result = numA / numB;
            return result;
        }
    }
}