namespace Simple_LINQ_ExtentionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Take
            List<int> raw1 = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            var result = raw1.Take(3);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            try
            {
                raw1.Take(-1);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument below 0 " + e.Message);
            }
            try
            {
                raw1.Take(50);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument bigger then collection size " + e.Message);
            }

            //Test Zero amount
            result = result.Take(0);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();



            //Test Top
            Console.WriteLine();
            Console.WriteLine("Top Test:");

            List<int> raw2 = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            result = raw2.Top(10);

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            try
            {
                raw2.Top(-1);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument below 0 " + e.Message);
            }
            try
            {
                raw2.Top(101);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument bigger then collection size " + e.Message);
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
