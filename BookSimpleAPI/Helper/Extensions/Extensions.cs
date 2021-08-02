using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSimpleAPI.Helper.Extensions
{
    public static class Extensions
    {

        public static int ToInt(this string str)
        {
            int.TryParse(str, out var returnValue);
            return returnValue;
        }
    }
}
