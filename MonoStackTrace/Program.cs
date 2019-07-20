using System;

using NLog;

namespace MonoStackTrace
{
    public class Program
    {
        private static ILogger Logger = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            Logger.Info("Started main.");
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Logger.Error(ex);
            }

            Console.ReadLine();
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
            throw new Exception("test exception");
        }
    }
}