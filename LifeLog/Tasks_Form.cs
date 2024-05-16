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
        public static bool handker_mark = false; // Данная переменная позволяет корректно обрабатывать изменение состояния вывполнения, она выключается когда 
                                                 // происходит загрузка данных в таблицу из БД и включается, когда загрузка базы данных закончилась и на калочку нажимет теперь пользователь.
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
            Load_Tasks(); Load_Tasks();
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
                Load_Tasks(); Load_Tasks();
            }

        }

        private void Tasks_Form_Load(object sender, EventArgs e)//Событие формы "Загрузка"
        {
            Load_Tasks();
            dataGridView_Tasks.AutoResizeColumn(1);

        }
        private void Load_Tasks() // Тут выбирается метод, подгрузки задач, пока только "ежедневные" и "еженедельные"
        {
            handker_mark = false; // см. описание переменной выше
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
            ProgramProcessor.Task_Handler(Data);//Устанавливаем правильный статус заданиям
            ProgramProcessor.Coloring(dataGridView_Tasks);//Устанавливаем Цвета для заданий
            progressBar1.Value = ProgramProcessor.ProgresbarUpdate(progressBar1, dataGridView_Tasks);
            handker_mark = true; // см. описание переменной выше
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

        private void dataGridView_Tasks_DoubleClick(object sender, EventArgs e)// Событие двойного нажатия по одной из задач, открывается новое окно, для изменеия данных задачи.
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
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// https://ru.stackoverflow.com/questions/1209741/Нажатие-в-datagridview-флажка-checkbox-являющимся-объектом-datatable/
        private void dataGridView_Tasks_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (handker_mark)
            {
                if (dataGridView_Tasks.IsCurrentCellDirty)
                {
                    dataGridView_Tasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void dataGridView_Tasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (handker_mark) 
            {
                if (e.ColumnIndex == 5)
                {
                    int id = int.Parse(dataGridView_Tasks.CurrentRow.Cells[0].Value.ToString());
                    string com = dataGridView_Tasks.CurrentRow.Cells[5].Value.ToString();
                    if (com == "") { com = "0"; }
                    int Complete = int.Parse(com);
                    ConnectionDB.Complete_Task(id, Complete);
                    Load_Tasks(); Load_Tasks();
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
