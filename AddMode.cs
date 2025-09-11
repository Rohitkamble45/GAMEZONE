using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMEZONE
{
    public partial class AddMode : Form
    {
        public AddMode()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsGameZone obj = new clsGameZone(txtGamingMode.Text);
            obj.SaveGamingMode();
            MessageBox.Show("Your data save succesfully");
        }

        private void AddMode_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGamingMode.Text = " ";
        }

        private void txtGamingMode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
