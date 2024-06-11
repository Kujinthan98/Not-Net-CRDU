namespace WindowsFormsApp1
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.stdtable = new System.Windows.Forms.DataGridView();
            this.btnClouse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gBoxGender = new System.Windows.Forms.GroupBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.address = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stdtable)).BeginInit();
            this.gBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1209, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // stdtable
            // 
            this.stdtable.AllowUserToAddRows = false;
            this.stdtable.AllowUserToDeleteRows = false;
            this.stdtable.AllowUserToResizeColumns = false;
            this.stdtable.AllowUserToResizeRows = false;
            this.stdtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stdtable.Location = new System.Drawing.Point(12, 96);
            this.stdtable.MultiSelect = false;
            this.stdtable.Name = "stdtable";
            this.stdtable.RowHeadersWidth = 51;
            this.stdtable.RowTemplate.Height = 24;
            this.stdtable.Size = new System.Drawing.Size(851, 426);
            this.stdtable.TabIndex = 1;
            this.stdtable.SelectionChanged += new System.EventHandler(this.stdtable_SelectionChanged);
            // 
            // btnClouse
            // 
            this.btnClouse.BackColor = System.Drawing.Color.White;
            this.btnClouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClouse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClouse.Location = new System.Drawing.Point(1076, 48);
            this.btnClouse.Name = "btnClouse";
            this.btnClouse.Size = new System.Drawing.Size(96, 30);
            this.btnClouse.TabIndex = 2;
            this.btnClouse.Text = "Clouse";
            this.btnClouse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClouse.UseVisualStyleBackColor = false;
            this.btnClouse.Click += new System.EventHandler(this.btnClouse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(974, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(883, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gBoxGender
            // 
            this.gBoxGender.Controls.Add(this.male);
            this.gBoxGender.Controls.Add(this.female);
            this.gBoxGender.Location = new System.Drawing.Point(1005, 170);
            this.gBoxGender.Name = "gBoxGender";
            this.gBoxGender.Size = new System.Drawing.Size(167, 44);
            this.gBoxGender.TabIndex = 31;
            this.gBoxGender.TabStop = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.male.Location = new System.Drawing.Point(6, 14);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(58, 20);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.female.Location = new System.Drawing.Point(82, 14);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(69, 20);
            this.female.TabIndex = 3;
            this.female.TabStop = true;
            this.female.Text = "female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.Silver;
            this.address.Location = new System.Drawing.Point(1005, 250);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(167, 47);
            this.address.TabIndex = 29;
            // 
            // grade
            // 
            this.grade.BackColor = System.Drawing.Color.Silver;
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "10A",
            "10B",
            "10C",
            "11A",
            "11B",
            "11C"});
            this.grade.Location = new System.Drawing.Point(1005, 220);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(167, 24);
            this.grade.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(879, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(879, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(879, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(878, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Last Name";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.Location = new System.Drawing.Point(879, 100);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(102, 20);
            this.fullName.TabIndex = 21;
            this.fullName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Silver;
            this.txtLastName.Location = new System.Drawing.Point(1005, 142);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(167, 22);
            this.txtLastName.TabIndex = 24;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1097, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 40);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Silver;
            this.txtFirstName.Location = new System.Drawing.Point(1005, 98);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(167, 22);
            this.txtFirstName.TabIndex = 22;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Location = new System.Drawing.Point(749, 47);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 29);
            this.btnCreate.TabIndex = 32;
            this.btnCreate.Text = "New Student";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.White;
            this.btnRead.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRead.Location = new System.Drawing.Point(615, 47);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(128, 29);
            this.btnRead.TabIndex = 33;
            this.btnRead.Text = "Read All";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 534);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gBoxGender);
            this.Controls.Add(this.address);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClouse);
            this.Controls.Add(this.stdtable);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Display page";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stdtable)).EndInit();
            this.gBoxGender.ResumeLayout(false);
            this.gBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView stdtable;
        private System.Windows.Forms.Button btnClouse;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gBoxGender;
        public System.Windows.Forms.RadioButton male;
        public System.Windows.Forms.RadioButton female;
        public System.Windows.Forms.TextBox address;
        public System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fullName;
        public System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRead;
    }
}