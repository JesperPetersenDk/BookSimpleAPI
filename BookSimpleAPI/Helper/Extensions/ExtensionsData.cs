using BookSimpleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSimpleAPI.Helper.Extensions
{
    public class ExtensionsData
    {
        public List<Book> ByDateAndTags(List<Book> list, int days, string tags)
        {
            if (string.IsNullOrEmpty(tags) || tags.Length == 0) return null;
            else if (days < 0) return null;
            else
            {
                var dt = DateTime.Now.AddDays(days);
                if (tags.Equals("stor") || tags.Equals("big") || tags.Equals("bigger"))
                {
                    return list.Where(r => r.DateTime > dt).ToList();
                }
                else if (tags.Equals("lille") || tags.Equals("less"))
                {
                    return list.Where(r => r.DateTime < dt).ToList();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
