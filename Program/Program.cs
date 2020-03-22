using System;
using System.Runtime.CompilerServices;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    class Model
    {
        private static readonly object ClassLockObject = new object();

        private static int _classVar;
        static int ClassVar
        {
            get
            {
                lock (ClassLockObject)
                {
                    return _classVar;
                }
            }
            set
            {
                lock (ClassLockObject)
                {
                    _classVar = value;
                }
            }
        }

        private readonly object InstanceLockObject = new object();

        private int _instanceVar;
        int InstanceVar
        {
            get
            {
                lock (InstanceLockObject)
                {
                    return _instanceVar;
                }
            }
            set
            {
                lock (InstanceLockObject)
                {
                    _instanceVar = value;
                }
            }
        }
        


    }
}