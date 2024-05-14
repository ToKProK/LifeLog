namespace LifeLog
{
    partial class Change_Task_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_content = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dateTimePicker_end);
            this.panel1.Controls.Add(this.dateTimePicker_start);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_comments);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_content);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 65);
            this.panel1.MinimumSize = new System.Drawing.Size(364, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 567);
            this.panel1.TabIndex = 16;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(86, 481);
            this.button_Save.Margin = new System.Windows.Forms.Padding(6);
            this.button_Save.MinimumSize = new System.Drawing.Size(70, 39);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(185, 60);
            this.button_Save.TabIndex = 14;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Комментарий";
            // 
            // textBox_comments
            // 
            this.textBox_comments.Location = new System.Drawing.Point(11, 391);
            this.textBox_comments.Multiline = true;
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(332, 81);
            this.textBox_comments.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата окончания";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(11, 40);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(328, 33);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_content
            // 
            this.textBox_content.Location = new System.Drawing.Point(11, 129);
            this.textBox_content.Name = "textBox_content";
            this.textBox_content.Size = new System.Drawing.Size(328, 33);
            this.textBox_content.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата начала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Содержимое";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Изменить задачу";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_start.Location = new System.Drawing.Point(11, 215);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.ShowUpDown = true;
            this.dateTimePicker_start.Size = new System.Drawing.Size(97, 33);
            this.dateTimePicker_start.TabIndex = 16;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_end.Location = new System.Drawing.Point(11, 303);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_end.ShowUpDown = true;
            this.dateTimePicker_end.Size = new System.Drawing.Size(97, 33);
            this.dateTimePicker_end.TabIndex = 17;
            // 
            // Change_Task_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Change_Task_Form";
            this.Text = "Change_Task_Form";
            this.Load += new System.EventHandler(this.Change_Task_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_content;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
    }
}