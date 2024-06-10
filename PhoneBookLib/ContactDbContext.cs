using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookLib
{
    public class ContactDbContext: DbContext
    {
       public ContactDbContext(DbContextOptions<ContactDbContext> options)
        : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
