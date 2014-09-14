namespace YoungClass
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.dgvStudentData = new System.Windows.Forms.DataGridView();
            this.gbQueryCondition = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gbInputCondition = new System.Windows.Forms.GroupBox();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbSub = new System.Windows.Forms.GroupBox();
            this.tbSubMobile = new System.Windows.Forms.TextBox();
            this.lblSubMobile = new System.Windows.Forms.Label();
            this.tbSubBWClass = new System.Windows.Forms.TextBox();
            this.lblSubBWClass = new System.Windows.Forms.Label();
            this.tbSubRelation = new System.Windows.Forms.TextBox();
            this.lblSubRelation = new System.Windows.Forms.Label();
            this.tbSubContact = new System.Windows.Forms.TextBox();
            this.lblSubContact = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tbMainMobile = new System.Windows.Forms.TextBox();
            this.lblMainMobile = new System.Windows.Forms.Label();
            this.tbMainBWClass = new System.Windows.Forms.TextBox();
            this.lblMainBWClass = new System.Windows.Forms.Label();
            this.tbMainRelation = new System.Windows.Forms.TextBox();
            this.lblMainRelation = new System.Windows.Forms.Label();
            this.tbMainContact = new System.Windows.Forms.TextBox();
            this.lblMainContact = new System.Windows.Forms.Label();
            this.pnlPic = new System.Windows.Forms.Panel();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.tbClassRoom = new System.Windows.Forms.TextBox();
            this.lblClassRoom = new System.Windows.Forms.Label();
            this.tbGroupName = new System.Windows.Forms.TextBox();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.tbContactTime = new System.Windows.Forms.TextBox();
            this.lblContactTime = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.pnlFunc = new System.Windows.Forms.Panel();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbHomeTel = new System.Windows.Forms.TextBox();
            this.lblHomeTel = new System.Windows.Forms.Label();
            this.tbIdentityNo = new System.Windows.Forms.TextBox();
            this.lblIdentityNo = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.tbSchool = new System.Windows.Forms.TextBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.tbAddYear = new System.Windows.Forms.TextBox();
            this.lblAddYear = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).BeginInit();
            this.gbQueryCondition.SuspendLayout();
            this.gbInputCondition.SuspendLayout();
            this.gbSub.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.pnlPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            this.pnlFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentData
            // 
            this.dgvStudentData.AllowUserToAddRows = false;
            this.dgvStudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudentData.Location = new System.Drawing.Point(0, 414);
            this.dgvStudentData.MultiSelect = false;
            this.dgvStudentData.Name = "dgvStudentData";
            this.dgvStudentData.RowTemplate.Height = 27;
            this.dgvStudentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentData.Size = new System.Drawing.Size(982, 239);
            this.dgvStudentData.TabIndex = 3;
            // 
            // gbQueryCondition
            // 
            this.gbQueryCondition.Controls.Add(this.tbName);
            this.gbQueryCondition.Controls.Add(this.lblName);
            this.gbQueryCondition.Controls.Add(this.btnQuery);
            this.gbQueryCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQueryCondition.Location = new System.Drawing.Point(0, 357);
            this.gbQueryCondition.Name = "gbQueryCondition";
            this.gbQueryCondition.Size = new System.Drawing.Size(982, 57);
            this.gbQueryCondition.TabIndex = 4;
            this.gbQueryCondition.TabStop = false;
            this.gbQueryCondition.Text = "Query Condition";
            // 
            // tbName
            // 
            this.tbName.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbName.Location = new System.Drawing.Point(83, 21);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(114, 25);
            this.tbName.TabIndex = 5;
            this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "學生姓名";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(203, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 25);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gbInputCondition
            // 
            this.gbInputCondition.Controls.Add(this.tbFileSize);
            this.gbInputCondition.Controls.Add(this.tbID);
            this.gbInputCondition.Controls.Add(this.tbAddress);
            this.gbInputCondition.Controls.Add(this.lblAddress);
            this.gbInputCondition.Controls.Add(this.gbSub);
            this.gbInputCondition.Controls.Add(this.gbMain);
            this.gbInputCondition.Controls.Add(this.pnlPic);
            this.gbInputCondition.Controls.Add(this.tbMemo);
            this.gbInputCondition.Controls.Add(this.lblMemo);
            this.gbInputCondition.Controls.Add(this.tbClassRoom);
            this.gbInputCondition.Controls.Add(this.lblClassRoom);
            this.gbInputCondition.Controls.Add(this.tbGroupName);
            this.gbInputCondition.Controls.Add(this.lblGroupName);
            this.gbInputCondition.Controls.Add(this.tbContactTime);
            this.gbInputCondition.Controls.Add(this.lblContactTime);
            this.gbInputCondition.Controls.Add(this.tbMail);
            this.gbInputCondition.Controls.Add(this.lblEmail);
            this.gbInputCondition.Controls.Add(this.tbLocation);
            this.gbInputCondition.Controls.Add(this.lblLocation);
            this.gbInputCondition.Controls.Add(this.pnlFunc);
            this.gbInputCondition.Controls.Add(this.tbHomeTel);
            this.gbInputCondition.Controls.Add(this.lblHomeTel);
            this.gbInputCondition.Controls.Add(this.tbIdentityNo);
            this.gbInputCondition.Controls.Add(this.lblIdentityNo);
            this.gbInputCondition.Controls.Add(this.dtpBirthday);
            this.gbInputCondition.Controls.Add(this.lblBirthday);
            this.gbInputCondition.Controls.Add(this.tbGrade);
            this.gbInputCondition.Controls.Add(this.lblGrade);
            this.gbInputCondition.Controls.Add(this.tbSchool);
            this.gbInputCondition.Controls.Add(this.lblSchool);
            this.gbInputCondition.Controls.Add(this.tbGender);
            this.gbInputCondition.Controls.Add(this.lblGender);
            this.gbInputCondition.Controls.Add(this.tbClass);
            this.gbInputCondition.Controls.Add(this.lblClass);
            this.gbInputCondition.Controls.Add(this.tbAddYear);
            this.gbInputCondition.Controls.Add(this.lblAddYear);
            this.gbInputCondition.Controls.Add(this.tbStudentName);
            this.gbInputCondition.Controls.Add(this.label1);
            this.gbInputCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInputCondition.Location = new System.Drawing.Point(0, 0);
            this.gbInputCondition.Name = "gbInputCondition";
            this.gbInputCondition.Size = new System.Drawing.Size(982, 357);
            this.gbInputCondition.TabIndex = 6;
            this.gbInputCondition.TabStop = false;
            this.gbInputCondition.Text = "Input Condition";
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(749, 18);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(100, 25);
            this.tbFileSize.TabIndex = 64;
            this.tbFileSize.Visible = false;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(749, -9);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 25);
            this.tbID.TabIndex = 63;
            this.tbID.Visible = false;
            // 
            // tbAddress
            // 
            this.tbAddress.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbAddress.Location = new System.Drawing.Point(563, 21);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(138, 49);
            this.tbAddress.TabIndex = 62;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(476, 21);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 15);
            this.lblAddress.TabIndex = 61;
            this.lblAddress.Text = "住址";
            // 
            // gbSub
            // 
            this.gbSub.Controls.Add(this.tbSubMobile);
            this.gbSub.Controls.Add(this.lblSubMobile);
            this.gbSub.Controls.Add(this.tbSubBWClass);
            this.gbSub.Controls.Add(this.lblSubBWClass);
            this.gbSub.Controls.Add(this.tbSubRelation);
            this.gbSub.Controls.Add(this.lblSubRelation);
            this.gbSub.Controls.Add(this.tbSubContact);
            this.gbSub.Controls.Add(this.lblSubContact);
            this.gbSub.Location = new System.Drawing.Point(234, 158);
            this.gbSub.Name = "gbSub";
            this.gbSub.Size = new System.Drawing.Size(236, 140);
            this.gbSub.TabIndex = 60;
            this.gbSub.TabStop = false;
            this.gbSub.Text = "次要聯絡人";
            // 
            // tbSubMobile
            // 
            this.tbSubMobile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSubMobile.Location = new System.Drawing.Point(93, 108);
            this.tbSubMobile.Name = "tbSubMobile";
            this.tbSubMobile.Size = new System.Drawing.Size(138, 25);
            this.tbSubMobile.TabIndex = 49;
            // 
            // lblSubMobile
            // 
            this.lblSubMobile.AutoSize = true;
            this.lblSubMobile.Location = new System.Drawing.Point(6, 116);
            this.lblSubMobile.Name = "lblSubMobile";
            this.lblSubMobile.Size = new System.Drawing.Size(39, 15);
            this.lblSubMobile.TabIndex = 48;
            this.lblSubMobile.Text = "手機";
            // 
            // tbSubBWClass
            // 
            this.tbSubBWClass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSubBWClass.Location = new System.Drawing.Point(93, 77);
            this.tbSubBWClass.Name = "tbSubBWClass";
            this.tbSubBWClass.Size = new System.Drawing.Size(138, 25);
            this.tbSubBWClass.TabIndex = 47;
            // 
            // lblSubBWClass
            // 
            this.lblSubBWClass.AutoSize = true;
            this.lblSubBWClass.Location = new System.Drawing.Point(6, 85);
            this.lblSubBWClass.Name = "lblSubBWClass";
            this.lblSubBWClass.Size = new System.Drawing.Size(71, 15);
            this.lblSubBWClass.TabIndex = 46;
            this.lblSubBWClass.Text = "研討班別";
            // 
            // tbSubRelation
            // 
            this.tbSubRelation.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSubRelation.Location = new System.Drawing.Point(93, 46);
            this.tbSubRelation.Name = "tbSubRelation";
            this.tbSubRelation.Size = new System.Drawing.Size(138, 25);
            this.tbSubRelation.TabIndex = 45;
            // 
            // lblSubRelation
            // 
            this.lblSubRelation.AutoSize = true;
            this.lblSubRelation.Location = new System.Drawing.Point(6, 54);
            this.lblSubRelation.Name = "lblSubRelation";
            this.lblSubRelation.Size = new System.Drawing.Size(39, 15);
            this.lblSubRelation.TabIndex = 44;
            this.lblSubRelation.Text = "關係";
            // 
            // tbSubContact
            // 
            this.tbSubContact.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSubContact.Location = new System.Drawing.Point(93, 15);
            this.tbSubContact.Name = "tbSubContact";
            this.tbSubContact.Size = new System.Drawing.Size(138, 25);
            this.tbSubContact.TabIndex = 43;
            // 
            // lblSubContact
            // 
            this.lblSubContact.AutoSize = true;
            this.lblSubContact.Location = new System.Drawing.Point(6, 23);
            this.lblSubContact.Name = "lblSubContact";
            this.lblSubContact.Size = new System.Drawing.Size(55, 15);
            this.lblSubContact.TabIndex = 42;
            this.lblSubContact.Text = "聯絡人";
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.tbMainMobile);
            this.gbMain.Controls.Add(this.lblMainMobile);
            this.gbMain.Controls.Add(this.tbMainBWClass);
            this.gbMain.Controls.Add(this.lblMainBWClass);
            this.gbMain.Controls.Add(this.tbMainRelation);
            this.gbMain.Controls.Add(this.lblMainRelation);
            this.gbMain.Controls.Add(this.tbMainContact);
            this.gbMain.Controls.Add(this.lblMainContact);
            this.gbMain.Location = new System.Drawing.Point(234, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(236, 140);
            this.gbMain.TabIndex = 59;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "主要聯絡人";
            // 
            // tbMainMobile
            // 
            this.tbMainMobile.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMainMobile.Location = new System.Drawing.Point(89, 109);
            this.tbMainMobile.Name = "tbMainMobile";
            this.tbMainMobile.Size = new System.Drawing.Size(138, 25);
            this.tbMainMobile.TabIndex = 41;
            // 
            // lblMainMobile
            // 
            this.lblMainMobile.AutoSize = true;
            this.lblMainMobile.ForeColor = System.Drawing.Color.Red;
            this.lblMainMobile.Location = new System.Drawing.Point(2, 117);
            this.lblMainMobile.Name = "lblMainMobile";
            this.lblMainMobile.Size = new System.Drawing.Size(39, 15);
            this.lblMainMobile.TabIndex = 40;
            this.lblMainMobile.Text = "手機";
            // 
            // tbMainBWClass
            // 
            this.tbMainBWClass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMainBWClass.Location = new System.Drawing.Point(89, 78);
            this.tbMainBWClass.Name = "tbMainBWClass";
            this.tbMainBWClass.Size = new System.Drawing.Size(138, 25);
            this.tbMainBWClass.TabIndex = 39;
            // 
            // lblMainBWClass
            // 
            this.lblMainBWClass.AutoSize = true;
            this.lblMainBWClass.Location = new System.Drawing.Point(2, 86);
            this.lblMainBWClass.Name = "lblMainBWClass";
            this.lblMainBWClass.Size = new System.Drawing.Size(71, 15);
            this.lblMainBWClass.TabIndex = 38;
            this.lblMainBWClass.Text = "研討班別";
            // 
            // tbMainRelation
            // 
            this.tbMainRelation.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMainRelation.Location = new System.Drawing.Point(89, 46);
            this.tbMainRelation.Name = "tbMainRelation";
            this.tbMainRelation.Size = new System.Drawing.Size(138, 25);
            this.tbMainRelation.TabIndex = 37;
            // 
            // lblMainRelation
            // 
            this.lblMainRelation.AutoSize = true;
            this.lblMainRelation.ForeColor = System.Drawing.Color.Red;
            this.lblMainRelation.Location = new System.Drawing.Point(2, 54);
            this.lblMainRelation.Name = "lblMainRelation";
            this.lblMainRelation.Size = new System.Drawing.Size(39, 15);
            this.lblMainRelation.TabIndex = 36;
            this.lblMainRelation.Text = "關係";
            // 
            // tbMainContact
            // 
            this.tbMainContact.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMainContact.Location = new System.Drawing.Point(89, 15);
            this.tbMainContact.Name = "tbMainContact";
            this.tbMainContact.Size = new System.Drawing.Size(138, 25);
            this.tbMainContact.TabIndex = 35;
            // 
            // lblMainContact
            // 
            this.lblMainContact.AutoSize = true;
            this.lblMainContact.ForeColor = System.Drawing.Color.Red;
            this.lblMainContact.Location = new System.Drawing.Point(2, 23);
            this.lblMainContact.Name = "lblMainContact";
            this.lblMainContact.Size = new System.Drawing.Size(55, 15);
            this.lblMainContact.TabIndex = 34;
            this.lblMainContact.Text = "聯絡人";
            // 
            // pnlPic
            // 
            this.pnlPic.Controls.Add(this.tbFile);
            this.pnlPic.Controls.Add(this.btnImport);
            this.pnlPic.Controls.Add(this.pbStudent);
            this.pnlPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPic.Location = new System.Drawing.Point(830, 21);
            this.pnlPic.Name = "pnlPic";
            this.pnlPic.Size = new System.Drawing.Size(149, 283);
            this.pnlPic.TabIndex = 58;
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(111, 253);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(100, 25);
            this.tbFile.TabIndex = 60;
            this.tbFile.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnImport.Location = new System.Drawing.Point(5, 252);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 30);
            this.btnImport.TabIndex = 59;
            this.btnImport.Text = "匯入照片";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pbStudent
            // 
            this.pbStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStudent.Location = new System.Drawing.Point(5, 1);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(136, 240);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 58;
            this.pbStudent.TabStop = false;
            // 
            // tbMemo
            // 
            this.tbMemo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMemo.Location = new System.Drawing.Point(563, 235);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(138, 64);
            this.tbMemo.TabIndex = 54;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(476, 235);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(39, 15);
            this.lblMemo.TabIndex = 53;
            this.lblMemo.Text = "備註";
            // 
            // tbClassRoom
            // 
            this.tbClassRoom.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbClassRoom.Location = new System.Drawing.Point(563, 202);
            this.tbClassRoom.Name = "tbClassRoom";
            this.tbClassRoom.Size = new System.Drawing.Size(138, 25);
            this.tbClassRoom.TabIndex = 52;
            // 
            // lblClassRoom
            // 
            this.lblClassRoom.AutoSize = true;
            this.lblClassRoom.Location = new System.Drawing.Point(476, 210);
            this.lblClassRoom.Name = "lblClassRoom";
            this.lblClassRoom.Size = new System.Drawing.Size(39, 15);
            this.lblClassRoom.TabIndex = 51;
            this.lblClassRoom.Text = "教室";
            // 
            // tbGroupName
            // 
            this.tbGroupName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGroupName.Location = new System.Drawing.Point(563, 169);
            this.tbGroupName.Name = "tbGroupName";
            this.tbGroupName.Size = new System.Drawing.Size(138, 25);
            this.tbGroupName.TabIndex = 50;
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(476, 177);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(39, 15);
            this.lblGroupName.TabIndex = 49;
            this.lblGroupName.Text = "組別";
            // 
            // tbContactTime
            // 
            this.tbContactTime.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbContactTime.Location = new System.Drawing.Point(563, 138);
            this.tbContactTime.Name = "tbContactTime";
            this.tbContactTime.Size = new System.Drawing.Size(138, 25);
            this.tbContactTime.TabIndex = 48;
            // 
            // lblContactTime
            // 
            this.lblContactTime.AutoSize = true;
            this.lblContactTime.Location = new System.Drawing.Point(476, 146);
            this.lblContactTime.Name = "lblContactTime";
            this.lblContactTime.Size = new System.Drawing.Size(87, 15);
            this.lblContactTime.TabIndex = 47;
            this.lblContactTime.Text = "可連絡時間";
            // 
            // tbMail
            // 
            this.tbMail.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbMail.Location = new System.Drawing.Point(563, 107);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(138, 25);
            this.tbMail.TabIndex = 46;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(476, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "email";
            // 
            // tbLocation
            // 
            this.tbLocation.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbLocation.Location = new System.Drawing.Point(563, 76);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(138, 25);
            this.tbLocation.TabIndex = 44;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(476, 84);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(71, 15);
            this.lblLocation.TabIndex = 43;
            this.lblLocation.Text = "住家區域";
            // 
            // pnlFunc
            // 
            this.pnlFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFunc.Controls.Add(this.btnGet);
            this.pnlFunc.Controls.Add(this.btnUpdate);
            this.pnlFunc.Controls.Add(this.btnInsert);
            this.pnlFunc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFunc.Location = new System.Drawing.Point(3, 304);
            this.pnlFunc.Name = "pnlFunc";
            this.pnlFunc.Size = new System.Drawing.Size(976, 50);
            this.pnlFunc.TabIndex = 42;
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
            // tbHomeTel
            // 
            this.tbHomeTel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbHomeTel.Location = new System.Drawing.Point(83, 274);
            this.tbHomeTel.Name = "tbHomeTel";
            this.tbHomeTel.Size = new System.Drawing.Size(138, 25);
            this.tbHomeTel.TabIndex = 25;
            // 
            // lblHomeTel
            // 
            this.lblHomeTel.AutoSize = true;
            this.lblHomeTel.ForeColor = System.Drawing.Color.Red;
            this.lblHomeTel.Location = new System.Drawing.Point(9, 282);
            this.lblHomeTel.Name = "lblHomeTel";
            this.lblHomeTel.Size = new System.Drawing.Size(71, 15);
            this.lblHomeTel.TabIndex = 24;
            this.lblHomeTel.Text = "住家電話";
            // 
            // tbIdentityNo
            // 
            this.tbIdentityNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbIdentityNo.Location = new System.Drawing.Point(83, 243);
            this.tbIdentityNo.Name = "tbIdentityNo";
            this.tbIdentityNo.Size = new System.Drawing.Size(138, 25);
            this.tbIdentityNo.TabIndex = 23;
            // 
            // lblIdentityNo
            // 
            this.lblIdentityNo.AutoSize = true;
            this.lblIdentityNo.Location = new System.Drawing.Point(9, 251);
            this.lblIdentityNo.Name = "lblIdentityNo";
            this.lblIdentityNo.Size = new System.Drawing.Size(55, 15);
            this.lblIdentityNo.TabIndex = 22;
            this.lblIdentityNo.Text = "身分證";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "yyyy/MM/dd";
            this.dtpBirthday.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpBirthday.Location = new System.Drawing.Point(83, 212);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(138, 25);
            this.dtpBirthday.TabIndex = 21;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(10, 219);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(39, 15);
            this.lblBirthday.TabIndex = 20;
            this.lblBirthday.Text = "生日";
            // 
            // tbGrade
            // 
            this.tbGrade.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGrade.Location = new System.Drawing.Point(83, 180);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(138, 25);
            this.tbGrade.TabIndex = 19;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(10, 188);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(71, 15);
            this.lblGrade.TabIndex = 18;
            this.lblGrade.Text = "學校年級";
            // 
            // tbSchool
            // 
            this.tbSchool.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbSchool.Location = new System.Drawing.Point(83, 149);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(138, 25);
            this.tbSchool.TabIndex = 17;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(10, 157);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(71, 15);
            this.lblSchool.TabIndex = 16;
            this.lblSchool.Text = "就讀學校";
            // 
            // tbGender
            // 
            this.tbGender.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbGender.Location = new System.Drawing.Point(83, 118);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(138, 25);
            this.tbGender.TabIndex = 15;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.Color.Red;
            this.lblGender.Location = new System.Drawing.Point(10, 126);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(39, 15);
            this.lblGender.TabIndex = 14;
            this.lblGender.Text = "性別";
            // 
            // tbClass
            // 
            this.tbClass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbClass.Location = new System.Drawing.Point(83, 87);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(138, 25);
            this.tbClass.TabIndex = 13;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(10, 95);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(39, 15);
            this.lblClass.TabIndex = 12;
            this.lblClass.Text = "班別";
            // 
            // tbAddYear
            // 
            this.tbAddYear.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbAddYear.Location = new System.Drawing.Point(83, 24);
            this.tbAddYear.Name = "tbAddYear";
            this.tbAddYear.Size = new System.Drawing.Size(138, 25);
            this.tbAddYear.TabIndex = 11;
            // 
            // lblAddYear
            // 
            this.lblAddYear.AutoSize = true;
            this.lblAddYear.ForeColor = System.Drawing.Color.Red;
            this.lblAddYear.Location = new System.Drawing.Point(10, 32);
            this.lblAddYear.Name = "lblAddYear";
            this.lblAddYear.Size = new System.Drawing.Size(71, 15);
            this.lblAddYear.TabIndex = 10;
            this.lblAddYear.Text = "加入年度";
            // 
            // tbStudentName
            // 
            this.tbStudentName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbStudentName.Location = new System.Drawing.Point(83, 56);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(138, 25);
            this.tbStudentName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "學生姓名";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.dgvStudentData);
            this.Controls.Add(this.gbQueryCondition);
            this.Controls.Add(this.gbInputCondition);
            this.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentData)).EndInit();
            this.gbQueryCondition.ResumeLayout(false);
            this.gbQueryCondition.PerformLayout();
            this.gbInputCondition.ResumeLayout(false);
            this.gbInputCondition.PerformLayout();
            this.gbSub.ResumeLayout(false);
            this.gbSub.PerformLayout();
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.pnlPic.ResumeLayout(false);
            this.pnlPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            this.pnlFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudentData;
        private System.Windows.Forms.GroupBox gbQueryCondition;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.GroupBox gbInputCondition;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox tbSchool;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox tbAddYear;
        private System.Windows.Forms.Label lblAddYear;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHomeTel;
        private System.Windows.Forms.Label lblHomeTel;
        private System.Windows.Forms.TextBox tbIdentityNo;
        private System.Windows.Forms.Label lblIdentityNo;
        private System.Windows.Forms.Panel pnlFunc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox tbClassRoom;
        private System.Windows.Forms.Label lblClassRoom;
        private System.Windows.Forms.TextBox tbGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox tbContactTime;
        private System.Windows.Forms.Label lblContactTime;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlPic;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox gbSub;
        private System.Windows.Forms.TextBox tbSubMobile;
        private System.Windows.Forms.Label lblSubMobile;
        private System.Windows.Forms.TextBox tbSubBWClass;
        private System.Windows.Forms.Label lblSubBWClass;
        private System.Windows.Forms.TextBox tbSubRelation;
        private System.Windows.Forms.Label lblSubRelation;
        private System.Windows.Forms.TextBox tbSubContact;
        private System.Windows.Forms.Label lblSubContact;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.TextBox tbMainMobile;
        private System.Windows.Forms.Label lblMainMobile;
        private System.Windows.Forms.TextBox tbMainBWClass;
        private System.Windows.Forms.Label lblMainBWClass;
        private System.Windows.Forms.TextBox tbMainRelation;
        private System.Windows.Forms.Label lblMainRelation;
        private System.Windows.Forms.TextBox tbMainContact;
        private System.Windows.Forms.Label lblMainContact;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbFileSize;
    }
}

