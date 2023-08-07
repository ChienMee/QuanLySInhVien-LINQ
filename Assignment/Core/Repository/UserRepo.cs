using Assignment.Core.Context;
using Assignment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Repository
{
    public class UserRepo : IUserRepo
    {
        private readonly UserDbContext context;
        public UserRepo(UserDbContext context) 
        {
            this.context = context;
        }
        public User GetUserByUserName(string username)
        {
            return context.Users.Find(username);
        }
        public string GetUserRole(string username)
        {
            var eUser = GetUserByUserName(username);
            return eUser.Role;
        }
        public bool Login(string username, string password)
        {
            var eUser = GetUserByUserName(username);
            if (eUser != null && password == eUser.Password )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
