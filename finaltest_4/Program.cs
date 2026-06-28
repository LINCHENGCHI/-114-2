namespace finaltest_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDel hander = new MyDel(MyMath.Add);
            hander += new MyDel(MyMath.Sub);
            hander += new MyDel(MyMath.Mul);
            hander += new MyDel(MyMath.Div);

            MyMath.str = "委派1";
            hander(20, 30);
            Console.WriteLine(MyMath.str);

            MyMath.str = "委派2";
            hander -= new MyDel(MyMath.Add);
            hander -= new MyDel(MyMath.Sub);
            hander(15, 14);
            Console.WriteLine(MyMath.str);
        }
    }
}
