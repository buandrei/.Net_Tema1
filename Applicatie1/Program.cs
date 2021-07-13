using System;

namespace Applicatie1
{
    class Program
    {
        public static void Main()
        {
            var stringList = new string[] { "a", "ab", "abc", "abcd", "abcde" };

            Console.WriteLine("Lista cu 5 elemente");
            Console.WriteLine("Elementul cu cea mai mare lungime este " + FindMaximumLengthOfStringFromArray(stringList));
            Console.WriteLine("Elementul cu cea mai mica lungime este " + FindMinimumLengthOfStringFromArray(stringList));

            var longerStringList = new string[] { "a", "ab", "abc", "abcd", "abcde", "abcdef", "abcdefg", "abcdefgh", "abcdefghi", "abcdefghij" };

            Console.WriteLine("\nLista cu 10 elemente");
            Console.WriteLine("Elementul cu cea mai mare lungime este " + FindMaximumLengthOfStringFromArray(longerStringList));
            Console.WriteLine("Elementul cu cea mai mica lungime este " + FindMinimumLengthOfStringFromArray(longerStringList));

        }

        public static string FindMaximumLengthOfStringFromArray(string[] list)
        {

            string longest = "";

            foreach (var item in list)
            {
                if (longest.Length < item.Length)
                    longest = item;
            }
            return longest;
        }

        public static string FindMinimumLengthOfStringFromArray(string[] list)
        {

            string shortest = "";

            foreach (var item in list)
            {
                if (item != "")
                {
                    if (String.IsNullOrEmpty(shortest))
                    {
                        shortest = item;
                    }
                }

                if (shortest.Length > item.Length)
                {
                    shortest = item;
                }

            }
            return shortest;
        }
    }
}
