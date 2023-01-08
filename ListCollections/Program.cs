namespace ListCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names  = new List<string>();
            string name = string.Empty;

            

            while (name != "-1")
            {
                Console.Write("Enter Names : ");
                name = Console.ReadLine();
                if(!string.IsNullOrEmpty(name) && !name.Equals("-1"))
                {
                    names.Add(name);
                    Console.WriteLine($"{name} was added successfully.");

                }
                
            }
            Console.WriteLine("Printing entered names:");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }

        }
    }
}