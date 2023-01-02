using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class BookList : List<Book>
    {

        public IEnumerable<string> Names => this.Select(x => x.Name);
        public IEnumerable<string> Authors => this.Select(x => x.Author);
        public IEnumerable<string> Years => this.Select(x => x.Year.ToString());

        public BookList(IEnumerable<Book> books) : base(books)
        {
        }

        public BookList() : base()
        {
        }

        public IEnumerable<string> GetColumnOutputList()
        {
            List<string> columnOutputList = new List<string>();
            columnOutputList.AddRange(this.Select(x => x.Name));
            columnOutputList.AddRange(this.Select(x => x.Author));
            columnOutputList.AddRange(this.Select(x => x.Year.ToString()));
            return columnOutputList;
        }

        public IEnumerable<string> GetRowOutputList()
        {
            List<string> rowOutputList = new List<string>();
            foreach (Book book in this)
            {
                rowOutputList.Add(book.Name);
                rowOutputList.Add(book.Author);
                rowOutputList.Add(book.Year.ToString());
            }
            return rowOutputList;
        }
    }
}
