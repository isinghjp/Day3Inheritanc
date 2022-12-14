using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Inheritanc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B obj=new B();
            obj.Fun1();

        }
       abstract class A
        {
            public A() 
            {
                Console.WriteLine("Constructor in A");
            }
            public abstract void Fun1();

            //public void Fun1()
            //{
            //    Console.WriteLine("Executing Fun1 in A");
            //}
        }
        class B : A 
        {
            public B() 
            {
                Console.WriteLine("Constructor in B");
            }
            public override void Fun1()      //showding not overriding
            {
                Console.WriteLine("Executing Fun1 in B");
            }
        }
    }
}
