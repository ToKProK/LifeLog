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
    public partial class Tasks_Form : Form
    {
        public Tasks_Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vibor_class form = new Vibor_class();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_Tasks_Form form = new New_Tasks_Form();
            form.Show();
        }

        private void Tasks_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Delete_Tasks_Form form = new Delete_Tasks_Form();
            form.Show();
        }
    }
}
