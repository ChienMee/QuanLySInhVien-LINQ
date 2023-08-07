using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Core.Models
{
    public class User
    {
        #region Fields
        private string _UserName;
        private string _Password;
        private string _Role;
        #endregion

        #region Getter/Setter
        public string UserName
        {
            get 
            {
                return _UserName; 
            }
            set 
            {
                _UserName = value; 
            }
        }
        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }
        public string Role
        {
            get
            {
                return _Role;
            }
            set
            {
                _Role = value;
            }
        }
        #endregion
    }
}
