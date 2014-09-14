using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoungClass
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 學生資本資料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentForm frm = new StudentForm();

            frm.ShowDialog();
        }

        private void 法寶ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuddhaTeaching frm = new BuddhaTeaching();

            frm.ShowDialog();
        }
    }
}
