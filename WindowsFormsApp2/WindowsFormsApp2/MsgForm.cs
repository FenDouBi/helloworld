using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MsgForm : Form
    {
        Icon icon;
        string mes;
        Button button;
        public MsgForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = new Size(500, 500);
            this.MinimumSize = new Size(500, 500);
            richTextBox1.Text = mes;
            richTextBox1.Font = new Font(new FontFamily("宋体"), 50);
            this.button.Focus();
            richTextBox1.HideSelection = true;
            int w = System.Windows.Forms.SystemInformation.WorkingArea.Width;
            int h = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            this.Location = new Point(w / 2 - this.Width /2, h / 2 - this.Height /2);
        }
        public void SetProperty(string message, string caption, MessageBoxButtons messageBox, Icon icon)
        {
            this.icon = icon;
            this.Text = caption;
            mes = message;
            if (messageBox == MessageBoxButtons.OK)
            {
                button = new Button();
                button.Size = new Size(50, 50);
                button.Location = new Point(250 - button.Width / 2, 400);
                button.Text = "确定";
                button.Click += ReturnResult;
                this.Controls.Add(button);
            }

        }
        private void ReturnResult(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawIcon(icon, 30, 30);

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            button.Focus();
          
        }
    }
    public class NewMessageBox
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons messageBox, MessageBoxIcon messageBoxIcon)
        {
            Icon icon = null;

            if (messageBoxIcon == MessageBoxIcon.Information)
            {
                icon = SystemIcons.Information;
            }
            else if (messageBoxIcon == MessageBoxIcon.Error)
            {
                icon = SystemIcons.Error;
            }

            else if (messageBoxIcon == MessageBoxIcon.Exclamation)
            {
                icon = SystemIcons.Exclamation;
            }
            else if (messageBoxIcon == MessageBoxIcon.Hand)
            {
                icon = SystemIcons.Hand;
            }
            else if (messageBoxIcon == MessageBoxIcon.Question)
            {
                icon = SystemIcons.Question;
            }
            else if (messageBoxIcon == MessageBoxIcon.Warning)
            {
                icon = SystemIcons.Warning;
            }
            else
            {
                icon = SystemIcons.Information;
            }



            MsgForm form = new MsgForm();
            form.SetProperty(message, caption, messageBox, icon);
            DialogResult dialogResult = form.ShowDialog();
            form.Dispose();
            return dialogResult;

        }
    }

}
