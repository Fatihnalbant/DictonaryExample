using System;
//using System.Collections.Generic;

namespace DictonaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(20, "Fatma");
            myDictionary.Add(32, "Cabbar");
            myDictionary.Print();
        }
    }
}
