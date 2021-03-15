using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EF_CORE_ADO.NET.Model;


namespace EF_CORE_ADO.NET.User
{
    public partial class LibraryEntity : DbContext
    {
        public LibraryEntity()
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BooksTheLibrary> BooksTheLibrary  { get; set; }
        public virtual DbSet<Сlients> Сlient { get; set; }
    }
}
