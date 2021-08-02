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

        public static List<Book> ByDateAndTags(this List<Book> str, int days, string tags)
        {
            if (string.IsNullOrEmpty(tags) || tags.Length == 0) return null;
            else if (days < 0) return null;
            else
            {
                var dt = DateTime.Now.AddDays(days);
                if(tags.Equals("stor") || tags.Equals("big") || tags.Equals("bigger"))
                {
                    return str.Where(r => r.DateTime > dt).ToList();
                }
                else if(tags.Equals("lille") || tags.Equals("less"))
                {
                    return str.Where(r => r.DateTime < dt).ToList();
                }
                else
                {
                    return null;
                }
            }

        }

    }
}
