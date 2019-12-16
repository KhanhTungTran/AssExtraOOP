namespace AssExtra
{
    partial class Bill_preview
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
            this.components = new System.ComponentModel.Container();
            this.show_field = new System.Windows.Forms.RichTextBox();
            this.day_label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.date_time_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // show_field
            // 
            this.show_field.Enabled = false;
            this.show_field.Location = new System.Drawing.Point(12, 12);
            this.show_field.Name = "show_field";
            this.show_field.Size = new System.Drawing.Size(332, 350);
            this.show_field.TabIndex = 0;
            this.show_field.Text = "";
            // 
            // day_label
            // 
            this.day_label.AutoSize = true;
            this.day_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_label.Location = new System.Drawing.Point(350, 21);
            this.day_label.Name = "day_label";
            this.day_label.Size = new System.Drawing.Size(158, 17);
            this.day_label.TabIndex = 2;
            this.day_label.Text = "Wesnesday 00/00/0000";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // date_time_label
            // 
            this.date_time_label.AutoSize = true;
            this.date_time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time_label.Location = new System.Drawing.Point(407, 48);
            this.date_time_label.Name = "date_time_label";
            this.date_time_label.Size = new System.Drawing.Size(44, 17);
            this.date_time_label.TabIndex = 3;
            this.date_time_label.Text = "00:00";
            // 
            // Bill_preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 374);
            this.Controls.Add(this.date_time_label);
            this.Controls.Add(this.day_label);
            this.Controls.Add(this.show_field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bill_preview";
            this.Text = "Bill preview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox show_field;
        private System.Windows.Forms.Label day_label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label date_time_label;
    }
}