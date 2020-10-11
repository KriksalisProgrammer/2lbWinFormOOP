using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lb.Factorial
{
    public static class Storage
    {
         public static Factor[] factors { get; private set; }
         static Storage()
         {
             factors = new Factor[0];
         }
        public static void AddObject(Factor obj)
        {
            var temp = new Factor[factors.Length+1];
            Array.Copy(factors,temp,factors.Length);
            temp[temp.Length - 1] = obj;
            factors = temp;
        }
       
    }
}
