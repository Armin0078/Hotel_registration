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

    public partial class frmAdminPanel : Form
    {
        public static string parameters;
        INterface myRul;
        public static string name;
        public static string family;
        public static string familyCount;
        public static string day1;
        public static string hour1;
        public static string cost1;
        public static string room1;
        public frmAdminPanel()
        {
            InitializeComponent();
            myRul = new HotelClass();
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            BandGrid();
        }

        private void dgAdminPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EditAdminPanelForm edit = new EditAdminPanelForm();
            //if (dgAdminPanel.MouseDoubleClick)
            //{
            //    edit.ShowDialog();
            //}  
        }
        private void BandGrid()
        {
            HotelClass hotel = new HotelClass();
            dgAdminPanel.DataSource = hotel.bank();
        }

        private void txtSearchAdminPanel_TextChanged(object sender, EventArgs e)
        {
            dgAdminPanel.DataSource = myRul.Search(txtSearchAdminPanel.Text);
        }

        private void btnEditAdminPanel_Click(object sender, EventArgs e)
        {


            if (dgAdminPanel.SelectedCells[1].Value.ToString() != "")
            {
                EditAdminPanelForm editAdminPanelForm = new EditAdminPanelForm();

                room1 = dgAdminPanel.SelectedCells[0].Value.ToString();
                name = dgAdminPanel.SelectedCells[1].Value.ToString();
                family = dgAdminPanel.SelectedCells[2].Value.ToString();
                familyCount = dgAdminPanel.SelectedCells[3].Value.ToString();
                day1 = dgAdminPanel.SelectedCells[6].Value.ToString();
                hour1 = dgAdminPanel.SelectedCells[7].Value.ToString();
                cost1 = dgAdminPanel.SelectedCells[4].Value.ToString();


                editAdminPanelForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("لطفا یک اتاق پر را برای ویرایش انتخاب کنید", "اخطار");
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BandGrid();
        }
    }
}
