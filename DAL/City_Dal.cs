using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp_MA.DAL
{
    class City_Dal
    {

        public static bool Insert(string Name)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_City"
            + "("
            + "[Name]"
            + ")"
            + " VALUES "
            + "("
            + $"'{Name}'"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Update(int id, string Name)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_City SET"
            + $" [Name] = N'{Name}'"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            bool isSucess = Dal.ExecuteSql(str);
            return isSucess;
        }

        public static bool Delete(int id)//normalement c bon a cheker sur le 2.3
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_City WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_City"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלה הנוכחית - בתנאי שהטבלה לא נמצאת כבר באוסף

            if (!dataSet.Tables.Contains("Table_City"))
            {
                Dal.FillDataSet(dataSet, "Table_City", "[Name]");
            }
        }
    }
}
