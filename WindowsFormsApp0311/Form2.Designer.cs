namespace WindowsFormsApp0311
{
    partial class Form2
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.birthDateLbl = new System.Windows.Forms.Label();
            this.nameTxtb = new System.Windows.Forms.TextBox();
            this.surnameTxtb = new System.Windows.Forms.TextBox();
            this.emailTxtb = new System.Windows.Forms.TextBox();
            this.phoneMtxtb = new System.Windows.Forms.MaskedTextBox();
            this.birthdateDtpckr = new System.Windows.Forms.DateTimePicker();
            this.usersLstb = new System.Windows.Forms.ListBox();
            this.fileTxtb = new System.Windows.Forms.TextBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(38, 73);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(55, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLbl.Location = new System.Drawing.Point(38, 116);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(81, 20);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "Surname";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLbl.Location = new System.Drawing.Point(38, 157);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 20);
            this.emailLbl.TabIndex = 2;
            this.emailLbl.Text = "Email";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.Location = new System.Drawing.Point(38, 202);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(60, 20);
            this.phoneLbl.TabIndex = 3;
            this.phoneLbl.Text = "Phone";
            // 
            // birthDateLbl
            // 
            this.birthDateLbl.AutoSize = true;
            this.birthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLbl.Location = new System.Drawing.Point(38, 238);
            this.birthDateLbl.Name = "birthDateLbl";
            this.birthDateLbl.Size = new System.Drawing.Size(83, 20);
            this.birthDateLbl.TabIndex = 4;
            this.birthDateLbl.Text = "Birthdate";
            // 
            // nameTxtb
            // 
            this.nameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxtb.Location = new System.Drawing.Point(182, 70);
            this.nameTxtb.Name = "nameTxtb";
            this.nameTxtb.Size = new System.Drawing.Size(212, 26);
            this.nameTxtb.TabIndex = 5;
            // 
            // surnameTxtb
            // 
            this.surnameTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTxtb.Location = new System.Drawing.Point(182, 113);
            this.surnameTxtb.Name = "surnameTxtb";
            this.surnameTxtb.Size = new System.Drawing.Size(212, 26);
            this.surnameTxtb.TabIndex = 6;
            // 
            // emailTxtb
            // 
            this.emailTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTxtb.Location = new System.Drawing.Point(182, 154);
            this.emailTxtb.Name = "emailTxtb";
            this.emailTxtb.Size = new System.Drawing.Size(212, 26);
            this.emailTxtb.TabIndex = 7;
            // 
            // phoneMtxtb
            // 
            this.phoneMtxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMtxtb.Location = new System.Drawing.Point(182, 196);
            this.phoneMtxtb.Mask = "+(000)00-000-00-00";
            this.phoneMtxtb.Name = "phoneMtxtb";
            this.phoneMtxtb.Size = new System.Drawing.Size(212, 26);
            this.phoneMtxtb.TabIndex = 8;
            // 
            // birthdateDtpckr
            // 
            this.birthdateDtpckr.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateDtpckr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateDtpckr.Location = new System.Drawing.Point(182, 238);
            this.birthdateDtpckr.Name = "birthdateDtpckr";
            this.birthdateDtpckr.Size = new System.Drawing.Size(212, 20);
            this.birthdateDtpckr.TabIndex = 9;
            // 
            // usersLstb
            // 
            this.usersLstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersLstb.FormattingEnabled = true;
            this.usersLstb.ItemHeight = 20;
            this.usersLstb.Location = new System.Drawing.Point(662, 70);
            this.usersLstb.Name = "usersLstb";
            this.usersLstb.Size = new System.Drawing.Size(197, 284);
            this.usersLstb.TabIndex = 10;
            this.usersLstb.SelectedIndexChanged += new System.EventHandler(this.usersLstb_SelectedIndexChanged);
            // 
            // fileTxtb
            // 
            this.fileTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileTxtb.Location = new System.Drawing.Point(662, 368);
            this.fileTxtb.Name = "fileTxtb";
            this.fileTxtb.Size = new System.Drawing.Size(197, 26);
            this.fileTxtb.TabIndex = 11;
            // 
            // changeBtn
            // 
            this.changeBtn.AutoSize = true;
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.Location = new System.Drawing.Point(319, 300);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(75, 30);
            this.changeBtn.TabIndex = 12;
            this.changeBtn.Text = "Change";
            this.changeBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = true;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(305, 346);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(89, 48);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.AutoSize = true;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadBtn.Location = new System.Drawing.Point(662, 400);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(92, 30);
            this.loadBtn.TabIndex = 14;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(767, 400);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(92, 30);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 617);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.fileTxtb);
            this.Controls.Add(this.usersLstb);
            this.Controls.Add(this.birthdateDtpckr);
            this.Controls.Add(this.phoneMtxtb);
            this.Controls.Add(this.emailTxtb);
            this.Controls.Add(this.surnameTxtb);
            this.Controls.Add(this.nameTxtb);
            this.Controls.Add(this.birthDateLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label birthDateLbl;
        private System.Windows.Forms.TextBox nameTxtb;
        private System.Windows.Forms.TextBox surnameTxtb;
        private System.Windows.Forms.TextBox emailTxtb;
        private System.Windows.Forms.MaskedTextBox phoneMtxtb;
        private System.Windows.Forms.DateTimePicker birthdateDtpckr;
        private System.Windows.Forms.ListBox usersLstb;
        private System.Windows.Forms.TextBox fileTxtb;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}