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
    public partial class AddType : Form
    {
        public AddType()
        {
            InitializeComponent();
        }

        private void AddType_Load(object sender, EventArgs e)
        {
            clsGameZone OBJ = new clsGameZone();
            DataTable dt = new DataTable();
            dt = OBJ.fetchGamingmode();
            cmbbxGamingModeType.ValueMember = "ID";
            cmbbxGamingModeType.DisplayMember = "GAMINGMODE";
            cmbbxGamingModeType.DataSource = dt;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxGamingType.Text = " ";
            cmbbxGamingModeType.Text = " ";
        }

        private void txtbxGamingType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddtype_Click(object sender, EventArgs e)
        {
            int MODEID = Convert.ToInt32(cmbbxGamingModeType.SelectedValue.ToString());
            //int MODEID = Convert.ToInt32(cmbbxGamingModeType.SelectedValue.ToString());
            clsGameZone obj = new clsGameZone(MODEID, txtbxGamingType.Text);
            obj.SaveGamingType();
            MessageBox.Show("Saved Succesfully");

        }

        private void cmbbxGamingModeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
