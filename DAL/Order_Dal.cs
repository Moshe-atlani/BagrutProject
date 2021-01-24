using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApp_MA.DAL
{
    class Order_Dal
    {//ne oas oublier de faire un petit tour voir si ya un pb ds le sql
        public static bool Insert(int clientName, DateTime date, string comment)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Order"

            + "("
             + "[Client],[Date],[Comment]"

            + ")"
            + " VALUES "
            + "("
             + $" '{clientName}' , '{date.ToString("yyyy-MM-dd")}' , '{comment}'"
            + ")";

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Order"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Order", "[Client],[Date]");

            DataRelation dataRelation = null;

            Dal_Client.FillDataSet(dataSet);

            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "OrderClient"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Client"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Order"].Columns["Client"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);



        }
        public static bool Update(int ID, int clientName, DateTime date, string comment)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Order SET"
            + $"[Client] = '{clientName}'"
            + $" ,[Date] = '{date.ToString("yyyy-MM-dd")}'"
            + $" ,[Comment] = '{comment}'"


            + $" WHERE ID = {ID}";
            return Dal.ExecuteSql(str);

            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה


        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Order WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }




    }
}