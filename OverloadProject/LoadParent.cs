using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadProject
{
     class LoadParent
    {
        public void Test()
        {
            Console.WriteLine("Parent's Test Method is Called");
        }
        public virtual void Show()  //Overridable Method
        {
            Console.WriteLine("Parent's Show Method is Called");
        }
    }

     class LoadChild : LoadParent
    {
        public void Test(int i)    // Overloading Parent's Test Method in child class
        {
            Console.WriteLine("Child's Test Method is Called");
        }

        public override void Show() //Overriding Parent's Show Method in child class (using override keyword)
        {
            Console.WriteLine("Parent's Show Method has been overriden by child class");
        }


        static void Main()
        {
            LoadChild c = new LoadChild();
            c.Test();
            c.Test(10);
            c.Show();
        }
    }
}
