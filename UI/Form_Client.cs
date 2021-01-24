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

namespace WindowsFormsApp_MA
{
    public partial class Form1 : Form
    {
  

        public Form1()
        {
            InitializeComponent();

            Form_Client_InputLanguageChanged(null, null);
            ClientArrToForm();
            CityArrToForm();
             
        }

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifie que ca resoi des chiffre

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

        private bool CheckForm()
        {

            //return si tout se que le client a remplie et bon ( le nombre de lettre )

            bool flag = true;
            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
                textBox_FirstName.BackColor = Color.White;
            //
            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;
            //
            if (comboBox_CellAreaCode.Text.Length == 0)
            {
                flag = false;
                comboBox_CellAreaCode.BackColor = Color.Red;
            }
            else
                comboBox_CellAreaCode.BackColor = Color.White;
            //
            if (textBox_Cel.Text.Length != 10)
            {
                flag = false;
                textBox_Cel.BackColor = Color.Red;
            }
            else
                textBox_Cel.BackColor = Color.White;
            //
            if (textBox_ZipCode.Text.Length != 7)
            {
                flag = false;
                textBox_ZipCode.BackColor = Color.Red;
            }
            else
                textBox_ZipCode.BackColor = Color.White;
            //
            if (textBox_Age.Text.Length == 0 || textBox_Age.Text.Length > 3)
            {
                flag = false;
                textBox_Age.BackColor = Color.Red;
            }
            else
                textBox_Age.BackColor = Color.White;
            //
            if (comboBox_City.Text.Length < 2)
            {
                flag = false;
                comboBox_City.BackColor = Color.Red;
            }
            else
                comboBox_City.BackColor = Color.White;

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
                Client client = FormToClient();//vue que tt est bon on cree un client pour commencer le prosses de sauvgarde

                if (client.Id == 0)
                {

                    if (client.Insert())
                    {
                        MessageBox.Show("Added successfully");
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Error Adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (client.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }


            }


        }

        private Client FormToClient()
        {//rend un "client" avec toute les donner retrer ds les textBox 
            //cette peoula sera ensuite utiliser par la peoula save
            Client client = new Client();

            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            if (textBox_ZipCode.Text != "")
                client.ZipCode = int.Parse(textBox_ZipCode.Text);
            client.CellPhone = int.Parse(textBox_Cel.Text);
            client.CellAreaCode = comboBox_CellAreaCode.Text;
            client.Age = int.Parse(textBox_Age.Text);
            client.City = comboBox_City.SelectedItem as City;
            client.Id = int.Parse(label_ID.Text);

            return client;
        }

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

            private void Form_Client_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
            {
                //verifie que ca n ecrie pas en hebre
                InputLanguage myCurrentLang =
                InputLanguage.CurrentInputLanguage;
                if (myCurrentLang.Culture.Name.ToLower() == "he-il")
                    MessageBox.Show("You are hebre letter", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }


        private void ClientArrToForm()//a voir avec raf 1.6
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }


        private void ClientToForm(Client client)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס


            if (client != null)
            {
                label_ID.Text = client.Id.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                textBox_Cel.Text = client.CellPhone.ToString();
                comboBox_CellAreaCode.Text = client.CellAreaCode;
                textBox_ZipCode.Text = client.ZipCode.ToString();
                textBox_Age.Text = client.Age.ToString();
                comboBox_City.SelectedValue = client.City.Id;
            }
            else
            {

                label_ID.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_Cel.Text = "";
                comboBox_CellAreaCode.Text = "";
                textBox_ZipCode.Text = "";
                textBox_Age.Text = "";
                comboBox_City.SelectedItem = null;
            }

        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();//
            if (client.Id == 0)
            {
                MessageBox.Show("No client selected for deletion");

            }
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if(MessageBox.Show("You are sure that you want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                { 
                    client.Delete();
                    ClientToForm(null);
                    ClientArrToForm();
                }
            }
        }

        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (filter_Id.Text != "")
                id = int.Parse(filter_Id.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, filter_LastName.Text,
            filter_PhoneNum.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }


        public void CityArrToForm(City curCity = null)
        {

            //ממירה את הטנ "מ אוסף ישובים לטופס

            CityArr cityArr = new CityArr();

            //הוספת ישוב ברירת מחדל - בחר ישוב
            //יצירת מופע חדש של ישוב עם מזהה מינוס 1 ושם מתאים

            City cityDefault = new City();
            cityDefault.Id = -1;
            cityDefault.Name = "choice a city";
           
//הוספת הישוב לאוסף הישובים - אותו נציב במקור הנתונים של תיבת הבחירה

            cityArr.Add(cityDefault);

            cityArr.Fill();

            comboBox_City.DataSource = cityArr;
            comboBox_City.ValueMember = "ID";
            comboBox_City.DisplayMember = "Name";

            if (curCity != null)
                comboBox_City.SelectedValue = curCity.Id;
        }

        private void button_AddCity_Click(object sender, EventArgs e)
        {

            Form_City form_City;
            form_City = new Form_City();
            form_City.ShowDialog();
            CityArrToForm(form_City.SelectedCity);
        }
    }
}
