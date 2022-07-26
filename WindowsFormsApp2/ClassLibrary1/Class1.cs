using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1 : Form
    {
        private Label label1;
        Icon icon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        string mes;
        


        public void Set(string message, string caption, MessageBoxButtons messageBox, Icon icon)
        {
            this.icon = icon;
            this.Text = caption;
            mes = message;
            if (messageBox == MessageBoxButtons.OK)
            {
                Button button = new Button();
                button.Size = new Size(50, 50);
                button.Location = new Point(200, 200);
                button.Text = "OK";
                this.Controls.Add(button);
            }
           
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Class1
            // 
            this.ClientSize = new System.Drawing.Size(867, 587);
            this.Controls.Add(this.label1);
            this.Name = "Class1";
            this.Load += new System.EventHandler(this.Class1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Class1_Load(object sender, EventArgs e)
        {
            //this.pictureBox1.im
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = new Size(1000, 1000);
            this.MinimumSize = new Size(1000, 1000);
            label1.Text = mes;
        }
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    e.Graphics.DrawIcon(icon, 50, 50);

        //}



    }


    public class NewMessageBox
    {
        public static DialogResult Show(string message, string caption, MessageBoxButtons messageBox, MessageBoxIcon messageBoxIcon)
        {
            Icon icon=null ;
            if(messageBoxIcon== MessageBoxIcon.Information)
            {
                icon = SystemIcons.Information;
            }
            Class1 class1 = new Class1();
            class1.Set(message, caption, messageBox, icon);
            DialogResult dialogResult = class1.ShowDialog();
            return dialogResult;
        }
    }
}
