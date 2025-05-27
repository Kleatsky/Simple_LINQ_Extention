using Simple_LINQ_ExtentionConsole.Model;

namespace Simple_LINQ_ExtentionConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Take
            TestTake();


            //Test Zero amount
            TestTop();


            //Test Top predicate
            TestTopPredicate();


            Console.WriteLine("Program complite success.");
        }
        private static void TestTake()
        {
            List<int> raw = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            var result = raw.Take(3);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            try
            {
                raw.Take(-1);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument below 0 " + e.Message);
            }
            try
            {
                raw.Take(50);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument bigger then collection size " + e.Message);
            }
            result = result.Take(0);
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        private static void TestTop()
        {
            //Test Top
            Console.WriteLine();
            Console.WriteLine("Top Test:");

            List<int> raw = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            var result = raw.Top(30);

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            try
            {
                raw.Top(-1);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument below 0 " + e.Message);
            }
            try
            {
                raw.Top(101);

            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argument bigger then collection size " + e.Message);
            }
        }
        private static void TestTopPredicate()
        {
            Console.WriteLine();
            Console.WriteLine("Top predicate Test:");
            List<Person> row3 = new List<Person>()
            {
                new Person(32, "Name1"),
                new Person(30, "Name2"),
                new Person(32, "Name3"),
                new Person(32, "Name4"),
                new Person(17, "Name5"),
                new Person(32, "Name6"),
                new Person(312, "Name7"),
                new Person(12, "Name8"),
                new Person(3, "Name9"),
            };

            var result = row3.Top(30, x => x.Age);

            foreach (var i in result)
            {
                Console.WriteLine(i.Age + " " + i.Name);
            }

            ////Выдаст ошибку, потому что такой запрос x => x.Age без проверки на null
            //row3.Add(null);
            //row3.Top(30, x => x.Age);
        }
    }
}
