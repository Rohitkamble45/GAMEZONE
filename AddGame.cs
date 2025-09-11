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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            clsGameZone Addgame = new clsGameZone();
            DataTable dt = new DataTable();
            dt = Addgame.fetchGamingmode();
            cmbbxGAMINGMODE.ValueMember = "ID";
            cmbbxGAMINGMODE.DisplayMember = "GamingMode";
            cmbbxGAMINGMODE.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxGAMINGTYPE.SelectedValue.ToString());
         //   Decimal pp = Convert.ToInt32(txtbxPrice.Text.ToString());
         //   DateTime date= DateTime.Now;
            clsGameZone obj = new clsGameZone(TypeID,txtbxGame.Text);
            obj.savegames();
            MessageBox.Show("Saved succesfully");
        }

        private void cmbbxGAMINGMODE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbxGAMINGMODE.Text == "ONLINE")
            {
                int Id = Convert.ToInt32(cmbbxGAMINGMODE.SelectedValue.ToString());
                clsGameZone objOnline = new clsGameZone(Id);
                DataTable dtT = new DataTable();
                dtT = objOnline.FetchGamingType();
                cmbbxGAMINGTYPE.ValueMember = "ID";
                cmbbxGAMINGTYPE.DisplayMember = "GAMINGTYPE";

                cmbbxGAMINGTYPE.DataSource = dtT;

            }
            else
            {
                int Id = Convert.ToInt32(cmbbxGAMINGMODE.SelectedValue.ToString());
                clsGameZone objOfflin = new clsGameZone(Id);
                DataTable dtT = new DataTable();
                dtT = objOfflin.FetchGamingType();   
                cmbbxGAMINGTYPE.ValueMember = "ID";
                cmbbxGAMINGTYPE.DisplayMember = "GAMINGTYPE";

                cmbbxGAMINGTYPE.DataSource = dtT;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxGAMINGTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
