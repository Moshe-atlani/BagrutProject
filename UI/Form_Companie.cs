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
    public partial class Form_Companie : Form
    {
        public Companie SelectedCompanie { get => listBox_companie.SelectedItem as Companie; }

        public Form_Companie(Companie companie = null)
        {
            InitializeComponent();
            //אם נשלח ישוב שאינו ישוב אמיתי )נדבר על זה בהמשך( - לאפס אותו

            if (companie != null && companie.Id <= 0)
                companie = null;

            //טעינת אוסף הישובים לרשימה בטופס

            CompanieArrToForm(companie);
            CompanieToForm(companie);
            CapsLockChek();
        }

        private bool CheckForm()
        {

            //return si tout se que le client a remplie et bon ( le nombre de lettre )

            bool flag = true;
            if (textBox_Companie.Text.Length < 2)
            {
                flag = false;
                textBox_Companie.BackColor = Color.Red;
            }
            else
                textBox_Companie.BackColor = Color.White;

            return flag;
        }

        private Companie FormToCompanie()
        {
            Companie companie = new Companie();

            companie.Name = textBox_Companie.Text;


            companie.Id = int.Parse(label_Id.Text);

            return companie;
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


        private void Form_Companie_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            //verifie que ca n ecrie pas en hebre
            InputLanguage myCurrentLang =
            InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() == "he-il")
                MessageBox.Show("You are hebre letter", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }


        private void CompanieArrToForm(Companie curCompanie)//a voir avec raf 1.6
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            CompanieArr companieArr = new CompanieArr();
            companieArr.Fill();
            listBox_companie.DataSource = companieArr;
            listBox_companie.ValueMember = "Id";//
            listBox_companie.DisplayMember = "Name";

            //אם נשלח לפעולה ישוב ,הצבתו בתיבת הבחירה של ישובים בטופס

            if (curCompanie != null)
                listBox_companie.SelectedValue = curCompanie.Id;

        }


        private void CompanieToForm(Companie companie)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס


            if (companie != null)
            {
                label_Id.Text = companie.Id.ToString();
                textBox_Companie.Text = companie.Name;

            }
            else
            {

                label_Id.Text = "0";
                textBox_Companie.Text = "";

            }

        }

        private void listBox_Companie_DoubleClick(object sender, EventArgs e)
        {
            CompanieToForm(listBox_companie.SelectedItem as Companie);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Companie companie = FormToCompanie();
            if (companie.Id == 0)
                MessageBox.Show("You must select a companie");
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
                    if (productArr.IsContains(companie))
                        MessageBox.Show("You can’t delete a companie that is related to a client");
                    else
                    if (companie.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CompanieToForm(null);
                        CompanieArrToForm(companie);
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
                Companie companie = FormToCompanie();
                if (companie.Id == 0)
                {
                    CompanieArr oldCompanieArr = new CompanieArr();
                    oldCompanieArr.Fill();
                    if (!oldCompanieArr.IsContain(companie.Name))
                    {



                        if (companie.Insert())
                        {
                            CompanieArr companieArr = new CompanieArr();
                            companieArr.Fill();
                            companie = companieArr.GetCompanieWithMaxId();

                            MessageBox.Show("Thank you for you registration!");
                            CompanieArrToForm(companie);
                        }

                        else
                            MessageBox.Show("Couldn't add the companie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                        MessageBox.Show("companie already existing");

                }

                else
                {
                    if (companie.Update())
                    {
                        MessageBox.Show("Update succesfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CompanieArrToForm(companie);
                    }

                    else
                        MessageBox.Show("Couldn't update the companie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
        }

    }
}
