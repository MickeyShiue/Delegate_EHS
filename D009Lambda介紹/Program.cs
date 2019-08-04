using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace D009Lambda介紹
{
    class Program
    {
        static void Main(string[] args)
        {
            //NET 3.5之後，帶大家實作一遍
            //Action<string> MyAction = 

            //Func<string, bool> Myfilter =

            //Predicate<string> MyPredicate =

            //Expression<Func<string, bool>> Myexception = 

            //所以何謂Lambda?，我自己會用一句話總結......

            List<string> MyList = new List<string>() { "AAAA", "BBB", "CC" };

            //示範三種 Where 寫法，早期、中期、後期
            //MyList.Where();

            //MyList.Where();

            //MyList.Where();

        }
    }
}

















////NET 3.5之後
//Action<string> MyAction = Name => Console.WriteLine(Name);

//Func<string, bool> Myfilter = Name => Name.Length > 1;

//Predicate<string> MyPredicate = Name => Name.Length > 1;

//Expression<Func<string, bool>> Myexception = Name => Name.Length > 1;

//List<string> MyList = new List<string>() { "AAAA", "BBB", "CC" };

////示範三種 Where 寫法
//MyList.Where(delegate (string Name) { return Name.Length > 1; });

//MyList.Where((Name) => { return Name.Length > 1; });

//MyList.Where(r => r.Length > 1);






