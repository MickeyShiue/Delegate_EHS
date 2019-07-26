using System;
namespace D001傳統委派Void
{
    //傳統宣告委派方式，缺點很冗長
    public delegate void MyVoidDelegate(string name); //.NET 1.1

    class Program
    {
        static void Main(string[] args)
        {
            MyVoidDelegate myVoidDelegate = new MyVoidDelegate(MyVoidMethod);//必須符合簽章 回傳型別void 與1個string參數
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
