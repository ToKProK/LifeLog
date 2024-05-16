using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LifeLog
{
    internal class ProgramProcessor
    {
        static public void Task_Handler(DataTable data)// Данный метод корректно распределяет статус задач
        {
            foreach (DataRow row in data.Rows)
            {
                int id = int.Parse(row["id"].ToString());
                DateTime date_start = DateTime.Parse(row["Дата_начала"].ToString());
                DateTime date_end = DateTime.Parse(row["Дата_конца"].ToString());
                DateTime date_now = DateTime.Now;
                int complete = int.Parse(row["Завершено"].ToString());
                if (complete == 1)// Выполнено
                {
                    int id_type = int.Parse(row["id_type"].ToString());
                    if (id_type == 2)
                    {
                        continue;
                    }
                    else
                    {
                        ConnectionDB.Update_Task_Type(id, 2);
                    }
                }
                else if (date_now < date_start && date_now < date_end)// Планируется
                {
                    int id_type = int.Parse(row["id_type"].ToString());
                    if (id_type == 4)
                    {
                        continue;
                    }
                    else
                    {
                        ConnectionDB.Update_Task_Type(id, 4);
                    }
                }
                else if (date_now >= date_start && date_now <= date_end)//В процессе
                {
                    int id_type = int.Parse(row["id_type"].ToString());
                    if (id_type == 3)
                    {
                        continue;
                    }
                    else
                    {
                        ConnectionDB.Update_Task_Type(id, 3);
                    }
                }
                else if (date_now > date_start && date_now > date_end)// Не выполненно
                {
                    int id_type = int.Parse(row["id_type"].ToString());
                    if (id_type == 1)
                    {
                        continue;
                    }
                    else
                    {
                        ConnectionDB.Update_Task_Type(id, 1);
                    }
                }
            }
        }
        static public void Coloring(DataGridView tabel)
        {
            foreach (DataGridViewRow row in tabel.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(145, 145, 145);//#919191
                }
                else if (Convert.ToInt32(row.Cells[7].Value) == 2)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(138, 226, 138);//#8ae28a
                }
                else if (Convert.ToInt32(row.Cells[7].Value) == 3)
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(113, 96, 232);//#7160e8
                }
                else
                {

                }
            }
        }

        static public int ProgresbarUpdate(ProgressBar progresbar, DataGridView tabel)
        {
            decimal count_max_progres_value = tabel.RowCount;
            decimal count_tasks_completed = 0;
            foreach (DataGridViewRow row in tabel.Rows)
            {
                if (Convert.ToInt32(row.Cells[7].Value) == 2)
                {
                    count_tasks_completed += 1;
                }
            }
            decimal result = Math.Round((count_tasks_completed / count_max_progres_value), 1);
            int Percent = Convert.ToInt32(result * 100);
            return Percent;
        }
    }
}
