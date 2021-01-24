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
   public class CompanieArr : ArrayList
    {

        public void Fill()
        {

            //להביא מה-DAL טבלה מלאה בכל הלקוחות

            DataTable dataTable = Companie_Dal.GetDataTable();

            //להעביר את הערכים מהטבלה לתוך אוסף הלקוחות
            //להעביר כל שורה בטבלה ללקוח

            DataRow dataRow;
            Companie curCompanie;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataRow = dataTable.Rows[i];
                curCompanie = new Companie(dataRow);
                this.Add(curCompanie);
            }
        }

        public bool IsContain(string companieName)
        {

            //בדיקה האם יש ישוב עם אותו שם
            string curCompanieName;
            for (int i = 0; i < this.Count; i++)
            {
                curCompanieName = (this[i] as Companie).Name;


                if (curCompanieName == companieName)
                    return true;

            }
            return false;
        }

        public Companie GetCompanieWithMaxId()
        {

            //מחזירה את הישוב עם המזהה הגבוה ביותר

            Companie maxCompanie = new Companie();
            for (int i = 0; i < this.Count; i++)
                if ((this[i] as Companie).Id > maxCompanie.Id)
                    maxCompanie = this[i] as Companie;

            return maxCompanie;
        }

    }
}
