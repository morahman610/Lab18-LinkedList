using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Object();

            LinkedList list = new LinkedList();
            list.AddAtStart("Adam");
            list.AddAtStart("Cat");
            list.AddAtStart("Mohammed");
            list.AddAtStart(o);
            list.AddAtStart("Shaun");
            list.AddToEnd("Danny");
            list.AddToEnd("Jaide");

            list.RemoveAll("Mohammed");



        }
    }
}
