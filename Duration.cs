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
    public partial class Duration : Form
    {
        public Duration()
        {
            InitializeComponent();
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

        private void cmbbxGAMINGTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeID = Convert.ToInt32(cmbbxGAMINGTYPE.SelectedValue.ToString());
            clsGameZone objD = new clsGameZone(TypeID);
            DataTable dtD = new DataTable();
            dtD = objD.FetchGame();
            cmbbxGAMINGGames.ValueMember = "TypeID";
            cmbbxGAMINGGames.DisplayMember = "Games";
            cmbbxGAMINGGames.DataSource = dtD;
        }

        private void Duration_Load(object sender, EventArgs e)
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
            // int DurationID = Convert.ToInt32(cmbbxGAMINGTYPE.SelectedValue.ToString());
            int TypeID = Convert.ToInt32(cmbbxGAMINGTYPE.SelectedValue.ToString());
            int MODEID = Convert.ToInt32(cmbbxGAMINGMODE.SelectedValue.ToString());
            int GameID = Convert.ToInt32(cmbbxGAMINGGames.SelectedValue.ToString());
            string Duration = txtbxDuration.Text;
            decimal pp = Convert.ToDecimal(txtbxPrice.Text.ToString());
            DateTime date = DateTime.Now;
            clsGameZone obj = new clsGameZone(TypeID, MODEID, GameID, Duration,pp,date);
            obj.saveplayerdata();
            MessageBox.Show("Saved succesfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxGAMINGMODE.Text = " ";
            cmbbxGAMINGTYPE.Text = " ";
            cmbbxGAMINGGames.Text = " ";
            txtbxDuration.Text = " ";
            txtbxPrice.Text = " ";
        }
    }
    }

