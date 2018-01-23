using System;

namespace RemotingOne
{
    [Serializable]
    public class MySerialized
    {
        public MySerialized(int val)
        {
            a = val;
        }
        public void Foo()
        {
            Console.WriteLine("MySerialized.Foo called");
        }
        public int A
        {
            get
            {
                Console.WriteLine("MySerialized.A called");
                return a;
            }
            set
            {
                a = value;
            }
        }
        protected int a;
    }

    public class Hello : MarshalByRefObject
    {
        public Hello()
        {
            Console.WriteLine("Hello constructor");
        }

        public string Greeting(string name)
        {
            Console.WriteLine("Greeting called");
            return "Hello, " + name;
        }

        public MySerialized GetMySerialized()
        {
            return new MySerialized(42);
        }
    }
}
