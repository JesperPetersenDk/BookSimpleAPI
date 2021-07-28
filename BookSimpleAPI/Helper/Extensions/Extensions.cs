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

        public static List<Book> ByDateAndTags(this List<Book> str, int days, string tags)
        {
            if (string.IsNullOrEmpty(tags) || tags.Length == 0) return str;
            else if (days < 0) return str;
            else
            {
                var dt = DateTime.Now.AddDays(days);
                if(tags.Equals("større") || tags.Equals("big") || tags.Equals("bigger") || tags.Equals("bigger than"))
                {
                    return (List<Book>)str.Where(r => r.DateTime > dt);
                }
                else if(tags.Equals("lille") || tags.Equals("mindre") || tags.Equals("less") || tags.Equals("less than"))
                {
                    return (List<Book>)str.Where(r => r.DateTime < dt);
                }
                else
                {
                    return str;
                }
            }

        }

    }
}
