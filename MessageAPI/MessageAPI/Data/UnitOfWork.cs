using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Data
{
    public class UnitOfWork
    {
        private readonly MessageDBContext _context;
        public UnitOfWork(MessageDBContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
