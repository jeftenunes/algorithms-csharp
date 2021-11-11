using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    public class Input
    {
        public static IEnumerable<int> ReadIntsFromInput(string filePath)
        {
            string line = default;
            using var reader = File.OpenText(filePath);

            while ((line = reader.ReadLine()) != null)
            {
                yield return int.Parse(line);
            }
        }
    }
}
