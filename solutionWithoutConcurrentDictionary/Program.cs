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
                if (!hashing.ContainsKey(c))
                {
                    hashing.Add(c, 1);
                }
            }
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
