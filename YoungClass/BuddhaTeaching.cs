using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoungClass
{
    //20140910,PJ,要解掉audio length textbox轉換實際秒數的問題
    public partial class BuddhaTeaching : Form
    {
        //連接字串
        String conString = "SERVER = localhost; DATABASE = youngclass; User ID = young; PASSWORD = young2014;";
        private int pathIndex = 0;

        public BuddhaTeaching()
        {
            InitializeComponent();
        }

        private void AddLinkColumn(string columnName)
        {
            //DataGridViewLinkColumn links = new DataGridViewLinkColumn();

            //links.UseColumnTextForLinkValue = true;
            //links.HeaderText = columnName;
            //links.DataPropertyName = columnName;
            //links.ActiveLinkColor = Color.White;
            //links.LinkBehavior = LinkBehavior.SystemDefault;
            //links.LinkColor = Color.Blue;
            //links.TrackVisitedState = true;
            //links.VisitedLinkColor = Color.YellowGreen;

            //this.dgvStudentData.Columns[0].DefaultCellStyle = links;
            //this.dgvStudentData.Columns.Add(links);
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try{
                //取得MySQLConnection
                MySqlConnection connection = new MySqlConnection(conString);

                connection.Open();
                string sSubjectType = "";

                if(this.cbTypeCondt.Text == "ALL")
                {
                    sSubjectType = "";
                }
                else
                {
                    sSubjectType = this.cbTypeCondt.Text;
                }
                StringBuilder sSql = new StringBuilder(@"select  no as 編號, subject_type as 類別, subject as 主題, content as 課程內容, 
                                   teacher as 主講者, SEC_TO_TIME(audio_len) as 音檔長度,
                                   audio_finish as 音檔, dvd as 歸檔DVD櫃,text_finish as 逐字稿,
                                   file_path as 電子影音檔 from youngclass.BuddhaTeaching where 1=1 and delete_flag = 'N'");
                if(sSubjectType.Length !=0)
                {
                    sSql.Append(" and subject_type ='" + sSubjectType + "'");
                }
                if(this.tbSubjectCondt.Text.Trim().Length != 0)
                {
                    sSql.Append(" and subject like '%" + this.tbSubjectCondt.Text.Replace("*", "%") + "%'");
                }
                if (this.tbTeacherCondt.Text.Trim().Length != 0)
                {
                    sSql.Append(" and teacher like '%" + this.tbTeacherCondt.Text.Replace("*", "%") + "%'");
                }
                MySqlCommand cmd = new MySqlCommand(sSql.ToString(), connection);
                
                //Data ResultSet
                using (MySqlDataReader data_reader = cmd.ExecuteReader())
                {
                    DataTable dtCustomers = new DataTable();
                    dtCustomers.Load(data_reader);
                    dgvStudentData.DataSource = dtCustomers;
                    //if (data_reader.HasRows)
                    //{
                    //    while (data_reader.Read())
                    //    {
                    //        //連線成功的話會輸出totrec的值1
                    //       // MessageBox.Show(data_reader.GetString("totrec"));
                    //    }
                    //}
                    pathIndex = dtCustomers.Columns.IndexOf("電子影音檔");
                }
                
                //AddLinkColumn("電子影音檔路徑");
                foreach (DataGridViewRow dr in this.dgvStudentData.Rows)
                {
                    DataGridViewLinkCell lc = new DataGridViewLinkCell();
                    lc.Value = dr.Cells[pathIndex].Value;
                    dgvStudentData[pathIndex, dr.Index] = lc;
                }
            }
            catch (Exception ex)
            {
                //失敗會有錯誤訊息
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex);
            }
            //this.dgvStudentData.Columns[26].Width = 500;
            //this.dgvStudentData.Rows[1].Height = 500;
        }

        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd;

            try
            {
                    con.Open();

                    MySqlCommand command = new MySqlCommand("select max(no) from youngclass.BuddhaTeaching", con);
                    string no = command.ExecuteScalar().ToString();                   
                    string CmdString = @"INSERT INTO youngclass.BuddhaTeaching
(
   no,
  subject,
  content,
  subject_type,
  teacher,  
  audio_len, 
  audio_finish,
  dvd,
  text_finish,
  file_path
)VALUES
(
  @no,
  @subject,
  @content,
  @subject_type,  
  @teacher, 
  @audio_len,
  @audio_finish,
  @dvd,
  @text_finish,  
  @file_path
)";
                    cmd = new MySqlCommand(CmdString, con);
                    
                    cmd.Parameters.Add("@no", MySqlDbType.UInt32);
                    cmd.Parameters.Add("@subject", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@content", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@subject_type", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@teacher", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@audio_len", MySqlDbType.UInt16);
                    cmd.Parameters.Add("@audio_finish", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@dvd", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@text_finish", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@file_path", MySqlDbType.VarChar);

                    cmd.Parameters["@no"].Value = Convert.ToUInt32(no) + 1;//取得最大的一個id + 1
                    cmd.Parameters["@subject"].Value = this.tbSubject.Text;
                    cmd.Parameters["@content"].Value = this.tbContent.Text;
                    cmd.Parameters["@subject_type"].Value = this.cbType.Text;
                    cmd.Parameters["@teacher"].Value = this.tbTeacher.Text;
                    //cmd.Parameters["@audio_len"].Value = TimeSpan.Parse(this.tbAudioLen.Text).TotalSeconds;
                    cmd.Parameters["@audio_len"].Value = 
                        TimeSpan.Parse(string.Format("{0}{1}{2}{3}{4}",
                        this.numHour.Value,this.label2.Text,this.numMin.Value,this.label3.Text,this.numSec.Value)).TotalSeconds;
                    if (this.cbAudioFinish.Text == "完成")
                    {
                        cmd.Parameters["@audio_finish"].Value = "Y";
                    }
                    else
                    {
                        cmd.Parameters["@audio_finish"].Value = "N";
                    }
                    cmd.Parameters["@dvd"].Value = this.tbDVD.Text;
                    if (this.cbTextFinish.Text == "完成")
                    {
                        cmd.Parameters["@text_finish"].Value = "Y";
                    }
                    else
                    {
                        cmd.Parameters["@text_finish"].Value = "N";
                    }
                    cmd.Parameters["@file_path"].Value = this.tbPath.Text;
                    
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Create sucessfully!");
                    }
                    con.Close();
                    btnQuery_Click(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {           
            try
            {
                if(((DataTable)this.dgvStudentData.DataSource).Rows.Count < 1)
                {
                    MessageBox.Show("沒有資料,請按查詢列出資料", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                string no = dgvStudentData.Rows[dgvStudentData.CurrentCell.RowIndex].Cells[0].Value.ToString();
                tbNo.Text = no;
                //取得MySQLConnection
                MySqlConnection connection = new MySqlConnection(conString);

                connection.Open();
                String command = @"select * from youngclass.BuddhaTeaching where no ='" + no + "'";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbSubject.Text = dataReader["subject"].ToString();
                    tbContent.Text = dataReader["content"].ToString();
                    cbType.Text = dataReader["subject_type"].ToString();
                    tbTeacher.Text = dataReader["teacher"].ToString();
                    //tbAudioLen.Text = dataReader["audio_len"].ToString();
                    string audioLen = dataReader["audio_len"].ToString();

                    if (audioLen.Length != 0)
                    {
                        int sec = Convert.ToInt32(audioLen);
                        int ss = sec % 60;
                        int mm = (sec / 60) % 60;
                        int hh = sec / 3600;
                        this.numHour.Value = hh;
                        this.numMin.Value = mm;
                        this.numSec.Value = ss;
                        //TimeSpan interval = new TimeSpan(hh, mm, ss);
                        //tbAudioLen.Text = interval.ToString();
                    }
                    else
                    {
                        //tbAudioLen.Text = "";
                        this.numHour.Value = 0;
                        this.numMin.Value = 0;
                        this.numSec.Value = 0;
                    }
                    string sAudioFinish = dataReader["audio_finish"].ToString();
                    if(sAudioFinish == "Y")
                    {
                        this.cbAudioFinish.Text = "完成";
                    }
                    else
                    {
                        this.cbAudioFinish.Text = "未完成";
                    }
                    tbDVD.Text = dataReader["dvd"].ToString();
                    string sTextFinish = dataReader["text_finish"].ToString();
                    if (sTextFinish == "Y")
                    {
                        this.cbTextFinish.Text = "完成";
                    }
                    else
                    {
                        this.cbTextFinish.Text = "未完成";
                    }
                    tbPath.Text = dataReader["file_path"].ToString();                  
                }
                //close Data Reader
                dataReader.Close();
            }
            catch (Exception ex)
            {
                //失敗會有錯誤訊息
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd;

            try
            {
                    con.Open();
                    string CmdString = @"UPDATE youngclass.BuddhaTeaching
                                         SET no = @no,subject = @subject,
                                         content = @content, subject_type = @subject_type, teacher = @teacher,
                                         audio_len = @audio_len, audio_finish = @audio_finish, dvd = @dvd,
                                         text_finish = @text_finish, file_path = @file_path WHERE no =@no;";
                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.AddWithValue("@no", Convert.ToUInt32(this.tbNo.Text));
                    cmd.Parameters.AddWithValue("@subject", tbSubject.Text);
                    cmd.Parameters.AddWithValue("@content", tbContent.Text);
                    cmd.Parameters.AddWithValue("@subject_type", cbType.Text);
                    cmd.Parameters.AddWithValue("@teacher", tbTeacher.Text);
                    //cmd.Parameters.AddWithValue("@audio_len", TimeSpan.Parse(this.tbAudioLen.Text).TotalSeconds);
                   cmd.Parameters.AddWithValue("@audio_len",
                           TimeSpan.Parse(string.Format("{0}{1}{2}{3}{4}",
                           this.numHour.Value, this.label2.Text, this.numMin.Value, this.label3.Text, this.numSec.Value)).TotalSeconds);    
                    if (this.cbAudioFinish.Text == "完成")
                    {
                        cmd.Parameters.AddWithValue("@audio_finish", "Y");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@audio_finish", "N");
                    }
                    cmd.Parameters.AddWithValue("@dvd", this.tbDVD.Text);
                    if (this.cbTextFinish.Text == "完成")
                    {
                        cmd.Parameters.AddWithValue("@text_finish", "Y");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@text_finish", "N");
                    }
                    cmd.Parameters.AddWithValue("@file_path", tbPath.Text);               


                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Updated sucessfully!");
                    }
                    con.Close();
                    btnQuery_Click(this, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuery_Click(sender, e);
            }
        }

        private void BuddhaTeaching_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (((DataTable)this.dgvStudentData.DataSource).Rows.Count < 1)
            {
                MessageBox.Show("沒有資料,請按查詢列出資料", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            DialogResult dr = new DialogResult();

            dr = MessageBox.Show("確定要刪除了嗎?", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {                
                string no = dgvStudentData.Rows[dgvStudentData.CurrentCell.RowIndex].Cells[0].Value.ToString();

                MySqlConnection con = new MySqlConnection(conString);
                MySqlCommand cmd;

                try
                {
                    con.Open();
                    string CmdString = @"UPDATE youngclass.BuddhaTeaching
                                         SET delete_flag = @delete_flag WHERE no =@no;";
                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.AddWithValue("@no", Convert.ToUInt32(no));
                    cmd.Parameters.AddWithValue("@delete_flag", "Y");
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Delete sucessfully!");
                    }
                    con.Close();
                    btnQuery_Click(this, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private void dgvStudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (this.dgvStudentData.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
            {
                //string link = "http://www...";
                if (e.ColumnIndex == pathIndex)
                {
                    System.Diagnostics.Process.Start(this.dgvStudentData.Rows[e.RowIndex].Cells[pathIndex].Value as string);
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            //移動上層在指定下層路徑
            dlg.RestoreDirectory = true;
            //dlg.InitialDirectory = "";
            dlg.Title = "Open media File";
            // Set filter for file extension and default file extension
            dlg.Filter = "mp3 media|*.mp3|waw media|*.wav|mp4 media|*.mp4|avi media|*.avi|mov media|*.mov";
            // Display OpenFileDialog by calling ShowDialog method ->ShowDialog()
            // Get the selected file name and display in a TextBox
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK && dlg.FileName != null)
            {
                // Open document
                this.tbPath.Text = dlg.FileName;
            }
        }
    }
}
