using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    public static class HelperMethods
    {
        public static bool Equals<T>(this IEnumerable<T> list1, IEnumerable<T> list2)
            where T : IComparable
        {
            if (!(list1 != null && list2 != null)) return false;
            if (list1.Count() != list2.Count()) return false;
            var tmpList1 = list1.ToArray();
            var tmpList2 = list2.ToArray();
            for (var i = 0; i < list1.Count(); i++)
            {
                if (!tmpList1[i].Equals(tmpList2[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}