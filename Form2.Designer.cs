namespace phoney_warehouse
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logo = new System.Windows.Forms.Label();
            this.remove_customer = new System.Windows.Forms.Button();
            this.update_customer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_customer = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.usage = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.customer_code = new System.Windows.Forms.TextBox();
            this.log_out = new System.Windows.Forms.Button();
            this.customer_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerinfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.load_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(167, 20);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(207, 33);
            this.logo.TabIndex = 33;
            this.logo.Text = "Phoney Warehouse";
            // 
            // remove_customer
            // 
            this.remove_customer.Location = new System.Drawing.Point(208, 196);
            this.remove_customer.Name = "remove_customer";
            this.remove_customer.Size = new System.Drawing.Size(75, 40);
            this.remove_customer.TabIndex = 32;
            this.remove_customer.Text = "Remove customer";
            this.remove_customer.UseVisualStyleBackColor = true;
            this.remove_customer.Click += new System.EventHandler(this.remove_customer_Click);
            // 
            // update_customer
            // 
            this.update_customer.Location = new System.Drawing.Point(208, 150);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(75, 40);
            this.update_customer.TabIndex = 31;
            this.update_customer.Text = "Update customer";
            this.update_customer.UseVisualStyleBackColor = true;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Usage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Phone number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Customer code";
            // 
            // add_customer
            // 
            this.add_customer.Location = new System.Drawing.Point(208, 104);
            this.add_customer.Name = "add_customer";
            this.add_customer.Size = new System.Drawing.Size(75, 40);
            this.add_customer.TabIndex = 25;
            this.add_customer.Text = "Add customer";
            this.add_customer.UseVisualStyleBackColor = true;
            this.add_customer.Click += new System.EventHandler(this.add_customer_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(25, 349);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Regular";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 326);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Saver";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 303);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Pay As You Go";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // usage
            // 
            this.usage.Location = new System.Drawing.Point(22, 273);
            this.usage.Name = "usage";
            this.usage.Size = new System.Drawing.Size(154, 20);
            this.usage.TabIndex = 21;
            this.usage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usage_KeyPress_1);
            // 
            // phone_number
            // 
            this.phone_number.Location = new System.Drawing.Point(22, 232);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(154, 20);
            this.phone_number.TabIndex = 20;
            this.phone_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_number_KeyPress_1);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(22, 194);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(154, 20);
            this.address.TabIndex = 19;
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(22, 155);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(154, 20);
            this.customer_name.TabIndex = 18;
            // 
            // customer_code
            // 
            this.customer_code.Location = new System.Drawing.Point(22, 115);
            this.customer_code.Name = "customer_code";
            this.customer_code.Size = new System.Drawing.Size(154, 20);
            this.customer_code.TabIndex = 17;
            // 
            // log_out
            // 
            this.log_out.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.log_out.Location = new System.Drawing.Point(208, 242);
            this.log_out.Name = "log_out";
            this.log_out.Size = new System.Drawing.Size(75, 40);
            this.log_out.TabIndex = 34;
            this.log_out.Text = "Log out";
            this.log_out.UseVisualStyleBackColor = true;
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // customer_ID
            // 
            this.customer_ID.Location = new System.Drawing.Point(22, 76);
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.Size = new System.Drawing.Size(154, 20);
            this.customer_ID.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "CustomerID ";
            // 
            // customerinfo
            // 
            this.customerinfo.Location = new System.Drawing.Point(309, 76);
            this.customerinfo.Multiline = true;
            this.customerinfo.Name = "customerinfo";
            this.customerinfo.ReadOnly = true;
            this.customerinfo.Size = new System.Drawing.Size(219, 236);
            this.customerinfo.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(309, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "Print customer statement";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.Text = "Select customer";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(340, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Note: To delete or edit records, customerID number should be entered!";
            // 
            // load_data
            // 
            this.load_data.Location = new System.Drawing.Point(208, 318);
            this.load_data.Name = "load_data";
            this.load_data.Size = new System.Drawing.Size(75, 38);
            this.load_data.TabIndex = 41;
            this.load_data.Text = "Load Data";
            this.load_data.UseVisualStyleBackColor = true;
            this.load_data.Click += new System.EventHandler(this.load_data_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.log_out;
            this.ClientSize = new System.Drawing.Size(552, 430);
            this.Controls.Add(this.load_data);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerinfo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customer_ID);
            this.Controls.Add(this.log_out);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.remove_customer);
            this.Controls.Add(this.update_customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_customer);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.usage);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.address);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.customer_code);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phoney Warehouse";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.Button remove_customer;
        private System.Windows.Forms.Button update_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_customer;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox usage;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.TextBox customer_code;
        private System.Windows.Forms.Button log_out;
        private System.Windows.Forms.TextBox customer_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button load_data;
    }
}
