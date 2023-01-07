using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int Page {  get; set; }
        public string? Description { get; set; }

        public List<BookCategory> BookCategories { get; set; }
        public int AuthorId { get; set; }

    }
}
