using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D004將委派塞入變數與參數傳遞
{
    public delegate void MyDelegate();

    class Program
    {
        static void Main(string[] args)
        {
            //變數 myDelegate 是委派，並且註冊了MyMethod 給他
            MyDelegate myDelegate = new MyDelegate(MyMethod);

            //將委派當作參數，傳遞給InvokeDelegate這個方法，而參數是一個委派，
            //換句話說也就是傳一個方法給InvokeDelegate
            InvokeDelegate(MyMethod);
        }

        public static void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }

        public static void InvokeDelegate(MyDelegate myDelegate)
        {
            myDelegate.Invoke();
        }
    }
}
