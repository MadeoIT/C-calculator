namespace CSharpPlayground
{
    class Multiplication : IOperation
    {
        public string OperationName 
        {
            get { return  "multiplication"; }
        }
        public int Operation(int numA, int numB)
        {
            var result = numA * numB;
            return result;
        }
    }
}
