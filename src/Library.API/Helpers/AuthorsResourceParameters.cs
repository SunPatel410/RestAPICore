using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.API.Helpers
{
    public class AuthorsResourceParameters
    {
        public const int maxPageSize = 20;

        public int PageNumber { get; set; } = 1;
        public int _pageSize = 10;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = (value > maxPageSize) ? maxPageSize : value; }
        }

        public string Genre { get; set; }
        public string SearchQuery { get; set; }
    }
}
