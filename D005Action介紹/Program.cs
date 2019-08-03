using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D005Action介紹
{
    public delegate void MyDelegate(string firstName,string LastName);
    class Program
    {
        static void Main(string[] args)
        {
            //傳統
            MyDelegate myDelegate = MyMethod;
            myDelegate.Invoke("Mickey", "Shiue");

            //簡化版
            Action<string, string> action = MyMethod;
            action.Invoke("Mickey", "Shiue");
 
            Console.Read();
            //但是......
        }

        public static void MyMethod(string firstName, string LastName)
        {
            Console.WriteLine(string.Format("{0}-{1}", firstName, LastName));
        }
    }
}
