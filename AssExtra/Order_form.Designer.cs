namespace AssExtra
{
    partial class Order_form
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
            this.tra_sua_btn = new System.Windows.Forms.Button();
            this.hong_tra_btn = new System.Windows.Forms.Button();
            this.tra_chanh_btn = new System.Windows.Forms.Button();
            this.tra_dao_btn = new System.Windows.Forms.Button();
            this.cafe_btn = new System.Windows.Forms.Button();
            this.finish_btn = new System.Windows.Forms.Button();
            this.drink_order = new System.Windows.Forms.TabControl();
            this.next_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tra_sua_btn
            // 
            this.tra_sua_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tra_sua_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tra_sua_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tra_sua_btn.Image = global::AssExtra.Properties.Resources.tra_sưa_pic1;
            this.tra_sua_btn.Location = new System.Drawing.Point(0, 0);
            this.tra_sua_btn.Name = "tra_sua_btn";
            this.tra_sua_btn.Size = new System.Drawing.Size(284, 85);
            this.tra_sua_btn.TabIndex = 0;
            this.tra_sua_btn.Text = "Trà sữa";
            this.tra_sua_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tra_sua_btn.UseVisualStyleBackColor = true;
            this.tra_sua_btn.Click += new System.EventHandler(this.Drink_btn_click);
            // 
            // hong_tra_btn
            // 
            this.hong_tra_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hong_tra_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hong_tra_btn.Image = global::AssExtra.Properties.Resources.hong_tra_pc1;
            this.hong_tra_btn.Location = new System.Drawing.Point(0, 91);
            this.hong_tra_btn.Name = "hong_tra_btn";
            this.hong_tra_btn.Size = new System.Drawing.Size(284, 85);
            this.hong_tra_btn.TabIndex = 1;
            this.hong_tra_btn.Text = "Hồng trà";
            this.hong_tra_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.hong_tra_btn.UseVisualStyleBackColor = true;
            this.hong_tra_btn.Click += new System.EventHandler(this.Drink_btn_click);
            // 
            // tra_chanh_btn
            // 
            this.tra_chanh_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tra_chanh_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tra_chanh_btn.Image = global::AssExtra.Properties.Resources.tra_chanh_pic1;
            this.tra_chanh_btn.Location = new System.Drawing.Point(0, 182);
            this.tra_chanh_btn.Name = "tra_chanh_btn";
            this.tra_chanh_btn.Size = new System.Drawing.Size(284, 85);
            this.tra_chanh_btn.TabIndex = 2;
            this.tra_chanh_btn.Text = "Trà chanh";
            this.tra_chanh_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tra_chanh_btn.UseVisualStyleBackColor = true;
            this.tra_chanh_btn.Click += new System.EventHandler(this.Drink_btn_click);
            // 
            // tra_dao_btn
            // 
            this.tra_dao_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tra_dao_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tra_dao_btn.Image = global::AssExtra.Properties.Resources.tra_dao_pic1;
            this.tra_dao_btn.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.tra_dao_btn.Location = new System.Drawing.Point(0, 273);
            this.tra_dao_btn.Name = "tra_dao_btn";
            this.tra_dao_btn.Size = new System.Drawing.Size(284, 85);
            this.tra_dao_btn.TabIndex = 3;
            this.tra_dao_btn.Text = "Trà đào";
            this.tra_dao_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.tra_dao_btn.UseVisualStyleBackColor = true;
            this.tra_dao_btn.Click += new System.EventHandler(this.Drink_btn_click);
            // 
            // cafe_btn
            // 
            this.cafe_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cafe_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cafe_btn.Image = global::AssExtra.Properties.Resources.cafe_pic1;
            this.cafe_btn.Location = new System.Drawing.Point(0, 364);
            this.cafe_btn.Name = "cafe_btn";
            this.cafe_btn.Size = new System.Drawing.Size(284, 85);
            this.cafe_btn.TabIndex = 4;
            this.cafe_btn.Text = "Cafe";
            this.cafe_btn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.cafe_btn.UseVisualStyleBackColor = true;
            this.cafe_btn.Click += new System.EventHandler(this.Drink_btn_click);
            // 
            // finish_btn
            // 
            this.finish_btn.BackColor = System.Drawing.Color.White;
            this.finish_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_btn.Location = new System.Drawing.Point(290, 406);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(189, 43);
            this.finish_btn.TabIndex = 6;
            this.finish_btn.Text = "Back";
            this.finish_btn.UseVisualStyleBackColor = false;
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // drink_order
            // 
            this.drink_order.Location = new System.Drawing.Point(290, 0);
            this.drink_order.Name = "drink_order";
            this.drink_order.SelectedIndex = 0;
            this.drink_order.Size = new System.Drawing.Size(525, 400);
            this.drink_order.TabIndex = 5;
            this.drink_order.SizeChanged += new System.EventHandler(this.drink_order_SizeChanged);
            // 
            // next_btn
            // 
            this.next_btn.BackColor = System.Drawing.Color.White;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(626, 406);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(189, 43);
            this.next_btn.TabIndex = 7;
            this.next_btn.Text = "Hủy";
            this.next_btn.UseVisualStyleBackColor = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // Order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AssExtra.Properties.Resources.tra_sưa_pic1;
            this.ClientSize = new System.Drawing.Size(821, 457);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.drink_order);
            this.Controls.Add(this.cafe_btn);
            this.Controls.Add(this.tra_dao_btn);
            this.Controls.Add(this.tra_chanh_btn);
            this.Controls.Add(this.hong_tra_btn);
            this.Controls.Add(this.tra_sua_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_form";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tra_sua_btn;
        private System.Windows.Forms.Button hong_tra_btn;
        private System.Windows.Forms.Button tra_chanh_btn;
        private System.Windows.Forms.Button tra_dao_btn;
        private System.Windows.Forms.Button cafe_btn;
        private System.Windows.Forms.Button finish_btn;
        private System.Windows.Forms.TabControl drink_order;
        private System.Windows.Forms.Button next_btn;
    }
}