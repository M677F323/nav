using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public sealed class PageNumber
    {
        private static int pageNumber = 0;

        public static int pageNum
        {
            get
            {
                return pageNumber;
            }
        }

        public static void setPage(int p)
        {
            pageNumber = p;
        }
    }
}