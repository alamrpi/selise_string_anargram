using System;
using System.Collections.Generic;
using System.Linq;

namespace AnagramsString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] anagramsList = Console.ReadLine().Split(',');

            List<List<string>> result = new List<List<string>>();

            foreach (var item in anagramsList)
            {

                if (!result.Any(f => f.Any(l => l.ToLower() == item.ToLower())))
                {
                    var firstString = item.ToCharArray().ToList();

                    foreach (var reItem in anagramsList)
                    {
                        if (item != reItem)
                        {
                            var secondString = reItem.ToCharArray().ToList();
                            bool isAnargramString = true;
                            foreach (var l in firstString)
                            {
                                isAnargramString = secondString.Any(x => x.ToString().ToLower() == l.ToString().ToLower()) && isAnargramString;
                            }

                            if (isAnargramString)
                            {
                                result.Add(new List<string>() { item, reItem });
                            }
                        }
                    }
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item[0]}, {item[1]}");
            }

            Console.ReadKey();
        }
    }
}
