using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
     interface ITestInterface1
    {
       public abstract void Add(int a, int b);  //public and abstract keyword is not required
    }
    interface ITestInterface2:ITestInterface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass: ITestInterface2
    {
        public void Add(int a,int b)   //override keyword is not required
        {
            Console.WriteLine(a+b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        
        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(10, 20);
            obj.Sub(20, 10);

            ITestInterface2 i = obj;   //we can create parents(interface) reference by using childs instance and call the child class overridden members
            i.Add(10, 20);
            i.Sub(20, 10);

            Console.BackgroundColor = ConsoleColor.Blue;


            
        }
    }
}
