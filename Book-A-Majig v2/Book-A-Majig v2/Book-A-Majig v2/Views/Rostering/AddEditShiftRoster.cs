using Book_A_Majig_v2.DatabaseEntities;
using Book_A_Majig_v2.Services;
using Book_A_Majig_v2.Views.Rostering.ReusableControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Book_A_Majig_v2.Views.Rostering
{
    public partial class AddEditShiftRoster : Form
    {
        public Employee User { get; set; }
        public int DayOfWeek { get; set; }
        public int RosterId { get; set; }
        private Shift WorkingShift;
        private List<Employee> AvailableEmployees;
        public AddEditShiftRoster()
        {
            InitializeComponent();

        }
        List<EmployeeShift> ShiftSlots = new List<EmployeeShift>();
        private void button4_Click(object sender, EventArgs e)
        {
            var newshift = new EmployeeShift() { StartTime = dateTimePicker2.Value, EmployeeShiftCategory = new EmployeeLevelCategory() { MinLevelStaffMember = 5, Name = "SSS" } };
            if (checkBox1.Checked)
            {
                newshift.EndTime = dateTimePicker3.Value;
            }
            else
            {
                newshift.EndTime = null;
            }
            ShiftSlots.Add(newshift);
            RebindShiftSlots();
        }

        private void RebindShiftSlots()
        {
            dgvSlotsToFill.DataSource = ShiftSlots.Select(x => new { StartTime = x.StartTime, EndTime = x.EndTime, Employee = x.Employee != null ? x.Employee.FullName : "" }).ToList();
        }

        private void AddEditShiftRoster_Load(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            RebindPresets();
            WorkingShift = unitofwork.ShiftRepository.Get(x => x.DayOfTheWeek == DayOfWeek && x.RosterId == RosterId, includeProperties: "EmployeeShifts.EmployeeShiftAssignments").FirstOrDefault();

            if (WorkingShift != null)
            {
                ShiftSlots = WorkingShift.EmployeeShifts.ToList();
                txtNotes.Text = WorkingShift.Notes;
                RebindShiftSlots();

            }
            RebindBookingInformation();
        }
        void RebindBookingInformation()
        {
            var unitofwork = new UnitOfWork();
            txtBookingInformation.AppendBoldLine("Total Number of Covers: ");
            var ListOfBookings = unitofwork.BookingRepository.Get(x =>
              x.BookingDate.Year == dateTimePicker1.Value.Year &&
              x.BookingDate.Month == dateTimePicker1.Value.Month &&
              x.BookingDate.Day == dateTimePicker1.Value.Day
              && x.DateInactive==null
              , y => y.OrderBy(q => q.BookingDate) ).ToList();
            txtBookingInformation.AppendLine(ListOfBookings.Count.ToString());
            var classifications = unitofwork.BookingClassificationRepository.Get();

            foreach( var classification in classifications)
            {
                var countofbookings = ListOfBookings.Where(x => x.BookingClasificationId1 == classification.Id).Count();
                if(countofbookings>0)
                {
                    txtBookingInformation.AppendBoldLine(classification.ClassificationName);
                    txtBookingInformation.AppendLine(countofbookings.ToString());
                }
            }

        }
        void RebindPresets()
        {
            var unitofwork = new UnitOfWork();
            cbPresetShifts.DataSource = unitofwork.ShiftCategoryRepository.Get().ToList();
            cbPresetShifts.DisplayMember = "CategoryName";
            cbPresetShifts.ValueMember = "Id";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Enabled = checkBox1.Checked;
        }
        public Shift GetFields(Shift s)
        {
            s.DayOfTheWeek = DayOfWeek;
            s.ShiftCategory = new ShiftCategory() { CategoryName = "SSSS" };
            s.EmployeeShifts = ShiftSlots;
            s.Notes = txtNotes.Text;
            s.RosterId = RosterId;
            
            return s;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            if (WorkingShift == null)
            {
                unitofwork.ShiftRepository.Insert(GetFields(new Shift()));
            }
            else
            {
                unitofwork.ShiftRepository.Update(GetFields(WorkingShift));
            }
            unitofwork.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void dgvAvailableUsers_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvSlotsToFill_SelectionChanged(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();

            var listofemployeeidsinuse = ShiftSlots.Where(y => y.Employee != null).Select(y => y.Employee.Id).ToList();
            AvailableEmployees = unitofwork.EmpoyeeRepository.Get(x => !listofemployeeidsinuse.Contains(x.Id)).ToList();
            dgvAvailableUsers.DataSource = AvailableEmployees.Select(x => new { EmployeeName = x.FullName, Suitability = 0 }).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgvAvailableUsers.SelectedRows.Count > 0 && dgvSlotsToFill.SelectedRows.Count > 0)
            {
                ShiftSlots[dgvSlotsToFill.SelectedRows[0].Index].EmployeeShiftAssignments.Add(new EmployeeShiftAssignment() { Employee = AvailableEmployees[dgvAvailableUsers.SelectedRows[0].Index] , Reason=""});
                ShiftSlots[dgvSlotsToFill.SelectedRows[0].Index].EmployeeAssignedDate = DateTime.Now;
                RebindShiftSlots();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvAvailableUsers.SelectedRows.Count > 0 && dgvSlotsToFill.SelectedRows.Count > 0)
            {
                ShiftSlots.RemoveAt(dgvSlotsToFill.SelectedRows[0].Index);
                RebindShiftSlots();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            var workingobject = unitofwork.ShiftCategoryRepository.Get(x => x.Id == (int)cbPresetShifts.SelectedValue, includeProperties: "EmployeeShiftPresets").FirstOrDefault();
            ShiftSlots = workingobject.EmployeeShiftPresets.Select(x => ConvertShiftPresetToShift(x)).ToList();
            RebindShiftSlots();
        }
        private EmployeeShift ConvertShiftPresetToShift(EmployeeShiftPresets shift)
        {
            return new EmployeeShift() { StartTime = shift.StartTime, EmployeeShiftCategory = shift.EmployeeLevelCategory, EndTime = shift.FinishTime };
        }
        private EmployeeShiftPresets ConvertShiftToShiftPreset(EmployeeShift shift)
        {
            return new EmployeeShiftPresets() { StartTime = shift.StartTime, EmployeeLevelCategory = shift.EmployeeShiftCategory, FinishTime = shift.EndTime };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            string value = "";
            if (CommonControls.InputBox("Save as...", "New Category Name:", ref value) == DialogResult.OK)
            {

                var workingobject = new ShiftCategory()
                {
                    CategoryName = value
                };

                workingobject.EmployeeShiftPresets = ShiftSlots.Select(x => ConvertShiftToShiftPreset(x)).ToList();
                unitofwork.ShiftCategoryRepository.Insert(workingobject);
                unitofwork.Save();
                RebindPresets();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var unitofwork = new UnitOfWork();
            var workingobject = unitofwork.ShiftCategoryRepository.Get(x => x.Id == (int)cbPresetShifts.SelectedValue).FirstOrDefault();
            workingobject.EmployeeShiftPresets = ShiftSlots.Select(x => ConvertShiftToShiftPreset(x)).ToList();
            unitofwork.Save();
            RebindShiftSlots();
        }

        private void dgvSlotsToFill_DragOver(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;
        }
        private Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void dgvSlotsToFill_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dgvSlotsToFill.PointToClient(new Point(e.X, e.Y));

            // Get the row index of the item the mouse is below. 
            rowIndexOfItemUnderMouseToDrop =
                dgvSlotsToFill.HitTest(clientPoint.X, clientPoint.Y).RowIndex;

            // If the drag operation was a move then remove and insert the row.
            if (e.Effect == DragDropEffects.Move)
            {
                if(rowIndexOfItemUnderMouseToDrop!=-1 && rowIndexFromMouseDown!=-1)
                {
                    ShiftSlots[rowIndexOfItemUnderMouseToDrop].EmployeeShiftAssignments.Add(new EmployeeShiftAssignment() { Employee = AvailableEmployees[rowIndexFromMouseDown], Reason="" });
                    ShiftSlots[rowIndexOfItemUnderMouseToDrop].EmployeeAssignedDate = DateTime.Now;
                }
                RebindShiftSlots();
           

            }
        }

        private void dgvAvailableUsers_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty &&
                    !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {

                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dgvAvailableUsers.DoDragDrop(
                    dgvAvailableUsers.Rows[rowIndexFromMouseDown],
                    DragDropEffects.Move);
                }
            }
        }

        private void dgvAvailableUsers_MouseDown(object sender, MouseEventArgs e)
        {
            rowIndexFromMouseDown = dgvAvailableUsers.HitTest(e.X, e.Y).RowIndex;
            if (rowIndexFromMouseDown != -1)
            {
                // Remember the point where the mouse down occurred. 
                // The DragSize indicates the size that the mouse can move 
                // before a drag event should be started.                
                Size dragSize = SystemInformation.DragSize;

                // Create a rectangle using the DragSize, with the mouse position being
                // at the center of the rectangle.
                dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2),
                                                               e.Y - (dragSize.Height / 2)),
                                    dragSize);
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        private void dgvAvailableUsers_DragOver(object sender, DragEventArgs e)
        {

        }
    }
    }

