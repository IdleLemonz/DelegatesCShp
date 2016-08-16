using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate d;

            d = DoSomething;
            d += DoSomethingElse;

            d("This is a delegate");

            Console.ReadKey();
        }

        delegate void MyDelegate(string text);        
        static public void DoSomething(string text)
        {
            Console.WriteLine(text);
        }

        static public void DoSomethingElse(string text)
        {
            text = "HAH! I changed your string :P This is the extra function, even though I ran the delegate once.";
            Console.WriteLine(text);
        }


    }
}
