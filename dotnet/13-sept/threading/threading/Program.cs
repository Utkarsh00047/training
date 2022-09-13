using System;
using System.Threading;

namespace threading
{
    public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
            {
                static void Main(string[] args)
                {

                    Console.WriteLine("Main Thread starts");
                    Thread t1 = new Thread(method1)
                    {
                        Name = "Thread1"
                    };
                    Thread t2 = new Thread(method2)
                    {
                        Name = "Thread2"
                    };
                    Thread t3 = new Thread(method3)
                    {
                        Name = "Thread3"
                    };


                    t1.Start();
                    t2.Start();
                    t3.Start();
                    Console.WriteLine("Main thread start");

                }
                private static void method1(object obj)
                {
                    Console.WriteLine("m1 start", Thread.CurrentThread.Name);
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine("Method1: " + i);
                    }
                    Console.WriteLine("m1 end", Thread.CurrentThread.Name);
                }
                private static void method2(object obj)
                {
                    Console.WriteLine("m2 start", Thread.CurrentThread.Name);
                    for (int i = 1; i <= 5; i++)
                    {
                        if (i == 3)
                        {
                            Console.WriteLine("perform thread opearion start");
                            Thread.Sleep(5000);
                            Console.WriteLine("thread operation compleated");
                        }
                    }
                    Console.WriteLine("m2 end", Thread.CurrentThread.Name);
                }
                private static void method3(object obj)
                {
                    Console.WriteLine("m3 start", Thread.CurrentThread.Name);
                    for (int i = 1; i <= 5; i++)
                    {
                        if (i == 3)
                        {
                            Console.WriteLine("threading start");
                            Thread.Sleep(5000);
                            Console.WriteLine("threading compleated");
                        }
                    }
                    Console.WriteLine("end", Thread.CurrentThread.Name);
                }
            }
        }
    