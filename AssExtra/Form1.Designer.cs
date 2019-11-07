namespace AssExtra {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnToGo = new System.Windows.Forms.Button();
            this.btnForHere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToGo
            // 
            this.btnToGo.Location = new System.Drawing.Point(254, 160);
            this.btnToGo.Name = "btnToGo";
            this.btnToGo.Size = new System.Drawing.Size(123, 23);
            this.btnToGo.TabIndex = 0;
            this.btnToGo.Text = "Mua mang đi";
            this.btnToGo.UseVisualStyleBackColor = true;
            this.btnToGo.Click += new System.EventHandler(this.btnToGo_Click);
            // 
            // btnForHere
            // 
            this.btnForHere.Location = new System.Drawing.Point(428, 160);
            this.btnForHere.Name = "btnForHere";
            this.btnForHere.Size = new System.Drawing.Size(123, 23);
            this.btnForHere.TabIndex = 1;
            this.btnForHere.Text = "Uống tại quán";
            this.btnForHere.UseVisualStyleBackColor = true;
            this.btnForHere.Click += new System.EventHandler(this.btnForHere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForHere);
            this.Controls.Add(this.btnToGo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToGo;
        private System.Windows.Forms.Button btnForHere;
    }
}

