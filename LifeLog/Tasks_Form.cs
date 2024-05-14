using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog
{
    public partial class Tasks_Form : Form
    {
        public Tasks_Form() //Инициализация
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)//Кнопка для возвращения в предыдущее окно
        {
            this.Hide();
            Vibor_class form = new Vibor_class();
            form.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)//Кнопка добавления задачи
        {
            New_Tasks_Form form = new New_Tasks_Form();
            form.ShowDialog();
        }

        private void Tasks_Form_FormClosing(object sender, FormClosingEventArgs e)//При закрытии окна, приложения тоже закрывается.
        {
            Application.Exit();
        }

        private void button_Del_Click(object sender, EventArgs e)// Кнопка удаления
        {
            int id = int.Parse(dataGridView_Tasks.CurrentRow.Cells[0].Value.ToString());
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данную задачу?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ConnectionDB.Remove_Task(id);
                Load_Tasks();
            }

        }

        private void Tasks_Form_Load(object sender, EventArgs e)//Событие формы "Загрузка"
        {
            Load_Tasks();
        }
        private void Load_Tasks() // Тут выбирается метод, подгрузки задач, пока только "ежедневные" и "еженедельные"
        {
            switch (Vibor_class.task_type) // При нажатии кнопки в форме "Vibor_class" задаётся парамет task_type исходя из которого мы
            {                              // либо загружаем ежедневные либо еженедельные задачи.
                case null:
                    {
                        break;
                    }
                case "every_day":
                    {
                        LoadEveryDayTasks();
                        break;
                    }
                case "every_week":
                    {
                        LoadEveryWeekTasks();
                        break;
                    }
            }
        }


        private void LoadEveryDayTasks() // Подгрузка ежедневных задач
        {
            dataGridView_Tasks.DataSource = ConnectionDB.GetData_EveryDayTasks();
        }

        private void LoadEveryWeekTasks() // Подгрузка еженедельные задач
        {
            dataGridView_Tasks.DataSource = ConnectionDB.GetData_EveryWeekTasks();
        }

        private void dataGridView_Tasks_DoubleClick(object sender, EventArgs e)// Событие двойного нажатия по одной из задач, открывается новое окно.
        {
            int id = int.Parse(dataGridView_Tasks.CurrentRow.Cells[0].Value.ToString());
            string name = dataGridView_Tasks.CurrentRow.Cells[1].Value.ToString();
            string content = dataGridView_Tasks.CurrentRow.Cells[2].Value.ToString();
            string data_start = dataGridView_Tasks.CurrentRow.Cells[3].Value.ToString();
            string data_end = dataGridView_Tasks.CurrentRow.Cells[4].Value.ToString();
            string comment = dataGridView_Tasks.CurrentRow.Cells[6].Value.ToString();
            Change_Task_Form form = new Change_Task_Form(id, name, content, data_start, data_end, comment);
            form.ShowDialog();
            Load_Tasks();
        }
    }
}
