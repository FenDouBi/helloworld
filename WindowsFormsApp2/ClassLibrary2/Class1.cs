using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary2
{
    public class Class1:Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Class1";
            this.Load += new System.EventHandler(this.Class1_Load);
            this.ResumeLayout(false);

        }

        private void Class1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = new Size(500, 500);
            this.MinimumSize = new Size(500, 500);
        }
    }
}
