namespace CSharpPlayground
{
    class Addition : IOperation
    {
        public string OperationName 
        {
            get { return  "addition"; }
        }
        public int Operation(int NumA, int NumB)
        {
            var result = NumA + NumB;
            return result;
        }
    }
}
