using MessageAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Data
{
    public class MessageDBContext: DbContext
    {
        public MessageDBContext(DbContextOptions<MessageDBContext> options) : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<USER> users { get; set; }
        public DbSet<CONTACT> conttacts { get; set; }
        public DbSet<MESSAGE> messages { get; set; }


    }
}
