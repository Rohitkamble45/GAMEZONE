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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void aDDMODEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddMode = new AddMode();
            AddMode.MdiParent = this;
            AddMode.Show();

        }

        private void aDDTYPEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form AddType = new AddType();
            AddType.MdiParent = this;
            AddType.Show();
        

        }

        private void aDDGAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddGame = new AddGame();
            AddGame.MdiParent = this;
            AddGame.Show();


        }

        private void Admin_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AllRecords = new AllRecords();
            AllRecords.MdiParent = this;
            AllRecords.Show();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aDDDURATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form  Duration= new Duration();
            Duration.MdiParent = this;
            Duration.Show();
        }
    }
}
