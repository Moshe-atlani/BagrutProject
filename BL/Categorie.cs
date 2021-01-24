using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_MA.DAL;
using System.Data;

namespace WindowsFormsApp_MA.BL
{
   public class Categorie
    {
        private int m_id;
        private string m_Name;

        public int Id { get => m_id; set => m_id = value; }
        public string Name { get => m_Name; set => m_Name = value; }

        public Categorie() { }

        public Categorie(DataRow dataRow)
        {
            Id = (int)dataRow["id"];
            m_Name = dataRow["Name"].ToString();
        }

        public bool Insert()
        {
            return Categorie_Dal.Insert(m_Name);
        }

        public bool Update()
        {
            return Categorie_Dal.Update(m_id, m_Name);
        }

        public bool Delete()
        {
            return Categorie_Dal.Delete(m_id);
        }

        public override string ToString()
        { return $"{m_Name} "; }

    }
}
