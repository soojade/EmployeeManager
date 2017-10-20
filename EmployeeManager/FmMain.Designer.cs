namespace EmployeeManager {
    partial class FormMain {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbEmployeeEdit = new System.Windows.Forms.GroupBox();
            this.btnEditPhotoAdd = new System.Windows.Forms.Button();
            this.dtpEditBDay = new System.Windows.Forms.DateTimePicker();
            this.rbtnEditWoman = new System.Windows.Forms.RadioButton();
            this.rbtnEditMan = new System.Windows.Forms.RadioButton();
            this.pbEditPhoto = new System.Windows.Forms.PictureBox();
            this.tbEditAddr = new System.Windows.Forms.TextBox();
            this.lbEditAddr = new System.Windows.Forms.Label();
            this.lbEditBDay = new System.Windows.Forms.Label();
            this.lbEditSex = new System.Windows.Forms.Label();
            this.tbEditPhone = new System.Windows.Forms.TextBox();
            this.lbEditPhone = new System.Windows.Forms.Label();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.lbEditName = new System.Windows.Forms.Label();
            this.tbEditId = new System.Windows.Forms.TextBox();
            this.lbEditId = new System.Windows.Forms.Label();
            this.dgvEmployeeShow = new System.Windows.Forms.DataGridView();
            this.EId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EBDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbQueryId = new System.Windows.Forms.Label();
            this.tbQueryId = new System.Windows.Forms.TextBox();
            this.lbQueryName = new System.Windows.Forms.Label();
            this.tbQueryName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbEmployeeEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeShow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEmployeeEdit
            // 
            this.gbEmployeeEdit.BackColor = System.Drawing.Color.Transparent;
            this.gbEmployeeEdit.Controls.Add(this.dtpEditBDay);
            this.gbEmployeeEdit.Controls.Add(this.rbtnEditWoman);
            this.gbEmployeeEdit.Controls.Add(this.rbtnEditMan);
            this.gbEmployeeEdit.Controls.Add(this.tbEditAddr);
            this.gbEmployeeEdit.Controls.Add(this.lbEditAddr);
            this.gbEmployeeEdit.Controls.Add(this.lbEditBDay);
            this.gbEmployeeEdit.Controls.Add(this.lbEditSex);
            this.gbEmployeeEdit.Controls.Add(this.tbEditPhone);
            this.gbEmployeeEdit.Controls.Add(this.lbEditPhone);
            this.gbEmployeeEdit.Controls.Add(this.tbEditName);
            this.gbEmployeeEdit.Controls.Add(this.lbEditName);
            this.gbEmployeeEdit.Controls.Add(this.tbEditId);
            this.gbEmployeeEdit.Controls.Add(this.lbEditId);
            this.gbEmployeeEdit.Controls.Add(this.btnEditPhotoAdd);
            this.gbEmployeeEdit.Controls.Add(this.pbEditPhoto);
            this.gbEmployeeEdit.Enabled = false;
            this.gbEmployeeEdit.Location = new System.Drawing.Point(12, 1);
            this.gbEmployeeEdit.Name = "gbEmployeeEdit";
            this.gbEmployeeEdit.Size = new System.Drawing.Size(779, 172);
            this.gbEmployeeEdit.TabIndex = 0;
            this.gbEmployeeEdit.TabStop = false;
            this.gbEmployeeEdit.Text = "员工信息";
            // 
            // btnEditPhotoAdd
            // 
            this.btnEditPhotoAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditPhotoAdd.Location = new System.Drawing.Point(588, 52);
            this.btnEditPhotoAdd.Name = "btnEditPhotoAdd";
            this.btnEditPhotoAdd.Size = new System.Drawing.Size(28, 81);
            this.btnEditPhotoAdd.TabIndex = 7;
            this.btnEditPhotoAdd.Text = "添加照片";
            this.btnEditPhotoAdd.UseVisualStyleBackColor = true;
            this.btnEditPhotoAdd.Click += new System.EventHandler(this.btnEditPhotoAdd_Click);
            // 
            // dtpEditBDay
            // 
            this.dtpEditBDay.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpEditBDay.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.dtpEditBDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEditBDay.Location = new System.Drawing.Point(100, 136);
            this.dtpEditBDay.Name = "dtpEditBDay";
            this.dtpEditBDay.Size = new System.Drawing.Size(101, 26);
            this.dtpEditBDay.TabIndex = 5;
            // 
            // rbtnEditWoman
            // 
            this.rbtnEditWoman.AutoSize = true;
            this.rbtnEditWoman.Location = new System.Drawing.Point(160, 79);
            this.rbtnEditWoman.Name = "rbtnEditWoman";
            this.rbtnEditWoman.Size = new System.Drawing.Size(41, 24);
            this.rbtnEditWoman.TabIndex = 3;
            this.rbtnEditWoman.TabStop = true;
            this.rbtnEditWoman.Text = "女";
            this.rbtnEditWoman.UseVisualStyleBackColor = true;
            // 
            // rbtnEditMan
            // 
            this.rbtnEditMan.AutoSize = true;
            this.rbtnEditMan.Location = new System.Drawing.Point(75, 81);
            this.rbtnEditMan.Name = "rbtnEditMan";
            this.rbtnEditMan.Size = new System.Drawing.Size(41, 24);
            this.rbtnEditMan.TabIndex = 3;
            this.rbtnEditMan.TabStop = true;
            this.rbtnEditMan.Text = "男";
            this.rbtnEditMan.UseVisualStyleBackColor = true;
            // 
            // pbEditPhoto
            // 
            this.pbEditPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEditPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEditPhoto.Location = new System.Drawing.Point(482, 15);
            this.pbEditPhoto.Name = "pbEditPhoto";
            this.pbEditPhoto.Size = new System.Drawing.Size(106, 147);
            this.pbEditPhoto.TabIndex = 2;
            this.pbEditPhoto.TabStop = false;
            // 
            // tbEditAddr
            // 
            this.tbEditAddr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEditAddr.Location = new System.Drawing.Point(304, 136);
            this.tbEditAddr.Name = "tbEditAddr";
            this.tbEditAddr.Size = new System.Drawing.Size(152, 26);
            this.tbEditAddr.TabIndex = 6;
            // 
            // lbEditAddr
            // 
            this.lbEditAddr.AutoSize = true;
            this.lbEditAddr.Location = new System.Drawing.Point(219, 142);
            this.lbEditAddr.Name = "lbEditAddr";
            this.lbEditAddr.Size = new System.Drawing.Size(79, 20);
            this.lbEditAddr.TabIndex = 0;
            this.lbEditAddr.Text = "家庭地址：";
            // 
            // lbEditBDay
            // 
            this.lbEditBDay.AutoSize = true;
            this.lbEditBDay.Location = new System.Drawing.Point(17, 142);
            this.lbEditBDay.Name = "lbEditBDay";
            this.lbEditBDay.Size = new System.Drawing.Size(79, 20);
            this.lbEditBDay.TabIndex = 0;
            this.lbEditBDay.Text = "出生日期：";
            // 
            // lbEditSex
            // 
            this.lbEditSex.AutoSize = true;
            this.lbEditSex.Location = new System.Drawing.Point(17, 85);
            this.lbEditSex.Name = "lbEditSex";
            this.lbEditSex.Size = new System.Drawing.Size(51, 20);
            this.lbEditSex.TabIndex = 0;
            this.lbEditSex.Text = "性别：";
            // 
            // tbEditPhone
            // 
            this.tbEditPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEditPhone.Location = new System.Drawing.Point(304, 79);
            this.tbEditPhone.Name = "tbEditPhone";
            this.tbEditPhone.Size = new System.Drawing.Size(152, 26);
            this.tbEditPhone.TabIndex = 4;
            // 
            // lbEditPhone
            // 
            this.lbEditPhone.AutoSize = true;
            this.lbEditPhone.Location = new System.Drawing.Point(248, 84);
            this.lbEditPhone.Name = "lbEditPhone";
            this.lbEditPhone.Size = new System.Drawing.Size(51, 20);
            this.lbEditPhone.TabIndex = 0;
            this.lbEditPhone.Text = "电话：";
            // 
            // tbEditName
            // 
            this.tbEditName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEditName.Location = new System.Drawing.Point(304, 15);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(152, 26);
            this.tbEditName.TabIndex = 2;
            // 
            // lbEditName
            // 
            this.lbEditName.AutoSize = true;
            this.lbEditName.Location = new System.Drawing.Point(248, 21);
            this.lbEditName.Name = "lbEditName";
            this.lbEditName.Size = new System.Drawing.Size(51, 20);
            this.lbEditName.TabIndex = 0;
            this.lbEditName.Text = "姓名：";
            // 
            // tbEditId
            // 
            this.tbEditId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEditId.Location = new System.Drawing.Point(73, 15);
            this.tbEditId.Name = "tbEditId";
            this.tbEditId.Size = new System.Drawing.Size(128, 26);
            this.tbEditId.TabIndex = 1;
            // 
            // lbEditId
            // 
            this.lbEditId.AutoSize = true;
            this.lbEditId.Location = new System.Drawing.Point(17, 21);
            this.lbEditId.Name = "lbEditId";
            this.lbEditId.Size = new System.Drawing.Size(51, 20);
            this.lbEditId.TabIndex = 0;
            this.lbEditId.Text = "工号：";
            // 
            // dgvEmployeeShow
            // 
            this.dgvEmployeeShow.AllowUserToAddRows = false;
            this.dgvEmployeeShow.AllowUserToDeleteRows = false;
            this.dgvEmployeeShow.AllowUserToResizeColumns = false;
            this.dgvEmployeeShow.AllowUserToResizeRows = false;
            this.dgvEmployeeShow.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvEmployeeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeeShow.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvEmployeeShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EId,
            this.EName,
            this.ESex,
            this.EPhone,
            this.EBDay,
            this.EAddr});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeShow.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvEmployeeShow.EnableHeadersVisualStyles = false;
            this.dgvEmployeeShow.Location = new System.Drawing.Point(12, 179);
            this.dgvEmployeeShow.MultiSelect = false;
            this.dgvEmployeeShow.Name = "dgvEmployeeShow";
            this.dgvEmployeeShow.ReadOnly = true;
            this.dgvEmployeeShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvEmployeeShow.RowHeadersVisible = false;
            this.dgvEmployeeShow.RowHeadersWidth = 42;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Red;
            this.dgvEmployeeShow.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvEmployeeShow.RowTemplate.Height = 23;
            this.dgvEmployeeShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeShow.Size = new System.Drawing.Size(588, 234);
            this.dgvEmployeeShow.TabIndex = 1;
            this.dgvEmployeeShow.SelectionChanged += new System.EventHandler(this.dgvEmployeeShow_SelectionChanged);
            // 
            // EId
            // 
            this.EId.DataPropertyName = "EId";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Transparent;
            this.EId.DefaultCellStyle = dataGridViewCellStyle13;
            this.EId.FillWeight = 80F;
            this.EId.HeaderText = "工号";
            this.EId.Name = "EId";
            this.EId.ReadOnly = true;
            this.EId.Width = 80;
            // 
            // EName
            // 
            this.EName.DataPropertyName = "EName";
            this.EName.HeaderText = "姓名";
            this.EName.Name = "EName";
            this.EName.ReadOnly = true;
            // 
            // ESex
            // 
            this.ESex.DataPropertyName = "ESex";
            this.ESex.FillWeight = 80F;
            this.ESex.HeaderText = "性别";
            this.ESex.Name = "ESex";
            this.ESex.ReadOnly = true;
            this.ESex.Width = 65;
            // 
            // EPhone
            // 
            this.EPhone.DataPropertyName = "EPhone";
            this.EPhone.HeaderText = "电话";
            this.EPhone.Name = "EPhone";
            this.EPhone.ReadOnly = true;
            // 
            // EBDay
            // 
            this.EBDay.DataPropertyName = "EBDay";
            this.EBDay.HeaderText = "出生日期";
            this.EBDay.Name = "EBDay";
            this.EBDay.ReadOnly = true;
            this.EBDay.Width = 120;
            // 
            // EAddr
            // 
            this.EAddr.DataPropertyName = "EAddr";
            this.EAddr.HeaderText = "家庭地址";
            this.EAddr.Name = "EAddr";
            this.EAddr.ReadOnly = true;
            this.EAddr.Width = 120;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(654, 22);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 53);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbQueryId
            // 
            this.lbQueryId.AutoSize = true;
            this.lbQueryId.BackColor = System.Drawing.Color.Transparent;
            this.lbQueryId.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQueryId.Location = new System.Drawing.Point(4, 32);
            this.lbQueryId.Name = "lbQueryId";
            this.lbQueryId.Size = new System.Drawing.Size(58, 21);
            this.lbQueryId.TabIndex = 3;
            this.lbQueryId.Text = "工号：";
            // 
            // tbQueryId
            // 
            this.tbQueryId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbQueryId.Location = new System.Drawing.Point(59, 27);
            this.tbQueryId.Name = "tbQueryId";
            this.tbQueryId.Size = new System.Drawing.Size(112, 26);
            this.tbQueryId.TabIndex = 0;
            this.tbQueryId.TextChanged += new System.EventHandler(this.tbQueryId_TextChanged);
            // 
            // lbQueryName
            // 
            this.lbQueryName.AutoSize = true;
            this.lbQueryName.BackColor = System.Drawing.Color.Transparent;
            this.lbQueryName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbQueryName.Location = new System.Drawing.Point(4, 70);
            this.lbQueryName.Name = "lbQueryName";
            this.lbQueryName.Size = new System.Drawing.Size(58, 21);
            this.lbQueryName.TabIndex = 3;
            this.lbQueryName.Text = "姓名：";
            // 
            // tbQueryName
            // 
            this.tbQueryName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbQueryName.Location = new System.Drawing.Point(59, 65);
            this.tbQueryName.Name = "tbQueryName";
            this.tbQueryName.Size = new System.Drawing.Size(112, 26);
            this.tbQueryName.TabIndex = 1;
            this.tbQueryName.TextChanged += new System.EventHandler(this.tbQueryName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tbQueryName);
            this.groupBox1.Controls.Add(this.tbQueryId);
            this.groupBox1.Controls.Add(this.lbQueryName);
            this.groupBox1.Controls.Add(this.lbQueryId);
            this.groupBox1.Location = new System.Drawing.Point(621, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询信息";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCancel.Location = new System.Drawing.Point(654, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 53);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Location = new System.Drawing.Point(621, 291);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(84, 41);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(708, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 41);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(708, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 41);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(621, 349);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(803, 435);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvEmployeeShow);
            this.Controls.Add(this.gbEmployeeEdit);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "员工信息管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.gbEmployeeEdit.ResumeLayout(false);
            this.gbEmployeeEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeShow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEmployeeEdit;
        private System.Windows.Forms.DataGridView dgvEmployeeShow;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbQueryId;
        private System.Windows.Forms.TextBox tbQueryId;
        private System.Windows.Forms.Label lbQueryName;
        private System.Windows.Forms.TextBox tbQueryName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pbEditPhoto;
        private System.Windows.Forms.TextBox tbEditId;
        private System.Windows.Forms.Label lbEditId;
        private System.Windows.Forms.TextBox tbEditAddr;
        private System.Windows.Forms.Label lbEditAddr;
        private System.Windows.Forms.Label lbEditBDay;
        private System.Windows.Forms.Label lbEditSex;
        private System.Windows.Forms.TextBox tbEditPhone;
        private System.Windows.Forms.Label lbEditPhone;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.Label lbEditName;
        private System.Windows.Forms.DateTimePicker dtpEditBDay;
        private System.Windows.Forms.RadioButton rbtnEditWoman;
        private System.Windows.Forms.RadioButton rbtnEditMan;
        private System.Windows.Forms.Button btnEditPhotoAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn EId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESex;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EBDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EAddr;
    }
}

