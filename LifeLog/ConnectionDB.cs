using System;
using System.Collections.Generic;
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
        public static void ConnectionSQLlite()
        {
            try
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
                    using (SQLiteConnection conect = new SQLiteConnection("Data Sourse = test.db; Version = 3"))
                    {
                        string command = "CREATE TABLE \"Тип_задачи\" (\"id_type\"INTEGER,\"Название\"TEXT,PRIMARY KEY(\"id_type\" AUTOINCREMENT));" +
                            "CREATE TABLE \"Категория_задачи\" (\"id_class\"INTEGER,\"Название\"TEXT,PRIMARY KEY(\"id_class\" AUTOINCREMENT));" +
                            "CREATE TABLE \"Задача\" (\"id\"INTEGER NOT NULL,\"Название\"TEXT NOT NULL,\"Содержание\"TEXT,\"Дата_начала\"TEXT NOT NULL,\"Дата_конца\"TEXT NOT NULL,\"Завершено\"BLOB,\"Комментарий\"TEXT,\"id_type\"INTEGER,\"id_class\"INTEGER,PRIMARY KEY(\"id\" AUTOINCREMENT),FOREIGN KEY(\"id_class\") REFERENCES \"Категория_задачи\"(\"id_class\"),FOREIGN KEY(\"id_type\") REFERENCES \"Тип_задачи\"(\"id_type\"));";
                        using (SQLiteCommand cmd = new SQLiteCommand(command, conect))
                        {
                            conect.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    
                }

            }
            catch 
            {

            }
        }
    }
}
    