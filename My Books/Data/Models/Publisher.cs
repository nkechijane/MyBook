using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books.Data.Models
{
    public class Publisher
    {
        public int id { get; set; }
        public string Name { get; set; }

        //Navigational Properties
        public List<Book> Books { get; set; }
    }
}
