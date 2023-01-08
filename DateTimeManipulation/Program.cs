using System.Globalization;

namespace DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dob = new DateTime(1980, 12, 30);
            Console.WriteLine(dob);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            DateTime dateFromString = DateTime.Parse("1/21/2023", CultureInfo.InvariantCulture);

            Console.WriteLine(dateFromString);

            DateOnly dateOnly = DateOnly.FromDateTime(now);
            Console.WriteLine(dateOnly);

            TimeOnly time = TimeOnly.FromDateTime(now);
            Console.WriteLine(time);

        }
    }
}