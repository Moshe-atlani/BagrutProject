namespace WindowsFormsApp_MA.UI
{
    partial class Form_City
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.listBox_City = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(249, 183);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 25);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 86);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 86);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ciyt Name :";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(243, 234);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(100, 31);
            this.textBox_city.TabIndex = 5;
            this.textBox_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // listBox_City
            // 
            this.listBox_City.FormattingEnabled = true;
            this.listBox_City.ItemHeight = 25;
            this.listBox_City.Location = new System.Drawing.Point(477, 111);
            this.listBox_City.Name = "listBox_City";
            this.listBox_City.Size = new System.Drawing.Size(270, 379);
            this.listBox_City.TabIndex = 6;
            this.listBox_City.Click += new System.EventHandler(this.listBox_City_DoubleClick);
            // 
            // Form_City
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 801);
            this.Controls.Add(this.listBox_City);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label1);
            this.Name = "Form_City";
            this.Text = "Form_City";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.ListBox listBox_City;
    }
}