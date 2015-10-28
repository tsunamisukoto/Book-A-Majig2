using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.DatabaseEntities
{
    public partial class Employee
    {
        public bool CanAddBookings()
        {
           return HasPermission("ADD EDIT BOOKINGS", true);
        }
        public bool HasPermission(string s, bool defaultValue)
        {
            var permission = AccessLevel.Permissions.FirstOrDefault(x => x.PermissionName == s);
            if(permission != null)
            {
                return permission.PermissionValue;
            }
            return defaultValue;
        }
      
    }
}
