using System;
using System.Collections.Generic;

namespace CSharpPlayground
{
    class OperationLister
    {
        public IList<IOperation> Operations { get; set; } = new List<IOperation>();

        public void Lister ()
        {
            foreach (var operation in Operations)
            {
                Console.WriteLine(Operations.IndexOf(operation)  + ") " + operation.OperationName);
            }
        }

        public void OperationAdder(IOperation operation)
        {
            Operations.Add(operation);
        }

        public int Do(int idx, int numA, int numB) 
        {
            var result = Operations[idx].Operation(numA, numB);
            return result;
        }
    }
}
