using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_MA.BL;
using WindowsFormsApp_MA.DAL;
using WindowsFormsApp_MA.UI;


namespace WindowsFormsApp_MA.UI
{
    public partial class Form_Product : Form
    {


        public Form_Product()
        {
            InitializeComponent();

            Form_Product_InputLanguageChanged(null, null);
            ProductArrToForm();
            CategorieArrToForm(comboBox_FilterCategorie, false, null);
            CompanieArrToForm(comboBox_FilterCompanie, false, null);
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private bool CheckForm()
        {

            //return si tout se que le client a remplie et bon ( le nombre de lettre )

            bool flag = true;
            if (textBox_NameProduct.Text.Length < 2)
            {
                flag = false;
                textBox_NameProduct.BackColor = Color.Red;
            }
            else
                textBox_NameProduct.BackColor = Color.White;
            //
            if (comboBox_Categorie.Text.Length < 2)
            {
                flag = false;
                comboBox_Categorie.BackColor = Color.Red;
            }
            else
                comboBox_Categorie.BackColor = Color.White;
            //
            if (comboBox_Companie.Text.Length < 2)
            {
                flag = false;
                comboBox_Companie.BackColor = Color.Red;
            }
            else
                comboBox_Companie.BackColor = Color.White;

            return flag;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                Product product = FormToProduct();//vue que tt est bon on cree un product pour commencer le prosses de sauvgarde

                if (product.Id == 0)
                {

                    if (product.Insert())
                    {
                        MessageBox.Show("Added successfully");
                        ProductArrToForm();
                    }
                    else
                        MessageBox.Show("Error Adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (product.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ProductArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }


            }


        }

        private Product FormToProduct()
        {//rend un "pruduit" avec toute les donner retrer ds les textBox 
            //cette peoula sera ensuite utiliser par la peoula save
            Product product = new Product();

            product.Name_Product = textBox_NameProduct.Text;
            product.Categorie = comboBox_Categorie.SelectedItem as Categorie;
            product.Companie = comboBox_Companie.SelectedItem as Companie;
            product.Id = int.Parse(label_Id.Text);

            return product;
        }

        private void textBox_Let_KeyPress(object sender, KeyPressEventArgs e)//jsp trop ou le maittre
        {
            if (!IsEnglishLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
                e.KeyChar = char.MinValue;
            if (CapsLockChek())
            {
                MessageBox.Show("CapsLock is locked");
                e.KeyChar = char.MinValue;

            }
        } // verification pour les lettre

        private bool CapsLockChek()//sa serre vrm sa ?
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        private bool IsEnglishLetter(char c)//je c pas trop ou le maitre
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }

        private void Form_Product_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            //verifie que ca n ecrie pas en hebre
            InputLanguage myCurrentLang =
            InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() == "he-il")
                MessageBox.Show("You are hebre letter", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }


        private void ProductArrToForm()
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            listBox_Products.DataSource = productArr;
        }


        private void ProductToForm(Product product)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס


            if (product != null)
            {
                label_Id.Text = product.Id.ToString();
                textBox_NameProduct.Text = product.Name_Product;
                comboBox_Categorie.SelectedValue = product.Categorie.Id;
                comboBox_Companie.SelectedValue = product.Companie.Id;
            }
            else
            {

                label_Id.Text = "0";
                textBox_NameProduct.Text = "";
                comboBox_Categorie.SelectedItem = null;
                comboBox_Companie.SelectedItem = null;
            }

        }

        private void listBox_Products_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listBox_Products.SelectedItem as Product);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Product product = FormToProduct();//
            if (product.Id == 0)
            {
                MessageBox.Show("No product selected for deletion");

            }
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("You are sure that you want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    product.Delete();
                    ProductToForm(null);
                    ProductArrToForm();
                }
            }
        }

       

        public void CategorieArrToForm(ComboBox comboBox, bool isMustChoose, Categorie curCategorie = null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CategorieArr categorieArr = new CategorieArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Categorie categorieDefault = new Categorie();
            categorieDefault.Id = -1;
            if (isMustChoose)
                categorieDefault.Name = "choice a categorie";
            else
                categorieDefault.Name = "All categorie";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            categorieArr.Add(categorieDefault);

            categorieArr.Fill();

            comboBox_Categorie.DataSource = categorieArr;
            comboBox_Categorie.ValueMember = "ID";
            comboBox_Categorie.DisplayMember = "Name";

            if (curCategorie != null)
                comboBox_Categorie.SelectedValue = curCategorie.Id;
        }

        public void CompanieArrToForm(ComboBox comboBox, bool isMustChoose, Companie curCompanie = null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CompanieArr companieArr = new CompanieArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            Companie companieDefault = new Companie();
            companieDefault.Id = -1;
            if (isMustChoose)
                companieDefault.Name = "choice a companie";
            else
                companieDefault.Name = "All companie";
            //הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            companieArr.Add(companieDefault);

            companieArr.Fill();

            comboBox_Companie.DataSource = companieArr;
            comboBox_Companie.ValueMember = "ID";
            comboBox_Companie.DisplayMember = "Name";

            if (curCompanie != null)
                comboBox_Companie.SelectedValue = curCompanie.Id;
        }

        private void button_AddCatogorie_Click(object sender, EventArgs e)
        {

            Form_Categorie form_Categorie;
            form_Categorie = new Form_Categorie();
            form_Categorie.ShowDialog();
            CategorieArrToForm(comboBox_Categorie, false, form_Categorie.SelectedCategorie);
        }


        private void button_AddCompanie_Click(object sender, EventArgs e)
        {

            Form_Companie form_Companie;
            form_Companie = new Form_Companie();
            form_Companie.ShowDialog();
            CompanieArrToForm(comboBox_Companie, false, form_Companie.SelectedCompanie);
        }

        //Filter
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }


        private void SetProductsByFilter()
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (filter_Id.Text != "")
                id = int.Parse(filter_Id.Text);

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(id, filter_NameProduct.Text,
            comboBox_FilterCompanie.SelectedItem as Companie,
            comboBox_FilterCategorie.SelectedItem as Categorie);

            //מציבים בתיבת הרשימה את אוסף המוצרים

            listBox_Products.DataSource = productArr;

        }

        
    }
}

