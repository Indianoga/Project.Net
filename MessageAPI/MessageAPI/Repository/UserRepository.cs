using MessageAPI.Data;
using MessageAPI.Interfaces;
using MessageAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MessageDBContext _context;

        public UserRepository(MessageDBContext context)
        {
            _context = context;
        }

        public long CreateUser(USER user)
        {
            long id = _context.users.Where(x => x.LOGIN == user.LOGIN && x.PASSWORD == user.PASSWORD).AsNoTracking().FirstOrDefault() != null ?
                     _context.users.Where(x => x.LOGIN == user.LOGIN && x.PASSWORD == user.PASSWORD).AsNoTracking().FirstOrDefault().ID : 0;

            if(id > 0)
            {
                return 0;
            }
            else
            {
                _context.users.Add(user);
                _context.SaveChanges();
                id = user.ID;
                return id;
                
            }
        }

        public List<USER> GetListUser()
        {
            return _context.users.ToList();
        }

        public USER GetUserById(long id)
        {
            USER user = _context.users.Where(x => x.ID == id).AsNoTracking().FirstOrDefault();


            if(user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
            
        }
    }
}
