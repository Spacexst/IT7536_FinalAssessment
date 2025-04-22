using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAuthorEditor
{
    class Book

    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public List<string> Genres { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"{Title} by {Author} ({Category})";
        }
    }
}
