using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorBooks.Elements
{
    public class Library : ICollection<Book>
    {
        private List<Book> _books;
        public Library()
        {
            _books = new List<Book>()
            {
                new Book("1984","George Orwell"),
                new Book("To kill a mockingbird","Harper Lee"),
                new Book("Peak","Anders Ericsson"),
                new Book("Sapiens","Yuval Noah Harary"),
                new Book("Hommo Deus","Yuval Noah Harary"),
                new Book("Atomic Habits","James Clear")
            };
        }
        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(_books);
        }
    }
}
