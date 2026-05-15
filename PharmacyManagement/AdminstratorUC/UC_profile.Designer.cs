namespace PharmacyManagement.AdminstratorUC
{
    partial class UC_profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_profile));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TxtDOB = new System.Windows.Forms.DateTimePicker();
            this.TxtMobileNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnReset = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(162, 425);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(261, 25);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtDOB
            // 
            this.TxtDOB.Location = new System.Drawing.Point(617, 485);
            this.TxtDOB.Name = "TxtDOB";
            this.TxtDOB.Size = new System.Drawing.Size(340, 22);
            this.TxtDOB.TabIndex = 27;
            // 
            // TxtMobileNumber
            // 
            this.TxtMobileNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMobileNumber.DefaultText = "";
            this.TxtMobileNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtMobileNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtMobileNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMobileNumber.DisabledState.Parent = this.TxtMobileNumber;
            this.TxtMobileNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtMobileNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMobileNumber.FocusedState.Parent = this.TxtMobileNumber;
            this.TxtMobileNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMobileNumber.ForeColor = System.Drawing.Color.Black;
            this.TxtMobileNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtMobileNumber.HoverState.Parent = this.TxtMobileNumber;
            this.TxtMobileNumber.Location = new System.Drawing.Point(617, 310);
            this.TxtMobileNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtMobileNumber.Name = "TxtMobileNumber";
            this.TxtMobileNumber.PasswordChar = '\0';
            this.TxtMobileNumber.PlaceholderText = "";
            this.TxtMobileNumber.SelectedText = "";
            this.TxtMobileNumber.ShadowDecoration.Parent = this.TxtMobileNumber;
            this.TxtMobileNumber.Size = new System.Drawing.Size(340, 36);
            this.TxtMobileNumber.TabIndex = 26;
            this.TxtMobileNumber.Enter += new System.EventHandler(this.UC_Profile_Enter);
            // 
            // TxtName
            // 
            this.TxtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtName.DefaultText = "";
            this.TxtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.DisabledState.Parent = this.TxtName;
            this.TxtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.FocusedState.Parent = this.TxtName;
            this.TxtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Black;
            this.TxtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtName.HoverState.Parent = this.TxtName;
            this.TxtName.Location = new System.Drawing.Point(617, 214);
            this.TxtName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtName.Name = "TxtName";
            this.TxtName.PasswordChar = '\0';
            this.TxtName.PlaceholderText = "";
            this.TxtName.SelectedText = "";
            this.TxtName.ShadowDecoration.Parent = this.TxtName;
            this.TxtName.Size = new System.Drawing.Size(340, 36);
            this.TxtName.TabIndex = 25;
            this.TxtName.Enter += new System.EventHandler(this.UC_Profile_Enter);
            // 
            // TxtUserRole
            // 
            this.TxtUserRole.BackColor = System.Drawing.Color.Transparent;
            this.TxtUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TxtUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtUserRole.FocusedColor = System.Drawing.Color.Empty;
            this.TxtUserRole.FocusedState.Parent = this.TxtUserRole;
            this.TxtUserRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserRole.ForeColor = System.Drawing.Color.Black;
            this.TxtUserRole.FormattingEnabled = true;
            this.TxtUserRole.HoverState.Parent = this.TxtUserRole;
            this.TxtUserRole.ItemHeight = 30;
            this.TxtUserRole.Items.AddRange(new object[] {
            "Administrator",
            "Pharmacist"});
            this.TxtUserRole.ItemsAppearance.Parent = this.TxtUserRole;
            this.TxtUserRole.Location = new System.Drawing.Point(617, 129);
            this.TxtUserRole.Name = "TxtUserRole";
            this.TxtUserRole.ShadowDecoration.Parent = this.TxtUserRole;
            this.TxtUserRole.Size = new System.Drawing.Size(340, 36);
            this.TxtUserRole.TabIndex = 24;
            this.TxtUserRole.SelectedIndexChanged += new System.EventHandler(this.TxtUserRole_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mobile number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Date of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(612, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "User Role";
            // 
            // BtnReset
            // 
            this.BtnReset.BorderRadius = 16;
            this.BtnReset.BorderThickness = 1;
            this.BtnReset.CheckedState.Parent = this.BtnReset;
            this.BtnReset.CustomImages.Parent = this.BtnReset;
            this.BtnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnReset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.BtnReset.HoverState.Parent = this.BtnReset;
            this.BtnReset.Location = new System.Drawing.Point(817, 629);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.ShadowDecoration.Parent = this.BtnReset;
            this.BtnReset.Size = new System.Drawing.Size(140, 45);
            this.BtnReset.TabIndex = 31;
            this.BtnReset.Text = "Reset";
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BorderRadius = 16;
            this.BtnSignUp.BorderThickness = 1;
            this.BtnSignUp.CheckedState.Parent = this.BtnSignUp;
            this.BtnSignUp.CustomImages.Parent = this.BtnSignUp;
            this.BtnSignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.BtnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSignUp.ForeColor = System.Drawing.Color.White;
            this.BtnSignUp.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnSignUp.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.BtnSignUp.HoverState.Parent = this.BtnSignUp;
            this.BtnSignUp.Location = new System.Drawing.Point(617, 629);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.ShadowDecoration.Parent = this.BtnSignUp;
            this.BtnSignUp.Size = new System.Drawing.Size(140, 45);
            this.BtnSignUp.TabIndex = 30;
            this.BtnSignUp.Text = "Update";
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.Parent = this.TxtPassword;
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.FocusedState.Parent = this.TxtPassword;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.HoverState.Parent = this.TxtPassword;
            this.TxtPassword.Location = new System.Drawing.Point(617, 558);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderText = "";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.ShadowDecoration.Parent = this.TxtPassword;
            this.TxtPassword.Size = new System.Drawing.Size(340, 36);
            this.TxtPassword.TabIndex = 29;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.Enter += new System.EventHandler(this.UC_Profile_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(612, 526);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Password";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Email
            // 
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.Parent = this.Email;
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.FocusedState.Parent = this.Email;
            this.Email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Black;
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.HoverState.Parent = this.Email;
            this.Email.Location = new System.Drawing.Point(617, 393);
            this.Email.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderText = "";
            this.Email.SelectedText = "";
            this.Email.ShadowDecoration.Parent = this.Email;
            this.Email.Size = new System.Drawing.Size(340, 36);
            this.Email.TabIndex = 33;
            this.Email.Enter += new System.EventHandler(this.UC_Profile_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "E-mail";
            // 
            // UC_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TxtDOB);
            this.Controls.Add(this.TxtMobileNumber);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.TxtUserRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_profile";
            this.Size = new System.Drawing.Size(1097, 769);
            this.Load += new System.EventHandler(this.UC_profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.DateTimePicker TxtDOB;
        private Guna.UI2.WinForms.Guna2TextBox TxtMobileNumber;
        private Guna.UI2.WinForms.Guna2TextBox TxtName;
        private Guna.UI2.WinForms.Guna2ComboBox TxtUserRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button BtnReset;
        private Guna.UI2.WinForms.Guna2Button BtnSignUp;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private System.Windows.Forms.Label label2;
    }
}
