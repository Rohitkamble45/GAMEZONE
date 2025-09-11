using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEZONE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginUser obj = new loginUser();
            obj.Show();
            obj.MdiParent = this;
        }

        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
             RegisterUser obj = new RegisterUser(); 
            obj.Show();
            obj.MdiParent = this;
        }


    }
}
