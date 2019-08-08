using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solutionWithoutConcurrentDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput = Console.ReadLine();
            Dictionary<char, int> hashing = new Dictionary<char, int>();
            foreach (var c in userinput)
            {
                //only add the key to the dictionary if the dictionary doesn't already contain the key 😇
                if (!hashing.ContainsKey(c))
                {
                    hashing.Add(c, 1);
                }
            }
            // create a string builder so that you can add each key in the dictionary to the stringbuilder and then return the stringbuilder ToString
            StringBuilder sb = new StringBuilder();
            foreach (var c in hashing)
            {
                sb.Append(c.Key);
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
