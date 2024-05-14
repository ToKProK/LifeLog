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
        static DataTable Data;
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
            Load_Tasks();
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
            dataGridView_Tasks.AutoResizeColumn(1);
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
                        Data = LoadEveryDayTasks();
                        break;
                    }
                case "every_week":
                    {
                        Data = LoadEveryWeekTasks();
                        break;
                    }
            }
            ProgramProcessor.Task_Handler(Data);
        }


        private DataTable LoadEveryDayTasks() // Подгрузка ежедневных задач
        {
            DataTable Data = ConnectionDB.GetData_EveryDayTasks();
            dataGridView_Tasks.DataSource = Data;
            return Data;
        }

        private DataTable LoadEveryWeekTasks() // Подгрузка еженедельные задач
        {
            DataTable Data = ConnectionDB.GetData_EveryWeekTasks();
            dataGridView_Tasks.DataSource = Data;
            return Data;
        }

        private void dataGridView_Tasks_DoubleClick(object sender, EventArgs e)// Событие двойного нажатия по одной из задач, открывается новое окно.
        {
            if (dataGridView_Tasks.CurrentCellAddress.X != 5) //Данное условие позволяет обходить вход в редактирование при двойном нажатие на галочку.
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

        private void dataGridView_Tasks_CellEndEdit(object sender, DataGridViewCellEventArgs e)//Когда нажимем на галочку выполнил происходит это событие
        { 
            this.BeginInvoke(new MethodInvoker(() => //Вылезала ошибка, исправил её через ассинхронный метод
                                                     //https://stackoverflow.com/questions/26522927/how-to-evade-reentrant-call-to-setcurrentcelladdresscore
            {
                int id = int.Parse(dataGridView_Tasks.CurrentRow.Cells[0].Value.ToString());
                string com = dataGridView_Tasks.CurrentRow.Cells[5].Value.ToString();
                if (com == "") { com = "0"; }
                int Complete = int.Parse(com);
                ConnectionDB.Complete_Task(id, Complete);
                Load_Tasks();
            }));
        }
    }
}
