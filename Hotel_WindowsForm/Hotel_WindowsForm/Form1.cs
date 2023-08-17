using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Hotel_WindowsForm
{

    public partial class MainForm : Form
    {
        public static bool execute = true;
        public static string fullName = "";
        public static int familyNumber = 1;
        public static int numroom = 1;
        public static string familyCount = "1";
        public static int day;
        public static int hour;
        public static string name;
        public static string family;
        public static string numroom1;
        


        INterface myRul;
        public MainForm()
        {
            InitializeComponent();
            myRul = new HotelClass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("به هتل ما خوش آمدید. در خدمتم");
            txtName.Text = "";
            txtFamily.Text = "";
            numCount.Value = 1;
            numFloor.Value = 1;
            txtDay.Value = 0;
            txtHour.Value = 0;
            lblDateMainForm.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            lblTimeMainForm.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void numCount_ValueChanged_1(object sender, EventArgs e)
        {
            int count = ((int)numCount.Value);
            familyCount =Convert.ToString( count) ;


        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {
            HotelClass hotel = new HotelClass();
             name = txtName.Text;
             family = txtFamily.Text;

            numroom1 =Convert.ToString(numFloor.Value);

            int btnAccept_Click = ((int)numCount.Value);
            int room = ((int)numFloor.Value);

            fullName = name + " " + family;

            familyNumber = (int)numCount.Value;
            execute = true;


            while (true)
                {


                if (txtFamily.Text == "" || txtFamily.Text == "")
                {
                    MessageBox.Show("لطفا نام و نام خانوادگی خود را وارد کنید");
                    execute = false;
                    break;
                }

                if (txtDay.Value == 0 && txtHour.Value == 0)
                {
                    MessageBox.Show("لطفا حداقل زمانی را که می خواهید در هتل اقامت داشته باشید را مشخص کنید ", "اخطار", MessageBoxButtons.OK);
                    execute = false;
                    break;

                }
                break;
            }

            if (execute == true)
            {
                Form_2 form = new Form_2();
                form.ShowDialog();
                Form1_Load(sender, e);
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void numFloor_ValueChanged(object sender, EventArgs e)
        {
            numroom = (int)numFloor.Value;

        }

        private void txtDay_ValueChanged(object sender, EventArgs e)
        {
          day = (int)txtDay.Value;
        }

        private void txtHour_ValueChanged(object sender, EventArgs e)
        {
            hour = (int)txtHour.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BankForm bank = new BankForm();
            bank.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmCheckAdmin frmCheckAdmin = new frmCheckAdmin();
            frmCheckAdmin.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblName.Text = "Name:";
            lblFamily.Text = "Family:";
            lblCount.Text = "How many are you:";
            lblFloor.Text = "Floor:";
            lblTime.Text = "How much want to stay:";
            lblHour.Text = "Hour";
            lblDay.Text = "Day";
            btnAccept.Text = "Submit";
            btnAdmin.Text = "Admin Panel";
            bnbRoomsInBanks.Text = "Hotel Rooms";
            gbSignUpMainForm.Text = "SignUp";
            grMainForm.Text = "List";

        }

        private void btnLanguagePersian_Click(object sender, EventArgs e)
        {
            lblName.Text = "نام:";
            lblFamily.Text = "نام خانوادگی:";
            lblCount.Text = "تعداد اعضای خانواده:";
            lblFloor.Text = "شماره طبقه:";
            lblTime.Text = "چه مدت اقامت دارید:";
            lblHour.Text = "ساعت";
            lblDay.Text = "روز";
            btnAccept.Text = "تایید";
            btnAdmin.Text = "پنل ادمین";
            bnbRoomsInBanks.Text = "اتاق های هتل";
            gbSignUpMainForm.Text = "ثبت نام";
            grMainForm.Text = "لیست";
        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTimeMainForm_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

 

        private void gbSignUpMainForm_Enter(object sender, EventArgs e)
        {

        }
    }

}
