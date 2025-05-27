namespace Simple_LINQ_ExtentionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {




            //Test Top
            List<int> raw1 = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            var resultTopRaw1 = raw1.Top(30);

            foreach (int i in raw1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Hello, World!");
        }
    }
}
