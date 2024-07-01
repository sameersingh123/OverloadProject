namespace OverloadProject
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("1st Method");
        }
        public void Test(int a)
        {
            Console.WriteLine("2nd Method");
        }
        public void Test(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void Test(int a, string s)
        {
            Console.WriteLine("4th Method");
        }
        public void Test(string s, int a)
        {
            Console.WriteLine("5th Method");
        }
        static void Main()
        {
            Program p=new Program();
            p.Test();
            p.Test(10);
            p.Test("Hello");
            p.Test(10, "Hello");
            p.Test("Hello", 10);

            string s = "Sameer Singh";
            Console.WriteLine(s.IndexOf('S'));
            Console.WriteLine(s.IndexOf('S',1));

        }
    }
}
