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
    public partial class frmCheckAdmin : Form
    {
        INterface rull;
        public frmCheckAdmin()
        {
            InitializeComponent();
            rull = new HotelClass();
        }

        private void CheckAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(rull.CheckAdmin(txtName.Text, txtPassword.Text) == true)
            {
                frmAdminPanel admin = new frmAdminPanel();
                admin.ShowDialog();
                Close();
                txtName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                txtName.Text = "";
                txtPassword.Text = "";
            }

            
        }
    }
}
