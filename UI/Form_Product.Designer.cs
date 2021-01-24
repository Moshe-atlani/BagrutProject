namespace WindowsFormsApp_MA.UI
{
    partial class Form_Product
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.textBox_NameProduct = new System.Windows.Forms.TextBox();
            this.comboBox_Categorie = new System.Windows.Forms.ComboBox();
            this.comboBox_Companie = new System.Windows.Forms.ComboBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_FilterCompanie = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterCategorie = new System.Windows.Forms.ComboBox();
            this.Companie = new System.Windows.Forms.Label();
            this.filter_NameProduct = new System.Windows.Forms.TextBox();
            this.filter_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.button_AddCategorie = new System.Windows.Forms.Button();
            this.button_AddCompanie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categorie :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Companie :";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(228, 83);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(24, 25);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "0";
            // 
            // textBox_NameProduct
            // 
            this.textBox_NameProduct.Location = new System.Drawing.Point(233, 198);
            this.textBox_NameProduct.Name = "textBox_NameProduct";
            this.textBox_NameProduct.Size = new System.Drawing.Size(100, 31);
            this.textBox_NameProduct.TabIndex = 5;
            this.textBox_NameProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Let_KeyPress);
            // 
            // comboBox_Categorie
            // 
            this.comboBox_Categorie.FormattingEnabled = true;
            this.comboBox_Categorie.Location = new System.Drawing.Point(233, 310);
            this.comboBox_Categorie.Name = "comboBox_Categorie";
            this.comboBox_Categorie.Size = new System.Drawing.Size(121, 33);
            this.comboBox_Categorie.TabIndex = 6;
            // 
            // comboBox_Companie
            // 
            this.comboBox_Companie.FormattingEnabled = true;
            this.comboBox_Companie.Location = new System.Drawing.Point(233, 407);
            this.comboBox_Companie.Name = "comboBox_Companie";
            this.comboBox_Companie.Size = new System.Drawing.Size(121, 33);
            this.comboBox_Companie.TabIndex = 7;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(65, 528);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(158, 80);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(278, 527);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 81);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_FilterCompanie);
            this.groupBox1.Controls.Add(this.comboBox_FilterCategorie);
            this.groupBox1.Controls.Add(this.Companie);
            this.groupBox1.Controls.Add(this.filter_NameProduct);
            this.groupBox1.Controls.Add(this.filter_Id);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(723, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 323);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // comboBox_FilterCompanie
            // 
            this.comboBox_FilterCompanie.FormattingEnabled = true;
            this.comboBox_FilterCompanie.Location = new System.Drawing.Point(176, 236);
            this.comboBox_FilterCompanie.Name = "comboBox_FilterCompanie";
            this.comboBox_FilterCompanie.Size = new System.Drawing.Size(121, 33);
            this.comboBox_FilterCompanie.TabIndex = 18;
            this.comboBox_FilterCompanie.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_FilterCategorie
            // 
            this.comboBox_FilterCategorie.FormattingEnabled = true;
            this.comboBox_FilterCategorie.Location = new System.Drawing.Point(175, 133);
            this.comboBox_FilterCategorie.Name = "comboBox_FilterCategorie";
            this.comboBox_FilterCategorie.Size = new System.Drawing.Size(121, 33);
            this.comboBox_FilterCategorie.TabIndex = 17;
            this.comboBox_FilterCategorie.TextChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // Companie
            // 
            this.Companie.AutoSize = true;
            this.Companie.Location = new System.Drawing.Point(39, 239);
            this.Companie.Name = "Companie";
            this.Companie.Size = new System.Drawing.Size(121, 25);
            this.Companie.TabIndex = 16;
            this.Companie.Text = "Companie :";
            // 
            // filter_NameProduct
            // 
            this.filter_NameProduct.Location = new System.Drawing.Point(175, 86);
            this.filter_NameProduct.Name = "filter_NameProduct";
            this.filter_NameProduct.Size = new System.Drawing.Size(100, 31);
            this.filter_NameProduct.TabIndex = 14;
            this.filter_NameProduct.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // filter_Id
            // 
            this.filter_Id.Location = new System.Drawing.Point(176, 41);
            this.filter_Id.Name = "filter_Id";
            this.filter_Id.Size = new System.Drawing.Size(100, 31);
            this.filter_Id.TabIndex = 13;
            this.filter_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            this.filter_Id.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Categorie :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Product name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Id :";
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 25;
            this.listBox_Products.Location = new System.Drawing.Point(678, 364);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(389, 379);
            this.listBox_Products.TabIndex = 11;
            this.listBox_Products.DoubleClick += new System.EventHandler(this.listBox_Products_DoubleClick);
            // 
            // button_AddCategorie
            // 
            this.button_AddCategorie.Location = new System.Drawing.Point(361, 310);
            this.button_AddCategorie.Name = "button_AddCategorie";
            this.button_AddCategorie.Size = new System.Drawing.Size(39, 42);
            this.button_AddCategorie.TabIndex = 12;
            this.button_AddCategorie.Text = "+";
            this.button_AddCategorie.UseVisualStyleBackColor = true;
            this.button_AddCategorie.Click += new System.EventHandler(this.button_AddCatogorie_Click);
            // 
            // button_AddCompanie
            // 
            this.button_AddCompanie.Location = new System.Drawing.Point(361, 407);
            this.button_AddCompanie.Name = "button_AddCompanie";
            this.button_AddCompanie.Size = new System.Drawing.Size(38, 42);
            this.button_AddCompanie.TabIndex = 13;
            this.button_AddCompanie.Text = "+";
            this.button_AddCompanie.UseVisualStyleBackColor = true;
            this.button_AddCompanie.Click += new System.EventHandler(this.button_AddCompanie_Click);
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 784);
            this.Controls.Add(this.button_AddCompanie);
            this.Controls.Add(this.button_AddCategorie);
            this.Controls.Add(this.listBox_Products);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.comboBox_Companie);
            this.Controls.Add(this.comboBox_Categorie);
            this.Controls.Add(this.textBox_NameProduct);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Product";
            this.Text = "Form_Product";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form_Product_InputLanguageChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.TextBox textBox_NameProduct;
        private System.Windows.Forms.ComboBox comboBox_Categorie;
        private System.Windows.Forms.ComboBox comboBox_Companie;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filter_NameProduct;
        private System.Windows.Forms.TextBox filter_Id;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.Label Companie;
        private System.Windows.Forms.Button button_AddCategorie;
        private System.Windows.Forms.Button button_AddCompanie;
        private System.Windows.Forms.ComboBox comboBox_FilterCompanie;
        private System.Windows.Forms.ComboBox comboBox_FilterCategorie;
    }
}