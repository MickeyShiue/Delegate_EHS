using System;
using System.Collections.Generic;

namespace D006Predicate介紹
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> MyPredicate = MyPredicateMethod;

            List<string> MyLsit = new List<string>()
            {
                "Mickey","David","Tom"
            };
            MyLsit.Find(r => r.Length > 4);
        }

        public static bool MyPredicateMethod(string name)
        {
            return name.Length > 4;
        }
    }
}