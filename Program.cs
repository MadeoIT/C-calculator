using System;

namespace CSharpPlayground
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // User inputs
                Console.Write("Insert firt number: ");
                var numA = Convert.ToInt16(Console.ReadLine());

                Console.Write("Insert second number: ");
                var numB = Convert.ToInt16(Console.ReadLine());

                // Initialize classes
                var operationLister = new OperationLister();
                operationLister.OperationAdder(new Multiplication());
                operationLister.OperationAdder(new Addition());
                operationLister.OperationAdder(new Division());
                
                // Menu of the operations
                Console.WriteLine("Operation List: ");
                operationLister.Lister();
                Console.Write("Type the number of your operation: ");
                var operationCommand = Console.ReadLine();   
                            
                try
                {
                    var operationNum = Convert.ToInt16(operationCommand);
                    Console.WriteLine("You choose: "+ operationLister.Operations[operationNum].OperationName);
                    var result = operationLister.Do(operationNum, numA, numB);
                    Console.WriteLine(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid command");
                    return;
                } 
            }
            catch (Exception)
            {
                Console.WriteLine("Only integer! Sorry =(");
                return;
            }
            

            


        }
    }
}
