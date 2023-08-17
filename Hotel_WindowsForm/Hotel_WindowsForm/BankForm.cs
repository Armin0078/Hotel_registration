using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_WindowsForm
{
    public partial class BankForm : Form
    {
        

        public BankForm()
        {
            InitializeComponent();
          
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         }

        private void BankForm_Load(object sender, EventArgs e)
        {
            BandGrid();

            
            

            for(int i=0; i < dg1.Rows.Count; i++)
            {
                string a = dg1.Rows[i].Cells[5].Value.ToString();
                if (a == "True")
                {
                    dg1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }
            for (int i = 0; i < dg1.Rows.Count; i++)
            {
                string a = dg1.Rows[i].Cells[5].Value.ToString();
                if (a == "False")
                {
                    dg1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }



        }
        private void BandGrid()
        {
            HotelClass hotel = new HotelClass();
            dg1.DataSource = hotel.bank();
        }

    }
}

