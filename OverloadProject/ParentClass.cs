using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
     class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Parent's Test1 Method is Called");
        }
        public void Test2() 
        {
            Console.WriteLine("Parent's Test2 Method is Called");
        }
    }
     class ChildClass : ParentClass
    {
        public override void Test1()    //Method Overriding
        {
            Console.WriteLine("Child's Test1 Method is Called");
        }

        public new void Test2()         //Method Hiding/Shadowing
        {
            Console.WriteLine("Child's Test2 Method is Called");
        }

        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        // Difference between Method Overriding and Method Hiding : In overriding, a parent class reference can call a child class overridden members but in hiding a parent class reference cannot call a child class method which is reimplemented using the hiding approach (new keyword).

        static void Main()
        {
            ChildClass c = new ChildClass();
            ParentClass p = c;
            p.Test1(); //Invokes child class's Test1 method as it is overridden so p is able to recognize  it(virual means taking persmission to override) and also overridden members are not considered as pure child class members
            p.Test2(); //Invokes parent class's Test2 method as it is hidden so p is not able to recognize it because hidden members are considered as pure child class members and not accessable to parents reference
            c.Test1();
            c.Test2();
        }

        
    }
   
}
