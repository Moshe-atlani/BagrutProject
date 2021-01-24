namespace WindowsFormsApp_MA.UI
{
    partial class Form_Categorie
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
            this.listBox_categorie = new System.Windows.Forms.ListBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_Categorie = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_categorie
            // 
            this.listBox_categorie.FormattingEnabled = true;
            this.listBox_categorie.ItemHeight = 25;
            this.listBox_categorie.Location = new System.Drawing.Point(476, 61);
            this.listBox_categorie.Name = "listBox_categorie";
            this.listBox_categorie.Size = new System.Drawing.Size(252, 379);
            this.listBox_categorie.TabIndex = 23;
            this.listBox_categorie.Click += new System.EventHandler(this.listBox_Categorie_DoubleClick);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(263, 343);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(115, 87);
            this.button_Delete.TabIndex = 22;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(82, 343);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(124, 87);
            this.button_Save.TabIndex = 21;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_Categorie
            // 
            this.textBox_Categorie.Location = new System.Drawing.Point(239, 209);
            this.textBox_Categorie.Name = "textBox_Categorie";
            this.textBox_Categorie.Size = new System.Drawing.Size(100, 31);
            this.textBox_Categorie.TabIndex = 20;
            this.textBox_Categorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(241, 158);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 25);
            this.label_Id.TabIndex = 19;
            this.label_Id.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Companie name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Id :";
            // 
            // Form_Categorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 656);
            this.Controls.Add(this.listBox_categorie);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_Categorie);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Categorie";
            this.Text = "Form_Categorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_categorie;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_Categorie;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}