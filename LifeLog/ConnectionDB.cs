using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LifeLog
{
    internal class ConnectionDB
    {
        static string db_info = @"Data Source=lifelog.db;Pooling=true;;Version=3";

        public static void CheckDB() //Проверяет наличие базы данных, если нет создаёт пустую.
        {
            if (!File.Exists("lifelog.db"))
            {
                DialogResult result = MessageBox.Show("База данных отсутсвует, создать новую?", "База данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("База данных отсутсвует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }


                SQLiteConnection.CreateFile("lifelog.db");
                using (SQLiteConnection conect = new SQLiteConnection(db_info))
                {
                    string command = "CREATE TABLE \"Категория_задачи\" (\"id_class\" INTEGER,\"Название\" TEXT,PRIMARY KEY(\"id_class\" AUTOINCREMENT)); " +
                        "CREATE TABLE \"Стадия_задачи\" (\"id_type\" INTEGER, \"Название\" TEXT,PRIMARY KEY(\"id_type\" AUTOINCREMENT)); " +
                        "CREATE TABLE \"Задачи\" (\"id\" INTEGER NOT NULL, \"Название\" TEXT NOT NULL, \"Содержание\" TEXT, \"Дата_начала\" TEXT NOT NULL, \"Дата_конца\" TEXT NOT NULL, \"Завершено\" INTEGER, \"Комментарий\" TEXT, \"id_type\" INTEGER, \"id_class\" INTEGER, \"day\" TEXT, PRIMARY KEY(\"id\" AUTOINCREMENT), FOREIGN KEY(\"id_type\") REFERENCES \"Тип_задачи\"(\"id_type\"), FOREIGN KEY(\"id_class\") REFERENCES \"Категория_задачи\"(\"id_class\")); " +
                        "INSERT INTO \"Стадия_задачи\" (\"id_type\", \"Название\") VALUES ('1', 'Невыполненные'); " +
                        "INSERT INTO \"Стадия_задачи\" (\"id_type\", \"Название\") VALUES ('2', 'Выполненные'); " +
                        "INSERT INTO \"Стадия_задачи\" (\"id_type\", \"Название\") VALUES ('3', 'В процессе выполнения'); " +
                        "INSERT INTO \"Стадия_задачи\" (\"id_type\", \"Название\") VALUES ('4', 'Планируемые'); " +
                        "INSERT INTO \"Категория_задачи\" (\"id_class\", \"Название\") VALUES ('1', 'Ежедневная');" +
                        "INSERT INTO \"Категория_задачи\" (\"id_class\", \"Название\") VALUES ('2', 'Еженедельная');";
                    using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                    {
                        conect.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static DataTable GetData_EveryDayTasks() //Собирает данные для таблицы с задачами на день
        {
            //try
            //{
            DataTable dt = new DataTable();
            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                string command = "SELECT * FROM Задачи WHERE id_class = 1";
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
        public static DataTable GetData_EveryWeekTasks()//Собирает данные для таблицы с задачами на неделю
        {
            //try
            //{
            DataTable dt = new DataTable();
            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                string command = "SELECT * FROM Задачи WHERE id_class = 2";
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

        public static bool Add_Task(string name, string content, string data_start, string data_end, string comment) //Добавляет новые задачи в базу данных
        {
            //try
            //{

            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                DateTime day = DateTime.Now.Date;
                string command = "INSERT INTO \"Задачи\" (\"Название\", \"Содержание\", \"Дата_начала\", \"Дата_конца\", \"Завершено\", \"Комментарий\", \"id_type\", \"id_class\", \"day\") " +
                                 $"VALUES ('{name}', '{content}', '{data_start}', '{data_end}', '0', '{comment}', '4', '{Vibor_class.task_type_id}', '{day}');";//type, class (тип сразу ставить не успел, класс ставиться в зависимости от выбранной вкладки вначале)
                using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                {
                    conect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}
        }

        public static bool Remove_Task(int id) // Удаляет задачи из BD
        {
            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                string command = $"DELETE FROM \"Задачи\" WHERE id = {id}";
                using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                {
                    conect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool Change_Task(int id, string name, string content, string data_start, string data_end, string comment)// Изменяет задачи в БД
        {
            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                string command = $"UPDATE Задачи SET Название = \"{name}\", Содержание = \"{content}\", Дата_начала = \"{data_start}\", Дата_конца = \"{data_end}\", Комментарий = \"{comment}\" " +
                                 $"WHERE id = {id}";
                using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                {
                    conect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool Complete_Task(int id, int complete)// Изменяет статус задачи при изменение галочки
        {
            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                string command = $"UPDATE Задачи SET Завершено = \'{complete}\' " +
                                 $"WHERE id = {id}";
                using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                {
                    conect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool Update_Task_Type(int id, int task_type)
        {
            using (SQLiteConnection conect = new SQLiteConnection(db_info))
            {
                string command = $"UPDATE Задачи SET id_type = \'{task_type}\' " +
                                 $"WHERE id = {id}";
                using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                {
                    conect.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static void DayUpdate()//Обновляет актуальность базы данных на сегодняшний день для ежедневных заданий.
        {
            DateTime day = DateTime.Now.Date;
            DataTable Data = GetData_EveryDayTasks();
            foreach (DataRow row in Data.Rows)
            {
                int id = int.Parse(row["id"].ToString());
                string db_day = row["day"].ToString();
                DateTime db_day_datetime = DateTime.Parse(db_day);
                if (day != db_day_datetime) 
                {
                    using (SQLiteConnection conect = new SQLiteConnection(db_info))
                    {
                        string command = $"UPDATE Задачи SET day = \'{db_day_datetime}\' " +
                                         $"WHERE id = {id}";
                        using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                        {
                            conect.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}