namespace WindowsFormsApp1
{
    partial class Form3
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
            this.btnfrm1 = new System.Windows.Forms.Button();
            this.btnfrm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnfrm1
            // 
            this.btnfrm1.Location = new System.Drawing.Point(98, 21);
            this.btnfrm1.Name = "btnfrm1";
            this.btnfrm1.Size = new System.Drawing.Size(75, 23);
            this.btnfrm1.TabIndex = 0;
            this.btnfrm1.Text = "form1";
            this.btnfrm1.UseVisualStyleBackColor = true;
            this.btnfrm1.Click += new System.EventHandler(this.btnfrm1_Click);
            // 
            // btnfrm2
            // 
            this.btnfrm2.Location = new System.Drawing.Point(98, 67);
            this.btnfrm2.Name = "btnfrm2";
            this.btnfrm2.Size = new System.Drawing.Size(75, 23);
            this.btnfrm2.TabIndex = 0;
            this.btnfrm2.Text = "form2";
            this.btnfrm2.UseVisualStyleBackColor = true;
            this.btnfrm2.Click += new System.EventHandler(this.btnfrm2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 234);
            this.Controls.Add(this.btnfrm2);
            this.Controls.Add(this.btnfrm1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnfrm1;
        private System.Windows.Forms.Button btnfrm2;
    }
}