namespace Hotel_WindowsForm
{
    partial class frmAdminPanel
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
            this.dgAdminPanel = new System.Windows.Forms.DataGridView();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FamilyCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpTableAdminPanel = new System.Windows.Forms.GroupBox();
            this.grpSearchAdminPanel = new System.Windows.Forms.GroupBox();
            this.txtSearchAdminPanel = new System.Windows.Forms.TextBox();
            this.btnEditAdminPanel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminPanel)).BeginInit();
            this.grpTableAdminPanel.SuspendLayout();
            this.grpSearchAdminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAdminPanel
            // 
            this.dgAdminPanel.AllowUserToAddRows = false;
            this.dgAdminPanel.AllowUserToDeleteRows = false;
            this.dgAdminPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAdminPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room,
            this.Name,
            this.FamilyName,
            this.FamilyCount,
            this.day,
            this.hour,
            this.cost,
            this.Full});
            this.dgAdminPanel.Location = new System.Drawing.Point(6, 26);
            this.dgAdminPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgAdminPanel.Name = "dgAdminPanel";
            this.dgAdminPanel.ReadOnly = true;
            this.dgAdminPanel.RowHeadersWidth = 51;
            this.dgAdminPanel.RowTemplate.Height = 24;
            this.dgAdminPanel.Size = new System.Drawing.Size(719, 392);
            this.dgAdminPanel.TabIndex = 0;
            this.dgAdminPanel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAdminPanel_CellContentClick);
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "اتاق";
            this.Room.MinimumWidth = 6;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            this.Room.Width = 125;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // FamilyName
            // 
            this.FamilyName.DataPropertyName = "Family";
            this.FamilyName.HeaderText = "نام خانوادگی";
            this.FamilyName.MinimumWidth = 6;
            this.FamilyName.Name = "FamilyName";
            this.FamilyName.ReadOnly = true;
            this.FamilyName.Width = 125;
            // 
            // FamilyCount
            // 
            this.FamilyCount.DataPropertyName = "FamilyCounts";
            this.FamilyCount.HeaderText = "تعداد اعضای خانواده";
            this.FamilyCount.MinimumWidth = 6;
            this.FamilyCount.Name = "FamilyCount";
            this.FamilyCount.ReadOnly = true;
            this.FamilyCount.Width = 125;
            // 
            // day
            // 
            this.day.DataPropertyName = "day";
            this.day.HeaderText = "روز";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            this.day.ReadOnly = true;
            this.day.Width = 125;
            // 
            // hour
            // 
            this.hour.DataPropertyName = "hour";
            this.hour.HeaderText = "ساعت";
            this.hour.MinimumWidth = 6;
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Width = 125;
            // 
            // cost
            // 
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "هزینه";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 125;
            // 
            // Full
            // 
            this.Full.DataPropertyName = "Full";
            this.Full.HeaderText = "رزرو";
            this.Full.MinimumWidth = 6;
            this.Full.Name = "Full";
            this.Full.ReadOnly = true;
            this.Full.Width = 125;
            // 
            // grpTableAdminPanel
            // 
            this.grpTableAdminPanel.Controls.Add(this.dgAdminPanel);
            this.grpTableAdminPanel.Location = new System.Drawing.Point(12, 102);
            this.grpTableAdminPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTableAdminPanel.Name = "grpTableAdminPanel";
            this.grpTableAdminPanel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTableAdminPanel.Size = new System.Drawing.Size(731, 424);
            this.grpTableAdminPanel.TabIndex = 1;
            this.grpTableAdminPanel.TabStop = false;
            this.grpTableAdminPanel.Text = "لیست مشتریان";
            // 
            // grpSearchAdminPanel
            // 
            this.grpSearchAdminPanel.Controls.Add(this.txtSearchAdminPanel);
            this.grpSearchAdminPanel.Location = new System.Drawing.Point(233, 15);
            this.grpSearchAdminPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearchAdminPanel.Name = "grpSearchAdminPanel";
            this.grpSearchAdminPanel.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearchAdminPanel.Size = new System.Drawing.Size(504, 79);
            this.grpSearchAdminPanel.TabIndex = 2;
            this.grpSearchAdminPanel.TabStop = false;
            this.grpSearchAdminPanel.Text = "جست و جو";
            // 
            // txtSearchAdminPanel
            // 
            this.txtSearchAdminPanel.Location = new System.Drawing.Point(28, 28);
            this.txtSearchAdminPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchAdminPanel.Name = "txtSearchAdminPanel";
            this.txtSearchAdminPanel.Size = new System.Drawing.Size(436, 27);
            this.txtSearchAdminPanel.TabIndex = 0;
            this.txtSearchAdminPanel.TextChanged += new System.EventHandler(this.txtSearchAdminPanel_TextChanged);
            // 
            // btnEditAdminPanel
            // 
            this.btnEditAdminPanel.Location = new System.Drawing.Point(33, 30);
            this.btnEditAdminPanel.Name = "btnEditAdminPanel";
            this.btnEditAdminPanel.Size = new System.Drawing.Size(75, 40);
            this.btnEditAdminPanel.TabIndex = 3;
            this.btnEditAdminPanel.Text = "ویرایش";
            this.btnEditAdminPanel.UseVisualStyleBackColor = true;
            this.btnEditAdminPanel.Click += new System.EventHandler(this.btnEditAdminPanel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(127, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "بروزرسانی";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 527);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEditAdminPanel);
            this.Controls.Add(this.grpSearchAdminPanel);
            this.Controls.Add(this.grpTableAdminPanel);
            this.Font = new System.Drawing.Font("B Nazanin", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "پنل ادمین";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAdminPanel)).EndInit();
            this.grpTableAdminPanel.ResumeLayout(false);
            this.grpSearchAdminPanel.ResumeLayout(false);
            this.grpSearchAdminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAdminPanel;
        private System.Windows.Forms.GroupBox grpTableAdminPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FamilyCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full;
        private System.Windows.Forms.GroupBox grpSearchAdminPanel;
        private System.Windows.Forms.TextBox txtSearchAdminPanel;
        private System.Windows.Forms.Button btnEditAdminPanel;
        private System.Windows.Forms.Button btnUpdate;
    }
}