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
    public partial class New_Tasks_Form : Form
    {
        public New_Tasks_Form()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == null || textBox_name.Text == "")
            {
                MessageBox.Show("Введите название задаче", "Неверное название", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateTimePicker_start.Value >= dateTimePicker_end.Value)
            {
                MessageBox.Show("Начальное время не должно превышать конечного", "Неверное время", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string time_start = dateTimePicker_start.Text;
                string time_end = dateTimePicker_end.Text;
                ConnectionDB.Add_Task(textBox_name.Text, textBox_content.Text, time_start, time_end, textBox_comments.Text);
                this.Close();
            }
            
        }

        private void New_Tasks_Form_Load(object sender, EventArgs e)
        {
        }
    }
}
