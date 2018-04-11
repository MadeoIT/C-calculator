namespace CSharpPlayground
{
    public interface IOperation
    {
        string OperationName { get; }
        int Operation(int numA, int numB);
    }
}
