using System;
using System.Collections.Generic;
using System.Text;

namespace EF_CORE_ADO.NET.Model
{
    public partial class Сlients
    {
        public Сlients()
        {
            this.BooksTheLibrary = new HashSet<BooksTheLibrary>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> IsDebtor { get; set; }

        public virtual ICollection<BooksTheLibrary> BooksTheLibrary { get; set; }
    }
}
