using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp_MA.DAL
{
    class Dal_Client
    {

        public static bool Insert(string firstName, string lastName, int
cellPhoneNumber, string cellPhoneAreaCode, int zipCode, int age, int city)
        {//cette peoula recoi toute c info du "insert " de "Client"(ds le BL)
            //trensforme c info en SQL pour pouvoir ensuite les rentrer ds le tablo (Dal.ExecuteSql(str))
            //מוסיפה את הלקוח למסד הנתונים
            //בניית הוראת ה-SQL

            string str = "INSERT INTO Table_Client"
            + "("
            + "[FirstName],[LastName],[CellphoneNumber],[CellAreaCode],[ZipCode],[Age],[City]"
            + ")"
            + " VALUES "
            + "("
            + $"'{firstName}','{lastName}',{cellPhoneNumber},'{cellPhoneAreaCode}',{zipCode},{age},{city}"
            + ")";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);

        }

        public static DataTable GetDataTable()//a voir avc raf 1.5
        {
            DataTable dataTable = null;
            DataSet dataSet = new DataSet();
            FillDataSet(dataSet);
            dataTable = dataSet.Tables["Table_Client"];
            return dataTable;
        }

        public static void FillDataSet(DataSet dataSet)//
        {

            //ממלאת את אוסף הטבלאות בטבלת הלקוחות
            Dal.FillDataSet(dataSet, "Table_Client", "[LastName],[FirstName]");

            City_Dal.FillDataSet(dataSet);

            DataRelation dataRelation = null;
            dataRelation = new DataRelation(

            //שם קשר הגומלין

            "ClientCity"

            //עמודת הקשר בטבלת האב )המפתח הראשי של טבלת האב(

            , dataSet.Tables["Table_City"].Columns["ID"]

            //עמודת הקשר בטבלת הבן )המפתח הזר בטבלת הבן(

            , dataSet.Tables["Table_Client"].Columns["City"]);

            //הוספת קשר הגומלין לאוסף הטבלאות

            dataSet.Relations.Add(dataRelation);
        }

        public static bool Update(int id, string firstName, string lastName
, int cellPhoneNumber, string cellPhoneAreaCode, int zipCode, int age,int city)
        {

            //מעדכנת את הלקוח במסד הנתונים

            string str = "UPDATE Table_Client SET"
            + $" [FirstName] = N'{firstName}'"
            + $",[LastName] = N'{lastName}'"
            + $",[CellphoneNumber] = {cellPhoneNumber}"
            + $",[CellAreaCode] = '{cellPhoneAreaCode}'"
            + $",[ZipCode] = {zipCode}"
            + $",[City] = {city}"
            + $" WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

        public static bool Delete(int id)
        {

            //מוחקת את הלקוח ממסד הנתונים

            string str = $"DELETE FROM Table_Client WHERE ID = {id}";
            //הפעלת פעולת הSQL -תוך שימוש בפעולה המוכנה ExecuteSql במחלקה Dal והחזרה האם הפעולה הצליחה
            return Dal.ExecuteSql(str);
        }

    }
}
