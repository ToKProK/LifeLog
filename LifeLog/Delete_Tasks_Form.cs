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
    public partial class Delete_Tasks_Form : Form
    {
        public Delete_Tasks_Form()
        {
            InitializeComponent();
        }

        private void Delete_Tasks_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tasks_Form form = new Tasks_Form();
            form.Show();
        }
    }
}
