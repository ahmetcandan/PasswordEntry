using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEntry
{
    public class PasswordDTO
    {
        public string ApplicationCode { get; set; }
        public string ApplicationName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return ApplicationName;
        }
    }
}
