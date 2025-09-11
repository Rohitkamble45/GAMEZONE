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
    public partial class Player : Form
    {
        public string Email { get; set; }

        public Player(string email)
        {
            InitializeComponent();
            Email = email;
        }

        private void Player_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void oNETIMEPLAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string UserType = "PLAYER";
            clsGameZone obj = new clsGameZone(Email, UserType);
            DataTable dt = new DataTable();
            dt = obj.FetchUser();
           string playerName = dt.Rows[0]["NAME"].ToString();
            Form OneTimePlay = new OneTimePlay(playerName);
            OneTimePlay.Show();
            OneTimePlay.MdiParent = this;

        }
    }
}
