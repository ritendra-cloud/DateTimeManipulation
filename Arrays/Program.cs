namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter Grades {i} : ");
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            string[] studentsName = new string[] {"Test", "Student1" };

        }
    }
}