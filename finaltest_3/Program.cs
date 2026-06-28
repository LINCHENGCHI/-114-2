namespace finaltest_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IName n1;
            string input = Console.ReadLine();

            if (input == "t") 
            {
                n1 = new Teacher();
                Console.WriteLine(n1);
            }
            else
            {
                n1 = new Student();
                Console.WriteLine("Student");
            }
        }
    }
}
