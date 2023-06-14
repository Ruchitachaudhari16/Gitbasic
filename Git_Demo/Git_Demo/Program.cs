using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GitDemoClass gitDemo=new GitDemoClass();
            gitDemo.Demo();
            gitDemo.Demo2();
            Console.ReadLine();
        }
    }
}
