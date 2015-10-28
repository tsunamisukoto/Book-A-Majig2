using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Book_A_Majig_v2.Services;

namespace Book_A_Majig_v2.DatabaseEntities
{
    public partial class UserInformation : UserControl
    {
        public UserInformation()
        {
            InitializeComponent();
        }
        private int? uID;
        public int? UserID
        {
            get
            {
                return uID;
            }
            set
            {
                uID = value;
                if(value!=null)
                {
                    var user = new UnitOfWork().EmpoyeeRepository.Get(x => x.Id == uID, includeProperties: "AccessLevel").FirstOrDefault();
                    lblFullName.Text = user.FullName;
                    lblAccessLevel.Text = user.AccessLevel.Name;
                }
             
            }
        }
    }
}
