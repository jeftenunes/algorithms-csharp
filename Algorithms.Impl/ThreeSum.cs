using System;
using System.Collections.Generic;

namespace Algorithms.Impl
{
    /// <summary>
    /// Encontrar no array os conjuntos de 3 numeros que somados, dao 0
    /// </summary>
    public class ThreeSum
    {
        public static List<((int, string), (int, string), (int, string))> Solve(int[] arr)
        {
            int counter = default;
            var length = arr.Length;
            List<((int, string), (int, string), (int, string))> results = new List<((int, string), (int, string), (int, string))>();

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    for (int k = j + 1; k < length; k++)
                    {
                        if (arr[i] + arr[j] + arr[k] == 0)
                        {
                            results.Add(((arr[i], $"Position {i}"), (arr[j], $"Position {j}"), (arr[k], $"Position {k}")));
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
            return results;
        }
    }
}
