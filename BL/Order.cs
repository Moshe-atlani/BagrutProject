using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp_MA.DAL;

namespace WindowsFormsApp_MA.BL
{
   public class Order
    {
        private Client m_client;
        private DateTime m_date;
        private string m_comment;
        private int m_id;


        public Client Client { get => m_client; set => m_client = value; }
        public DateTime Date { get => m_date; set => m_date = value; }
        public string Comment { get => m_comment; set => m_comment = value; }
        public int Id { get => m_id; set => m_id = value; }



        public Order() { }

        public Order(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח

            this.m_id = (int)dataRow["ID"];
            m_client = new Client(dataRow.GetParentRow("OrderClient"));
            m_date = DateTime.Parse(dataRow["date"].ToString());
            m_comment = dataRow["Comment"].ToString();



        }

        public bool Insert()
        {
            return Order_Dal.Insert(m_client.Id, m_date, m_comment);
        }

        public bool Update()
        {
            return Order_Dal.Update(m_id, m_client.Id, m_date, m_comment);
        }


        public bool Delete()
        {
            return Order_Dal.Delete(m_id);
        }

        public override string ToString()
        {
            return "OrderClient: " + $"{ m_date.ToString()} : {m_id}";
        }


    }
}

