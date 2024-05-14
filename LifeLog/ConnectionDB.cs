using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog
{
    internal class ConnectionDB
    {
        static string db_info = @"Data Source=lifelog.db;Pooling=true;;Version=3";
        public static void ConnectionSQLlite()
        {
            if (!File.Exists("lifelog.db"))
            {
                DialogResult result =  MessageBox.Show("База данных отсутсвует, создать новую?", "База данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("База данных отсутсвует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }


                SQLiteConnection.CreateFile("lifelog.db");
                using (SQLiteConnection conect = new SQLiteConnection(db_info))
                {
                    string command = "CREATE TABLE \"Категория_задачи\" (\"id_class\" INTEGER,\"Название\" TEXT,PRIMARY KEY(\"id_class\" AUTOINCREMENT));" +
                        "CREATE TABLE \"Тип_задачи\" (\"id_type\" INTEGER, \"Название\" TEXT,PRIMARY KEY(\"id_type\" AUTOINCREMENT));" +
                        "CREATE TABLE \"Задачи\" (\"id\" INTEGER NOT NULL, \"Название\" TEXT NOT NULL, \"Содержание\" TEXT, \"Дата_начала\" TEXT NOT NULL, \"Дата_конца\" TEXT NOT NULL, \"Завершено\" INTEGER, \"Комментарий\" TEXT, \"id_type\" INTEGER, \"id_class\" INTEGER, PRIMARY KEY(\"id\" AUTOINCREMENT), FOREIGN KEY(\"id_type\") REFERENCES \"Тип_задачи\"(\"id_type\"), FOREIGN KEY(\"id_class\") REFERENCES \"Категория_задачи\"(\"id_class\"))";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                    {
                        conect.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static DataTable GetData_EveryDayTasks()
        {
            //try
            //{
                DataTable dt = new DataTable();
                using (SQLiteConnection conect = new SQLiteConnection(db_info))
                {
                    string command = "SELECT * FROM Задачи";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                    {
                        conect.Open();
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                }
                return dt;
            //}
            ////catch
            //{
            //    return null;
            //}
        }

        public static DataTable GetData_EveryWeekTasks()
        {
            //try
            //{
                DataTable dt = new DataTable();
                using (SQLiteConnection conect = new SQLiteConnection(db_info))
                {
                    string command = "SELECT * FROM Задачи";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                    {
                        conect.Open();
                        SQLiteDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                }
                return dt;
            //}
            //catch
            //{
            //    return null;
            //}
        }
    }
}
    