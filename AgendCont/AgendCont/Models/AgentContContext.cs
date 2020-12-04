using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AgendCont.Models
{
    public class AgentContContext : DbContext
    {
        public AgentContContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<AgendCont.Models.Person> People { get; set; }

        public System.Data.Entity.DbSet<AgendCont.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<AgendCont.Models.Contact> Contacts { get; set; }

        public System.Data.Entity.DbSet<AgendCont.Models.Tipo> Tipoes { get; set; }        
    }
}