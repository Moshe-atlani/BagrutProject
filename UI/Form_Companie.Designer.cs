namespace WindowsFormsApp_MA.UI
{
    partial class Form_Companie
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
            this.listBox_companie = new System.Windows.Forms.ListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Companie = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_companie
            // 
            this.listBox_companie.FormattingEnabled = true;
            this.listBox_companie.ItemHeight = 25;
            this.listBox_companie.Location = new System.Drawing.Point(495, 96);
            this.listBox_companie.Name = "listBox_companie";
            this.listBox_companie.Size = new System.Drawing.Size(252, 379);
            this.listBox_companie.TabIndex = 15;
            this.listBox_companie.Click += new System.EventHandler(this.listBox_Companie_DoubleClick);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(282, 378);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(115, 87);
            this.button_Delete.TabIndex = 14;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(101, 378);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(124, 87);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_Companie
            // 
            this.textBox_Companie.Location = new System.Drawing.Point(258, 244);
            this.textBox_Companie.Name = "textBox_Companie";
            this.textBox_Companie.Size = new System.Drawing.Size(100, 31);
            this.textBox_Companie.TabIndex = 12;
            this.textBox_Companie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(260, 193);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 25);
            this.label_Id.TabIndex = 11;
            this.label_Id.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Companie name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id :";
            // 
            // Form_Companie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 724);
            this.Controls.Add(this.listBox_companie);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Companie);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Companie";
            this.Text = "Form_Companie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_companie;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Companie;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}