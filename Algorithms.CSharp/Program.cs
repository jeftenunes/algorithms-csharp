using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Algorithms.Impl;

namespace Algorithms.Test
{
    class Program
    {
        static void Main(string[] args)
        { 
            var _1KInts = Input.ReadIntsFromInput(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Data\{1}Kints.txt")).ToList();
            var _2KInts = Input.ReadIntsFromInput(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Data\{2}Kints.txt")).ToList();
            var _4KInts = Input.ReadIntsFromInput(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Data\{4}Kints.txt")).ToList();
            var _8KInts = Input.ReadIntsFromInput(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Data\{8}Kints.txt")).ToList();
            var _16KInts = Input.ReadIntsFromInput(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"Data\{16}Kints.txt")).ToList();

            Stopwatch watcher = new Stopwatch();
            watcher.Start();
             
            var results1K = ThreeSum.Solve(_1KInts.ToArray());

            watcher.Stop();
            Console.WriteLine($"Elapsed, 1k ints: {watcher.Elapsed}");
        }
    }
}
