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
    public partial class Form_Order : Form
    {


        public Form_Order()
        {
            InitializeComponent();
            OrderArrToForm();
        }
        #region OrderPage


        private bool IsEnglishLetter(char c)
        {
            return ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
        }


        private bool CapsLockChek()
        {
            return (Control.IsKeyLocked(Keys.CapsLock));
        }

        private void Form_Order_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e)
        {
            //verifie que ca n'ecrit pas en hebreu

            InputLanguage myCurrentLang =
            InputLanguage.CurrentInputLanguage;
            if (myCurrentLang.Culture.Name.ToLower() == "he-il")
                MessageBox.Show("You are hebre letter", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }


        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifie que ca resoi des chiffre

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
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



        private bool CheckForm()
        {

            //return si tout se que le client a remplie et bon ( le nombre de lettre )

            bool flag = true;
            if (textBox_comment.Text.Length < 2)
            {
                flag = false;
                textBox_comment.BackColor = Color.Red;
            }
            else
                textBox_comment.BackColor = Color.White;

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
                Order order = FormToOrder();//vue que tt est bon on cree un client pour commencer le prosses de sauvgarde

                if (order.Id == 0)
                {

                    if (order.Insert())
                    {
                        MessageBox.Show("Added successfully");
                        OrderArrToForm();
                    }
                    else
                        MessageBox.Show("Error Adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (order.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        OrderArrToForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }


            }


        }

        private Order FormToOrder()
        {
            //rend un "client" avec toute les donner retrer ds les textBox 
            //cette peoula sera ensuite utiliser par la peoula save

            Order order = new Order();
            order.Comment = textBox_comment.Text;
            order.Date =dateTimePicker1.Value;
            order.Client = (listBox_Clients.SelectedItem as Client);
            return order;
        }

        private void OrderArrToForm()//a voir avec raf 1.6
        {

            //ממירה את הטנ "מ אוסף לקוחות לטופס
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Order.DataSource = orderArr;
        }


        private void OrderToForm(Order order)
        {

            //ממירה את המידע בטנ "מ לקוח לטופס


            if (order != null)
            {
                textBox_comment.Text = order.Comment;

                label_id.Text = order.Id.ToString();
                dateTimePicker1.Value = order.Date;
                //avec client  je  sais  pas quoi mettre(c'est pas clair)
               
            }
            else
            {

                label_id.Text = "0";
                textBox_comment.Text = "";
                dateTimePicker1.Text = "";
                //avec client  je  sais  pas quoi mettre(c'est pas clair)


            }

        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            Order order = FormToOrder();//
            if (order.Id == 0)
            {
                MessageBox.Show("No order selected for deletion");

            }
            else
            {

                //בהמשך תהיה כאן בדיקה שאין מידע נוסף על לקוח זה
                if (MessageBox.Show("You are sure that you want to delete ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign |
                MessageBoxOptions.RtlReading) ==
                System.Windows.Forms.DialogResult.Yes)
                {
                    order.Delete();
                    OrderToForm(null);
                    OrderArrToForm();          
                }
            }
        }

        private void listBox_Order_DoubleClick(object sender, EventArgs e)
        {
            OrderToForm(listBox_Order.SelectedItem as Order);
        }

        //faire la פעולה filter 






        #endregion OrderPage

        #region Client
        private void ClientArrToForm()
        {

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
            listBox_Clients.ValueMember = "ID";
            listBox_Clients.DisplayMember = "";
        }

        private void listBox_Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }

        private void ClientToForm(Client client)
        {
            label_FirstName.Text = client.FirstName;
            label_lastname.Text = client.LastName;
            label_zipCode.Text = client.ZipCode.ToString();
            label_phonenum.Text = client.CellPhone.ToString();

        }


        private void textBox_Filter_Client_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            //אם המשתמש רשם ערך בשדה המזהה

            if (textBox_FilterClientId.Text != "")
                id = int.Parse(textBox_FilterClientId.Text);

            //מייצרים אוסף של כלל הלקוחות

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש

            clientArr = clientArr.Filter(id, textBox_filterClientLastName.Text,
            textBox_filterPhoneNum.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות

            listBox_Clients.DataSource = clientArr;
        }

        #endregion Client 


    }
}
