using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Hotel_WindowsForm
{
    public partial class Form_2 : Form
    {
        INterface rul;
        public static string roomnumber;
        public static string costRoom;
        public static bool CheckRoom;
        public Form_2()
        {
            InitializeComponent();
            rul = new HotelClass();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
            HotelClass cost = new HotelClass();
            string numroom1 = Convert.ToString(MainForm.numroom);
            txtRoomNumber.Text = numroom1 + MainForm.familyNumber;


                txtfullName_Form2.Text = MainForm.fullName;
                txtCount_Form2.Text = Convert.ToString(MainForm.familyNumber);
                txtCount_Form2.Text = MainForm.familyNumber.ToString();
                
                int count = Convert.ToInt32(MainForm.familyCount);
                int floor = Convert.ToInt32(MainForm.numroom);
                int day = MainForm.day;
                float hour = MainForm.hour;
                txtCost_Form2.Text = Convert.ToString(cost.Cost(count, floor, day, hour)) + '$';
                roomnumber = txtRoomNumber.Text;
                costRoom = txtCost_Form2.Text;
                CheckRoom = rul.InsertInformation(txtRoomNumber.Text, MainForm.name, MainForm.family, MainForm.familyCount, txtCost_Form2.Text , day , hour);
            if(CheckRoom == false)
            {
                Close();
                //MainForm frm = new MainForm();
                //frm.Form1_Load_1(sender,e);
            }    
            
            

        }

        private void txtCost_Form2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void lblCost_Form2_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}
