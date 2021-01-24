namespace WindowsFormsApp_MA.UI
{
    partial class Form_Order
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OrderProduct = new System.Windows.Forms.TabPage();
            this.listBox_Order = new System.Windows.Forms.ListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_filter1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_comment = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Client = new System.Windows.Forms.TabPage();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_phonenum = new System.Windows.Forms.Label();
            this.label_zipCode = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_FilterClient = new System.Windows.Forms.GroupBox();
            this.textBox_filterPhoneNum = new System.Windows.Forms.TextBox();
            this.textBox_filterClientLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterClientId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.OrderProduct.SuspendLayout();
            this.groupBox_filter1.SuspendLayout();
            this.Client.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox_FilterClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OrderProduct);
            this.tabControl1.Controls.Add(this.Client);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1071, 790);
            this.tabControl1.TabIndex = 0;
            // 
            // OrderProduct
            // 
            this.OrderProduct.Controls.Add(this.listBox_Order);
            this.OrderProduct.Controls.Add(this.button_Delete);
            this.OrderProduct.Controls.Add(this.button_Save);
            this.OrderProduct.Controls.Add(this.groupBox_filter1);
            this.OrderProduct.Controls.Add(this.textBox_comment);
            this.OrderProduct.Controls.Add(this.dateTimePicker1);
            this.OrderProduct.Controls.Add(this.label6);
            this.OrderProduct.Controls.Add(this.label_id);
            this.OrderProduct.Controls.Add(this.label4);
            this.OrderProduct.Controls.Add(this.label3);
            this.OrderProduct.Controls.Add(this.label2);
            this.OrderProduct.Controls.Add(this.label1);
            this.OrderProduct.Location = new System.Drawing.Point(8, 39);
            this.OrderProduct.Name = "OrderProduct";
            this.OrderProduct.Padding = new System.Windows.Forms.Padding(3);
            this.OrderProduct.Size = new System.Drawing.Size(1055, 743);
            this.OrderProduct.TabIndex = 1;
            this.OrderProduct.Text = "OrderProduct";
            this.OrderProduct.UseVisualStyleBackColor = true;
            // 
            // listBox_Order
            // 
            this.listBox_Order.FormattingEnabled = true;
            this.listBox_Order.ItemHeight = 25;
            this.listBox_Order.Location = new System.Drawing.Point(600, 352);
            this.listBox_Order.Name = "listBox_Order";
            this.listBox_Order.Size = new System.Drawing.Size(395, 329);
            this.listBox_Order.TabIndex = 11;
            this.listBox_Order.DoubleClick += new System.EventHandler(this.listBox_Order_DoubleClick);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(228, 336);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(99, 55);
            this.button_Delete.TabIndex = 10;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(85, 336);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(97, 55);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // groupBox_filter1
            // 
            this.groupBox_filter1.Controls.Add(this.textBox2);
            this.groupBox_filter1.Controls.Add(this.textBox1);
            this.groupBox_filter1.Controls.Add(this.dateTimePicker3);
            this.groupBox_filter1.Controls.Add(this.dateTimePicker2);
            this.groupBox_filter1.Controls.Add(this.label20);
            this.groupBox_filter1.Controls.Add(this.label19);
            this.groupBox_filter1.Controls.Add(this.label18);
            this.groupBox_filter1.Controls.Add(this.label17);
            this.groupBox_filter1.Location = new System.Drawing.Point(600, 48);
            this.groupBox_filter1.Name = "groupBox_filter1";
            this.groupBox_filter1.Size = new System.Drawing.Size(395, 274);
            this.groupBox_filter1.TabIndex = 8;
            this.groupBox_filter1.TabStop = false;
            this.groupBox_filter1.Text = "groupBox1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 12;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(154, 144);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 197);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 25);
            this.label20.TabIndex = 14;
            this.label20.Text = "Client :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 144);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 25);
            this.label19.TabIndex = 13;
            this.label19.Text = "Jusqu a :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 25);
            this.label18.TabIndex = 12;
            this.label18.Text = "A partir de :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Id :";
            // 
            // textBox_comment
            // 
            this.textBox_comment.Location = new System.Drawing.Point(228, 186);
            this.textBox_comment.Multiline = true;
            this.textBox_comment.Name = "textBox_comment";
            this.textBox_comment.Size = new System.Drawing.Size(107, 31);
            this.textBox_comment.TabIndex = 7;
            this.textBox_comment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 31);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(214, 70);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 25);
            this.label_id.TabIndex = 4;
            this.label_id.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comment :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // Client
            // 
            this.Client.Controls.Add(this.listBox_Clients);
            this.Client.Controls.Add(this.groupBox2);
            this.Client.Controls.Add(this.groupBox_FilterClient);
            this.Client.Location = new System.Drawing.Point(8, 39);
            this.Client.Name = "Client";
            this.Client.Padding = new System.Windows.Forms.Padding(3);
            this.Client.Size = new System.Drawing.Size(1055, 743);
            this.Client.TabIndex = 0;
            this.Client.Text = "Client";
            this.Client.UseVisualStyleBackColor = true;
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 25;
            this.listBox_Clients.Location = new System.Drawing.Point(620, 84);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(353, 304);
            this.listBox_Clients.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_phonenum);
            this.groupBox2.Controls.Add(this.label_zipCode);
            this.groupBox2.Controls.Add(this.label_FirstName);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_lastname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(113, 474);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(729, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label_phonenum
            // 
            this.label_phonenum.AutoSize = true;
            this.label_phonenum.Location = new System.Drawing.Point(477, 74);
            this.label_phonenum.Name = "label_phonenum";
            this.label_phonenum.Size = new System.Drawing.Size(19, 25);
            this.label_phonenum.TabIndex = 7;
            this.label_phonenum.Text = "-";
            // 
            // label_zipCode
            // 
            this.label_zipCode.AutoSize = true;
            this.label_zipCode.Location = new System.Drawing.Point(477, 31);
            this.label_zipCode.Name = "label_zipCode";
            this.label_zipCode.Size = new System.Drawing.Size(19, 25);
            this.label_zipCode.TabIndex = 6;
            this.label_zipCode.Text = "-";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(213, 74);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(19, 25);
            this.label_FirstName.TabIndex = 5;
            this.label_FirstName.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Zip code :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 25);
            this.label12.TabIndex = 3;
            this.label12.Text = "First Name :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Phone num :";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Location = new System.Drawing.Point(213, 31);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(19, 25);
            this.label_lastname.TabIndex = 1;
            this.label_lastname.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Last Name :";
            // 
            // groupBox_FilterClient
            // 
            this.groupBox_FilterClient.Controls.Add(this.textBox_filterPhoneNum);
            this.groupBox_FilterClient.Controls.Add(this.textBox_filterClientLastName);
            this.groupBox_FilterClient.Controls.Add(this.textBox_FilterClientId);
            this.groupBox_FilterClient.Controls.Add(this.label8);
            this.groupBox_FilterClient.Controls.Add(this.label7);
            this.groupBox_FilterClient.Controls.Add(this.label5);
            this.groupBox_FilterClient.Location = new System.Drawing.Point(21, 78);
            this.groupBox_FilterClient.Name = "groupBox_FilterClient";
            this.groupBox_FilterClient.Size = new System.Drawing.Size(506, 317);
            this.groupBox_FilterClient.TabIndex = 0;
            this.groupBox_FilterClient.TabStop = false;
            // 
            // textBox_filterPhoneNum
            // 
            this.textBox_filterPhoneNum.Location = new System.Drawing.Point(192, 152);
            this.textBox_filterPhoneNum.Name = "textBox_filterPhoneNum";
            this.textBox_filterPhoneNum.Size = new System.Drawing.Size(100, 31);
            this.textBox_filterPhoneNum.TabIndex = 5;
            // 
            // textBox_filterClientLastName
            // 
            this.textBox_filterClientLastName.Location = new System.Drawing.Point(192, 104);
            this.textBox_filterClientLastName.Name = "textBox_filterClientLastName";
            this.textBox_filterClientLastName.Size = new System.Drawing.Size(100, 31);
            this.textBox_filterClientLastName.TabIndex = 4;
            // 
            // textBox_FilterClientId
            // 
            this.textBox_FilterClientId.Location = new System.Drawing.Point(192, 56);
            this.textBox_FilterClientId.Name = "textBox_FilterClientId";
            this.textBox_FilterClientId.Size = new System.Drawing.Size(100, 31);
            this.textBox_FilterClientId.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phone Num :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Id :";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1055, 743);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 913);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Order";
            this.Text = "Form_Order";
            this.tabControl1.ResumeLayout(false);
            this.OrderProduct.ResumeLayout(false);
            this.OrderProduct.PerformLayout();
            this.groupBox_filter1.ResumeLayout(false);
            this.groupBox_filter1.PerformLayout();
            this.Client.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox_FilterClient.ResumeLayout(false);
            this.groupBox_FilterClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OrderProduct;
        private System.Windows.Forms.TabPage Client;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox listBox_Order;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.GroupBox groupBox_filter1;
        private System.Windows.Forms.TextBox textBox_comment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox_FilterClient;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_filterPhoneNum;
        private System.Windows.Forms.TextBox textBox_filterClientLastName;
        private System.Windows.Forms.TextBox textBox_FilterClientId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_phonenum;
        private System.Windows.Forms.Label label_zipCode;
        private System.Windows.Forms.Label label_FirstName;
    }
}