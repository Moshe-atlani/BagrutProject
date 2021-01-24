using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_MA.DAL;
using WindowsFormsApp_MA.BL;
using System.Data;

namespace WindowsFormsApp_MA.BL
{
    public class Client
    {
        private int m_id;
        private string m_firstName;
        private string m_lastName;
        private string m_cellAreaCode;
        private int m_cellPhone;
        private int m_zipCode;
        private int m_age;
        private City m_city;
        

        public string FirstName { get => m_firstName; set => m_firstName = value; }
        public string LastName { get => m_lastName; set => m_lastName = value; }
        public string CellAreaCode { get => m_cellAreaCode; set => m_cellAreaCode = value; }
        public int CellPhone { get => m_cellPhone; set => m_cellPhone = value; }
        public int ZipCode { get => m_zipCode; set => m_zipCode = value; }
        public int Age { get => m_age; set => m_age = value; }
        public int Id { get => m_id; set => m_id = value; }
        public City City { get => m_city; set => m_city = value; }
        public Client() { }

        public Client(DataRow dataRow)//a voir avec raf 1.6
        {

            //מייצרת לקוח מתוך שורת לקוח
            Id = (int)dataRow["id"];
            m_firstName = dataRow["FirstName"].ToString();
            m_lastName = dataRow["LastName"].ToString();
            m_cellPhone = (int)dataRow["CellPhoneNumber"];
            m_cellAreaCode = dataRow["CellAreaCode"].ToString();
            m_zipCode = (int)dataRow["ZipCode"];
            m_age = (int)dataRow["Age"];
            m_city = new City(dataRow.GetParentRow("ClientCity"));
        }

        public override string ToString()
        { return $"{m_lastName} {m_firstName} {m_cellAreaCode}"; }

        public bool Insert()
        {
            return Dal_Client.Insert(m_firstName, m_lastName, m_cellPhone,
            m_cellAreaCode, m_zipCode, m_age, m_city.Id);
        }

        public bool Update()
        {
            return Dal_Client.Update(m_id, m_firstName, m_lastName, m_cellPhone,
            m_cellAreaCode, m_zipCode, m_age, m_city.Id);
        }

        public bool Delete()
        {
            return Dal_Client.Delete(m_id);
        }

    }
}
