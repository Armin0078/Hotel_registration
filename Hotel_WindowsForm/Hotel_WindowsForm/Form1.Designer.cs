namespace Hotel_WindowsForm
{
    partial class MainForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtHour = new System.Windows.Forms.NumericUpDown();
            this.txtDay = new System.Windows.Forms.NumericUpDown();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.bnbRoomsInBanks = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.gpLanguageMainForm = new System.Windows.Forms.GroupBox();
            this.btnLanguageEnglish = new System.Windows.Forms.Button();
            this.btnLanguagePersian = new System.Windows.Forms.Button();
            this.grMainForm = new System.Windows.Forms.GroupBox();
            this.gbSignUpMainForm = new System.Windows.Forms.GroupBox();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.numFloor = new System.Windows.Forms.NumericUpDown();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblTimeMainForm = new System.Windows.Forms.Label();
            this.lblDateMainForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).BeginInit();
            this.gpLanguageMainForm.SuspendLayout();
            this.grMainForm.SuspendLayout();
            this.gbSignUpMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(363, 35);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 26);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "نام:";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(363, 89);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(80, 26);
            this.lblFamily.TabIndex = 2;
            this.lblFamily.Text = "نام خانوادگی:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 33);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(19, 86);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(328, 33);
            this.txtFamily.TabIndex = 4;
            this.txtFamily.TextChanged += new System.EventHandler(this.txtFamily_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(161, 329);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(78, 36);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "تایید";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click_1);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(333, 282);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 26);
            this.lblTime.TabIndex = 11;
            this.lblTime.Text = "چه مدت اقامت دارید:";
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(194, 280);
            this.txtHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(133, 33);
            this.txtHour.TabIndex = 12;
            this.txtHour.ValueChanged += new System.EventHandler(this.txtHour_ValueChanged);
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(19, 280);
            this.txtDay.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(149, 33);
            this.txtDay.TabIndex = 13;
            this.txtDay.ValueChanged += new System.EventHandler(this.txtDay_ValueChanged);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(243, 251);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(44, 26);
            this.lblHour.TabIndex = 14;
            this.lblHour.Text = "ساعت";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(80, 251);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(27, 26);
            this.lblDay.TabIndex = 15;
            this.lblDay.Text = "روز";
            // 
            // bnbRoomsInBanks
            // 
            this.bnbRoomsInBanks.Location = new System.Drawing.Point(31, 151);
            this.bnbRoomsInBanks.Name = "bnbRoomsInBanks";
            this.bnbRoomsInBanks.Size = new System.Drawing.Size(103, 41);
            this.bnbRoomsInBanks.TabIndex = 16;
            this.bnbRoomsInBanks.Text = "اتاق های هتل";
            this.bnbRoomsInBanks.UseVisualStyleBackColor = true;
            this.bnbRoomsInBanks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(31, 201);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(103, 36);
            this.btnAdmin.TabIndex = 17;
            this.btnAdmin.Text = "پنل ادمین";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // gpLanguageMainForm
            // 
            this.gpLanguageMainForm.Controls.Add(this.btnLanguageEnglish);
            this.gpLanguageMainForm.Controls.Add(this.btnLanguagePersian);
            this.gpLanguageMainForm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gpLanguageMainForm.Location = new System.Drawing.Point(10, 26);
            this.gpLanguageMainForm.Name = "gpLanguageMainForm";
            this.gpLanguageMainForm.Size = new System.Drawing.Size(176, 119);
            this.gpLanguageMainForm.TabIndex = 18;
            this.gpLanguageMainForm.TabStop = false;
            this.gpLanguageMainForm.Text = "زبان         Language";
            // 
            // btnLanguageEnglish
            // 
            this.btnLanguageEnglish.Location = new System.Drawing.Point(39, 78);
            this.btnLanguageEnglish.Name = "btnLanguageEnglish";
            this.btnLanguageEnglish.Size = new System.Drawing.Size(75, 33);
            this.btnLanguageEnglish.TabIndex = 1;
            this.btnLanguageEnglish.Text = "English";
            this.btnLanguageEnglish.UseVisualStyleBackColor = true;
            this.btnLanguageEnglish.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLanguagePersian
            // 
            this.btnLanguagePersian.Location = new System.Drawing.Point(39, 39);
            this.btnLanguagePersian.Name = "btnLanguagePersian";
            this.btnLanguagePersian.Size = new System.Drawing.Size(75, 33);
            this.btnLanguagePersian.TabIndex = 0;
            this.btnLanguagePersian.Text = "فارسی";
            this.btnLanguagePersian.UseVisualStyleBackColor = true;
            this.btnLanguagePersian.Click += new System.EventHandler(this.btnLanguagePersian_Click);
            // 
            // grMainForm
            // 
            this.grMainForm.Controls.Add(this.bnbRoomsInBanks);
            this.grMainForm.Controls.Add(this.gpLanguageMainForm);
            this.grMainForm.Controls.Add(this.btnAdmin);
            this.grMainForm.Location = new System.Drawing.Point(18, 12);
            this.grMainForm.Name = "grMainForm";
            this.grMainForm.Size = new System.Drawing.Size(192, 382);
            this.grMainForm.TabIndex = 19;
            this.grMainForm.TabStop = false;
            this.grMainForm.Text = "لیست";
            // 
            // gbSignUpMainForm
            // 
            this.gbSignUpMainForm.Controls.Add(this.numCount);
            this.gbSignUpMainForm.Controls.Add(this.numFloor);
            this.gbSignUpMainForm.Controls.Add(this.lblFloor);
            this.gbSignUpMainForm.Controls.Add(this.lblCount);
            this.gbSignUpMainForm.Controls.Add(this.txtName);
            this.gbSignUpMainForm.Controls.Add(this.lblName);
            this.gbSignUpMainForm.Controls.Add(this.lblDay);
            this.gbSignUpMainForm.Controls.Add(this.lblFamily);
            this.gbSignUpMainForm.Controls.Add(this.lblHour);
            this.gbSignUpMainForm.Controls.Add(this.txtFamily);
            this.gbSignUpMainForm.Controls.Add(this.txtDay);
            this.gbSignUpMainForm.Controls.Add(this.btnAccept);
            this.gbSignUpMainForm.Controls.Add(this.txtHour);
            this.gbSignUpMainForm.Controls.Add(this.lblTime);
            this.gbSignUpMainForm.Location = new System.Drawing.Point(216, 12);
            this.gbSignUpMainForm.Name = "gbSignUpMainForm";
            this.gbSignUpMainForm.Size = new System.Drawing.Size(500, 382);
            this.gbSignUpMainForm.TabIndex = 20;
            this.gbSignUpMainForm.TabStop = false;
            this.gbSignUpMainForm.Text = "ثبت نام";
            this.gbSignUpMainForm.Enter += new System.EventHandler(this.gbSignUpMainForm_Enter);
            // 
            // numCount
            // 
            this.numCount.Location = new System.Drawing.Point(19, 145);
            this.numCount.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(328, 33);
            this.numCount.TabIndex = 21;
            this.numCount.ValueChanged += new System.EventHandler(this.numCount_ValueChanged_1);
            // 
            // numFloor
            // 
            this.numFloor.Location = new System.Drawing.Point(19, 199);
            this.numFloor.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numFloor.Name = "numFloor";
            this.numFloor.Size = new System.Drawing.Size(328, 33);
            this.numFloor.TabIndex = 20;
            this.numFloor.ValueChanged += new System.EventHandler(this.numFloor_ValueChanged);
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Location = new System.Drawing.Point(363, 206);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(76, 26);
            this.lblFloor.TabIndex = 19;
            this.lblFloor.Text = "شماره طبقه:";
            this.lblFloor.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(353, 147);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(117, 26);
            this.lblCount.TabIndex = 18;
            this.lblCount.Text = "تعداد اعضای خانواده:";
            this.lblCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTimeMainForm
            // 
            this.lblTimeMainForm.AutoSize = true;
            this.lblTimeMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTimeMainForm.Location = new System.Drawing.Point(763, 54);
            this.lblTimeMainForm.Name = "lblTimeMainForm";
            this.lblTimeMainForm.Size = new System.Drawing.Size(37, 19);
            this.lblTimeMainForm.TabIndex = 21;
            this.lblTimeMainForm.Text = "زمان";
            this.lblTimeMainForm.Click += new System.EventHandler(this.lblTimeMainForm_Click);
            // 
            // lblDateMainForm
            // 
            this.lblDateMainForm.AutoSize = true;
            this.lblDateMainForm.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDateMainForm.Location = new System.Drawing.Point(746, 101);
            this.lblDateMainForm.Name = "lblDateMainForm";
            this.lblDateMainForm.Size = new System.Drawing.Size(38, 19);
            this.lblDateMainForm.TabIndex = 22;
            this.lblDateMainForm.Text = "تاریخ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(868, 406);
            this.Controls.Add(this.lblDateMainForm);
            this.Controls.Add(this.lblTimeMainForm);
            this.Controls.Add(this.gbSignUpMainForm);
            this.Controls.Add(this.grMainForm);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "هتل";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDay)).EndInit();
            this.gpLanguageMainForm.ResumeLayout(false);
            this.grMainForm.ResumeLayout(false);
            this.gbSignUpMainForm.ResumeLayout(false);
            this.gbSignUpMainForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown txtHour;
        private System.Windows.Forms.NumericUpDown txtDay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button bnbRoomsInBanks;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.GroupBox gpLanguageMainForm;
        private System.Windows.Forms.Button btnLanguageEnglish;
        private System.Windows.Forms.Button btnLanguagePersian;
        private System.Windows.Forms.GroupBox grMainForm;
        private System.Windows.Forms.GroupBox gbSignUpMainForm;
        private System.Windows.Forms.Label lblTimeMainForm;
        private System.Windows.Forms.Label lblDateMainForm;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.NumericUpDown numFloor;
    }
}

