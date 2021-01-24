using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp_MA.DAL;
using System.Data;
using WindowsFormsApp_MA.BL;

namespace WindowsFormsApp_MA.BL
{
   public class Product
    {
        private int m_id;
        private string m_name_Product;
        private Companie m_companie;
        private Categorie m_categorie;


        public string Name_Product { get => m_name_Product; set => m_name_Product = value; }
        public Companie Companie { get => m_companie; set => m_companie = value; }
        public Categorie Categorie { get => m_categorie; set => m_categorie = value; }
        public int Id { get => m_id; set => m_id = value; }

        public Product() { }

        public Product(DataRow dataRow)
        {

            //מייצרת לקוח מתוך שורת לקוח
            Id = (int)dataRow["Id"];
            m_name_Product = dataRow["Name_Product"].ToString();
            m_companie =  new Companie(dataRow.GetParentRow("ProductCompanie")); 
             m_categorie =  new Categorie(dataRow.GetParentRow("ProductCategorie"));


        }

        public override string ToString()
        { return $" {m_name_Product} {m_categorie} {m_companie} "; }

        public bool Insert()
        {
            return Product_Dal.Insert(m_name_Product, m_companie.Id, m_categorie.Id);
        }

        public bool Update()
        {
            return Product_Dal.Update(m_id, m_name_Product, m_companie.Id, m_categorie.Id);
        }

        public bool Delete()
        {
            return Product_Dal.Delete(m_id);
        }

    }
}
