﻿using System;
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
    public partial class Vibor_class : Form
    {

        public Vibor_class()
        {
            InitializeComponent();
        }
        static public string task_type;
        static public int task_type_id;
        private void button_everyweek_Click(object sender, EventArgs e)
        {
            this.Hide();
            task_type = "every_week";
            task_type_id = 2;
            Tasks_Form form = new Tasks_Form();
            form.Show();
        }

        private void button_everyday_Click(object sender, EventArgs e)
        {
            this.Hide();
            task_type = "every_day";
            task_type_id = 1;
            Tasks_Form form = new Tasks_Form();
            form.Show();
        }

        private void Vibor_class_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Vibor_class_Load(object sender, EventArgs e)
        {
            ConnectionDB.ConnectionSQLlite();
        }
    }
}
