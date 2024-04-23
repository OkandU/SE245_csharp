using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winbook_cfuller
{
    public class book
    {
        private String title;
        private String authorFirst;
        private String authorLast;
        private Double price;
        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public String AuthorFirst
        {
            get { return authorFirst; }
            set { authorFirst = value; }
        }

        public String AuthorLast
        {
            get { return authorLast; }
            set { authorLast = value; }
        }

        public Double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
