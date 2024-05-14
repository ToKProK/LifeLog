namespace LifeLog
{
    partial class Tasks_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Tasks = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Комментарий = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Tasks
            // 
            this.dataGridView_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.Комментарий,
            this.id_type,
            this.id_class});
            this.dataGridView_Tasks.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_Tasks.Name = "dataGridView_Tasks";
            this.dataGridView_Tasks.Size = new System.Drawing.Size(743, 280);
            this.dataGridView_Tasks.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить задачу";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id";
            this.Column4.HeaderText = "Номер";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Название";
            this.Column1.HeaderText = "Задача";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Содержание";
            this.Column2.HeaderText = "Содерживмое";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Дата_начала";
            this.Column5.HeaderText = "Дата начала";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Дата_конца";
            this.Column6.HeaderText = "Дата окончания";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Завершено";
            this.Column3.HeaderText = "Выполнено";
            this.Column3.Name = "Column3";
            // 
            // Комментарий
            // 
            this.Комментарий.DataPropertyName = "Комментарий";
            this.Комментарий.HeaderText = "Комментарий";
            this.Комментарий.Name = "Комментарий";
            // 
            // id_type
            // 
            this.id_type.DataPropertyName = "id_type";
            this.id_type.HeaderText = "id_type";
            this.id_type.Name = "id_type";
            this.id_type.Visible = false;
            // 
            // id_class
            // 
            this.id_class.DataPropertyName = "id_class";
            this.id_class.HeaderText = "id_class";
            this.id_class.Name = "id_class";
            this.id_class.Visible = false;
            // 
            // Tasks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView_Tasks);
            this.Name = "Tasks_Form";
            this.Text = "LifeLog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tasks_Form_FormClosing);
            this.Load += new System.EventHandler(this.Tasks_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Tasks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Комментарий;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_class;
    }
}

