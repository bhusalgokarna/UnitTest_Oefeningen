using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_Oefeningen
{
    public class User
    {
        public string? MadeBy { get; set; }

        public bool CanceledBy(string user)
        {
            MadeBy = user;
            if (MadeBy == "Admin" || MadeBy == "Self")
            {
                return true;
            }  
            else
              return false;
        }
    }
}
