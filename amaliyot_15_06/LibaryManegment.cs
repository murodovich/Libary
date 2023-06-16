using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amaliyot_15_06
{
    public class LibaryManegment
    {

        public List<Book> Books;
        public List<User> Users;


        public LibaryManegment()
        {
            Books = new List<Book>();
            Users = new List<User>();

        }

        public LibaryManegment(List<Book> books, List<User> users)
        {
            Books = Books;
            Users = Users;  
        }


    }
}
