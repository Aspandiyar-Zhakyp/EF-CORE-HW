using System;
using System.Collections.Generic;
using System.Text;

namespace BestLibrary
{
    using System;
    using System.Collections.Generic;

    public partial class Author
    {
        public Author()
        {
            this.BooksInLibrary = new HashSet<BooksInLibrary>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<BooksInLibrary> BooksInLibrary { get; set; }
    }
}
