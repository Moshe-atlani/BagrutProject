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

namespace WindowsFormsApp_MA.UI
{
    public partial class Form_Categorie : Form
    {
        public Categorie SelectedCategorie { get => listBox_categorie.SelectedItem as Categorie; }

        public Form_Categorie(Categorie categorie = null)
        {
            InitializeComponent();
            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (categorie != null && categorie.Id <= 0)
                categorie = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CategorieArrToForm(categorie);
            CategorieToForm(categorie);
            CapsLockChek();
        }

        private bool CheckForm()
        {

            //return si tout se que le client a remplie et bon ( le nombre de lettre )

            bool flag = true;
            if (textBox_Categorie.Text.Length < 2)
            {
                flag = false;
                textBox_Categorie.BackColor = Color.Red;
            }
            else
                textBox_Categorie.BackColor = Color.White;

            return flag;
        }

        private Categorie FormToCategorie()
        {
            Categorie categorie = new Categorie();

            categorie.Name = textBox_Categorie.Text;


            categorie.Id = int.Parse(label_Id.Text);

            return categorie;
        }
        //jai  pa sfait l eclair
        private void textBox_Let_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEnglishLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
                e.KeyChar = char.MinValue;
            if (CapsLockChek())
            {
                MessageBox.Show("CapsLock is locked");
                e.KeyChar = char.MinValue;

            }
        } // verification pour les lettre

        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        private bool IsEnglishLetter(char c)
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }


        private void Form_Categorie_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            //verifie que ca n ecrie pas en hebre
            InputLanguage myCurrentLang =
            InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() == "he-il")
                MessageBox.Show("You are hebre letter", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }


        private void CategorieArrToForm(Categorie curCategorie)//a voir avec raf 1.6
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CategorieArr categorieArr = new CategorieArr();
            categorieArr.Fill();
            listBox_categorie.DataSource = categorieArr;
            listBox_categorie.ValueMember = "Id";//
            listBox_categorie.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCategorie != null)
                listBox_categorie.SelectedValue = curCategorie.Id;

        }


        private void CategorieToForm(Categorie categorie)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס


            if (categorie != null)
            {
                label_Id.Text = categorie.Id.ToString();
                textBox_Categorie.Text = categorie.Name;

            }
            else
            {

                label_Id.Text = "0";
                textBox_Categorie.Text = "";

            }

        }

        private void listBox_Categorie_DoubleClick(object sender, EventArgs e)
        {
            CategorieToForm(listBox_categorie.SelectedItem as Categorie);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Categorie categorie = FormToCategorie();
            if (categorie.Id == 0)
                MessageBox.Show("You must select a categorie");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ProductArr productArr = new ProductArr();//asldkxcjdkslxkcj
                    productArr.Fill();
                    if (productArr.IsContains(categorie))
                        MessageBox.Show("You can’t delete a categorie that is related to a client");
                    else
                    if (categorie.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CategorieToForm(null);
                        CategorieArrToForm(categorie);
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())

                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                Categorie categorie = FormToCategorie();
                if (categorie.Id == 0)
                {
                    CategorieArr oldCategorieeArr = new CategorieArr();
                    oldCategorieeArr.Fill();
                    if (!oldCategorieeArr.IsContain(categorie.Name))
                    {



                        if (categorie.Insert())
                        {
                            CategorieArr categorieArr = new CategorieArr();
                            categorieArr.Fill();
                            categorie = categorieArr.GetCategorieWithMaxId();

                            MessageBox.Show("Thank you for you registration!");
                            CategorieArrToForm(categorie);
                        }

                        else
                            MessageBox.Show("Couldn't add the categorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                        MessageBox.Show("categorie already existing");

                }

                else
                {
                    if (categorie.Update())
                    {
                        MessageBox.Show("Update succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CategorieArrToForm(categorie);
                    }

                    else
                        MessageBox.Show("Couldn't update the categorie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
        }


    }
}
