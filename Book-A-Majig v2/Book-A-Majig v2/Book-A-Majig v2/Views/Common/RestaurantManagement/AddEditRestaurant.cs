using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.Objects;
using System.Windows.Forms;
using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;

namespace Book_A_Majig_v2
{
    public partial class AddEditRestaurant : Form
    {
        public AddEditRestaurant()
        {
            InitializeComponent();
        }

        public Employee user { get; set; }
        public int? RestaurantID { get; set; }
        private Restaurant Restaurant;

        private void button1_Click(object sender, EventArgs e)
        {
            var unitOfWork = new UnitOfWork();
            if(RestaurantID== null)
            {
                unitOfWork.RestaurantRepository.Insert(new Restaurant() { Location = tbLocation.Text, Name = tbName.Text, Capacity = (int)tbCapacity.Value });

            }
            else
            {
                Restaurant.Name = tbName.Text;
                Restaurant.Capacity = (int)tbCapacity.Value;
                Restaurant.Location = tbLocation.Text;
                unitOfWork.RestaurantRepository.Update(Restaurant);
            }
            unitOfWork.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void AddEditRestaurant_Load(object sender, EventArgs e)
        {
            if(RestaurantID!=null)
            {
                var unitOfWork = new UnitOfWork();
                Restaurant = unitOfWork.RestaurantRepository.Get(x => x.Id == RestaurantID).FirstOrDefault();
                tbLocation.Text = Restaurant.Location;
                tbName.Text = Restaurant.Name;
                tbCapacity.Value = Restaurant.Capacity;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
