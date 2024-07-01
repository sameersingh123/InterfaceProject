using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    interface Interface1
    {
       public abstract void Test();  //public and abstract keyword is not required(optional)
        void Show();
    }

    interface Interface2 
    {
        void Test();
        void Show();
    }


    class MultipleInheritanceTest : Interface1, Interface2
    {
        public void Test()            //normal interface implementation(override keyword is not required)
        {
            Console.WriteLine("Interfaces method implemented in child class");
        }

        void Interface1.Show()       //explicit interface implementation
        {
            Console.WriteLine("Declared in Interface1 and implemented in class");
        }
        void Interface2.Show()       //explicit interface implementation
        {
            Console.WriteLine("Declared in Interface2 and implemented in class");
        }

        static void Main()
        {
            MultipleInheritanceTest multipleInheritanceTest = new MultipleInheritanceTest();
            multipleInheritanceTest.Test();



            //For explicit interface implementation, we cannot call through child's instance, we can create Parents(interface) reference using child's instance and call the method

            Interface1 i1 = multipleInheritanceTest;  //we can create parents(interface) reference by using childs instance and call the child class overridden members
            i1.Show();
            Interface2 i2 = multipleInheritanceTest;  //we can create parents(interface) reference by using childs instance
            i2.Show();

            Console.BackgroundColor = ConsoleColor.DarkBlue;

            

        }
    }
}
