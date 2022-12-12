using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAula1.Models;

namespace WebAppAula1.Data
{
    public class WebAppAula1Context : DbContext
    {
        public WebAppAula1Context (DbContextOptions<WebAppAula1Context> options)
            : base(options)
        {
        }

        public DbSet<WebAppAula1.Models.Book> Book { get; set; } = default!;

        public DbSet<WebAppAula1.Models.Author> Author { get; set; } = default!;
    }
}
