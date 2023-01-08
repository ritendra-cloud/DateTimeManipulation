namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int num1 = 19;
				int num2 = 0;
				Console.WriteLine("Result: " + (num1 / num2));
			}
			catch (DivideByZeroException e)
			{

				Console.WriteLine("Attempted divide by zero");
			}
			finally 
			{
				Console.WriteLine("Finally Block");
					
			}
        }
    }
}