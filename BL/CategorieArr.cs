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
   public class CategorieArr : ArrayList
    {

        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Categorie_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Categorie curCategorie;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {   
                dataRow = dataTable.Rows[i];
                curCategorie = new Categorie(dataRow);
                this.Add(curCategorie);
            }
        }

        public bool IsContain(string categorieName)
        {

            //בדיקה האם יש ישוב עם אותו שם
            string curCategorieName;
            for (int i = 0; i < this.Count; i++)
            {
                curCategorieName = (this[i] as Categorie).Name;


                if (curCategorieName == categorieName)
                    return true;

            }
            return false;
        }

        public Categorie GetCategorieWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Categorie maxCategorie = new Categorie();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Categorie).Id > maxCategorie.Id)
                    maxCategorie = this[i] as Categorie;

            return maxCategorie;
        }

    }
}
