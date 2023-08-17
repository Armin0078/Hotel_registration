using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_WindowsForm
{
    

    public partial class EditAdminPanelForm : Form
    {
        frmAdminPanel edt = new frmAdminPanel();
        public EditAdminPanelForm()
        {
            InitializeComponent();
        }

        private void EditAdminPanelForm_Load(object sender, EventArgs e)
        {
            txtName.Text = frmAdminPanel.name;
            txtFamily.Text = frmAdminPanel.family;
            txtDay.Text = frmAdminPanel.day1;
            txtHour.Text = frmAdminPanel.hour1;
            txtFamilyCount.Text = frmAdminPanel.familyCount;
            txtCost.Text = frmAdminPanel.cost1;
            txtFloor.Text = frmAdminPanel.room1[0].ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            HotelClass ht = new HotelClass();
            int familyCount = Convert.ToInt32(txtFamilyCount.Text);
            int flloor = Convert.ToInt32(txtFloor.Text);
            int day = Convert.ToInt32(txtDay.Text);
            float hour = Convert.ToInt32(txtFamilyCount.Text);
            float cost =  ht.Cost(familyCount, flloor, day, hour);
            string cost1 = cost.ToString();
            bool correct = ht.EditInformation(frmAdminPanel.room1 , txtName.Text , txtFamily.Text , txtFamilyCount.Text , cost1 , day, hour);
            if(correct == true)
            {
                MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK);
                Close();
            }
            else
            {
                MessageBox.Show("عملیات شکست خورد", "خطا", MessageBoxButtons.OK);
            }
        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void numFamilyNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblFamilyNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblHour_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
