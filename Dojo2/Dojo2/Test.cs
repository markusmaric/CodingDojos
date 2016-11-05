using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo2
{
    class Test
    {
        static void Main(string[] args)
        {
            //Stack should be "filled" and executed in this program.
            TestWithObject();
            //TestWithString();
            //TestWithInt();
            Console.ReadLine();
        }

        static void TestWithInt()
        {
            Stack<int> test = new Stack<int>();

            test.Push(2);
            test.Push(3);
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(4);
            test.Pop();
            test.Pop();
            Console.WriteLine("read: {0}", test.Peek());
            test.Pop();
        }

        static void TestWithString()
        {
            Stack<string> test = new Stack<string>();

            test.Push("E1");
            test.Push("E2");
            Console.WriteLine("read: {0}", test.Peek());
            test.Push("E3");
            test.Pop();
            test.Pop();
            Console.WriteLine("read: {0}", test.Peek());
            test.Pop();

        }

        static void TestWithObject()
        {
            Stack<TestObject> test = new Stack<TestObject>();

            test.Push(new TestObject("J'ai cherché", 41));
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(new TestObject("Jump Around", 80));
            Console.WriteLine("read: {0}", test.Peek());
            test.Push(new TestObject("Freedom", 15));
            Console.WriteLine("read: {0}", test.Peek());
            test.Pop();
            Console.WriteLine("read: {0}", test.Peek());
            test.Pop();
            Console.WriteLine("read: {0}", test.Peek());
            test.Pop();
            Console.WriteLine("read: {0}", test.Peek());

        }
    }
}
