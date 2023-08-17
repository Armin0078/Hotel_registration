namespace Hotel_WindowsForm
{
    partial class Form_2
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
            this.lblfullName_Form2 = new System.Windows.Forms.Label();
            this.lblCount_Form2 = new System.Windows.Forms.Label();
            this.lblCost_Form2 = new System.Windows.Forms.Label();
            this.txtfullName_Form2 = new System.Windows.Forms.TextBox();
            this.txtCount_Form2 = new System.Windows.Forms.TextBox();
            this.txtCost_Form2 = new System.Windows.Forms.TextBox();
            this.lblroom = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblfullName_Form2
            // 
            this.lblfullName_Form2.AutoSize = true;
            this.lblfullName_Form2.Location = new System.Drawing.Point(322, 34);
            this.lblfullName_Form2.Name = "lblfullName_Form2";
            this.lblfullName_Form2.Size = new System.Drawing.Size(148, 26);
            this.lblfullName_Form2.TabIndex = 0;
            this.lblfullName_Form2.Text = "نام و نام خانوادگی مشتری:";
            // 
            // lblCount_Form2
            // 
            this.lblCount_Form2.AutoSize = true;
            this.lblCount_Form2.Location = new System.Drawing.Point(312, 86);
            this.lblCount_Form2.Name = "lblCount_Form2";
            this.lblCount_Form2.Size = new System.Drawing.Size(158, 26);
            this.lblCount_Form2.TabIndex = 1;
            this.lblCount_Form2.Text = "تعداد اعضای خانواده مشتری:";
            // 
            // lblCost_Form2
            // 
            this.lblCost_Form2.AutoSize = true;
            this.lblCost_Form2.Location = new System.Drawing.Point(375, 197);
            this.lblCost_Form2.Name = "lblCost_Form2";
            this.lblCost_Form2.Size = new System.Drawing.Size(44, 26);
            this.lblCost_Form2.TabIndex = 2;
            this.lblCost_Form2.Text = "هزینه:";
            this.lblCost_Form2.Click += new System.EventHandler(this.lblCost_Form2_Click);
            // 
            // txtfullName_Form2
            // 
            this.txtfullName_Form2.Enabled = false;
            this.txtfullName_Form2.Location = new System.Drawing.Point(12, 34);
            this.txtfullName_Form2.Name = "txtfullName_Form2";
            this.txtfullName_Form2.Size = new System.Drawing.Size(238, 33);
            this.txtfullName_Form2.TabIndex = 3;
            // 
            // txtCount_Form2
            // 
            this.txtCount_Form2.Enabled = false;
            this.txtCount_Form2.Location = new System.Drawing.Point(12, 83);
            this.txtCount_Form2.Name = "txtCount_Form2";
            this.txtCount_Form2.Size = new System.Drawing.Size(238, 33);
            this.txtCount_Form2.TabIndex = 4;
            // 
            // txtCost_Form2
            // 
            this.txtCost_Form2.Enabled = false;
            this.txtCost_Form2.Location = new System.Drawing.Point(12, 194);
            this.txtCost_Form2.Name = "txtCost_Form2";
            this.txtCost_Form2.Size = new System.Drawing.Size(238, 33);
            this.txtCost_Form2.TabIndex = 5;
            this.txtCost_Form2.TextChanged += new System.EventHandler(this.txtCost_Form2_TextChanged);
            // 
            // lblroom
            // 
            this.lblroom.AutoSize = true;
            this.lblroom.Location = new System.Drawing.Point(364, 145);
            this.lblroom.Name = "lblroom";
            this.lblroom.Size = new System.Drawing.Size(70, 26);
            this.lblroom.TabIndex = 6;
            this.lblroom.Text = "شماره اتاق:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Location = new System.Drawing.Point(13, 138);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(237, 33);
            this.txtRoomNumber.TabIndex = 7;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.txtRoomNumber_TextChanged);
            // 
            // Form_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 253);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblroom);
            this.Controls.Add(this.txtCost_Form2);
            this.Controls.Add(this.txtCount_Form2);
            this.Controls.Add(this.txtfullName_Form2);
            this.Controls.Add(this.lblCost_Form2);
            this.Controls.Add(this.lblCount_Form2);
            this.Controls.Add(this.lblfullName_Form2);
            this.Font = new System.Drawing.Font("B Nazanin", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form_2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشتری";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfullName_Form2;
        private System.Windows.Forms.Label lblCount_Form2;
        private System.Windows.Forms.Label lblCost_Form2;
        private System.Windows.Forms.TextBox txtfullName_Form2;
        private System.Windows.Forms.TextBox txtCount_Form2;
        private System.Windows.Forms.TextBox txtCost_Form2;
        private System.Windows.Forms.Label lblroom;
        private System.Windows.Forms.TextBox txtRoomNumber;
    }
}