using System.Drawing;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread[] tids = new Thread[3];
            Print p1 = new Print();
            for (int i = 0; i < 3; i++)
            {
                tids[i] = new Thread(new ThreadStart(p1.printNum));
                tids[i].Name = "執行緒" + i + ":";
            }
            foreach (Thread t in tids)
            {
                t.Start();
            }
            Thread.Sleep(500);
            Console.WriteLine(Print.str);
        }
    }
}
