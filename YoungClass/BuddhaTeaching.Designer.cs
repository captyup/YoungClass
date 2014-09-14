namespace YoungClass
{
    partial class BuddhaTeaching
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuddhaTeaching));
            this.dgvStudentData = new System.Windows.Forms.DataGridView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.tbTeacherCondt = new System.Windows.Forms.TextBox();
            this.lblTeacherCondt = new System.Windows.Forms.Label();
            this.cbTypeCondt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSubjectCondt = new System.Windows.Forms.TextBox();
            this.lblSubjectCondt = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gbInputCondition = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSec = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numHour = new System.Windows.Forms.NumericUpDown();
            this.btnFile = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.pnlFunc = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.cbTextFinish = new System.Windows.Forms.ComboBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.lblNo = new System.Windows.Forms.Label();
            this.cbAudioFinish = new System.Windows.Forms.ComboBox();
            this.lblTextFinish = new System.Windows.Forms.Label();
            this.tbDVD = new System.Windows.Forms.TextBox();
            this.lblDVD = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblAudioFinish = new System.Windows.Forms.Label();
            this.lblAudioLen = new System.Windows.Forms.Label();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.lblSubjectType = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).BeginInit();
            this.gbQueryCondition.SuspendLayout();
            this.gbInputCondition.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).BeginInit();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentData
            // 
            this.dgvStudentData.AllowUserToAddRows = false;
            this.dgvStudentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentData.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dgvStudentData.Location = new System.Drawing.Point(0, 256);
            this.dgvStudentData.MultiSelect = false;
            this.dgvStudentData.Name = "dgvStudentData";
            this.dgvStudentData.RowTemplate.Height = 27;
            this.dgvStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStudentData.Size = new System.Drawing.Size(982, 397);
            this.dgvStudentData.TabIndex = 3;
            this.dgvStudentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentData_CellContentClick);
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.tbTeacherCondt);
            this.gbQueryCondition.Controls.Add(this.lblTeacherCondt);
            this.gbQueryCondition.Controls.Add(this.cbTypeCondt);
            this.gbQueryCondition.Controls.Add(this.label1);
            this.gbQueryCondition.Controls.Add(this.tbSubjectCondt);
            this.gbQueryCondition.Controls.Add(this.lblSubjectCondt);
            this.gbQueryCondition.Controls.Add(this.btnQuery);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 189);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(982, 67);
            this.gbQueryCondition.TabIndex = 4;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "Query Condition";
            // 
            // tbTeacherCondt
            // 
            this.tbTeacherCondt.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbTeacherCondt.Location = new System.Drawing.Point(481, 27);
            this.tbTeacherCondt.Name = "tbTeacherCondt";
            this.tbTeacherCondt.Size = new System.Drawing.Size(140, 27);
            this.tbTeacherCondt.TabIndex = 74;
            this.tbTeacherCondt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lblTeacherCondt
            // 
            this.lblTeacherCondt.AutoSize = true;
            this.lblTeacherCondt.Location = new System.Drawing.Point(400, 34);
            this.lblTeacherCondt.Name = "lblTeacherCondt";
            this.lblTeacherCondt.Size = new System.Drawing.Size(56, 16);
            this.lblTeacherCondt.TabIndex = 73;
            this.lblTeacherCondt.Text = "主講者";
            // 
            // cbTypeCondt
            // 
            this.cbTypeCondt.FormattingEnabled = true;
            this.cbTypeCondt.Items.AddRange(new object[] {
            "ALL",
            "青少年班",
            "讀經班"});
            this.cbTypeCondt.Location = new System.Drawing.Point(56, 30);
            this.cbTypeCondt.Name = "cbTypeCondt";
            this.cbTypeCondt.Size = new System.Drawing.Size(138, 24);
            this.cbTypeCondt.TabIndex = 72;
            this.cbTypeCondt.Text = "ALL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "類別";
            // 
            // tbSubjectCondt
            // 
            this.tbSubjectCondt.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSubjectCondt.Location = new System.Drawing.Point(254, 27);
            this.tbSubjectCondt.Name = "tbSubjectCondt";
            this.tbSubjectCondt.Size = new System.Drawing.Size(140, 27);
            this.tbSubjectCondt.TabIndex = 5;
            this.tbSubjectCondt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lblSubjectCondt
            // 
            this.lblSubjectCondt.AutoSize = true;
            this.lblSubjectCondt.Location = new System.Drawing.Point(199, 34);
            this.lblSubjectCondt.Name = "lblSubjectCondt";
            this.lblSubjectCondt.Size = new System.Drawing.Size(40, 16);
            this.lblSubjectCondt.TabIndex = 4;
            this.lblSubjectCondt.Text = "主題";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(633, 28);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 30);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gbInputCondition
            // 
            this.gbInputCondition.Controls.Add(this.panel1);
            this.gbInputCondition.Controls.Add(this.btnFile);
            this.gbInputCondition.Controls.Add(this.cbType);
            this.gbInputCondition.Controls.Add(this.pnlFunc);
            this.gbInputCondition.Controls.Add(this.lblPath);
            this.gbInputCondition.Controls.Add(this.cbTextFinish);
            this.gbInputCondition.Controls.Add(this.tbNo);
            this.gbInputCondition.Controls.Add(this.lblNo);
            this.gbInputCondition.Controls.Add(this.cbAudioFinish);
            this.gbInputCondition.Controls.Add(this.lblTextFinish);
            this.gbInputCondition.Controls.Add(this.tbDVD);
            this.gbInputCondition.Controls.Add(this.lblDVD);
            this.gbInputCondition.Controls.Add(this.tbPath);
            this.gbInputCondition.Controls.Add(this.lblAudioFinish);
            this.gbInputCondition.Controls.Add(this.lblAudioLen);
            this.gbInputCondition.Controls.Add(this.tbTeacher);
            this.gbInputCondition.Controls.Add(this.lblTeacher);
            this.gbInputCondition.Controls.Add(this.lblSubjectType);
            this.gbInputCondition.Controls.Add(this.tbSubject);
            this.gbInputCondition.Controls.Add(this.lblAddYear);
            this.gbInputCondition.Controls.Add(this.tbContent);
            this.gbInputCondition.Controls.Add(this.lblContent);
            this.gbInputCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInputCondition.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbInputCondition.Location = new System.Drawing.Point(0, 0);
            this.gbInputCondition.Name = "gbInputCondition";
            this.gbInputCondition.Size = new System.Drawing.Size(982, 189);
            this.gbInputCondition.TabIndex = 6;
            this.gbInputCondition.TabStop = false;
            this.gbInputCondition.Text = "Input Condition";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSec);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numHour);
            this.panel1.Location = new System.Drawing.Point(533, 55);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 0);
            this.panel1.Size = new System.Drawing.Size(160, 31);
            this.panel1.TabIndex = 75;
            // 
            // numSec
            // 
            this.numSec.Dock = System.Windows.Forms.DockStyle.Left;
            this.numSec.Location = new System.Drawing.Point(113, 2);
            this.numSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSec.Name = "numSec";
            this.numSec.Size = new System.Drawing.Size(39, 27);
            this.numSec.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(97, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = ":";
            // 
            // numMin
            // 
            this.numMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.numMin.Location = new System.Drawing.Point(58, 2);
            this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(39, 27);
            this.numMin.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(42, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 78;
            this.label2.Text = ":";
            // 
            // numHour
            // 
            this.numHour.Dock = System.Windows.Forms.DockStyle.Left;
            this.numHour.Location = new System.Drawing.Point(3, 2);
            this.numHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numHour.Name = "numHour";
            this.numHour.Size = new System.Drawing.Size(39, 27);
            this.numHour.TabIndex = 75;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(890, 100);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(89, 30);
            this.btnFile.TabIndex = 71;
            this.btnFile.Text = "設定檔案";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "ALL",
            "青少年班",
            "讀經班"});
            this.cbType.Location = new System.Drawing.Point(56, 65);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(160, 24);
            this.cbType.TabIndex = 70;
            this.cbType.Text = "青少年班";
            // 
            // pnlFunc
            // 
            this.pnlFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFunc.Controls.Add(this.btnDelete);
            this.pnlFunc.Controls.Add(this.btnGet);
            this.pnlFunc.Controls.Add(this.btnUpdate);
            this.pnlFunc.Controls.Add(this.btnInsert);
            this.pnlFunc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFunc.Location = new System.Drawing.Point(3, 136);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(976, 50);
            this.pnlFunc.TabIndex = 69;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(321, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGet.Image = ((System.Drawing.Image)(resources.GetObject("btnGet.Image")));
            this.btnGet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGet.Location = new System.Drawing.Point(3, 3);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 40);
            this.btnGet.TabIndex = 12;
            this.btnGet.Text = "取得";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(215, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
            this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Location = new System.Drawing.Point(109, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 40);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "新增";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.ForeColor = System.Drawing.Color.Black;
            this.lblPath.Location = new System.Drawing.Point(216, 108);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(88, 16);
            this.lblPath.TabIndex = 68;
            this.lblPath.Text = "電子影音檔";
            // 
            // cbTextFinish
            // 
            this.cbTextFinish.FormattingEnabled = true;
            this.cbTextFinish.Items.AddRange(new object[] {
            "未完成",
            "完成"});
            this.cbTextFinish.Location = new System.Drawing.Point(817, 61);
            this.cbTextFinish.Name = "cbTextFinish";
            this.cbTextFinish.Size = new System.Drawing.Size(160, 24);
            this.cbTextFinish.TabIndex = 67;
            this.cbTextFinish.Text = "未完成";
            // 
            // tbNo
            // 
            this.tbNo.Enabled = false;
            this.tbNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbNo.Location = new System.Drawing.Point(56, 27);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(160, 27);
            this.tbNo.TabIndex = 66;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.ForeColor = System.Drawing.Color.Red;
            this.lblNo.Location = new System.Drawing.Point(4, 32);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(40, 16);
            this.lblNo.TabIndex = 65;
            this.lblNo.Text = "編號";
            // 
            // cbAudioFinish
            // 
            this.cbAudioFinish.FormattingEnabled = true;
            this.cbAudioFinish.Items.AddRange(new object[] {
            "未完成",
            "完成"});
            this.cbAudioFinish.Location = new System.Drawing.Point(533, 23);
            this.cbAudioFinish.Name = "cbAudioFinish";
            this.cbAudioFinish.Size = new System.Drawing.Size(160, 24);
            this.cbAudioFinish.TabIndex = 64;
            this.cbAudioFinish.Text = "未完成";
            // 
            // lblTextFinish
            // 
            this.lblTextFinish.AutoSize = true;
            this.lblTextFinish.ForeColor = System.Drawing.Color.Black;
            this.lblTextFinish.Location = new System.Drawing.Point(697, 66);
            this.lblTextFinish.Name = "lblTextFinish";
            this.lblTextFinish.Size = new System.Drawing.Size(56, 16);
            this.lblTextFinish.TabIndex = 24;
            this.lblTextFinish.Text = "逐字稿";
            // 
            // tbDVD
            // 
            this.tbDVD.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbDVD.Location = new System.Drawing.Point(817, 20);
            this.tbDVD.Name = "tbDVD";
            this.tbDVD.Size = new System.Drawing.Size(160, 27);
            this.tbDVD.TabIndex = 23;
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Location = new System.Drawing.Point(697, 25);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(96, 16);
            this.lblDVD.TabIndex = 22;
            this.lblDVD.Text = "歸檔(DVD)櫃";
            // 
            // tbPath
            // 
            this.tbPath.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbPath.Location = new System.Drawing.Point(315, 101);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(569, 27);
            this.tbPath.TabIndex = 19;
            // 
            // lblAudioFinish
            // 
            this.lblAudioFinish.AutoSize = true;
            this.lblAudioFinish.Location = new System.Drawing.Point(478, 30);
            this.lblAudioFinish.Name = "lblAudioFinish";
            this.lblAudioFinish.Size = new System.Drawing.Size(40, 16);
            this.lblAudioFinish.TabIndex = 18;
            this.lblAudioFinish.Text = "音檔";
            // 
            // lblAudioLen
            // 
            this.lblAudioLen.AutoSize = true;
            this.lblAudioLen.Location = new System.Drawing.Point(478, 67);
            this.lblAudioLen.Name = "lblAudioLen";
            this.lblAudioLen.Size = new System.Drawing.Size(40, 16);
            this.lblAudioLen.TabIndex = 16;
            this.lblAudioLen.Text = "長度";
            // 
            // tbTeacher
            // 
            this.tbTeacher.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbTeacher.Location = new System.Drawing.Point(314, 63);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.Size = new System.Drawing.Size(160, 27);
            this.tbTeacher.TabIndex = 15;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.ForeColor = System.Drawing.Color.Black;
            this.lblTeacher.Location = new System.Drawing.Point(220, 68);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(56, 16);
            this.lblTeacher.TabIndex = 14;
            this.lblTeacher.Text = "主講者";
            // 
            // lblSubjectType
            // 
            this.lblSubjectType.AutoSize = true;
            this.lblSubjectType.ForeColor = System.Drawing.Color.Red;
            this.lblSubjectType.Location = new System.Drawing.Point(4, 68);
            this.lblSubjectType.Name = "lblSubjectType";
            this.lblSubjectType.Size = new System.Drawing.Size(40, 16);
            this.lblSubjectType.TabIndex = 12;
            this.lblSubjectType.Text = "類別";
            // 
            // tbSubject
            // 
            this.tbSubject.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSubject.Location = new System.Drawing.Point(56, 101);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(160, 27);
            this.tbSubject.TabIndex = 11;
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.ForeColor = System.Drawing.Color.Red;
            this.lblAddYear.Location = new System.Drawing.Point(4, 106);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(40, 16);
            this.lblAddYear.TabIndex = 10;
            this.lblAddYear.Text = "主題";
            // 
            // tbContent
            // 
            this.tbContent.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbContent.Location = new System.Drawing.Point(314, 24);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(160, 27);
            this.tbContent.TabIndex = 8;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(220, 30);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(72, 16);
            this.lblContent.TabIndex = 7;
            this.lblContent.Text = "課程內容";
            // 
            // BuddhaTeaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.dgvStudentData);
            this.Controls.Add(this.gbQueryCondition);
            this.Controls.Add(this.gbInputCondition);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuddhaTeaching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "法寶";
            this.Load += new System.EventHandler(this.BuddhaTeaching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).EndInit();
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.gbInputCondition.ResumeLayout(false);
            this.gbInputCondition.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHour)).EndInit();
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentData;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.TextBox tbSubjectCondt;
        private System.Windows.Forms.Label lblSubjectCondt;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox gbInputCondition;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lblAudioFinish;
        private System.Windows.Forms.Label lblAudioLen;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Label lblSubjectType;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Label lblTextFinish;
        private System.Windows.Forms.TextBox tbDVD;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox cbTextFinish;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.ComboBox cbAudioFinish;
        private System.Windows.Forms.Panel pnlFunc;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbTeacherCondt;
        private System.Windows.Forms.Label lblTeacherCondt;
        private System.Windows.Forms.ComboBox cbTypeCondt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSec;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.NumericUpDown numHour;
    }
}

