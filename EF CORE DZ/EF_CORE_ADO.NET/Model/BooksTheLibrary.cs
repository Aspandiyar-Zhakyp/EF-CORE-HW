using System;
using System.Collections.Generic;
using System.Text;

namespace BestLibrary
{
    using EF_CORE_ADO.NET.Model;
    using System;
    using System.Collections.Generic;
    
    public partial class BooksInLibrary
    {
        public int Id { get; set; }
        public Nullable<int> Id_book { get; set; }
        public Nullable<int> Id_author { get; set; }
        public Nullable<int> Id_client { get; set; }
    
        public virtual Author Authors { get; set; }
        public virtual Books Books { get; set; }
        public virtual Сlients Сlient { get; set; }
    }
}
