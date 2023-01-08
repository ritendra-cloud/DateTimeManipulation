namespace OOPSinCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OOPS programming -> create your own data types

            Person person = new();

            Console.WriteLine("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            person.Age =Convert.ToInt32(Console.ReadLine());
            person.setSalary();

            Console.WriteLine($"Salary is: {person.getSalary()}");



        }
    }

   
}