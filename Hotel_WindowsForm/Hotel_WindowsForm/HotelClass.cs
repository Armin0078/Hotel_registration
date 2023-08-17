using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_WindowsForm
{
    internal class HotelClass : INterface
    {
        string connection = "Data Source= .\\SQLSERVER2022 ; Initial Catalog= Hotel_DB ; Integrated Security = true   ";

        public DataTable bank()
        {
            string query = "Select * from Form ";
            SqlConnection connect = new SqlConnection(connection);
            SqlDataAdapter adapt = new SqlDataAdapter(query, connect);
            DataTable data = new DataTable();
            adapt.Fill(data);
            return data;
         }

        public bool CheckAdmin(string username, string password)
        {
            string query1 = "Select UserName from AdminTable ";
            string query2 = "Select PassWord from AdminTable ";
            SqlConnection connect = new SqlConnection(connection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connect);
            SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connect);
            DataTable data1 = new DataTable();
            DataTable data2 = new DataTable();
            adapter1.Fill(data1);
            adapter2.Fill(data2);
            string str1 = Convert.ToString(data1.Rows[0]["UserName"]);
            string str2 = Convert.ToString(data2.Rows[0]["PassWord"]);
            if ( str1 == username && str2 == password)
            {
                MessageBox.Show("ورود مجاز", "موفقیت", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("ورود غیر مجاز", "شکست", MessageBoxButtons.OK);
                return false;
            }
            
        }

        public float Cost(int count, int floor, int day, float hour)
        {
            float hours = hour / 24;

            return ((float)(count * floor * 10)) * ((float)day + hours);
        }

        public bool EditInformation(string Room, string Name, string Family, string FamilyCounts, string cost, int day, float hour)
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                string query = "Update Form set  Name = @Name , Family = @Family , FamilyCounts = @FamilyCounts , cost = @cost , day = @day , hour = @hour  Where Room = @Room ";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@Room", Room);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Family", Family);
                cmd.Parameters.AddWithValue("@FamilyCounts", FamilyCounts);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@hour", hour);
                connect.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                MessageBox.Show("شکست در ویرایش اطلاعات", "خطا", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                connect.Close();
            }
        }

        public bool InsertInformation(string Room, string Name, string Family, string FamilyCounts, string cost, int day, float hour)
        {
            SqlConnection connect = new SqlConnection(connection);
            try
            {
                int FULL = 1;
                string query = "Update Form set  Name = @Name , Family = @Family , FamilyCounts = @FamilyCounts , cost = @cost , [Full] = @FULL , day = @day , hour = @hour  Where Room = @Room and [Full] = 0 ";
                string query2 = "Select [Full] from Form where Room = @room";
                string str1;
                SqlDataAdapter adapt = new SqlDataAdapter(query2, connect);
                adapt.SelectCommand.Parameters.AddWithValue("@room", Room);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                str1 = Convert.ToString(dt.Rows[0]["Full"]); 
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@Room", Room);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Family", Family);
                cmd.Parameters.AddWithValue("@FamilyCounts", FamilyCounts);
                cmd.Parameters.AddWithValue("@cost", cost);
                cmd.Parameters.AddWithValue("@day", day);
                cmd.Parameters.AddWithValue("@hour", hour);
                cmd.Parameters.AddWithValue("@FULL", FULL);
                connect.Open();
                if(str1 == "False")
                {
                cmd.ExecuteNonQuery();
                return true;
                }
                else
                {
                    MessageBox.Show(".اتاق پر است لطفا اتاق دیگری را انتخاب کنید","خطا",MessageBoxButtons.OK);
                    return false;
                }
                
            }
            catch
            {
                MessageBox.Show("شکست در ثبت اطلاعات","خطا",MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                connect.Close();
            }

            
        }



        public string person(string name, string family)
        {
            return name + " " + family;
        }

        public DataTable Search(string parameter)
        {
            string query = "select * from Form where Name like @parameter or Family like @parameter";
            SqlConnection connect = new SqlConnection(connection);
            SqlDataAdapter adapt = new SqlDataAdapter(query, connect);
            adapt.SelectCommand.Parameters.AddWithValue("@parameter","%" + parameter + "%");
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            return dt;
        }
    }
}
