using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CORE_ADO.NET.Model
{
    public partial class Books
    {
        public Books()
        {
            this.BooksTheLibrary = new HashSet<BooksTheLibrary>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<BooksTheLibrary> BooksTheLibrary { get; set; }
    }
}
