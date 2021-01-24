using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp_MA.DAL
{
    class Product_Dal
    {
        public static bool Insert(string name_Product, int companie, int categorie)
        {

            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Product"
            + "("
            + "[Name_Product],[Companie],[Categorie]"
            + ")"
            + " VALUES "
            + "("
            + $"'{name_Product}',{companie},{categorie}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }


        public static DataTable GetDataTable()
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Product"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Product", "[Name_Product]");

            Categorie_Dal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

               "ProductCategorie" 

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_Categorie"].Columns["Id"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Product"].Columns["Categorie"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);//la

            //now for companie

            Companie_Dal.FillDataSet(dataSet);
            DataRelation dataRelation_2 = null;
            dataRelation_2 = new DataRelation(

                  "ProductCompanie"

                   , dataSet.Tables["Table_Companie"].Columns["Id"]

                    , dataSet.Tables["Table_Product"].Columns["Companie"]);

            dataSet.Relations.Add(dataRelation_2);



        }

        public static bool Update(int id, string name_Product, int categorie,  int companie)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Product SET"
            + $" [Name_Product] = N'{name_Product}'"
            + $",[Companie] = {companie}"
            + $",[Categorie] = {categorie}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Product WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

    }
}
