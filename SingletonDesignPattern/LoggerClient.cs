using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns
{
    class LoggerClient
    {
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new

            Logger s1 = Logger.GetInstance();
            // Test for same instance
            s1.WriteLineToLog("=================================================");
            s1.WriteLineToLog("Line from Logger "+ Logger.GetInstance().GetHashCode());
            s1.WriteLineToLog("=================================================");
            s1.WriteLineToLog(DateTime.Now.ToString()+" Log Message");


            Logger s2 = Logger.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("s1=s2");
                s2.WriteLineToLog("s1=s2");

            }
            // Test for same instance
            s2.WriteLineToLog("=================================================");
            s2.WriteLineToLog("Line from Logger " + Logger.GetInstance().GetHashCode());
            s2.WriteLineToLog("=================================================");
            s2.WriteLineToLog(DateTime.Now.ToString() + " Log Message");
            // Wait for user

            // Test for same instance
            Logger.GetInstance().WriteLineToLog("=================================================");
            Logger.GetInstance().WriteLineToLog("Line from Logger " + Logger.GetInstance().GetHashCode());
            Logger.GetInstance().WriteLineToLog("=================================================");
            Logger.GetInstance().WriteLineToLog(DateTime.Now.ToString() + " Log Message");

            Logger.WriteLine("jhfh fhtfuyf");
            AnotherLogCall();
            Console.ReadKey();
        }

        static void AnotherLogCall()
        {
            Logger.GetInstance().WriteLineToLog("=================================================");
            Logger.GetInstance().WriteLineToLog("Line from AnotherLogCall " + Logger.GetInstance().GetHashCode());
            Logger.GetInstance().WriteLineToLog("=================================================");
            Logger.GetInstance().WriteLineToLog(DateTime.Now.ToString() + " Log Message");
            f2();
        }




        static void f2() {
            Logger.WriteLine("jgfhftygfhgfhgfghfgh");
        }

    }
}
