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
            ConnectionDB.Change_Task(id, textBox_name.Text, textBox_content.Text, textBox_datastart.Text, textBox_dataend.Text, textBox_comments.Text);
            this.Close();

        }

        public Change_Task_Form(int id, string name, string content, string data_start, string data_end, string comment)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.content = content;
            this.data_start = data_start;
            this.data_end = data_end;
            this.comment = comment;
        }

        private void Change_Task_Form_Load(object sender, EventArgs e)
        {
            textBox_name.Text = name;
            textBox_content.Text = content;
            textBox_datastart.Text = data_start;
            textBox_dataend.Text = data_end;
            textBox_comments.Text = comment;
        }
    }
}
