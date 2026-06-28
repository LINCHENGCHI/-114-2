using System.Security.Cryptography.X509Certificates;

namespace finaltest_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.GetName());
            Console.WriteLine(p1.GetName("德明"));
        }
    }
}
