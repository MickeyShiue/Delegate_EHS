using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D002傳統委派具有回傳值
{
    public delegate string MyStringDelegate(string name); //.NET 1.1
    class Program
    {
        static void Main(string[] args)
        {
            MyStringDelegate myStringDelegate = new MyStringDelegate(MyStringMethod);
            myStringDelegate += MyStringMethod2;
            var result = myStringDelegate.Invoke(string.Empty);
            Console.WriteLine(result);
            Console.Read();

            //C# 2.0 開始支援
            //不再一定需要依賴於某一個執行個體方法，或是靜態方法。而可以直接透過delegate關鍵字宣告匿名方法(Anonymous Method)
            MyStringDelegate mystringdelegate2 = delegate (string name)
            {
               return name;
            };  
            //JS 
            //$.post("ajax/test.html", function(data) {
            //    $(".result").html(data);
            //});
            //$.post("ajax/test.html",MyCallBackfunction);
        }

        public static string MyStringMethod(string name) => "MyStringMethod";   
        public static string MyStringMethod2(string name) => "MyStringMethod2";
    }
}
