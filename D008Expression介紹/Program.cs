using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace D008Expression介紹
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int>> expr = r => r * 2; // 將Lambda 轉換成樹狀資料結構
            Func<int, int> Myfunc = expr.Compile();// 將樹狀結構逆向轉為程式碼，並存入委派物件.
            Console.WriteLine(Myfunc(10));// 印出 20.

            ParameterExpression p = Expression.Parameter(typeof(int), "r");//定義傳入參數型別及參數名稱
            ConstantExpression c = Expression.Constant(2);//定義恆數 2
            BinaryExpression b = BinaryExpression.Multiply(p, c);//定義變數間的操作動作 `*`
            LambdaExpression l = Expression.Lambda(b, p); //將多個 expression 組成 lambda expression
            Expression<Func<int, int>> e = (Expression<Func<int, int>>)l;//將 lambda expression 轉成  `Expression<TDelegate>`
            Console.WriteLine(e.Compile()(10));// 印出 20.
        }
    }
}
