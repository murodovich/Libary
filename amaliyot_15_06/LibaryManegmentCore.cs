using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amaliyot_15_06
{
    public abstract class LibaryManegmentCore
    {

        public LibaryManegment Store { get; set; }

        public LibaryManegmentCore()
        {
            Store = new LibaryManegment();
        }

        public LibaryManegmentCore(List<Book> books, List<User> users)
        {
            Store = new LibaryManegment(books, users);

        }




    }
}
