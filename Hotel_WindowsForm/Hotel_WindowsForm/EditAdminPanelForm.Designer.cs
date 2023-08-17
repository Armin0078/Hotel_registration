namespace Hotel_WindowsForm
{
    partial class EditAdminPanelForm
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
            this.lblFamilyNumber = new System.Windows.Forms.Label();
            this.lblFloor = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtFamilyCount = new System.Windows.Forms.TextBox();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblName.Location = new System.Drawing.Point(235, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام:";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFamily.Location = new System.Drawing.Point(203, 46);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(107, 26);
            this.lblFamily.TabIndex = 1;
            this.lblFamily.Text = "نام و نام خانوادگی:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(12, 45);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(171, 27);
            this.txtFamily.TabIndex = 3;
            this.txtFamily.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblFamilyNumber
            // 
            this.lblFamilyNumber.AutoSize = true;
            this.lblFamilyNumber.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFamilyNumber.Location = new System.Drawing.Point(203, 79);
            this.lblFamilyNumber.Name = "lblFamilyNumber";
            this.lblFamilyNumber.Size = new System.Drawing.Size(121, 26);
            this.lblFamilyNumber.TabIndex = 4;
            this.lblFamilyNumber.Text = "تعداد اعضای خانواده :";
            this.lblFamilyNumber.Click += new System.EventHandler(this.lblFamilyNumber_Click);
            // 
            // lblFloor
            // 
            this.lblFloor.AutoSize = true;
            this.lblFloor.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFloor.Location = new System.Drawing.Point(220, 113);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(76, 26);
            this.lblFloor.TabIndex = 7;
            this.lblFloor.Text = "شماره طبقه:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDay.Location = new System.Drawing.Point(75, 198);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(27, 26);
            this.lblDay.TabIndex = 21;
            this.lblDay.Text = "روز";
            this.lblDay.Click += new System.EventHandler(this.lblDay_Click);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHour.Location = new System.Drawing.Point(235, 198);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(44, 26);
            this.lblHour.TabIndex = 20;
            this.lblHour.Text = "ساعت";
            this.lblHour.Click += new System.EventHandler(this.lblHour_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAccept.Location = new System.Drawing.Point(119, 357);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(78, 36);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "تایید";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTime.Location = new System.Drawing.Point(108, 173);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(121, 26);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "چه مدت اقامت دارید:";
            // 
            // txtFamilyCount
            // 
            this.txtFamilyCount.Location = new System.Drawing.Point(12, 78);
            this.txtFamilyCount.Name = "txtFamilyCount";
            this.txtFamilyCount.Size = new System.Drawing.Size(171, 27);
            this.txtFamilyCount.TabIndex = 22;
            // 
            // txtFloor
            // 
            this.txtFloor.Location = new System.Drawing.Point(12, 111);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(172, 27);
            this.txtFloor.TabIndex = 23;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(21, 227);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(126, 27);
            this.txtDay.TabIndex = 25;
            this.txtDay.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(184, 227);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(121, 27);
            this.txtHour.TabIndex = 26;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(12, 287);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(171, 27);
            this.txtCost.TabIndex = 27;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCost.Location = new System.Drawing.Point(235, 286);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(44, 26);
            this.lblCost.TabIndex = 28;
            this.lblCost.Text = "هزینه:";
            // 
            // EditAdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 405);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.txtFamilyCount);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblFloor);
            this.Controls.Add(this.lblFamilyNumber);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblFamily);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditAdminPanelForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش پنل کاربری";
            this.Load += new System.EventHandler(this.EditAdminPanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label lblFamilyNumber;
        private System.Windows.Forms.Label lblFloor;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtFamilyCount;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
    }
}