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
    public partial class StudentForm : Form
    {
        //連接字串
        String conString = "SERVER = localhost; DATABASE = world; User ID = young; PASSWORD = young2014;";

        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try{
                //取得MySQLConnection
                MySqlConnection connection = new MySqlConnection(conString);

                connection.Open();
                String command = "select * from youngclass.student where name like '%" + tbName.Text + "%'";
                MySqlCommand cmd = new MySqlCommand(command, connection);
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

        byte[] _imageData;

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image files | *.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbStudent.Image = Image.FromFile(ofd.FileName);
                    tbFile.Text = ofd.SafeFileName;
                    FileStream fs;
                    BinaryReader br;
                   
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    int fileLen = (int)fs.Length;
                    tbFileSize.Text = fileLen.ToString();
                    _imageData = br.ReadBytes(fileLen);
                    br.Close();
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conString);
            MySqlCommand cmd;

            try
            {
                if (tbFile.Text.Length > 0)
                {
                    con.Open();

                    MySqlCommand command = new MySqlCommand("select max(id) from youngclass.student", con);
                    string id = command.ExecuteScalar().ToString();                   
                    string CmdString = @"INSERT INTO youngclass.student
(
  id,
  addyear,
  name,
  class,  
  gender, 
  school,
  grade,
  birthday,
  identity_no,  
  home_tel,
  main_contact,
  main_relation,
  bw_class,
  main_mobile,
  sub_contact,
  sub_relation,
  sub_bw_class,
  sub_mobile,
  address,
  location,
  email,
  contact_time,
  group_name,
  class_room,
  pic,  
  memo 
)VALUES
(
  @id,
  @addyear,
  @name,
  @class,  
  @gender, 
  @school,
  @grade,
  @birthday,
  @identity_no,  
  @home_tel,
  @main_contact,
  @main_relation,
  @bw_class,
  @main_mobile,
  @sub_contact,
  @sub_relation,
  @sub_bw_class,
  @sub_mobile,
  @address,
  @location,
  @email,
  @contact_time,
  @group_name,
  @class_room,
  @pic,  
  @memo
)";
                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.Add("@id", MySqlDbType.Int32);
                    cmd.Parameters.Add("@addyear", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@name", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@class", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@gender", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@school", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@grade", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@birthday", MySqlDbType.DateTime);
                    cmd.Parameters.Add("@identity_no", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@home_tel", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@main_contact", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@main_relation", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@bw_class", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@main_mobile", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@sub_contact", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@sub_relation", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@sub_bw_class", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@sub_mobile", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@address", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@location", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@contact_time", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@group_name", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@class_room", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@pic_name", MySqlDbType.VarChar);
                    cmd.Parameters.Add("@pic_size", MySqlDbType.Int32);
                    cmd.Parameters.Add("@pic", MySqlDbType.Blob);
                    cmd.Parameters.Add("@memo", MySqlDbType.VarChar);
       
                    cmd.Parameters["@id"].Value= Convert.ToUInt32(id) + 1;//取得最大的一個id + 1
                    cmd.Parameters["@addyear"].Value= tbAddYear.Text;
                    cmd.Parameters["@name"].Value=tbStudentName.Text;
                    cmd.Parameters["@class"].Value=tbClass.Text;
                    cmd.Parameters["@gender"].Value=tbGender.Text;
                    cmd.Parameters["@school"].Value=tbSchool.Text;
                    cmd.Parameters["@grade"].Value=tbGrade.Text;
                    cmd.Parameters["@birthday"].Value=dtpBirthday.Value;
                    cmd.Parameters["@identity_no"].Value=tbIdentityNo.Text;
                    cmd.Parameters["@home_tel"].Value=tbHomeTel.Text;
                    cmd.Parameters["@main_contact"].Value=tbMainContact.Text;
                    cmd.Parameters["@main_relation"].Value=tbMainRelation.Text;
                    cmd.Parameters["@bw_class"].Value=tbMainBWClass.Text;
                    cmd.Parameters["@main_mobile"].Value=tbMainMobile.Text;
                    cmd.Parameters["@sub_contact"].Value=tbSubContact.Text;
                    cmd.Parameters["@sub_relation"].Value=tbSubRelation.Text;
                    cmd.Parameters["@sub_bw_class"].Value=tbSubBWClass.Text;
                    cmd.Parameters["@sub_mobile"].Value=tbSubMobile.Text;
                    cmd.Parameters["@address"].Value=tbAddress.Text;
                    cmd.Parameters["@location"].Value=tbLocation.Text;
                    cmd.Parameters["@email"].Value=tbMail.Text;
                    cmd.Parameters["@contact_time"].Value=tbContactTime.Text;
                    cmd.Parameters["@group_name"].Value=tbGroupName.Text;
                    cmd.Parameters["@class_room"].Value=tbClassRoom.Text;
                    cmd.Parameters["@pic_name"].Value = tbFile.Text;
                    cmd.Parameters["@pic_size"].Value = Convert.ToInt32(tbFileSize.Text);
                    cmd.Parameters["@pic"].Value=_imageData;
                    cmd.Parameters["@memo"].Value=tbMemo.Text;

                    
                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Image saved sucessfully!");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                string id = dgvStudentData.SelectedRows[0].Cells[0].Value.ToString();
                tbID.Text = id;
                //取得MySQLConnection
                MySqlConnection connection = new MySqlConnection(conString);

                connection.Open();
                String command = "select * from youngclass.student where id ='" + id + "'";
                MySqlCommand cmd = new MySqlCommand(command, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    tbAddYear.Text = dataReader["id"].ToString().Substring(0,4);
                    tbStudentName.Text = dataReader["name"].ToString();
                    tbClass.Text = dataReader["class"].ToString();
                    tbGender.Text = dataReader["gender"].ToString();
                    tbSchool.Text = dataReader["school"].ToString();
                    tbGrade.Text = dataReader["grade"].ToString();
                    dtpBirthday.Value = (DateTime)dataReader["birthday"];
                    tbIdentityNo.Text = dataReader["identity_no"].ToString();
                    tbHomeTel.Text = dataReader["home_tel"].ToString();
                    tbMainContact.Text = dataReader["main_contact"].ToString();
                    tbMainRelation.Text = dataReader["main_relation"].ToString();
                    tbMainBWClass.Text = dataReader["bw_class"].ToString();
                    tbMainMobile.Text = dataReader["main_mobile"].ToString();
                    tbSubContact.Text = dataReader["sub_contact"].ToString();
                    tbSubRelation.Text = dataReader["sub_relation"].ToString();
                    lblSubBWClass.Text = dataReader["sub_bw_class"].ToString();
                    tbSubMobile.Text = dataReader["sub_mobile"].ToString();
                    tbAddress.Text = dataReader["address"].ToString();
                    tbLocation.Text = dataReader["location"].ToString();
                    tbMail.Text = dataReader["email"].ToString();
                    tbContactTime.Text = dataReader["contact_time"].ToString();
                    tbGroupName.Text = dataReader["group_name"].ToString();
                    tbClassRoom.Text = dataReader["class_room"].ToString();
                    tbFile.Text = dataReader["pic_name"].ToString();
                    tbFileSize.Text = dataReader["pic_size"].ToString();
                    int FileSize = Convert.ToInt32(tbFileSize.Text);

                    if (FileSize > 0)
                    {
                        byte[] rawData = new byte[FileSize];

                        dataReader.GetBytes(dataReader.GetOrdinal("pic"), 0, rawData, 0, FileSize);
                        MemoryStream ms = new MemoryStream(rawData);
                        this.pbStudent.Image = Image.FromStream(ms);
                    }

                    tbMemo.Text = dataReader["memo"].ToString();                    
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
            FileStream fs;
            BinaryReader br;

            try
            {
                if (tbFile.Text.Length > 0)
                {
                    con.Open();
                    string id = tbID.Text;
                    string CmdString = @"UPDATE youngclass.student
                                         SET addyear = @addyear,name = @name,
                                         class = @class, gender = @gender, school = @school,
                                         grade = @grade, birthday = @birthday, identity_no = @identity_no,
                                         home_tel = @home_tel, main_contact = @main_contact, main_relation = @main_relation,
                                         bw_class = @bw_class, main_mobile = @main_mobile, sub_contact = @sub_contact,
                                         sub_relation = @sub_relation, sub_bw_class = @sub_bw_class, sub_mobile = @sub_mobile,
                                         address = @address,location = @location,email = @email,contact_time = @contact_time,
                                         group_name = @group_name,class_room = @class_room,pic_name = @pic_name,pic_size = @pic_size,
                                         pic = @pic,memo = @memo WHERE id =@id;";
                    cmd = new MySqlCommand(CmdString, con);

                    cmd.Parameters.AddWithValue("@id", Convert.ToUInt32(id));
                    cmd.Parameters.AddWithValue("@addyear", tbAddYear.Text);
                    cmd.Parameters.AddWithValue("@name", tbStudentName.Text);
                    cmd.Parameters.AddWithValue("@class", tbClass.Text);
                    cmd.Parameters.AddWithValue("@gender", tbGender.Text);
                    cmd.Parameters.AddWithValue("@school", tbSchool.Text);
                    cmd.Parameters.AddWithValue("@grade", tbGrade.Text);
                    cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value);
                    cmd.Parameters.AddWithValue("@identity_no", tbIdentityNo.Text);
                    cmd.Parameters.AddWithValue("@home_tel", tbHomeTel.Text);
                    cmd.Parameters.AddWithValue("@main_contact", tbMainContact.Text);
                    cmd.Parameters.AddWithValue("@main_relation", tbMainRelation.Text);
                    cmd.Parameters.AddWithValue("@bw_class", tbMainBWClass.Text);
                    cmd.Parameters.AddWithValue("@main_mobile", tbMainMobile.Text);
                    cmd.Parameters.AddWithValue("@sub_contact", tbSubContact.Text);
                    cmd.Parameters.AddWithValue("@sub_relation", tbSubRelation.Text);
                    cmd.Parameters.AddWithValue("@sub_bw_class", tbSubBWClass.Text);
                    cmd.Parameters.AddWithValue("@sub_mobile", tbSubMobile.Text);
                    cmd.Parameters.AddWithValue("@address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@location", tbLocation.Text);
                    cmd.Parameters.AddWithValue("@email", tbMail.Text);
                    cmd.Parameters.AddWithValue("@contact_time", tbContactTime.Text);
                    cmd.Parameters.AddWithValue("@group_name", tbGroupName.Text);
                    cmd.Parameters.AddWithValue("@class_room", tbClassRoom.Text);
                    cmd.Parameters.AddWithValue("@pic_name", tbFile.Text);
                    cmd.Parameters.AddWithValue("@pic_size", Convert.ToUInt32(tbFileSize.Text));
                    cmd.Parameters.AddWithValue("@pic", _imageData);
                    cmd.Parameters.AddWithValue("@memo", tbMemo.Text);

                    int RowsAffected = cmd.ExecuteNonQuery();
                    if (RowsAffected > 0)
                    {
                        MessageBox.Show("Image updated sucessfully!");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
