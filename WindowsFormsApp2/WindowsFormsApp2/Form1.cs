
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            string str = ConfigurationManager.AppSettings["IsComCommunication"];
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMessageBox.Show("1231111rrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr", "信息", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.Image  = SystemIcons.Error;
            //this.Icon = SystemIcons.Error;

            ////this.pictureBox1.im
            //this.MaximizeBox = false;
            //this.MinimizeBox = false;
            //this.MaximumSize = new Size(500,500);
            //this.MinimumSize = new Size(500, 500);
        }


    }
}
