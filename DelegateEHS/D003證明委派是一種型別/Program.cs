using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D003證明委派是一種型別
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            //說明委派 欄位、屬性、事件差異

        }
    }
    public delegate void MyVoidDelegate();
    public class MyClass
    {
        //屬性
        public MyVoidDelegate _delegateProperty { get; set; }

        //欄位
        public MyVoidDelegate _delegateFiled;

        //事件
        public event MyVoidDelegate MyEvent;
    }
}
