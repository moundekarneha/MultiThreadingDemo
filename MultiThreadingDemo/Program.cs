using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    internal class Program
    {
        public static void Test1()
        {
            for (int ii = 1; ii <= 10; ii++)
            {
                Console.WriteLine("Test 1 = " + ii);
            }
            Console.WriteLine("Test 1 Exited ======= ");
        }

        public static void Test2()
        {
            for (int ii = 1; ii <= 10; ii++)
            {
                Console.WriteLine("Test 2 = " + ii);
            }
            Console.WriteLine("Test 2 Exited ======= ");
        }

        public static void Test3()
        {
            for (int ii = 1; ii <= 10; ii++)
            { 
                if (ii == 5)
                {
                    Console.WriteLine("Test 3 going to sleep ");
                    Thread.Sleep(5000); 
                    Console.WriteLine("Test 3 waked up  ");
                }
                Console.WriteLine("Test 3 = " + ii);
            }
            Console.WriteLine("Test 3 Exited ======= ");
        }

        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); 
            t2.Start(); 
            t3.Start();
            t.Name = "MainThread";
            Console.WriteLine("Current executing thread "+Thread.CurrentThread.Name );

            Test1();
            Test2();
            Test3();
            Console.WriteLine("Main Thread Exited ======= ");
            Console.ReadLine();
        }
    }
}
