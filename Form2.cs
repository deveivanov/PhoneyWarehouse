using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Printing;

namespace phoney_warehouse
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:/customers.accdb;Jet OLEDB:Database Password=Emo4ee123";
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

        }
        string Account;
        string payasyougo;
        string saver;
        string regular;
        double fee = 0;
        double? finalfee;
        private double? payg;
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

         Customer code1 = new Customer();

            Customer name1 = new Customer();

            Customer number1 = new Customer();

            Customer address1 = new Customer();
            Account usage1 = new Account();

        private void log_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from customers";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                 while (reader.Read())
                 {
                     comboBox1.Items.Add(reader["CustomerName"].ToString());
                 }
                
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
        }
        

        private void add_customer_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command = new OleDbCommand("INSERT INTO customers ([CustomerCode], [CustomerName], [PhoneNumber], [Address], [Account], [Usage], [CustomerID]) VALUES (@CustomerCode,@CustomerName,@PhoneNumber,@Address,@Account,@Usage,@CustomerID)", connection);
                command.Parameters.AddWithValue("@CustomerCode", customer_code.Text);
                command.Parameters.AddWithValue("@CustomerName", customer_name.Text);
                command.Parameters.AddWithValue("@PhoneNumber", phone_number.Text);
                command.Parameters.AddWithValue("@Address", address.Text);
                command.Parameters.AddWithValue("@Account", Account);
                command.Parameters.AddWithValue("@Usage", usage.Text);
                command.Parameters.AddWithValue("@CustomerID", customer_ID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Data saved successfuly!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();

            //Customer
            //*******************************************************************
            Customer code1 = new Customer();
            code1.CustomerCode = customer_code.Text;
            Customer name1 = new Customer();
            name1.Name = customer_name.Text;
            Customer number1 = new Customer();
            number1.PhoneNumber = phone_number.Text;
            Customer address1 = new Customer();
            address1.Address = address.Text;
            //Account
            //*******************************************************************
            Account usage1 = new Account();
            Account fee1 = new Account();
            fee1.AccountFees = 0;
            usage1.AccountUsage = Convert.ToInt32(usage.Text);
           
            PayAsYouGoAccount payga1 = new PayAsYouGoAccount();
            payga1.AccountCost = payga1.AccountCost;
            Saver saver1 = new Saver();
            saver1.AccountFees = saver1.AccountFees;
            saver1.AccountUsage = saver1.AccountUsage;
            saver1.AccountCost = saver1.AccountCost;
            Regular regular1 = new Regular();
            regular1.AccountFees = regular1.AccountFees;
            regular1.AccountUsage = regular1.AccountUsage;
            regular1.AccountCost = regular1.AccountCost;
            //====================================================================
            if (radioButton1.Checked == true)
            {
                payasyougo = "Pay As You Go";
                payg = payga1.AccountCost * usage1.AccountUsage;
            }
            else if (radioButton1.Checked == false)
            {
                payasyougo = "";
                payg = null;
            }
            if (radioButton2.Checked == true)
            {
                saver = "Saver";
                fee = usage1.AccountUsage - saver1.AccountUsage;
                if (fee < 0)
                {
                    finalfee = saver1.AccountFees;
                }
                else
                {
                    finalfee = (fee * saver1.AccountCost) + saver1.AccountFees;
                }
            }
            else if (radioButton2.Checked == false)
            {
                saver = "";
                finalfee = null;
            }
            if (radioButton3.Checked == true)
            {
                regular = "Regular";
                fee = usage1.AccountUsage - regular1.AccountUsage;
                if (fee < 0)
                {
                    finalfee = regular1.AccountFees;
                }
                else
                {
                    finalfee = (fee * regular1.AccountCost) + regular1.AccountFees;
                }
            }
            else if (radioButton3.Checked == false)
            {
                regular = "";
            }
            //display
            customerinfo.Text = ("Customer code: " + code1.CustomerCode
                + Environment.NewLine + "Customer name: " + name1.Name
                + Environment.NewLine + "Phone number: " + number1.PhoneNumber
                + Environment.NewLine + "Customer address:" + address1.Address
                + Environment.NewLine + "Customer account: " + payasyougo + saver + regular
                + Environment.NewLine + "Current month usage: " + usage1.AccountUsage + " minutes"
                + Environment.NewLine + "Current month cost: £ " + finalfee + payg);
        }

       

        private void phone_number_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));

        }

        private void usage_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar));

        }

        private void update_customer_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update customers set [CustomerCode]='" + customer_code.Text + "' ,[CustomerName]='" + customer_name.Text + "',[Address]='" + address.Text + "',[PhoneNumber]='" + phone_number.Text + "',[Account]='" + Account + "',[Usage]='" + usage.Text + "'where CustomerID=" + customer_ID.Text + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data updated successfuly!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
        }

        private void remove_customer_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from customers where CustomerID="+customer_ID.Text+"";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data deleted successfuly!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
            customer_ID.Text = "";
            customer_code.Text = "";
            customer_name.Text = "";
            address.Text = "";
            phone_number.Text = "";
            usage.Text = "";
        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(customerinfo.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from customers where CustomerName='"+comboBox1.Text+"'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    customer_code.Text = reader["CustomerCode"].ToString();
                    customer_name.Text = reader["CustomerName"].ToString();
                    address.Text = reader["Address"].ToString();
                    phone_number.Text = reader["PhoneNumber"].ToString();
                    Account = reader["Account"].ToString();
                    usage.Text = reader["Usage"].ToString();
                    customer_ID.Text = reader["CustomerID"].ToString();
                }
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            //Customer
            //*******************************************************************
            Customer code1 = new Customer();
            code1.CustomerCode = customer_code.Text;
            Customer name1 = new Customer();
            name1.Name = customer_name.Text;
            Customer number1 = new Customer();
            number1.PhoneNumber = phone_number.Text;
            Customer address1 = new Customer();
            address1.Address = address.Text;
            //Account
            //*******************************************************************
            Account usage1 = new Account();
            Account fee1 = new Account();
            fee1.AccountFees = 0;
            usage1.AccountUsage = Convert.ToInt32(usage.Text);
           
            PayAsYouGoAccount payga1 = new PayAsYouGoAccount();
            payga1.AccountCost = payga1.AccountCost;
            Saver saver1 = new Saver();
            saver1.AccountFees = saver1.AccountFees;
            saver1.AccountUsage = saver1.AccountUsage;
            saver1.AccountCost = saver1.AccountCost;
            Regular regular1 = new Regular();
            regular1.AccountFees = regular1.AccountFees;
            regular1.AccountUsage = regular1.AccountUsage;
            regular1.AccountCost = regular1.AccountCost;
            //====================================================================
            if (radioButton1.Checked == true)
            {
                payasyougo = "Pay As You Go";
                payg = payga1.AccountCost * usage1.AccountUsage;
            }
            else if (radioButton1.Checked == false)
            {
                payasyougo = "";
                payg = null;
            }
            if (radioButton2.Checked == true)
            {
                saver = "Saver";
                fee = usage1.AccountUsage - saver1.AccountUsage;
                if (fee < 0)
                {
                    finalfee = saver1.AccountFees;
                }
                else
                {
                    finalfee = (fee * saver1.AccountCost) + saver1.AccountFees;
                }
            }
            else if (radioButton2.Checked == false)
            {
                saver = "";
                finalfee = null;
            }
            if (radioButton3.Checked == true)
            {
                regular = "Regular";
                fee = usage1.AccountUsage - regular1.AccountUsage;
                if (fee < 0)
                {
                    finalfee = regular1.AccountFees;
                }
                else
                {
                    finalfee = (fee * regular1.AccountCost) + regular1.AccountFees;
                }
            }
            else if (radioButton3.Checked == false)
            {
                regular = "";
            }
            //display
            customerinfo.Text = ("Customer code: " + code1.CustomerCode
                + Environment.NewLine + "Customer name: " + name1.Name
                + Environment.NewLine + "Phone number: " + number1.PhoneNumber
                + Environment.NewLine + "Customer address:" + address1.Address
                + Environment.NewLine + "Customer account: " + payasyougo + saver + regular
                + Environment.NewLine + "Current month usage: " + usage1.AccountUsage + " minutes"
                + Environment.NewLine + "Current month cost: £ " + finalfee + payg);
         
        }

        private void load_data_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update customers set [CustomerCode]= ? ,[CustomerName]= ? ,[Address]= ? ,[PhoneNumber]= ? ,[Account]= ? ,[Usage]= ? where CustomerID=0";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Data updated successfuly!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            connection.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Account = "PayAsYouGo";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Saver";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Account = "Regular";
        }
        }
    }


