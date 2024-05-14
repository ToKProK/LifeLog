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
            ConnectionDB.Add_Task(textBox_name.Text, textBox_content.Text, textBox_datastart.Text, textBox_dataend.Text, textBox_comments.Text);
            this.Close();
        }

    }
}
