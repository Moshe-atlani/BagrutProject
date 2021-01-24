namespace WindowsFormsApp_MA
{
    partial class Form1
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
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Cel = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_ZipCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_CellAreaCode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_Idh = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filter_PhoneNum = new System.Windows.Forms.TextBox();
            this.filter_LastName = new System.Windows.Forms.TextBox();
            this.filter_Id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.button_AddCity = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(233, 170);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 31);
            this.textBox_FirstName.TabIndex = 2;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // textBox_Cel
            // 
            this.textBox_Cel.Location = new System.Drawing.Point(351, 345);
            this.textBox_Cel.Name = "textBox_Cel";
            this.textBox_Cel.Size = new System.Drawing.Size(100, 31);
            this.textBox_Cel.TabIndex = 5;
            this.textBox_Cel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(233, 257);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 31);
            this.textBox_LastName.TabIndex = 3;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(233, 477);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(100, 31);
            this.textBox_Age.TabIndex = 7;
            this.textBox_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_ZipCode
            // 
            this.textBox_ZipCode.Location = new System.Drawing.Point(233, 407);
            this.textBox_ZipCode.Name = "textBox_ZipCode";
            this.textBox_ZipCode.Size = new System.Drawing.Size(100, 31);
            this.textBox_ZipCode.TabIndex = 6;
            this.textBox_ZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cellphone Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zip code :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 519);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 9;
            // 
            // comboBox_CellAreaCode
            // 
            this.comboBox_CellAreaCode.FormattingEnabled = true;
            this.comboBox_CellAreaCode.Items.AddRange(new object[] {
            "+972",
            "+33",
            "+55",
            "+77"});
            this.comboBox_CellAreaCode.Location = new System.Drawing.Point(224, 345);
            this.comboBox_CellAreaCode.Name = "comboBox_CellAreaCode";
            this.comboBox_CellAreaCode.Size = new System.Drawing.Size(121, 33);
            this.comboBox_CellAreaCode.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Age :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 25;
            this.listBox_Clients.Location = new System.Drawing.Point(634, 311);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(391, 404);
            this.listBox_Clients.TabIndex = 17;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label_Idh
            // 
            this.label_Idh.AutoSize = true;
            this.label_Idh.Location = new System.Drawing.Point(120, 98);
            this.label_Idh.Name = "label_Idh";
            this.label_Idh.Size = new System.Drawing.Size(41, 25);
            this.label_Idh.TabIndex = 18;
            this.label_Idh.Text = "Id :";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(249, 98);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(24, 25);
            this.label_ID.TabIndex = 19;
            this.label_ID.Text = "0";
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(351, 604);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(175, 46);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.filter_PhoneNum);
            this.groupBox1.Controls.Add(this.filter_LastName);
            this.groupBox1.Controls.Add(this.filter_Id);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(634, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 215);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // filter_PhoneNum
            // 
            this.filter_PhoneNum.Location = new System.Drawing.Point(191, 158);
            this.filter_PhoneNum.Name = "filter_PhoneNum";
            this.filter_PhoneNum.Size = new System.Drawing.Size(100, 31);
            this.filter_PhoneNum.TabIndex = 5;
            this.filter_PhoneNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // filter_LastName
            // 
            this.filter_LastName.Location = new System.Drawing.Point(191, 106);
            this.filter_LastName.Name = "filter_LastName";
            this.filter_LastName.Size = new System.Drawing.Size(100, 31);
            this.filter_LastName.TabIndex = 4;
            this.filter_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // filter_Id
            // 
            this.filter_Id.Location = new System.Drawing.Point(191, 53);
            this.filter_Id.Name = "filter_Id";
            this.filter_Id.Size = new System.Drawing.Size(100, 31);
            this.filter_Id.TabIndex = 3;
            this.filter_Id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Phone Number :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Last Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Id :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(143, 538);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "City :";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(224, 535);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(121, 33);
            this.comboBox_City.TabIndex = 23;
            // 
            // button_AddCity
            // 
            this.button_AddCity.Location = new System.Drawing.Point(351, 538);
            this.button_AddCity.Name = "button_AddCity";
            this.button_AddCity.Size = new System.Drawing.Size(30, 30);
            this.button_AddCity.TabIndex = 24;
            this.button_AddCity.Text = "+";
            this.button_AddCity.UseVisualStyleBackColor = true;
            this.button_AddCity.Click += new System.EventHandler(this.button_AddCity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 755);
            this.Controls.Add(this.button_AddCity);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label_Idh);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_CellAreaCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.textBox_ZipCode);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Cel);
            this.Controls.Add(this.textBox_FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_Cel;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_ZipCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_CellAreaCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_Idh;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox filter_PhoneNum;
        private System.Windows.Forms.TextBox filter_LastName;
        private System.Windows.Forms.TextBox filter_Id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Button button_AddCity;
    }
}

