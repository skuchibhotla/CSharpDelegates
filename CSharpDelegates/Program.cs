using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(CallBack);
        }

        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }

    public class MyClass
    {
        // MyClass will communicate with Program class using this delegate. 
        public delegate void CallBack(int i);
        public void LongRunning(CallBack obj)
        {
            for(var i = 0; i<1000; i++)
            {
                // Does something
                obj(i);
            }
        }
    }
}
