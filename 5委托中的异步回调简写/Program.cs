﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5委托中的异步回调简写
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("★主1====" + DateTime.Now.ToString() + "================" + Thread.CurrentThread.ManagedThreadId);
            Func<string> func = () =>
            {
                Console.WriteLine("☆支1====" + DateTime.Now.ToString() + "================" + Thread.CurrentThread.ManagedThreadId);
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("DoTestFun()...");
                }
                return MethodBase.GetCurrentMethod().Name + "方法返结果，执行该方法的线程id:" + Thread.CurrentThread.ManagedThreadId;
            };

            Console.WriteLine("func.Method---" + func.Method);
            var iar = func.BeginInvoke(ar =>
            {
                Console.WriteLine("☆支2====" + DateTime.Now.ToString() + "================" + Thread.CurrentThread.ManagedThreadId);
                var fun = ar.AsyncState as Func<string>;
                var result = fun.EndInvoke(ar);
                Console.WriteLine("☆支3====" + DateTime.Now.ToString() + "================" + Thread.CurrentThread.ManagedThreadId);

                Console.WriteLine("result:" + result);

                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(MethodBase.GetCurrentMethod().Name + "()...");
                }
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + "方法返结果，执行该方法的线程id:" + Thread.CurrentThread.ManagedThreadId);


            }, func);
            Console.WriteLine("aaa:" + iar.ToString());
            Console.WriteLine("★主2====" + DateTime.Now.ToString() + "================" + Thread.CurrentThread.ManagedThreadId);


            for (int i = 0; i < 8; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(MethodBase.GetCurrentMethod().Name + "().★主=.." + Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("★主3====" + DateTime.Now.ToString() + "================" + Thread.CurrentThread.ManagedThreadId);

            Console.ReadKey();

        }
    }
}

