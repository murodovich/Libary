using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amaliyot_15_06
{
    public class Book
    {

        public Guid Id { get; set; }    
        public string Name { get; set; }

        public string Category { get; set; }   

        public string Description { get; set; } 


        public string Author { get; set; }

        public Guid ReaderId { get; set; }

        public Book(string name, string author, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Author = author;
            Description = description;


        }

        

        
    }
}
