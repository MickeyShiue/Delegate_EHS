using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D007Func介紹
{
    class Program
    {
        static void Main(string[] args)
        {
            //基本簡介
            Func<MemberInfo, bool> filter = MyFilter;
            var members = GetMembers().Where(MyFilter);

            //前面講到Delegate 的使用時機，當你沒辦法控制的時候，應該要用Delegate
            //示範Select 的型別
            //members.Select
        }

        public static bool MyFilter(MemberInfo member)
        {
            return member.FistrName == "Mickey";
        }

        public static IEnumerable<MemberInfo> GetMembers()
        {
            List<MemberInfo> members = new List<MemberInfo>()
            {
                new MemberInfo{FistrName="Mickey",LastName="Shiue",Gender=true },
                new MemberInfo{FistrName="Tom",LastName="Ting",Gender=true },
            };
            return members;
        }
    }

    public class MemberInfo
    {
        public string FistrName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
    }
}
