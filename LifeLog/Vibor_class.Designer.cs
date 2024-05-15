namespace LifeLog
{
    partial class Vibor_class
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
            this.button_everyweek = new System.Windows.Forms.Button();
            this.button_everyday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_everyweek
            // 
            this.button_everyweek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.button_everyweek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_everyweek.Location = new System.Drawing.Point(271, 296);
            this.button_everyweek.Name = "button_everyweek";
            this.button_everyweek.Size = new System.Drawing.Size(270, 76);
            this.button_everyweek.TabIndex = 0;
            this.button_everyweek.Text = "Ежедневные задачи";
            this.button_everyweek.UseVisualStyleBackColor = false;
            this.button_everyweek.Visible = false;
            this.button_everyweek.Click += new System.EventHandler(this.button_everyweek_Click);
            // 
            // button_everyday
            // 
            this.button_everyday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            this.button_everyday.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_everyday.Location = new System.Drawing.Point(271, 160);
            this.button_everyday.Name = "button_everyday";
            this.button_everyday.Size = new System.Drawing.Size(270, 76);
            this.button_everyday.TabIndex = 2;
            this.button_everyday.Text = "Ежедневные задачи";
            this.button_everyday.UseVisualStyleBackColor = false;
            this.button_everyday.Click += new System.EventHandler(this.button_everyday_Click);
            // 
            // Vibor_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_everyday);
            this.Controls.Add(this.button_everyweek);
            this.Name = "Vibor_class";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LifeLOg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vibor_class_FormClosing);
            this.Load += new System.EventHandler(this.Vibor_class_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_everyweek;
        private System.Windows.Forms.Button button_everyday;
    }
}