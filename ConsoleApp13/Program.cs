namespace ConsoleApp13
{
    internal class Program
    {
        public static string Likes(string[] names)
        {
            int count = names.Length;

            if (count == 0)
                return "no on likes this";
            else if (count == 1)
                return $"{names[0]} likes this";
            else if (count == 2)
                return $"{names[0]} and {names[1]} likes this";
            else if (count == 3)
                return $"{names[0]} ans {names[1]} and {names[2]} likes this";
            else 
                return $"{names[0]}, {names[1]} and {count - 2} others like this";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Likes(new string[] {}));
            Console.WriteLine(Likes(new string[] {"Peter"}));
            Console.WriteLine(Likes(new string[] {"Peter", "John"}));
            Console.WriteLine(Likes(new string[] {"Peter", "John", "Mary"}));
            Console.WriteLine(Likes(new string[] {"Peter", "John", "Mary", "Alice"}));
        }
    }
}
