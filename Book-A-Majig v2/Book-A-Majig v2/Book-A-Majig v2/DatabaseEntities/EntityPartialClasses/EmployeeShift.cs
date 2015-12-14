using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Book_A_Majig_v2.DatabaseEntities
{
    public partial class EmployeeShift
    {
        public Employee Employee
        {
            get
            {
                var emp = this.EmployeeShiftAssignments.FirstOrDefault(x => x.DateInactive == null);
                if (emp != null)
                    return emp.Employee;
                else
                    return null;
            }
          
        }
    }
}
