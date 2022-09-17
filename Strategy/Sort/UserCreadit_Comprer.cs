using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sort
{
    public class UserCreadit_Comparer : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
           if(x.Creadit==y.Creadit)
                return 0;
            else if (x.Creadit > y.Creadit)
                return 1;
            else
                return -1;
        }
    }
    public class UserById_Comparer : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            if (x.Id == y.Id)
                return 0;
            else if (x.Id > y.Id)
                return 1;
            else
                return -1;
        }
    }
}
