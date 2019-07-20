using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoStackTrace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Method1();
        }

        public static void Method1()
        {
            Method2();
        }

        public static void Method2()
        {
            Method3();
        }

        public static void Method3()
        {
            Method4();
        }

        public static void Method4()
        {
            Method5();
        }

        public static void Method5()
        {
            throw new Exception();
        }
    }
}