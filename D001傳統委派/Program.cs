using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D001傳統委派Void
{
    //傳統宣告委派方式
    //缺點很冗長
    public delegate void MyVoidDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            MyVoidDelegate myVoidDelegate = new MyVoidDelegate(MyVoidMethod);
            myVoidDelegate += MyVoidMethod2;          
            myVoidDelegate -= MyVoidMethod2;
            myVoidDelegate.Invoke("Mickey");
        }

        public static void MyVoidMethod(string name)
        {
            Console.WriteLine("Void：" + name);
        }

        public static void MyVoidMethod2(string name)
        {
            Console.WriteLine("Void2:" + name);
        }
    }
}
