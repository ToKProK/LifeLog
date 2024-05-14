using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeLog
{
    public partial class Change_Task_Form : Form
    {
        int id;
        string name, content, data_start, data_end, comment;



        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == null || textBox_name.Text == "")
            {
                MessageBox.Show("Введите название задаче", "Неверное название", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker_start.Value <= dateTimePicker_end.Value)
            {
                MessageBox.Show("Начальное время не должно превышать конечного", "Неверное время", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string time_start = dateTimePicker_start.Text;
                string time_end = dateTimePicker_start.Text;
                ConnectionDB.Change_Task(id, textBox_name.Text, textBox_content.Text, time_start, time_end, textBox_comments.Text);
                this.Close();
            }


        }

        public Change_Task_Form(int id, string name, string content, string data_start, string data_end, string comment)// Инициализация
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.content = content;
            this.data_start = data_start;
            this.data_end = data_end;
            this.comment = comment;
        }

        private void Change_Task_Form_Load(object sender, EventArgs e)// Заполнение textBox
        {
            textBox_name.Text = name;
            textBox_content.Text = content;
            dateTimePicker_start.Text = data_start;
            dateTimePicker_end.Text = data_end;
            textBox_comments.Text = comment;
        }
    }
}
