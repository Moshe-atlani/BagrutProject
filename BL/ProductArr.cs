using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using WindowsFormsApp_MA.DAL;


namespace WindowsFormsApp_MA.BL
{
   public class ProductArr : ArrayList
    {

        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Product_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Product curProduct;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curProduct = new Product(dataRow);
                this.Add(curProduct);
            }
        }

        public ProductArr Filter(int id, string Name_Pruduct, Companie companie, Categorie categorie)
        {
            ProductArr productArr = new ProductArr();
            Product product;
            for (int i = 0; i < this.Count; i++)
            {

                //הצבת הלקוח הנוכחי במשתנה עזר - לקוח

                product = (this[i] as Product);
                if
                (

                // מזהה 0 – כלומר, לא נבחר מזהה בסינון

                (id <= 0 || product.Id == id)
                && product.Name_Product.StartsWith(Name_Pruduct)
                && (companie == null || companie.Id == -1 || product.Companie.Id == companie.Id)
                && (categorie == null || categorie.Id == -1 || product.Categorie.Id == categorie.Id)
                )

                    //הלקוח ענה לדרישות הסינון - הוספת הלקוח לאוסף הלקוחות המוחזר

                    productArr.Add(product);

                if (id > 0) return productArr;
            }
            return productArr;
        }

       
        public bool IsContains(Categorie curCategorie)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Categorie.Id == curCategorie.Id)
                    return true;

            return false;
        }

        public bool IsContains(Companie curCompanie)
        {
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Product).Companie.Id == curCompanie.Id)
                    return true;

            return false;
        }

    }
}
