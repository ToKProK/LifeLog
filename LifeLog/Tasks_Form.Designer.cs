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
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Комментарий = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Tasks
            // 
            this.dataGridView_Tasks.AllowUserToAddRows = false;
            this.dataGridView_Tasks.AllowUserToDeleteRows = false;
            this.dataGridView_Tasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dataGridView_Tasks.Size = new System.Drawing.Size(741, 256);
            this.dataGridView_Tasks.TabIndex = 0;
            this.dataGridView_Tasks.DoubleClick += new System.EventHandler(this.dataGridView_Tasks_DoubleClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "id";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Номер";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Название";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Задача";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Содержание";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Содерживмое";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Дата_начала";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Дата начала";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Дата_конца";
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Дата окончания";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Завершено";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Выполнено";
            this.Column3.Name = "Column3";
            // 
            // Комментарий
            // 
            this.Комментарий.DataPropertyName = "Комментарий";
            this.Комментарий.Frozen = true;
            this.Комментарий.HeaderText = "Комментарий";
            this.Комментарий.Name = "Комментарий";
            // 
            // id_type
            // 
            this.id_type.DataPropertyName = "id_type";
            this.id_type.HeaderText = "id_type";
            this.id_type.Name = "id_type";
            this.id_type.ReadOnly = true;
            this.id_type.Visible = false;
            // 
            // id_class
            // 
            this.id_class.DataPropertyName = "id_class";
            this.id_class.HeaderText = "id_class";
            this.id_class.Name = "id_class";
            this.id_class.ReadOnly = true;
            this.id_class.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 345);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(134, 55);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Добавить задачу";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Del
            // 
            this.button_Del.Location = new System.Drawing.Point(152, 345);
            this.button_Del.Name = "button_Del";
            this.button_Del.Size = new System.Drawing.Size(134, 55);
            this.button_Del.TabIndex = 4;
            this.button_Del.Text = "Удалить задачу";
            this.button_Del.UseVisualStyleBackColor = true;
            this.button_Del.Click += new System.EventHandler(this.button_Del_Click);
            // 
            // Tasks_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.button_Del);
            this.Controls.Add(this.button_Add);
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
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Del;
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

