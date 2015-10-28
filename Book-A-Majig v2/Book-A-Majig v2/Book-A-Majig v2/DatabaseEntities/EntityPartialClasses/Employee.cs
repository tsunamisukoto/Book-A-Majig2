using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.DatabaseEntities
{
    public partial class Employee
    {
        public string FullName
        {
            get
            {
                return this.FirstName+ " " + this.LastName;
              
            }
        }
        
    }
}
