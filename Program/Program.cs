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
        static readonly object ClassLockObject = new object();

        static int classvar
        {
            get { return classvar; }
            set
            {
                lock (ClassLockObject)
                {
                    classvar = value;
                }
            }
        }

        readonly object InstanceLockObject = new object();

        int instanceVar
        {
            get { return instanceVar;}
            set
            {
                lock (InstanceLockObject)
                {
                    instanceVar = value;
                }
            }
        }
        


    }
}