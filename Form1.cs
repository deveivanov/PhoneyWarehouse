using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;                  
using System.Globalization;
      

namespace phoney_warehouse
{
    public partial class Form1 : Form
    {
      private OleDbConnection connection = new OleDbConnection();
               
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:/customers.accdb;Jet OLEDB:Database Password=Emo4ee123";
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                label6.Text = "Database status: Successfuly connected";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                
            }
   
        }

        private void login_Enter(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from login where username='"+txt_Username.Text+"' and Password='"+txt_Password.Text+"'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
                //count++;

            }
            if(count == 1)
            {
                MessageBox.Show("Username and Password are correct");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (count > 1)
            {
                MessageBox.Show("Duplicate Username and Password are correct");
            }
            else 
            {
                MessageBox.Show("Username or Password is incorrect");
            }
            connection.Close();
        }

    }
     
}
