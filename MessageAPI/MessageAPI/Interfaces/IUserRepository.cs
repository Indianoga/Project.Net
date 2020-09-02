using MessageAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageAPI.Interfaces
{
    public interface IUserRepository
    {

        public long CreateUser(USER user);
        public USER GetUserById(long id);
        public List<USER> GetListUser();

    }
}
