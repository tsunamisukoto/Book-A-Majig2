using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Common.RestaurantManagement
{
    public partial class ViewRestaurants : Form
    {
        public Employee User { get; set; }

        public ViewRestaurants()
        {
            InitializeComponent();
        }
        private List<Restaurant> restaurantsList;
        private void ViewRestaurants_Load(object sender, EventArgs e)
        {
            Rebind();
        }
        private void Rebind()
        {
            var unitOfWork = new UnitOfWork();
            restaurantsList = unitOfWork.RestaurantRepository.Get(includeProperties: "Employees").ToList();
            dgvRestaurants.DataSource = restaurantsList.Select(x => new { Name = x.Name, Location = x.Location , EmployeeCount= x.Employees.Count}).ToList();
            dgvRestaurants.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            AddEditRestaurant c = new AddEditRestaurant();
            c.user = User;
            c.ShowDialog();
            if (c.DialogResult == DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/
            if (dgvRestaurants.SelectedRows.Count > 0)
            {

                AddEditRestaurant c = new AddEditRestaurant();
                c.user = User;
                c.RestaurantID = restaurantsList[dgvRestaurants.SelectedRows[0].Index].Id;
                c.ShowDialog();
                if (c.DialogResult == DialogResult.OK)
                {
                    Rebind();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*TO DO: Permissions*/

            ManageRestaurantEmployees c = new ManageRestaurantEmployees();
            c.user = User;
            c.RestaurantID = restaurantsList[dgvRestaurants.SelectedRows[0].Index].Id;
            c.ShowDialog();
            if (c.DialogResult == DialogResult.OK)
            {
                Rebind();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
