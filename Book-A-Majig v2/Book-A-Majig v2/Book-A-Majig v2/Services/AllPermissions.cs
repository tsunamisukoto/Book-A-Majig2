using Book_A_Majig_v2.DatabaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.Services
{
    class AllPermissions
    {
        public static List<Permissions> PermissionList()
        {
            var retList = new List<Permissions>();

            retList.Add(new Permissions() { PermissionName = "ADD EDIT BOOKINGS", PermissionValue=true });
            retList.Add(new Permissions() { PermissionName = "VIEW ROSTERS", PermissionValue=false });
            retList.Add(new Permissions() { PermissionName = "ADD EDIT ROSTERS", PermissionValue=true });
            retList.Add(new Permissions() { PermissionName = "ADD EDIT USERS", PermissionValue=true });
            return retList;
        }
    }
}
